using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookApp
{
    public class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberMe { get; set; }
        public string AccessToken { get; set; }
        private const string k_FileName = "appSettings.xml";

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(876, 780);
            RememberMe = false;
            AccessToken = null;
        }

        public void SaveToFile()
        {
            String path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = string.Format("{0}\\{1}", path, k_FileName);
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            String path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = string.Format("{0}\\{1}", path, k_FileName);
            AppSettings obj = null;
            try
            {
                if (File.Exists(path))
                {
                    using (Stream stream = new FileStream(path, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        obj = (AppSettings)serializer.Deserialize(stream);
                    }
                }
                else
                {
                    obj = new AppSettings();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
                obj = new AppSettings();
            }

            return obj;
        }
    }
}
