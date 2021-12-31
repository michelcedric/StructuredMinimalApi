using Microsoft.Extensions.Configuration;

namespace MinimalApi.Endpoint.Configurations.Extensions
{
    public static class ConfigurationManagerExtensions
    {
        /// <summary>
        /// Add config file usefull to load specific settings
        /// </summary>
        /// <param name="configurationManager"></param>
        public static ConfigurationManager AddConfigurationFile(this ConfigurationManager configurationManager)
        {
            return AddConfigurationFileWithPath(configurationManager, "appsettings.json");
        }

        /// <summary>
        /// Add config file usefull to load specific settings
        /// </summary>
        /// <param name="configurationManager"></param>
        public static ConfigurationManager AddConfigurationFile(this ConfigurationManager configurationManager, string path)
        {
            return AddConfigurationFileWithPath(configurationManager, path);
        }

        private static ConfigurationManager AddConfigurationFileWithPath(ConfigurationManager configurationManager, string path)
        {
            var configPath = Path.Combine(AppContext.BaseDirectory, path);
            configurationManager.AddJsonFile(configPath, true, false);
            return configurationManager;
        }
    }
}
