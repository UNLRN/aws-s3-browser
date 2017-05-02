using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aws_uploader
{
    public partial class aws_settings : Form
    {
        public aws_settings()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Console.WriteLine();

            if (tbx_accountName.Text != "" & tbx_accessKey.Text != "" & tbx_secretKey.Text != "")
            {
                string[] credentials = { "[default]", "aws_access_key_id = " + tbx_accessKey.Text, "aws_secret_access_key = " + tbx_secretKey.Text };

                string filePath = @"%USERPROFILE%\.aws\";
                filePath = Environment.ExpandEnvironmentVariables(filePath);

                bool direxists = Directory.Exists(filePath);
                bool fileexists = File.Exists(filePath + "credentials.");
                if (!direxists)
                    Directory.CreateDirectory(filePath);
                if (!fileexists)
                {
                    File.Create(filePath + "credentials.");
                    try
                    {
                        File.WriteAllLines((filePath + "credentials."), credentials);
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Credentials already exist for this user.\r\nOverwrite File?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        try
                        {
                            File.WriteAllLines((filePath + "credentials."), credentials);
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err);
                        }
                }

            }
        }


    }
}
