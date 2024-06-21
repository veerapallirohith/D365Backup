using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.IdentityModel.Clients.ActiveDirectory; //ADAL client library for getting the access token
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;

namespace DemoAzureFileUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set Ids of your Azure account
            AzureOperations.applicationId = "";
            AzureOperations.clientSecret = "";
            AzureOperations.tenantId = "";

            //Demo Upload File
            string srcPathToUpload = string.Format(@"C:\Users\abdul.rehman\Desktop\AzureFileUpload\myfile.txt");            
            UploadFile(srcPathToUpload);


            //Demo Download File
            string azurePathInBlob = "dev/files/myfile.txt";
            string destinationPath= string.Format(@"C:\Users\abdul.rehman\Desktop\AzureFileDownload\myfile.txt");
            DownloadFile(destinationPath, azurePathInBlob);

        }

        public static void UploadFile(string srcPath)
        {            
            AzureOperationHelper azureOperationHelper = new AzureOperationHelper();
            // your Storage Account Name
            azureOperationHelper.storageAccountName = "dbpoc";
            azureOperationHelper.storageEndPoint = "core.windows.net";
            // File path to upload
            azureOperationHelper.srcPath = srcPath; 
            // Your Container Name 
            azureOperationHelper.containerName = "filecontainer"; 
            // Destination Path you can set it file name or if you want to put it in folders do it like below
            azureOperationHelper.blobName = string.Format("dev/files/" + Path.GetFileName(srcPath)); 
            AzureOperations.UploadFile(azureOperationHelper);

        }

        public static void DownloadFile(string destinationPath, string srcPath)
        {           
            AzureOperationHelper azureOperationHelper = new AzureOperationHelper();
            // your Storage Account Name
            azureOperationHelper.storageAccountName = "dbpoc";
            azureOperationHelper.storageEndPoint = "core.windows.net";
            // Destination Path where you want to download file
            azureOperationHelper.destinationPath = destinationPath;
            // Your Container Name 
            azureOperationHelper.containerName = "filecontainer";
            // Blob Path in container where to download File
            azureOperationHelper.blobName = srcPath;
            
            AzureOperations.DownloadFile(azureOperationHelper);

        }       
    }
}
