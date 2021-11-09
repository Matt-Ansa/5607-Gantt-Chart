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
    public partial class WardsReportForm : Form // the reference to the data controller and main form objects
    {
        private DataController DC;
        private MainForm frmMenu;
        public WardsReportForm(DataController dc, MainForm mnu) // constructor change to accept the data controller and main form references
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDisplayWards_Click(object sender, EventArgs e)
        {
            string wardsText = "";
            txtWards.Text = "";

            foreach (DataRow drWard in DC.dtWard.Rows)
            {
                wardsText += "WardID: " + drWard["WardID"] + ", WardName: ";
                wardsText += drWard["WardName"] + "Location: ";
                wardsText += drWard["Location"] + "Capacity";
                wardsText += drWard["Capacity"] + "\r\n\r\n";
                txtWards.Text += wardsText;
                wardsText = "";
            }
        }
    }
}
