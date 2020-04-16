using System;

namespace Celebrity.Data
{
    public class LoadedGames
    {
        public Guid Id { get; set; }
        public DateTime LoadedDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public Guid? User { get; set; }

        public Guid GameId { get; set; }
        public Games Game { get; set; }
    }
}
