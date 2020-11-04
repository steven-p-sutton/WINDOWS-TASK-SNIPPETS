using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

// Extracted from UWP Tutorial for reuse so included here 
// https://docs.microsoft.com/en-us/windows/uwp/get-started/settings-learning-track

namespace WindowsTaskSnippets.AppSettings
{
    public class AppSettings
    {
        ApplicationDataContainer _storage;

        public enum Type
        {
            Local,
            Roaming
        }

        public AppSettings()
        {
            _storage = Windows.Storage.ApplicationData.Current.LocalSettings;
        }

        public AppSettings(Type type)
        {
            if (type == Type.Local)
            {
                _storage = Windows.Storage.ApplicationData.Current.LocalSettings;
            }
            else
            {
                _storage = Windows.Storage.ApplicationData.Current.RoamingSettings;
            }
        }

        public void SaveSetting(string name, string value)
        {
            try
            {
                _storage.Values[name] = value;
            }
            catch
            {
            }

            // Save setting that is local to the device

            //ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            //localSettings.Values["AssociateName"] = _AssociateName;

            // Save a composite setting that will be roamed between devices

            //ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            //Windows.Storage.ApplicationDataCompositeValue composite = new Windows.Storage.ApplicationDataCompositeValue();

            //composite["Font"] = "Calibri";
            //composite["FontSize"] = 11;
            //roamingSettings.Values["RoamingFontInfo"] = composite;
        }

        public string GetSetting(string name)
        {
            try
            {
                return _settings.Values[name].ToString();
            }
            catch
            {
                return string.Empty;
            }

            // load a setting that is local to the device

            //ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            //_AssociateName = localSettings.Values["AssociateName"] as string;

            // load a composite setting that roams between devices

            //ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            //Windows.Storage.ApplicationDataCompositeValue composite = (ApplicationDataCompositeValue)roamingSettings.Values["RoamingFontInfo"];
            //if (composite != null)
            //{
            //    String fontName = composite["Font"] as string;
            //    int fontSize = (int)composite["FontSize"];
            //}

            //_AssociateName = "AssociateName";
            //_TargetInstallDate = "TargetInstallDate";
            //_InstallTime = "InstallTime";
        }
    }
}
