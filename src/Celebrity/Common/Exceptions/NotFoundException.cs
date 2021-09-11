using System;

namespace Celebrity
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("element was not found") { }
        public NotFoundException(int id) : base($"Element with id {id} was not found") { }
        public NotFoundException(Guid id) : base($"Element with id {id} was not found") { }
        public NotFoundException(int id, string objectName) : base($"{objectName} with id {id} was not found") { }
        public NotFoundException(Guid id, string objectName) : base($"{objectName} with id {id} was not found") { }
    }
}
