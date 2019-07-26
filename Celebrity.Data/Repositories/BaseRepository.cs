using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Celebrity.Data.Repositories
{
    public class BaseRepository<T>
    {
        public IEnumerable<T> Select(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                SQLiteDataReader sqlReader = command.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        yield return Create(sqlReader);
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

        private T Create(SQLiteDataReader sqlReader)
        {
            T objeto = (T)Activator.CreateInstance(typeof(T));
            foreach (PropertyInfo propiedad in typeof(T).GetProperties())
            {
                if (sqlReader[propiedad.Name] is DBNull)
                {
                    propiedad.SetValue(objeto, null, null);
                }
                else
                {
                    if (propiedad.PropertyType == typeof(bool))
                    {
                        var dato = GetBoolean((long)sqlReader[propiedad.Name]);
                        propiedad.SetValue(objeto, dato, null);
                    }
                    else
                        propiedad.SetValue(objeto, sqlReader[propiedad.Name], null);
                }
            }
            return objeto;
        }

        private bool GetBoolean(long dato) => dato != 0;


        public void Insert(T objeto) => InsertRecord(objeto, TodasLasPropiedades().ToList());
        public void InsertAutonumerico(T objeto) => InsertRecord(objeto, TodasLasPropiedadesExceptoId().ToList());
        public void Insert(IEnumerable<T> objetos) => InsertRecords(objetos, TodasLasPropiedades().ToList());
        public void InsertAutonumerico(IEnumerable<T> objetos) => InsertRecords(objetos, TodasLasPropiedadesExceptoId().ToList());

        private void InsertRecord(T objeto, List<PropertyInfo> propiedades)
        {
            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"INSERT INTO {typeof(T).Name}");
                sb.Append($" ( {string.Join(", ", propiedades.Select(x => x.Name))} ) ");
                sb.Append($"VALUES ({string.Join(", ", NombresDeParametros(propiedades))})");

                using (SQLiteCommand command = new SQLiteCommand(sb.ToString(), connection))
                {
                    int numCol = 1;
                    foreach (PropertyInfo item in propiedades)
                    {
                        command.Parameters.AddWithValue("@V" + numCol, item.GetValue(objeto, null));
                        numCol++;
                    }
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        private void InsertRecords(IEnumerable<T> objetos, List<PropertyInfo> propiedades)
        {
            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var objeto in objetos)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append($"INSERT INTO {typeof(T).Name}");
                        sb.Append($" ( {string.Join(", ", propiedades.Select(x => x.Name))} ) ");
                        sb.Append($"VALUES ({string.Join(", ", NombresDeParametros(propiedades))})");

                        using (SQLiteCommand command = new SQLiteCommand(sb.ToString(), connection, transaction))
                        {
                            int numCol = 1;
                            foreach (PropertyInfo item in propiedades)
                            {
                                command.Parameters.AddWithValue("@V" + numCol, item.GetValue(objeto, null));
                                numCol++;
                            }
                            var result = command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
            }
        }

        private IEnumerable<string> NombresDeParametros(IEnumerable<PropertyInfo> propiedades)
        {
            foreach (int i in Enumerable.Range(1, propiedades.Count()))
                yield return $"@V{i}";
        }

        private IEnumerable<PropertyInfo> TodasLasPropiedades() => typeof(T).GetProperties();

        private IEnumerable<PropertyInfo> TodasLasPropiedadesExceptoId()
        {
            foreach (var property in typeof(T).GetProperties())
            {
                if (!property.Name.ToUpper().Equals("ID"))
                    yield return property;
            }
        }


        private string GetIdValue(T obj, string campoId = "Id")
        {
            try
            {
                return typeof(T).GetProperties().First(x => x.Name.ToUpper().Equals(campoId.ToUpper())).GetValue(obj, null).ToString();
            }
            catch (Exception ex) { throw new ArgumentException($"No se pudo obtener la clave primaria {campoId ?? "<empty>" } de la tabla " + typeof(T).Name + "\n\n" + ex.Message); }
        }


        public void UpdateRecord(T objeto, string campoId = "Id")
        {
            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();
                var propiedades = TodasLasPropiedadesExceptoId().ToList();
                var idValue = GetIdValue(objeto);
                StringBuilder sb = new StringBuilder();
                sb.Append($"UPDATE {typeof(T).Name}");
                sb.Append($" SET {string.Join(", ", propiedades.Select(x => $"{x.Name} = @V{(propiedades.IndexOf(x) + 1)}"))}  ");
                sb.Append($" WHERE {campoId} = '{idValue}' ");

                using (SQLiteCommand command = new SQLiteCommand(sb.ToString(), connection))
                {
                    int numCol = 1;
                    foreach (PropertyInfo item in propiedades)
                    {
                        command.Parameters.AddWithValue("@V" + numCol, item.GetValue(objeto, null));
                        numCol++;
                    }
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string id)
        {
            string stringSql = $"DELETE FROM {typeof(T).Name} WHERE Id='@id'";

            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                var idParameter = new SQLiteParameter("@id")
                {
                    Value = id
                };
                command.Parameters.Add(idParameter);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAll()
        {
            string stringSql = $"DELETE FROM {typeof(T).Name}";

            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.ExecuteNonQuery();
            }
        }

        public void ExecuteSql(string stringSql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(UnitOfWork.GetConnectionString()))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
