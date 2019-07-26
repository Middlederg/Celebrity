namespace Celebrity.Model
{
    public class TerceraRonda : Ronda
    {
        public override string Descripcion => "Mímica y sonidos para describir el concepto";
        public override bool SePuedePasar => true;
        public override bool SePuedeFallar => false;

        public TerceraRonda() : base(3) { }
    }
}
