using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Xml.Serialization;

namespace ISRso
{
    [Serializable]
    public class Settings
    {
        public string DBpath { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool isDefault { get; set; }

        private const string ErrOpen = "Не удалось прочитать файл настроек!\n";
        private const string ErrSave = "Не удалось сохранить настройки!\n";
        private static Settings _instance = new Settings();
        static Settings() { }
        private Settings()
        {
            isDefault = true;
        }
        public static Settings Instance => _instance;

        public void Save()
        {
            try
            {
                FileMode mode;
                FileInfo test = new FileInfo("config.xml");
                if (test.Exists)
                {
                    mode = FileMode.Truncate;
                }
                else
                {
                    mode = FileMode.OpenOrCreate;
                }
                var saver = new XmlSerializer(Instance.GetType());
                using (var stream = File.Open("config.xml", mode, FileAccess.Write))
                {
                    saver.Serialize(stream, Settings.Instance);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(ErrSave + err.Message);
            }
        }
        public void Load()
        {
            try
            {
                var saver = new XmlSerializer(typeof(Settings));
                using (var stream = File.Open("config.xml", FileMode.Open, FileAccess.Read))
                {
                    _instance = (Settings)saver.Deserialize(stream);
                    isDefault = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(ErrOpen + err.Message);
            }

        }
    }
}
