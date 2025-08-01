using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.Localization
{
    public class clsSaveLanguageSettings
    {
        private const string RegistryKey = @"Software\MyApp";
        private const string ValueName = "Language";

        public static void SaveLanguage(string langCode)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKey);
            key.SetValue(ValueName, langCode);
        }

        //Save language settings in registry key
        public static string LoadLanguage()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKey);
            // If the key or value doesn't exist, fallback to "en"
            if (key == null || key.GetValue(ValueName) == null)
                return "en";

            string lang = key?.GetValue(ValueName, "en")?.ToString();
            key?.Close();
            return lang;
        }
       
    }
}
