namespace Celebrity.Model
{
    public abstract class Ronda
    {
        public int NumeroRonda { get; private set; }
        public abstract string Descripcion { get; }
        public abstract bool SePuedePasar { get; }
        public abstract bool SePuedeFallar { get; }

        protected Ronda(int numeroRonda)
        {
            NumeroRonda = numeroRonda;
        }

        public override string ToString() => $"Ronda {NumeroRonda}";
        public string PasarText() => SePuedePasar ? "Se puede pasar a la siguiente tarjeta si no la adivinais" : "No se puede pasar a la siguiente tarjeta hasta adivinar la actual";
        public string FallarText() => SePuedeFallar ? "Respuestas ilimitadas por tarjeta" : "Solo una respuesta por tarjeta";
    }
}
