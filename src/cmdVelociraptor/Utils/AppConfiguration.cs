using cmdVelociraptor.Models;
using System.Configuration;
using System.Reflection;

namespace cmdVelociraptor.Utils
{
    public class AppConfiguration
    {
        internal static void LoadConfiguration(ApplicationArguments applicationArguments)
        {
            PropertyInfo[] properties = applicationArguments.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                var propertyValue = prop.GetValue(applicationArguments, null);
                if (propertyValue == null)
                    prop.SetValue(applicationArguments, propertyValue);
                else
                    AddUpdateAppSettings(prop.Name, propertyValue.ToString());
            }
        }


        private static void AddUpdateAppSettings(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
                settings.Add(key, value);
            else
                settings[key].Value = value;
            
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}
