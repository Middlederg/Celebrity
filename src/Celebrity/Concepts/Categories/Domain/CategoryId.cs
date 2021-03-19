using System;

namespace Celebrity.Domain
{
    public class CategoryId : Id
    {
        public CategoryId() { }
        public CategoryId(Guid identificator) : base(identificator) { }
    }
}
