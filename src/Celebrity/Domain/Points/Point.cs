namespace Celebrity.Domain
{
    public class Point : Identity<PointId>
    {
        public ConceptId ConceptId { get; private set; }
        public DeckConcept Concept { get; private set; }

        public int Round { get; }
        public (ConceptId id, int round) GetInfo => (Concept.Id, Round);
       
        public TeamId TeamId { get; set; }
        public Team Team { get; set; }

        public Point(PointId id, ConceptId conceptId, int round) : base(id)
        {
            ConceptId = conceptId;
            Round = round;
        }

        public override string ToString() => $"{Concept} (Round {Round})";
    }
}
