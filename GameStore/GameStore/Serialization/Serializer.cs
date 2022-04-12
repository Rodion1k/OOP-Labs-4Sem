using System.IO;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;


namespace GameStore.Serialization
{
    public static class Serializer
    {
        public static void Serialize<T>(T obj, string path)
        {
            using (var stream = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write))
            {
                stream.SetLength(0);
                var formatter = new DataContractJsonSerializer(typeof(T));
                formatter.WriteObject(stream, obj);
            }
        }
        public static bool Deserialize<T>(string path, out T obj)
        {
            using (var stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                var formatter = new DataContractJsonSerializer(typeof(T));
                obj = (T)formatter.ReadObject(stream);
                if(obj == null)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}