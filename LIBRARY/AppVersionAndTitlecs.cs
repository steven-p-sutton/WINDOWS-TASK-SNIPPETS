using Windows.ApplicationModel; // UWP only - tbc

// [Package class](https://msdn.microsoft.com/library/windows/apps/windows.applicationmodel.package.aspx)  
// [Interpolated strings] (https://msdn.microsoft.com/library/dn961160.aspx) (strings with a $ prefix) 

namespace WindowsTaskSnippets
{
   public static class AppVersionAndTitle
    {
        public static string AppName
        {
            get { return Package.Current.Id.Name; }
        }
        public static string AppVersion
        {
            get
            {
                PackageVersion version = Package.Current.Id.Version;
                return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
            }
        }
    } 
}
