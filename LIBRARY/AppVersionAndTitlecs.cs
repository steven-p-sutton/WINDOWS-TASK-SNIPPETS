using Windows.ApplicationModel;

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
