using System;

namespace Celebrity
{
    public class User
    {
        public static User Anonymous(ClientInfo clientInfo) => new User(null, nameof(Anonymous), clientInfo);
        public static User Create(string id, string username, ClientInfo clientInfo) => new User(Guid.Parse(id), username, clientInfo);

        public Guid? Id { get; }

        private readonly string username;
        public ClientInfo ClientInfo { get; }

        private User(Guid? id, string username, ClientInfo clientInfo)
        {
            Id = id;
            this.username = username;
            ClientInfo = clientInfo;
        }

        public override string ToString() => username;
    }
}
