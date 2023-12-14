using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2_HierarchicalStructure
{
    public partial class PersonInfo : Form
    {
        
        private readonly PersonController _personController;
        private PersonList personListForm;
        private Person _selectedPerson;

        public PersonInfo(PersonList personListForm, Person selectedPerson = null)
        {
            InitializeComponent();
            _personController = new PersonController();
            this.personListForm = personListForm;
            SetUniqueIDtoPerson();
            _selectedPerson = selectedPerson;

            if (_selectedPerson != null ) 
            {
                UpdatePersonDetails(_selectedPerson);

            }
            else
            {
                SetUniqueIDtoPerson();
            }

        }

        private void SetUniqueIDtoPerson()
        {
            string uniqueId = GenerateUniqueId(); 
            idNumberTextbox.Text = uniqueId; 
            idNumberTextbox.ReadOnly = true;
        }

        private void addPersonCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addPersonSaveButton_Click(object sender, EventArgs e)
        {
            if (_selectedPerson == null)
            {
                // Adding a new person
                _personController.AddPerson(PersonWithInfo());
                string newUniqueId = GenerateUniqueId();
                idNumberTextbox.Text = newUniqueId;
            }
            else
            {
                // Updating an existing person
                UpdatePersonDetails(_selectedPerson);
            }

            this.Close();
            


        }

        private string GenerateUniqueId()
        {
            return Guid.NewGuid().ToString();
        }

        private Person PersonWithInfo()
        {
            string id = idNumberTextbox.Text;
            string name = nameTextbox.Text;
            string surname = surnameTextbox.Text;
            int age = (int)ageNumeric.Value;
            string sex = sexComboBox.SelectedItem?.ToString();
            string gender = genderComboBox.SelectedItem?.ToString();
            bool isDeceased = relationshipCheckBox.Checked;

            
            Person person = new Person(id, name, surname, age, sex, gender, isDeceased);

            return person;
        }

        public void UpdatePersonDetails(Person selectedPerson)
        {


            idNumberTextbox.Text = selectedPerson.Id;
            nameTextbox.Text = selectedPerson.Name;
            surnameTextbox.Text = selectedPerson.Surname;
            ageNumeric.Value = selectedPerson.Age; 
            sexComboBox.SelectedItem = selectedPerson.Sex; 
            genderComboBox.SelectedItem = selectedPerson.Gender;
            relationshipCheckBox.Checked = selectedPerson.IsDeceased;
        }

    }
}
