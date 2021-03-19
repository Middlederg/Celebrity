namespace Celebrity.Domain
{
    public class Point : Identity<PointId>
    {
        public ConceptId ConceptId { get; private set; }
        public ConceptName Name { get; private set; }

        public int Round { get; private set; }
       
        public TeamId TeamId { get; private set; }
        public Team Team { get; private set; }

        public Point(PointId id, ConceptId conceptId, int round) : base(id)
        {
            ConceptId = conceptId;
            Round = round;
        }

        public override string ToString() => $"{Name} (Round {Round})";
    }
}
