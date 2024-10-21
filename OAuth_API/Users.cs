namespace OAuth_API
{
    public class Users
    {
        public string ClientId { get; set; }
        public int ClientSecrets { get; set; }
        // Un/comment in case of permission hierarchy
        public bool IsAdmin { get; set; }

        // Built-in Identity Server
        // User List
        public static IEnumerable<Users> Get()
        {
            return new List<Users>
        {
            new Users
            {
                ClientId = "user",
                ClientSecrets = "pass".GetHashCode(),
                IsAdmin = false
            }
            ,
            new Users
            {
                ClientId = "admin",
                ClientSecrets = "admin".GetHashCode(),
                IsAdmin = true
            }
            /*
            ,
            new Users
            { 
                ...
            }
            */
        };
        }
    }
}
