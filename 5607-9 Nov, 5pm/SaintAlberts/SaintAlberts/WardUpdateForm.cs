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
    public partial class WardUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public WardUpdateForm(DataController dc, MainForm mnu)
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
            nudWardCapacity.DataBindings.Add("Text", DC.dsSaintAlberts, "Ward.WardCapacity");
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

        private void btnUpdateWard_Click(object sender, EventArgs e)
        {
            DataRow updateWardRow = DC.dtWard.Rows[currencyManager.Position];
            if ((txtWardName.Text == "") || (txtWardLocation.Text == "") || (nudWardCapacity.Text == ""))
            {
                MessageBox.Show("Please fill in the fileds correctly", "Error");
                return;
            }
            else
            {
                updateWardRow["WardName"] = txtWardName.Text;
                updateWardRow["WardLocation"] = txtWardLocation.Text;
                updateWardRow["WardCapacity"] = nudWardCapacity.Value;
                currencyManager.EndCurrentEdit();
                DC.UpdateWard();
                MessageBox.Show("Ward updated successfully", "Success");
            }
        }
    }
}
