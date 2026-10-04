namespace AppHelloWorld
{
    public class GlobalSettings
    {
        public const string DefaultEndpoint = "https://dummyjson.com";
        public string UserEndpoint { get; set; }

        public static GlobalSettings Instance { get; } = new GlobalSettings();
        public GlobalSettings()
        {
            UserEndpoint = $"{DefaultEndpoint}/users";
        }
    }
}
