namespace Celebrity.Model
{
    public class Acierto
    {
        public Concepto Tarjeta { get; private set; }
        public int Ronda { get; private set; }

        public Acierto(Concepto tarjeta, int ronda)
        {
            Tarjeta = tarjeta;
            Ronda = ronda;
        }

        public override string ToString() => $"Ronda {Ronda} - {Tarjeta.ToString()}";
    }
}
