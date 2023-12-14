using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure.Forms
{
    public partial class ManageRelationships : Form
    {

        private readonly PersonController _personController;
        PersonModel personModel = PersonModel.GetInstance();
        private PersonList personListForm;
        public Person mainPerson;


        private List<Person> allPersons;

        public ManageRelationships(PersonList personListForm, List<Person> persons)
        {
            InitializeComponent();

            _personController = new PersonController();
            this.personListForm = personListForm;
            allPersons = persons;
            LoadDataGridView();



        }

        private void LoadDataGridView()
        {
            mpRelationshipDataGridView.ColumnCount = 3;
            mpRelationshipDataGridView.Columns[0].Name = "RelationshipType";
            mpRelationshipDataGridView.Columns[1].Name = "RelatedPersonName";
            mpRelationshipDataGridView.Columns[2].Name = "RelatedPerson";
            mpRelationshipDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        public void DisplayRelationshipsInDataGridView(Person mainPerson)
        {
            this.mainPerson = mainPerson;
            mpRelationshipDataGridView.Rows.Clear();

            foreach (Relationship relationship in mainPerson.Relationships)
            {
                if (relationship.RelatedPerson != null && relationship.RelatedPerson != null)
                {
                    mpRelationshipDataGridView.Rows.Add(
                        relationship.Type, relationship.RelatedPerson.Name, relationship.RelatedPerson);
                }

            }
        }
        public void SetMainPersonDetails(Person mainPerson)
        {

            mainPersonTextbox.Text = $"{mainPerson.Name} {mainPerson.Surname}";

            mainPersonTextbox.ReadOnly = true;
        }



        public void PopulateRelationshipTypesCombo()
        {
            relationshipTypeComboBox.DataSource = Enum.GetValues(typeof(RelationshipType));
        }


        public void PopulateRelatedPersonCombo(string mainPersonId)
        {
            var relatedPersons = allPersons.Where(p => p.Id != mainPersonId).ToList();

            cbxNames.DataSource = relatedPersons;
            cbxNames.DisplayMember = "Name";
            cbxNames.ValueMember = "Id";

        }

        private void addRelationshipButton_Click(object sender, EventArgs e)
        {
            if (mainPerson != null)
            {
                if (relationshipTypeComboBox.SelectedItem is RelationshipType selectedRelationship &&
                    cbxNames.SelectedItem is Person relatedPerson)
                {
                    bool relationshipExists = mainPerson.Relationships.Any(r =>
                        r.Type == selectedRelationship && r.RelatedPerson == relatedPerson);

                    if (relationshipExists)
                    {
                        MessageBox.Show("Relationship already exists!");
                        return;
                    }

                    Relationship newRelationship = new Relationship(relatedPerson, selectedRelationship);
                    _personController.AddRelationship(mainPerson, newRelationship);
                }
            }
            DisplayRelationshipsInDataGridView(mainPerson);
        }


        private void cancelRelationshipButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mpRelationshipDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (mpRelationshipDataGridView.SelectedRows.Count == 1)
            {
                removeRelationshipButton.Enabled = true;
            }
            else
            {
                removeRelationshipButton.Enabled = false;
            }
        }
       

        private void removeRelationshipButton_Click(object sender, EventArgs e)
        {
            if (mpRelationshipDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = mpRelationshipDataGridView.SelectedRows[0];

                Relationship relationToRemove = GetRelationFromSelectedRow(selectedRow);

                _personController.RemoveRelationship(mainPerson, relationToRemove);

                DisplayRelationshipsInDataGridView(mainPerson);

            }
        }

        private Relationship GetRelationFromSelectedRow(DataGridViewRow selectedRow)
        {
            if (selectedRow != null && selectedRow.Cells.Count >= 2)
            {
                
                Person relatedPersonId = selectedRow.Cells["RelatedPerson"].Value as Person;
                RelationshipType selectedRelationship;

                if (Enum.TryParse(selectedRow.Cells["RelationshipType"].Value?.ToString(), out selectedRelationship))
                {
                    return new Relationship(relatedPersonId, selectedRelationship);
                }
            }

            return null;
        }

    }
}
