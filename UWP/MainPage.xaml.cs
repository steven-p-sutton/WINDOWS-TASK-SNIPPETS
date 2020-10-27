using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using WindowsTaskSnippets; // LIBRARY project

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

        public async void Button_Click(object sender, RoutedEventArgs e)
        {
            // String Format https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netcore-3.1

            // Required more fiddling to get columns to align
            string h0 = String.Format("{0,-25}   {1,-50}\n", "Field", "Value");
            string r1 = String.Format("{0,-25} = {1,-50}\n", "AppName", AppVersionAndTitle.AppName);
            string r2 = String.Format("{0,-25} = {1,-50}\n", "AppVersion", AppVersionAndTitle.AppVersion);

            await displayMessageAsync("App Version And Title", h0 + r1 + r2, string.Empty);
        }

        //Stackoverflow Exampe of Dialog Box
        public async Task displayMessageAsync(String title, String content, String dialogType)
        {

            // Dialog Boxes  https://prod.liveshare.vsengsaas.visualstudio.com/join?F2151E126AE030174AC02156F688EF381B3B
            var messageDialog = new MessageDialog(content, title);
            if (dialogType == "notification")
            {
                //Do nothing here.Display normal notification MessageDialog
            }
            else
            {
                //Display questions-Yes or No- MessageDialog
                //messageDialog.Commands.Add(new UICommand("Yes", null));
                //messageDialog.Commands.Add(new UICommand("No", null));
                messageDialog.Commands.Add(new UICommand("OK", null));
                messageDialog.DefaultCommandIndex = 0;

                messageDialog.CancelCommandIndex = 1;
                var cmdResult = await messageDialog.ShowAsync();

                Debug.WriteLine("My Dialog answer label is:: " + cmdResult.Label);

                if (cmdResult.Label == "Yes")
                {
                    Debug.WriteLine("My Dialog answer label is:: " + cmdResult.Label);
                }
                else if (cmdResult.Label == "No")
                {
                    Debug.WriteLine("My Dialog answer label is:: " + cmdResult.Label);
                }
                else
                {
                    Debug.WriteLine("My Dialog answer label is:: " + cmdResult.Label);
                }
            }
        }
    }
}
