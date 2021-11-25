using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintAlberts
{
    public partial class MedicationAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public MedicationAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        public void DisplayMedications()
        {
            string medicationText = "";
            txtMedications.Text = "";
            foreach (DataRow drMedication in DC.dtMedication.Rows)
            {
                medicationText += drMedication["MedicationID"] + ", ";
                medicationText += drMedication["MedicationName"] + ", ";
                medicationText += drMedication["MedicationCost"] + " NZD, " + "\r\n\r\n";
                txtMedications.Text += medicationText;
                medicationText = "";
            }
        }

        private void clearFields()
        {
            txtMedicationName.Text = "";
            nudMedicationCost.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            if (txtMedicationName.Text == "" || nudMedicationCost.Text == "")
            {
                MessageBox.Show("Please fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newMedicationRow = DC.dtMedication.NewRow();
                newMedicationRow["MedicationName"] = txtMedicationName.Text;
                newMedicationRow["MedicationCost"] = nudMedicationCost.Value;
                DC.dsSaintAlberts.Tables["Medication"].Rows.Add(newMedicationRow);
                DC.UpdateMedication();
                DisplayMedications();
                MessageBox.Show("Medication added successfully", "Acknowledgment", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                DialogResult dialogAgain = MessageBox.Show("Add another medication?", "Add", MessageBoxButtons.YesNo);
                if (dialogAgain == DialogResult.Yes)
                {
                    txtMedicationName.Text = "";
                    nudMedicationCost.Text = "";
                }
                else if (dialogAgain == DialogResult.No)
                {
                    txtMedicationName.Text = "";
                    nudMedicationCost.Text = "";
                    this.Hide();
                    frmMenu.Show();
                }
                clearFields();
            }
        }

        private void MedicationAddForm_Load(object sender, EventArgs e)
        {
            DisplayMedications();
        }
    }
}
