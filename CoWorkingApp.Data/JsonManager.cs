using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoWorkingApp.Data
{
    public class JsonManager<T>
    {
        public List<T> GetCollection()
        {
            // Get and create string path
            string collectionPath = $@"{Directory.GetCurrentDirectory()}/{typeof(T)}.json";

            // Create New List Temp
            List<T> myCollection = new List<T>();

            if(File.Exists(collectionPath))
            {
                var streamReader = new StreamReader(collectionPath);
                var currentContent = streamReader.ReadToEnd();
                myCollection = JsonConvert.DeserializeObject<List<T>>(currentContent); // Transform string to Json
                streamReader.Close(); // Good practica
            }
            else
            {
                var streamWritter = new StreamWriter(collectionPath);
                var jsonCollection = JsonConvert.SerializeObject(myCollection);
                streamWritter.WriteLine(jsonCollection);
                streamWritter.Close();
            }

            return myCollection;

        }

        public bool SaveCollection(T collection)
        {
            string collectionPath = $@"{Directory.GetCurrentDirectory()}/{typeof(T)}.json";

            try
            {
                var streamWritter = new StreamWriter(collectionPath);
                var jsonCollection = JsonConvert.SerializeObject(collection); // Transform string to Json
                streamWritter.WriteLine(jsonCollection);
                streamWritter.Close();
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;

        }

    }
}