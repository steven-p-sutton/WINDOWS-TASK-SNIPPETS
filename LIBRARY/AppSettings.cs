using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

// Extracted from UWP Tutorial for reuse so included here 
// https://docs.microsoft.com/en-us/windows/uwp/get-started/settings-learning-track

//Save and load settings
//                https://docs.microsoft.com/en-us/windows/uwp/get-started/settings-learning-track
    
//                Save app settings
//                    https://docs.microsoft.com/en-us/windows/uwp/get-started/settings-learning-track#save-app-settings
//                Load app settings
//                    https://docs.microsoft.com/en-us/windows/uwp/get-started/settings-learning-track#load-app-settings
    
//                References
//                    ApplicationData Class
//                        https://docs.microsoft.com/en-us/uwp/api/Windows.Storage.ApplicationData?view=winrt-19041#Windows_Storage_ApplicationData_LocalSettings
//                    ApplicationData.RoamingSettings Property
//                        https://docs.microsoft.com/en-us/uwp/api/windows.storage.applicationdata.roamingsettings?view=winrt-19041#Windows_Storage_ApplicationData_RoamingSettings
//                    ApplicationDataContainer Class
//                        https://docs.microsoft.com/en-us/uwp/api/windows.storage.applicationdatacontainer?view=winrt-19041
//                    ApplicationDataCompositeValue Class
//                        https://docs.microsoft.com/en-us/uwp/api/Windows.Storage.ApplicationDataCompositeValue?view=winrt-19041
    
//                    DatePicker & TimePicker Binding
//                        http://www.teixeira-soft.com/bluescreen/2016/02/26/binding-the-xaml-controls-datepicker-and-timepicker-to-a-variable-of-type-datetime/


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
                return _storage.Values[name].ToString();
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
