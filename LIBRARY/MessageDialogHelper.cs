using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace WindowsTaskSnippets.MessageDialogHelper
{
    public static class MessageDialogHelper
    {
        //Stackoverflow Exampe of Dialog Box
        public static async Task displayMessageAsync(String title, String content, String dialogType)
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
