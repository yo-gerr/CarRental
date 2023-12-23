using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Classes
{
    internal class Configuration
    {
        public static string ConnString
        {
            get
            {
                return _getConfig("ConnString");
            }
        }
        public static string UploadPath
        {
            get
            {
                return _getConfig("UploadPath");
            }
        }
        private static string ConfigFile
        {
            get
            {
                return System.AppDomain.CurrentDomain.BaseDirectory + "Config.txt";
            }
        }
        private static string _getConfig(string configName)
        {
            string configValue = "";
            FileStream fs = new FileStream(ConfigFile, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.IndexOf(configName) > -1)
                {
                    configValue = line.Substring(line.IndexOf("=") + 1);
                }
            }
            fs.Close();
            sr.Close();
            return configValue;
        }
    }
}
