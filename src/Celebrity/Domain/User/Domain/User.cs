using System;
using System.Globalization;

namespace Celebrity.Domain
{
    public class User
    {
        public const string DefaultCulture = "en";

        public static User Anonymous(CultureInfo culture) 
            => new User(null, nameof(Anonymous), culture, loggedInUser:false);

        public static User Create(string id, string username, CultureInfo culture) 
            => new User(Guid.Parse(id), username, culture, loggedInUser:true);

        public Guid? Id { get; }

        private readonly string username;
        public bool IsLoggedIn { get; }

        public CultureInfo Culture { get; }

        private User(Guid? id, string username, CultureInfo culture, bool loggedInUser)
        {
            Id = id;
            this.username = username;
            Culture = culture;
            IsLoggedIn = loggedInUser;
        }

        public override string ToString() => username;
    }
}
