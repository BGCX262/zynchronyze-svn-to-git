using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace zynchronyze.util.Transmission
{
    public class SenderClient
    {
        public static string curMsg = "Idle";
        public static void SendFile(string fileName)
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);


                string filePath = "";

                fileName = fileName.Replace("\\", "/");
                while (fileName.IndexOf("/") > -1)
                {
                    filePath += fileName.Substring(0, fileName.IndexOf("/") + 1);
                    fileName = fileName.Substring(fileName.IndexOf("/") + 1);
                }


                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                if (fileNameByte.Length > 850 * 1024)
                {
                    curMsg = "File size is more than 850kb, please try with small file.";
                    return;
                }

                curMsg = "Buffering ...";
                byte[] fileData = File.ReadAllBytes(filePath + fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                curMsg = "Connection to server ...";
                clientSock.Connect(ipEnd);

                curMsg = "File sending...";
                clientSock.Send(clientData);

                curMsg = "Disconnecting...";
                clientSock.Close();
                curMsg = "File transferred.";

            }
            catch (Exception ex)
            {
                if (ex.Message == "No connection could be made because the target machine actively refused it")
                    curMsg = "File Sending fail. Because server not running.";
                else
                    curMsg = "File Sending fail." + ex.Message;
            }

        }
    }
}
