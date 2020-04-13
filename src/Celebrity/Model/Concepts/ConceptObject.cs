using System;
using System.Collections.Generic;

namespace Celebrity
{
    public class ConceptObject : ValueObject
    {
        private readonly ConceptId id;
        public bool Is(ConceptId id) => this.id == id;

        private readonly string name;

        public ConceptObject(Guid id, string name)
        {
            this.id = new ConceptId(id);
            this.name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return id;
            yield return name;
        }
    }
}
