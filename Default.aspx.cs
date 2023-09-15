using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Azure.Storage.Blobs;

namespace CLDVClassGroupActivity
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string Vpath = @"C:\Users\Jarryd\Videos";
            string Ppath = @"C:\Users\Jarryd\Pictures";
            string Container;

            string Path;
            Console.WriteLine("1. Upload Photo's\n2.Upload Videos");
            int select = int.Parse(Console.ReadLine());

            if (select == 1)
            {
                Path = Ppath;
                Container = "myphotos";
            }
            else
            {
                Path = Vpath;
                Container = "myvideos";
            }

            foreach (var file in GetFiles(Path))
            {
                Console.WriteLine(file.Name);
            }

            var files = GetFiles(Path);
            Upload(files, "DefaultEndpointsProtocol=https;AccountName=10085210video;AccountKey=TZ21WDXIj4gpErTyClb5Xw9hfsbJMgivoOCMBEJ74ChtWCIMcaTivi+rr8lODsOuJGo082Dzc0d1+AStiYm0Lg==;EndpointSuffix=core.windows.net",
               Container);
            Console.ReadLine();   
        }

        static IEnumerable<FileInfo> GetFiles(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetFiles();
        }

        static void Upload(IEnumerable<FileInfo> files, string connString, string container)
        {
            BlobContainerClient containerClient = new BlobContainerClient(connString, container);
            foreach (var file in files)
            {
                var blobClient = containerClient.GetBlobClient(file.Name);
                using (var filestream = File.OpenRead(file.FullName))
                {
                    blobClient.Upload(filestream);
                }
                Console.WriteLine(file.Name + "Uploaded");
            }
        }
    }
}