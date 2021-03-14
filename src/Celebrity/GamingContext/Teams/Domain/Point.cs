namespace Celebrity.GamingContext
{
    public class Point
    {
        public Concept Concept { get; }
        public int Round { get; }
        public (ConceptId id, int round) GetInfo => (Concept.Id, Round);

        public Point(Concept tarjeta, int ronda)
        {
            Concept = tarjeta;
            Round = ronda;
        }

        public override string ToString() => $"{Concept} (Round {Round})";
    }
}
