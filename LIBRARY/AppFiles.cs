using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            // Work with files
                //https://docs.microsoft.com/en-us/windows/uwp/get-started/fileio-learning-track
    
                //Write text to a file
                //    https://docs.microsoft.com/en-us/windows/uwp/get-started/fileio-learning-track#write-text-to-a-file
                //Read text from a file
                //    https://docs.microsoft.com/en-us/windows/uwp/get-started/fileio-learning-track#read-text-from-a-file
                //Access the file system
                //    https://docs.microsoft.com/en-us/windows/uwp/get-started/fileio-learning-track#access-the-file-system
                
                //References
                //    StorageFile Class
                //        https://docs.microsoft.com/en-us/uwp/api/windows.storage.storagefile?view=winrt-19041
                //    Tutorial
                //        https://docs.microsoft.com/en-us/windows/uwp/files/quickstart-reading-and-writing-files
                //    GIt Example
                //        https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess
                //    File Path 
                //        https://docs.microsoft.com/en-us/uwp/api/windows.storage.storagefile.getfilefrompathasync?view=winrt-19041
                //    File IO
                //        https://docs.microsoft.com/en-us/uwp/api/windows.storage.fileio?view=winrt-19041
                //    StorageFolder
                //        https://docs.microsoft.com/en-us/uwp/api/windows.storage.storagefolder?view=winrt-19041
                //    KnownFolders
                //        https://docs.microsoft.com/en-us/uwp/api/windows.storage.knownfolders?view=winrt-19041

namespace WindowsTaskSnippets.AppFiles
{
    public class AppFiles
    {
        Windows.Storage.StorageFile _File;
        Windows.Storage.StorageFolder _Folder;
        string _Name;
        public string s;

        public AppFiles(string name)
        {
            _Folder = Windows.Storage.ApplicationData.Current.LocalFolder;
            _Name = name;
        }
        public async System.Threading.Tasks.Task WriteFileAsync(String s)
        {
            _File = await _Folder.CreateFileAsync(_Name, Windows.Storage.CreationCollisionOption.OpenIfExists);
            await Windows.Storage.FileIO.WriteTextAsync(_File, s);

            // Append a list of strings, one per line, to the file
            //var listOfStrings = new List<string> { "line1", "line2", "line3" };
            //await Windows.Storage.FileIO.AppendLinesAsync(_File, listOfStrings); // each entry in the list is written to the file on its own line.
        }
        public async System.Threading.Tasks.Task ReadFileAsync()
        {
            //Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile _File = await _Folder.GetFileAsync(_Name);
            s = await Windows.Storage.FileIO.ReadTextAsync(_File);

            // You can also read each line of the file into individual strings in a collection with 
            //IList<string> contents = await Windows.Storage.FileIO.ReadLinesAsync(_File);
            //foreach (var s in contents)
            //{
            //    Console.Write(s + " ");
            //}
        }
    }
}
