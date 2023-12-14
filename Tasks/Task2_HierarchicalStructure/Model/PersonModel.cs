using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2_HierarchicalStructure.Model
{
   
        public class PersonModel
        {
            private static PersonModel instance;
           
            public List<Person> People { get; private set; }

        

            private PersonModel()
            {
            People = JSONFileDatabase.LoadAllPersonsFromJSONFile();
            }

        //Create a single instance of People list to be used across the whole application:
        // Using Singleton Pattern

        public static PersonModel GetInstance() 
        {
            if (instance == null)
            {
                instance = new PersonModel();
            }
            return instance;
        }

           
            public void AddPerson(Person person)
            {
                People.Add(person);
            JSONFileDatabase.SaveAllPersonsToJsonFile( People);
            }

        public bool RemovePerson(Person person)
        {
            JSONFileDatabase.RemoveAPersonFromJsonFile(person);
            return People.Remove(person);    

        }

        public void AddRelationship(Person mainPerson, Relationship newRelationship)
        {

            mainPerson.AddRelationship(newRelationship);
            JSONFileDatabase.SaveAllPersonsToJsonFile(People);

        }

        public void RemoveRelationship(Person mainPerson, Relationship relationToRemove)
        {
            mainPerson.RemoveRelationship(relationToRemove);
            JSONFileDatabase.SaveAllPersonsToJsonFile(People);

        }
       



    }

}
