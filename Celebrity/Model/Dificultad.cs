using System;

namespace Celebrity.Model
{
    public class Dificultad
    {
        public int Estrellas { get; }
        private readonly string nombre;

        public static Dificultad FromString(string dificultad)
        {
            switch (dificultad.ToUpper())
            {
                case "1":
                case "FACIL":
                case "FÁCIL":
                    return Facil;

                case "2":
                case "MEDIA":
                case "MEDIO":
                    return Media;

                case "3":
                case "DIFÍCIL":
                case "DIFICIL":
                    return Dificil;
            }
            throw new NotImplementedException();
        }

        public static Dificultad FromDatabase(long dificultad)
        {
            switch (dificultad)
            {
                case 1: return Facil;
                case 2: return Media;
                case 3: return Dificil;
            }
            throw new NotImplementedException();
        }

        public static Dificultad Facil => new Dificultad("Fácil", 1);
        public static Dificultad Media => new Dificultad("Media", 2);
        public static Dificultad Dificil => new Dificultad("Difícil", 3);
        public static Dificultad None => new Dificultad("", 0);

        private Dificultad(string nombre, int estrellas)
        {
            this.nombre = nombre;
            Estrellas = estrellas;
        }

        public bool EsFacil => Estrellas == 1;
        public bool EsMedia => Estrellas == 2;
        public bool EsDificil => Estrellas == 3;

        public override string ToString() => nombre;

        public override bool Equals(object obj)
        {
            if (obj is Dificultad d)
                return d.Estrellas == Estrellas;
            return false;
        }
        public override int GetHashCode() => Estrellas.GetHashCode();
    }
}
