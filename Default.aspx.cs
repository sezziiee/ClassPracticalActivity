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
            
            string[] videofiles = { ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv" };
            string[] imagefiles = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff" };

            string connString = "DefaultEndpointsProtocol=https;AccountName=10085210video;AccountKey=TZ21WDXIj4gpErTyClb5Xw9hfsbJMgivoOCMBEJ74ChtWCIMcaTivi+rr8lODsOuJGo082Dzc0d1+AStiYm0Lg==;EndpointSuffix=core.windows.net";
            string fileName = fuFiles.FileName;

            string container = "groupphotos";
            string Path;

            for (int i = 0; i < 6; i++)
            {
                if (fileName.EndsWith(videofiles[i].ToString())) 
                {
                    container = "groupvideos";
                }else if (fileName.EndsWith(imagefiles[i].ToString()))
                {
                    container = "groupphotos";
                }else { container = "groupfiles"; }
            }
            

            
            BlobContainerClient containerClient = new BlobContainerClient(connString, container);
            var blobClient = containerClient.GetBlobClient(fileName);
            using (var filestream = fuFiles.FileContent)
            {
                blobClient.Upload(filestream);
            }

            lblStatus.Text = "File uploaded";
        }
    }
}