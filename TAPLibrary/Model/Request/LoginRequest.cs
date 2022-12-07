namespace TAPLibrary.Model.Request 
{
    public class LoginRequest 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClientId { get; set; }
    }
    public class LoginToAuthenticate
    {
        public string Username { get; set; }
        public string Secret { get; set; }
        public string ClientId { get; set; }

    }
}
