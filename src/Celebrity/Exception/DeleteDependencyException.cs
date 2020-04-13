using System;

namespace Celebrity
{
    public class DeleteDependencyException : Exception
    {
        private string entityName;

        public DeleteDependencyException(string entityName)
        {
            this.entityName = entityName;
        }

        public override string Message => $"Can not delete {entityName} object because has dependency in other objects";
    }
}
