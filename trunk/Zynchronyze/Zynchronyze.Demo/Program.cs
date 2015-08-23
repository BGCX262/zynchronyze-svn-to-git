
namespace Zynchronyze.Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Xml;

    class Program
    {
        static string FILE_PATH=@"C:\zynchronyze";
        static string CHANGED_ICON_PATH = String.Concat(FILE_PATH, @"\images\zynchronyze_folderchanged.ico");
        static XmlDocument objXmlDocumentDataBase;
        
        static void Main(string[] args)
        {
            objXmlDocumentDataBase = new XmlDocument();

            // Create watcher and set point to C:\synchronyze
            FileSystemWatcher watcher = new FileSystemWatcher(FILE_PATH);
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            // Mapping events
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.WaitForChanged(WatcherChangeTypes.Changed);

            // -- Pause
            Console.ReadKey();
        }
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.All:
                    break;
                case WatcherChangeTypes.Changed:
                    Console.WriteLine("{0} has been modified", e.Name);
                    zynchronyze.util.IO.FileHelper objFileHelper = new zynchronyze.util.IO.FileHelper(FILE_PATH);
                    objFileHelper.CreateFolderIcon(CHANGED_ICON_PATH, "Changes");
                    // Create MD5 Hash from file
                    foreach (string hash in GetMD5FromFile(e.FullPath))
                    {
                        Console.WriteLine(String.Format("hash generated: {0}",hash));
                    }
                    Console.WriteLine("Icon has been changed...");
                    break;
                case WatcherChangeTypes.Created:
                    break;
                case WatcherChangeTypes.Deleted:
                    break;
                case WatcherChangeTypes.Renamed:
                    break;
                default:
                    break;
            }
        }
        static IEnumerable<string> GetMD5FromFile(string FilePath)
        {
            List<string> hashes = new List<string>();
            FileStream objFileStream = null;

            byte[] bReadBytes = {};   // Bytes read in each block iteration
            int iTotalFileSize = 0;
            int iReadedBytesCount = 0;
            int iBlockSize = 0;
            int iBytesToRead = 0;

            // - Retrieve file information
            FileInfo objFileInfo = new FileInfo(FilePath);

            /*
             * Algorithm
             *  Part total size in 10% and makes hash md5 for each partition data
             *  
             */

            // Get Stream for read
            objFileStream = objFileInfo.OpenRead();
            // Get size
            iTotalFileSize = (int)objFileStream.Length;
            // Generate Block Size
            iBlockSize = (iTotalFileSize * 10) /*10%*/ / 100;

            while (iReadedBytesCount < iTotalFileSize)
            { 
                // Calculates how much bytes will be read
                iBytesToRead = iBlockSize - iReadedBytesCount;
                if (iBytesToRead <= 0)
                    iBytesToRead = iBlockSize;
                
                // Generate the array for get data
                bReadBytes = new byte[iBytesToRead];

                // Read a Block
                int iReadedBtytes = objFileStream.Read(bReadBytes, 0 ,iBytesToRead);
                System.Text.ASCIIEncoding codificador = new System.Text.ASCIIEncoding();
                Console.WriteLine(codificador.GetString(bReadBytes));

                // Parse block readed to MD5
                string md5Hash = zynchronyze.util.Security.CryptoHelper.MD5Hash(bReadBytes);
                // Add the MD5 to List of hashes
                hashes.Add(md5Hash);

                // set new ActualSize Value to forward cursor in iterations
                iReadedBytesCount += iReadedBtytes;
            }

            return hashes;
        }
    }
}
