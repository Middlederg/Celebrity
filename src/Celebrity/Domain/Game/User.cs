using System;

namespace Celebrity
{
    public class User
    {
        public static User Anonymous => new User(null, nameof(Anonymous));
        public static User Create(Guid id, string username) => new User(id, username);

        public Guid? Id { get; }

        private readonly string username;

        private User(Guid? id, string username)
        {
            Id = id;
            this.username = username;
        }

        public override string ToString() => username;
    }
}
