namespace Celebrity.Model
{
    public class CuartaRonda : Ronda
    {
        public override string Descripcion => "Escenificar una posición, como si el jugador fuese una estatua, para describir el concepto";
        public override bool SePuedePasar => true;
        public override bool SePuedeFallar => false;

        public CuartaRonda() : base(4) { }
    }
}
