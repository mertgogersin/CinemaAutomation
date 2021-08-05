using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu.Repositories
{
    public class JsonManagement
    {
        JsonSerializer serializer;
       
        string path;
        List<Musteri> musteriler;
        public JsonManagement()
        {
            path = @"../Musteriler.json";
            serializer = new JsonSerializer();
            musteriler = new List<Musteri>();
        }
        public List<Musteri> GetDeserializedMusteriler()
        {
            return musteriler;
        }
        public void SerializeMusteriler()
        {
            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, musteriler);
            writer.Close();
        }
        public void DeserializeMusteriler()
        {
            StreamReader reader = new StreamReader(path);
            musteriler = (List<Musteri>)serializer.Deserialize(reader, typeof(List<Musteri>));
            reader.Close();

        }
         
        
    }
}
