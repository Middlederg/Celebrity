namespace Microsoft.Extensions.Configuration
{
    public class ApiConfiguration
    {
        public string Secret { get; set; }
        public string UserAgent { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
