namespace Celebrity
{
    public class Point
    {
        public Concept Concept { get; }
        public int Round { get; }

        public Point(Concept tarjeta, int ronda)
        {
            Concept = tarjeta;
            Round = ronda;
        }

        public override string ToString() => $"{Concept} (Round {Round})";
    }
}
