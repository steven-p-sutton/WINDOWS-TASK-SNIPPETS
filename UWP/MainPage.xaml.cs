using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using WindowsTaskSnippets.AppVersionAndTitle;  // LIBRARY project
using WindowsTaskSnippets.MessageDialogHelper; // LIBRARY project


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // Auto set the Name & Version
        public string _AppName = AppVersionAndTitle.AppName;
        public string _AppVersion = AppVersionAndTitle.AppVersion;

        // Set the Name & Version on click event
        public async void Button_Click(object sender, RoutedEventArgs e)
        {
            // String Format https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1

            // Required more fiddling to get columns to align
            string h0 = String.Format("{0,-25}   {1,-50}\n", "Field", "Value");
            string r1 = String.Format("{0,-25} = {1,-50}\n", "AppName", AppVersionAndTitle.AppName);
            string r2 = String.Format("{0,-25} = {1,-50}\n", "AppVersion", AppVersionAndTitle.AppVersion);

            await MessageDialogHelper.displayMessageAsync("App Version And Title", h0 + r1 + r2, string.Empty);
        }
    }
}
