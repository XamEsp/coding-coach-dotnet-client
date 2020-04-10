namespace CodingCoach.DotNetClient
{
    public class Configuration
    {
        public static Env Environment { get; set; }
        public static string CustomUrl { get; set; }
        public string Url
        {
            get
            {
                switch (Environment)
                {
                    case Env.Staging:
                        return "https://api-staging.codingcoach.io";

                    case Env.Prod:
                        return "https://api.codingcoach.io";

                    default:
                        return CustomUrl;
                }
            }
        }
    }

    public enum Env
    {
        Prod,
        Staging,
        Custom
    }
}
