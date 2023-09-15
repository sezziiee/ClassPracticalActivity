using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string connString = "DefaultEndpointsProtocol=https;AccountName=10085210video;AccountKey=TZ21WDXIj4gpErTyClb5Xw9hfsbJMgivoOCMBEJ74ChtWCIMcaTivi+rr8lODsOuJGo082Dzc0d1+AStiYm0Lg==;EndpointSuffix=core.windows.net";
            
            string Vpath = @"C:\Users\Jarryd\Videos";
            string Ppath = @"C:\Users\Jarryd\Pictures";
            string container;

            string Path;
            
            container = "groupvideos";
            BlobContainerClient containerClient = new BlobContainerClient(connString, container);
            var blobClient = containerClient.GetBlobClient(fuFiles.FileName);
            using (var filestream = fuFiles.FileContent)
            {
                blobClient.Upload(filestream);
            }
        }
    }
}