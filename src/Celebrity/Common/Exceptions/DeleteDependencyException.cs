using System;

namespace Celebrity
{
    public class DeleteDependencyException : Exception
    {
        private readonly string entityName;
        private readonly string message;

        public DeleteDependencyException(string entityName, string message = "")
        {
            this.entityName = entityName;
            this.message = message;
        }

        public override string Message => $"Can not delete {entityName} object because has dependency in other objects\n\n{message}";
    }
}
