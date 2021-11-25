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
    public partial class WardAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public WardAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        
        public void DisplayWards()
        {
            string wardText = "";
            txtWards.Text = "";

            foreach (DataRow drWard in DC.dtWard.Rows)
            {
                wardText += drWard["WardName"] + ", ";
                wardText += drWard["WardLocation"] + ", ";
                wardText += drWard["WardCapacity"] + "\r\n";
                txtWards.Text += wardText;
                wardText = "";
            }
        }

        private void clearFields()
        {
            txtWardName.Text = "";
            txtWardLocation.Text = "";
            nudWardCapacity.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddWard_Click(object sender, EventArgs e)
        {
            if (txtWardName.Text == "" || txtWardLocation.Text == "" || nudWardCapacity.Text == "")
            {
                MessageBox.Show("Please fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newWardRow = DC.dtWard.NewRow();
                newWardRow["WardName"] = txtWardName.Text;
                newWardRow["WardLocation"] = txtWardLocation.Text;
                newWardRow["WardCapacity"] = nudWardCapacity.Value;
                DC.dsSaintAlberts.Tables["Ward"].Rows.Add(newWardRow);
                DC.UpdateWard();
                DisplayWards();
                MessageBox.Show("Ward added successfully", "Acknowledgment", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                DialogResult dialogAgain = MessageBox.Show("Add another ward?", "Add", MessageBoxButtons.YesNo);
                if (dialogAgain == DialogResult.Yes)
                {
                    txtWardName.Text = "";
                    txtWardLocation.Text = "";
                    nudWardCapacity.Text = "";
                }
                else if (dialogAgain == DialogResult.No)
                {
                    txtWardName.Text = "";
                    txtWardLocation.Text = "";
                    nudWardCapacity.Text = "";
                    this.Hide();
                    frmMenu.Show();
                }
                clearFields();
            }
        }
        private void WardAddForm_Load(object sender, EventArgs e)
        {
            DisplayWards();
        }
    }
}
