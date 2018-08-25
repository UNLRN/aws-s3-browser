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
using Amazon;

namespace aws_uploader
{
    public partial class aws_settings : Form
    {
        public aws_settings()
        {
            InitializeComponent();

            cbx_Region.Items.Clear();
            cbx_Region.DataSource = RegionEndpoint.EnumerableAllRegions;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {

            if (cbx_Region.SelectedItem != null & tbx_accessKey.Text != "" & tbx_secretKey.Text != "")
            {

                var configuration = new BucketConfiguration()
                {
                    Region = ((RegionEndpoint) cbx_Region.SelectedItem).DisplayName,
                    SecretKey = tbx_secretKey.Text,
                    AccessKey = tbx_accessKey.Text,
                };

                AWSConfigurationManager.SaveConfiguration(configuration);

                MessageBox.Show("Configurations has been updated.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void aws_settings_Load(object sender, EventArgs e)
        {
            var config = AWSConfigurationManager.GetConfiguration();
            tbx_accessKey.Text = config.AccessKey;
            tbx_secretKey.Text = config.SecretKey;
            cbx_Region.SelectedItem =
                RegionEndpoint.EnumerableAllRegions.FirstOrDefault(r => r.DisplayName == config.Region);

        }
    }
}
