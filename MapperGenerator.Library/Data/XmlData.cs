using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MapperGenerator.Library.Data
{
    public class XmlData<T> where T : class
    {
        private string filePath = "./savedata/data.xml";
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void Save(T item)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            string folderPath = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Entitize;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (XmlWriter writer = XmlWriter.Create(fileStream, ws))
                {
                    ser.Serialize(writer, item);
                }
            }
        }

        public T Load()
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            string folderPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(folderPath))
            {
                return null;
            }
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return ser.Deserialize(fileStream) as T;
            }
        }
    }
}
