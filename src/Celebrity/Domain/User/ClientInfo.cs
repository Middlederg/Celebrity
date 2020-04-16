using System.Collections.Generic;

namespace Celebrity
{
    public class ClientInfo : ValueObject
    {
        public static ClientInfo Undefined => new ClientInfo(UserAgent.Undefined, IpAddress.Undefined);

        public UserAgent UserAgent { get; }
        public IpAddress IpAddress { get; }

        public ClientInfo(UserAgent userAgent, IpAddress ipAddress)
        {
            UserAgent = userAgent;
            IpAddress = ipAddress;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return UserAgent;
            yield return IpAddress;
        }
    }
}
