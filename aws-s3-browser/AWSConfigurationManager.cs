using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3.Model;

namespace aws_uploader
{
    class AWSConfigurationManager
    {

        private static string parentPath = @"%USERPROFILE%\.aws\";
        private static string fileName = "credentials.";

        public static BucketConfiguration GetConfiguration()
        {
            var fullFileName = Environment.ExpandEnvironmentVariables(parentPath) + AWSConfigurationManager.fileName;

            if (!File.Exists(fullFileName))
            {
                return new BucketConfiguration();
            }

            var lines = System.IO.File.ReadAllLines(fullFileName);
            return new BucketConfiguration()
            {
                AccessKey = lines[1].Split('=')[1].Trim(),
                SecretKey = lines[2].Split('=')[1].Trim(),
                Region = lines[3].Split('=')[1].Trim(),
            };
        }

        public static void SaveConfiguration(BucketConfiguration bucketConfiguration)
        {
            string[] lines =
            {
                "[default]",
                $"aws_access_key_id = {bucketConfiguration.AccessKey}",
                $"aws_secret_access_key = {bucketConfiguration.SecretKey}",
                $"aws_region_name = {bucketConfiguration.Region}",
            };

            var filePath = Environment.ExpandEnvironmentVariables(parentPath);

            bool direxists = Directory.Exists(filePath);
            bool fileexists = File.Exists(filePath + fileName);

            if (!direxists)
                Directory.CreateDirectory(filePath);

            if (!fileexists)
            {
                File.Create(filePath + fileName);
            }

            File.WriteAllLines((filePath + fileName), lines);

        }
    }

    internal class BucketConfiguration
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Region { get; set; }

    }
}
