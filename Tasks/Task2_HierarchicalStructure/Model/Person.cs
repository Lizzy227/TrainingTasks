using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace Task2_HierarchicalStructure.Model
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }

        public int Age { get; set; }
        public string Sex { get; set; }
        public string Gender { get; set; }
        public bool IsDeceased { get; set; }


       // public List<BChildren>?  BiologicalChildren {  get; set; }
       // public List<Pets>? Pets { get; set; }
        public List<Relationship>? Relationships { get; private set; }


    public Person(string id, string name, string surname, int age, string sex, string gender, bool isDeceased)
    {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
            Gender = gender;
            IsDeceased = isDeceased;
            Relationships = new List<Relationship>();
    }

        //@LIZ does this need to move to model?
        public void AddRelationship(Relationship newRelationship)
        {
            
            var relatedPerson = newRelationship.RelatedPerson;
            var relationshipType = newRelationship.Type;

                Relationships.Add(new Relationship(relatedPerson, relationshipType));
        }

        public void RemoveRelationship(Relationship relationshipToRemove)
        {
            if (relationshipToRemove != null)
            {
                
                string relatedPersonID = relationshipToRemove.RelatedPerson.Id;
                RelationshipType relationshipType = relationshipToRemove.Type;

              
                Relationship relationshipInList = Relationships.FirstOrDefault(r => r.RelatedPerson.Id == relatedPersonID && r.Type == relationshipType);

                if (relationshipInList != null)
                {
                    Relationships.Remove(relationshipInList);
                }
            }


    }



   

}}
