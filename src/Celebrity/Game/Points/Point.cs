namespace Celebrity.Domain
{
    public class Point : Identity<PointId>
    {
        public ConceptId ConceptId { get; private set; }
        public ConceptName Name { get; private set; }

        public int Round { get; private set; }
       
        public TeamId TeamId { get; private set; }
        public Team Team { get; private set; }

        private Point() { }
        public Point(PointId id, DeckConcept concept, int round) : base(id)
        {
            ConceptId = concept.ConceptId;
            Name = concept.Name;
            Round = round;
        }

        public override string ToString() => $"{Name} (Round {Round})";
    }
}
