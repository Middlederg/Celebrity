using System;

namespace Celebrity.Data
{
    public class UserMapper
    {
        private readonly Users user;

        public UserMapper(Users user)
        {
            this.user = user;
        }
        public User Map() => User.Create(Guid.Parse(user.Id), user.UserName);
    }
}
