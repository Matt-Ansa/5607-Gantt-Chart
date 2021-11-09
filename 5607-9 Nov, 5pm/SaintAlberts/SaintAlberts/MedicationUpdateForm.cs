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
    public partial class MedicationUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public MedicationUpdateForm(DataController dc, MainForm mnu)
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

        private void btnUpdateMedication_Click(object sender, EventArgs e)
        {
            DataRow updateMedicationRow = DC.dtMedication.Rows[currencyManager.Position];
            if ((txtMedicationName.Text == "") || (nudMedicationCost.Text == ""))
            {
                MessageBox.Show("Please fill in the fileds correctly", "Error");
                return;
            }
            else
            {
                updateMedicationRow["MedicationName"] = txtMedicationName.Text;
                updateMedicationRow["MedicationCost"] = nudMedicationCost.Value;
                currencyManager.EndCurrentEdit();
                DC.UpdateMedication();
                MessageBox.Show("Medication updated successfully", "Success");
            }
        }

        private void MedicationUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
