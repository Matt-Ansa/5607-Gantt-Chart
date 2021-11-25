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
    public partial class MedicationDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public MedicationDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        public void BindControls()
        {
            txtMedicationID.DataBindings.Add("Text", DC.dsSaintAlberts, "Medication.MedicationID");
            txtMedicationName.DataBindings.Add("Text", DC.dsSaintAlberts, "Medication.MedicationName");
            nudMedicationCost.DataBindings.Add("Value", DC.dsSaintAlberts, "Medication.MedicationCost");
            lstMedications.DataSource = DC.dsSaintAlberts;
            lstMedications.DisplayMember = "Medication.MedicationID";
            lstMedications.ValueMember = "Medication.MedicationID";
            lstMedications.DisplayMember = "Medication.MedicationName";
            lstMedications.ValueMember = "Medication.MedicationName";
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsSaintAlberts, "Medication"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteMedication_Click(object sender, EventArgs e)
        {
            DataRow deleteMedicationRow = DC.dtMedication.Rows[currencyManager.Position];
            DataRow[] drPrescriptions = deleteMedicationRow.GetChildRows(DC.dtMedication.ChildRelations["MedicationPrescription"]);
            if (drPrescriptions.Length == 0)
            {
                deleteMedicationRow.Delete();
                DC.UpdateMedication();
                MessageBox.Show("Medication deleted successfully", "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Delete another medication?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                clearFields();
            }
            else
            {
                MessageBox.Show("This medication has prescirptions linked to it", "Error");
            }
        }
        private void clearFields()
        {
            txtMedicationName.Text = "";
            nudMedicationCost.Text = "";
        }
    }
}
