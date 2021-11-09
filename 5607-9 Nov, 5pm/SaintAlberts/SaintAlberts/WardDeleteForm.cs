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
    public partial class WardDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public WardDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        public void BindControls()
        {
            txtWardID.DataBindings.Add("Text", DC.dsSaintAlberts, "Ward.WardID");
            txtWardName.DataBindings.Add("Text", DC.dsSaintAlberts, "Ward.WardName");
            txtWardLocation.DataBindings.Add("Text", DC.dsSaintAlberts, "Ward.WardLocation");
            nudWardCapacity.DataBindings.Add("Value", DC.dsSaintAlberts, "Ward.WardCapacity");
            lstWards.DataSource = DC.dsSaintAlberts;
            lstWards.DisplayMember = "Ward.WardID";
            lstWards.ValueMember = "Ward.WardID";
            lstWards.DisplayMember = "Ward.WardName";
            lstWards.ValueMember = "Ward.WardName";
            currencyManager = (CurrencyManager)this.BindingContext[DC.dsSaintAlberts, "Ward"];
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteWard_Click(object sender, EventArgs e)
        {
            DataRow deleteWardRow = DC.dtWard.Rows[currencyManager.Position];
            DataRow[] drAdmissions = deleteWardRow.GetChildRows(DC.dtMedication.ChildRelations["WARD_ADMISSION"]);
            if (drAdmissions.Length == 0)
            {
                deleteWardRow.Delete();
                DC.UpdateWard();
                MessageBox.Show("Ward deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("This ward has admissions linked to it", "Error");
            }
        }
    }

}
