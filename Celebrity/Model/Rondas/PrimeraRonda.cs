namespace Celebrity.Model
{
    public class PrimeraRonda : Ronda
    {
        public override string Descripcion => "Describir el concepto pudiendo hablar con libertad, pero sin utilizar partes de la palabra o su traducción en otro idioma.";
        public override bool SePuedePasar => false;
        public override bool SePuedeFallar => true;

        public PrimeraRonda() : base(1) { }
    }
}
