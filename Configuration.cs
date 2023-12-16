namespace BlogASPNET;

public static class Configuration
{
    // TOKEN - JWT - Json Web Token
    public static string JwtKey = "NzlhOTFhNjY5NWQ2MTFlZWI5ZDEwMjQyYWMxMjAwMDI=";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "api_d41d8cd98f0/0b204e980099/8ecf8427e=";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
