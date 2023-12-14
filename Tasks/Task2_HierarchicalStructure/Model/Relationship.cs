using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public class Relationship
    {
        public Person RelatedPerson { get; set; }
   
        public RelationshipType Type { get; }

    public Relationship( Person relatedPerson, RelationshipType type)
    {
        RelatedPerson = relatedPerson;
        Type = type;
    }
       
    }


    public enum RelationshipType
    {
        Parent, //neutral
        Child,
        Sibling,
        Partner, //neutral
        Father, //Male
        Son,
        Brother,
        Boyfriend,
        Husband, //Male
        Mother, //Female
        Daughter,
        Sister,
        Girlfriend,
        Wife //Female


        
    }

}
