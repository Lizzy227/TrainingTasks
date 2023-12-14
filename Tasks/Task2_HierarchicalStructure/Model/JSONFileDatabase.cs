using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public static class JSONFileDatabase
    {
        static string jsonFilePath = @"..\..\..\Data\JSONFamily.json";

       
        public static void SaveAllPersonsToJsonFile(List<Person> people)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error saving to JSON file: {ex.Message}");
            }
        }


        public static List<Person> LoadAllPersonsFromJSONFile()
        {
            List<Person> people = new List<Person>();
            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

                
            }
            catch (Exception ex)
            {

                throw new Exception("Failed to load person objects from JSONfile");
            }
            return people;
        }


        public static void RemoveAPersonFromJsonFile(Person person)
        {

            List<Person> existingData = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(jsonFilePath));


            existingData.RemoveAll(p => p.Id == person.Id);


            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingData, Formatting.Indented));
        }

        
    }
}
