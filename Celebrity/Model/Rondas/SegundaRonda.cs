namespace Celebrity.Model
{
    public class SegundaRonda : Ronda
    {
        public override string Descripcion => "Solo una palabra para describir el concepto";
        public override bool SePuedePasar => true;
        public override bool SePuedeFallar => false;

        public SegundaRonda() : base(2) { }
    }
}
