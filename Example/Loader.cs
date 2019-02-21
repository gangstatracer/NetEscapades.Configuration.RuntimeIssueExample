using Microsoft.Extensions.Configuration;

namespace Example
{
    public static class Loader
    {
        public static IConfiguration Load()
        {
            var builder = new ConfigurationBuilder();
            builder.AddYamlFile("configuration.yaml");
            return builder.Build();
        }
    }
}