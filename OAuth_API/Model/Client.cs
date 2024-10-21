namespace OAuth_API.Model
{
    public class Client
    {
        public string? error { get; set; }
        public IEnumerable<GetClient>? clients { get; set; }
    }
    public class GetClient {
        public string? code { get; set; }
        public string? name { get; set; }
        public string? street { get; set; }
        public string? city { get; set; }
        public string? countrycode { get; set; }
        public string? phone { get; set; }
    }
}
