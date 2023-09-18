using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
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

            string[] videofiles = { "mp4", "avi", "mkv", "mov", "wmv", "flv" };
            string[] imagefiles = { "jpg", "jpeg", "png", "gif", "bmp", "tiff" };

            string connString = "DefaultEndpointsProtocol=https;AccountName=10085210video;AccountKey=TZ21WDXIj4gpErTyClb5Xw9hfsbJMgivoOCMBEJ74ChtWCIMcaTivi+rr8lODsOuJGo082Dzc0d1+AStiYm0Lg==;EndpointSuffix=core.windows.net";
            string fileName = fuFiles.FileName;

            string container;
            string Path;

            string filext = fileName.Split('.')[1];


            if (videofiles.Contains(filext))
            {
                container = "groupvideos";
            }
            else if (imagefiles.Contains(filext))
            {
                container = "groupphotos";
            }
            else { container = "groupfiles"; }

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