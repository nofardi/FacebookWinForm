using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookApp
{
    class AppSettings
    {
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberMe { get; set; }
        public string AccessToken { get; set; }

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
            path = string.Format("{0}\\appSettings.xml", path);
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            String path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = string.Format("{0}\\appSettings.xml", path);
            AppSettings obj = null;
            try
            {
                if (File.Exists(path))
                {
                    using (Stream stream = new FileStream("", FileMode.Truncate))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        obj = serializer.Deserialize(stream) as AppSettings;
                    }
                }
                else
                {
                    obj = new AppSettings();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
                obj = new AppSettings();
            }

            return obj;
        }
    }
}
