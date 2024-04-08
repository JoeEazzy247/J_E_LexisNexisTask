using Microsoft.Extensions.Configuration;

namespace J_E_LexisNexisTask.Config
{
    public class readConfig
    {
        private static IConfigurationRoot ConfigurationRoot
        {
            get
            {
                var configurationBuilder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile($"settings.json", true);

                return configurationBuilder.Build();
            }
        }

        public static string GetRemoteAddress =>
            new string(ConfigurationRoot.GetSection("env:url").Value);

    }
}
