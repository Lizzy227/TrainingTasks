using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_HierarchicalStructure.Model;
using Task2_HierarchicalStructure.View;
using Newtonsoft.Json;
using System.Reflection;
using System.Windows.Forms;

namespace Task2_HierarchicalStructure.Controller
{
    public class PersonController
    {
        PersonModel personModel = PersonModel.GetInstance();


        public PersonController() 
        {
                                  
        }
        public List<Person> GetPeopleList()
        {
            return personModel.People;
        }

        public void AddPerson(Person person)
        {
           personModel.AddPerson(person);
        }

        public bool RemovePerson(Person person)
        {
            return personModel.RemovePerson(person);
        }

        public void AddRelationship(Person mainPerson, Relationship newRelationship)
        {
             personModel.AddRelationship(mainPerson, newRelationship);
        }

        public void RemoveRelationship(Person mainPerson, Relationship relationToRemove) 
        {
            personModel.RemoveRelationship(mainPerson, relationToRemove);
        }
        
        //Display relationship with derived name:
        
        

      
    }
}
