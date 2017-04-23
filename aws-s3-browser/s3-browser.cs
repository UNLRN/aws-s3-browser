﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Amazon;
using Amazon.S3;
using Amazon.S3.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.IO;

namespace aws_uploader
{
    public partial class frmMain : Form
    {
        //CODE FOR PLACEHOLDER TEXT IN TEXTBOX//
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        //Upload Variables//
        public string[] folders;
        public string[] files;

        //S3 Variables//
        public AmazonS3Client s3Client;
        public string bucketname = "srpdesign";
        public string rootFolder = "";

        //S3 Methods//
        //Create S3 Bucket//
        static void CreateBucket(IAmazonS3 client, string bucket)
        {
            bucket = bucket.Replace("\\", "/");
            try
            {
                PutBucketRequest putRequest = new PutBucketRequest
                {
                    BucketName = "srpdesign/" + bucket + "/",
                    UseClientRegion = true
                };

                PutBucketResponse response = client.PutBucket(putRequest);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                Console.WriteLine(amazonS3Exception);
            }
        }
        //Upload S3 Files//

        public frmMain()
        {
            InitializeComponent();

            //CODE FOR PLACEHOLDER TEXT IN TEXTBOX
            //SendMessage(tbx_searchKey.Handle, EM_SETCUEBANNER, 0, "Search Key...");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            s3Client = new AmazonS3Client(RegionEndpoint.USEast1);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            aws_settings settings = new aws_settings();
            settings.Show();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (ofd_getFolders.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofd_getFolders.FileName != null &&
                        (ofd_getFolders.FileName.EndsWith("Choose Folder") || !File.Exists(ofd_getFolders.FileName)) &&
                        !Directory.Exists(ofd_getFolders.FileName))
                    {
                        tbx_directory.Text = Path.GetDirectoryName(ofd_getFolders.FileName);
                        folders = Directory.GetDirectories(tbx_directory.Text, "*", SearchOption.AllDirectories);
                        foreach (string item in folders)
                        {
                            dgv_fileList.Rows.Add(item, "Folder");
                        }
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                }
                ofd_getFolders.FileName = "Choose Folder";
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (ofd_getFiles.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    files = ofd_getFiles.FileNames;
                    foreach (string item in files)
                    {
                        dgv_fileList.Rows.Add(item, "File");
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                }
            }
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgv_fileList.SelectedRows)
            {
                dgv_fileList.Rows.RemoveAt(item.Index);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgv_fileList.Rows)
            {
                if (dgv_fileList.Rows[i].Cells["Type"].Value.ToString() == "Folder")
                {
                    string itemToUpload = dgv_fileList.Rows[i].Cells["Item"].Value.ToString();
                    if (!(AmazonS3Util.DoesS3BucketExist(s3Client, itemToUpload)))
                    {
                        DialogResult dialogResult = MessageBox.Show("S3 Bucket does not exist. Would you like to create it?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            CreateBucket(s3Client, itemToUpload);
                        }
                    }
                }
                if (dgv_fileList.Rows[i].Cells["Type"].Value.ToString() == "File")
                {
                    try
                    {
                        TransferUtility fileTransferUtility = new TransferUtility(s3Client);
                        string itemToUpload = dgv_fileList.Rows[i].Cells["Item"].Value.ToString();
                        string key = itemToUpload.Replace("C:\\", "");

                        TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
                        {
                            BucketName = "srpdesign",
                            FilePath = itemToUpload,
                            Key = (key.Replace("\\", "/"))
                        };
                        fileTransferUtility.Upload(request);

                    }
                    catch (AmazonS3Exception ae)
                    {
                        Console.WriteLine(ae.Message, ae.InnerException);
                    }
                }
                i++;
            }

            try
            {
                TransferUtility fileTransferUtility = new TransferUtility(s3Client);
                string itemToUpload = dgv_fileList.Rows[0].Cells[0].Value.ToString();
                string s = itemToUpload.Replace(@"C:\", "");

                TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
                {
                    BucketName = "srpdesign",
                    FilePath = itemToUpload,
                    Key = (s.Replace("\\", "/"))
                };
                fileTransferUtility.Upload(request);

            }
            catch (AmazonS3Exception ae)
            {
                Console.WriteLine(ae.Message, ae.InnerException);
            }
        }
    }
}