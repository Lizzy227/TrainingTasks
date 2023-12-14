using ReaLTaiizor.Controls;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Forms;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure
{
    public partial class PersonList : Form
    {
        private PersonController _personController;

        public PersonList()
        {
            _personController = new PersonController();
            InitializeComponent();
            LoadDataGridView();
            DisplayPeopleInDataGridView();

        }

        #region Form events
        private void LoadDataGridView()
        {
            personDataGridView.ColumnCount = 3;
            personDataGridView.Columns[0].Name = "ID";
            personDataGridView.Columns[1].Name = "Person";
            personDataGridView.Columns[2].Name = "Relations";
            personDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        #endregion
        public void DisplayPeopleInDataGridView()
        {
            personDataGridView.Rows.Clear();

            foreach (Person person in _personController.GetPeopleList())
            {

                string relationshipsInfo = GetRelationshipsInfo(person);

                personDataGridView.Rows.Add(person.Id, person.Name + " " + person.Surname, relationshipsInfo);
            }
        }

        private string GetRelationshipsInfo(Person person)
        {
            StringBuilder relationships = new StringBuilder();

            foreach (Relationship relationship in person.Relationships)
            {
                if (relationship.RelatedPerson != null && relationship.RelatedPerson.Name != null)
                {
                    relationships.Append($"{relationship.Type} to {relationship.RelatedPerson.Name}, ");
                }
                else
                {
                    relationships.Append($"{relationship.Type} with unknown person, ");
                }
            }


            if (relationships.Length > 0)
            {
                relationships.Length -= 2;
            }

            return relationships.ToString();
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            ShowFormPersonInfo();

        }


        private void personDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count == 1)
            {
                removePersonButton.Enabled = true;
                manageRelationshipsButton.Enabled = true;
            }
            else
            {
                removePersonButton.Enabled = false;
                manageRelationshipsButton.Enabled = false;
            }
        }

        private void removePersonButton_Click(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];

                Person personToRemove = GetPersonFromSelectedRow(selectedRow);

                RemovePerson(personToRemove);

                DisplayPeopleInDataGridView();
            }
        }

        private Person GetPersonFromSelectedRow(DataGridViewRow selectedRow)
        {
            string personId = selectedRow.Cells["ID"].Value.ToString();

            return _personController.GetPeopleList().FirstOrDefault(p => p.Id == personId);
        }

        private void RemovePerson(Person person)
        {
            bool removed = _personController.RemovePerson(person);

            if (removed)
            {
                MessageBox.Show("Person removed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to remove person.");
            }
        }

        private void manageRelationshipsButton_Click(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];

                Person mainPerson = GetPersonFromSelectedRow(selectedRow);

                if (mainPerson != null)
                {
                    ShowFormManageRelationships(mainPerson);
                }

                else
                {
                    MessageBox.Show("Please select a person from the list.");
                }
            }
        }

        private void ShowFormPersonInfo()
        {
            PersonInfo personInfoForm = new PersonInfo(this);
            personInfoForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView();
            personInfoForm.ShowDialog();
        }
        private void ShowFormManageRelationships(Person mainPerson)
        {
            ManageRelationships manageRelationshipsForm = new ManageRelationships(this, _personController.GetPeopleList());
            manageRelationshipsForm.DisplayRelationshipsInDataGridView(mainPerson);
            manageRelationshipsForm.SetMainPersonDetails(mainPerson);
            manageRelationshipsForm.PopulateRelatedPersonCombo(mainPerson.Id);
            manageRelationshipsForm.PopulateRelationshipTypesCombo();
            manageRelationshipsForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView();
            manageRelationshipsForm.Show();
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];
                Person selectedPerson = GetPersonFromSelectedRow(selectedRow);
                OpenEditPersonForm(selectedPerson);
            }

        }

        private void OpenEditPersonForm(Person selectedPerson)
        {
            PersonInfo personInfoForm = new PersonInfo(this, selectedPerson);
            personInfoForm.FormClosed += (s, ev) =>
            {
                if (personInfoForm.DialogResult == DialogResult.OK) // Assuming DialogResult.OK on successful save
                {
                    // Update the selected person in the list after changes in PersonInfo form
                    var peopleList = _personController.GetPeopleList();
                    int index = peopleList.FindIndex(p => p.Id == selectedPerson.Id); // Assuming Person has an ID property
                    if (index != -1)
                    {
                        peopleList[index] = selectedPerson; // Update the person in the list
                        DisplayPeopleInDataGridView(); // Refresh the DataGridView
                    }
                }
            };
            personInfoForm.ShowDialog();
        }
    }

    //public class HelperClass
    //{
    //    public void HelpMe(object sender, EventArgs e)
    //    {
    //        if (sender is not DataGridView dgv)
    //            return;

    //        if (dgv.SelectedRows.Count <= 0)
    //            return;

    //        DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];

    //        Person personToRemove = GetPersonFromSelectedRow(selectedRow);

    //        RemovePerson(personToRemove);

    //        DisplayPeopleInDataGridView();
    //    }
    //}
}