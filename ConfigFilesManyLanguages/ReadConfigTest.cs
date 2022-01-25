using System.Configuration;

namespace ConfigFilesManyLanguages
{
    class ReadConfigTest {
        public static void Main(string[] args) {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = @".\App.config";
            var configFile = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            var configValue1 = configFile.AppSettings.Settings["DefaultConnection"];
            System.Console.WriteLine(configValue1.Key + ": " + configValue1.Value);
        } 
    }
}