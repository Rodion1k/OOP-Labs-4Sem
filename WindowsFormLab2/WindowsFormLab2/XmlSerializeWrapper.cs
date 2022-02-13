using System.IO;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace WindowsFormLab2
{
    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs,obj);
            }
        }
        public static void Deserialize<T>(ref T obj, string filename)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
              obj = (T)xmlFormatter.Deserialize(fs);
            }
        }
        
    }
}