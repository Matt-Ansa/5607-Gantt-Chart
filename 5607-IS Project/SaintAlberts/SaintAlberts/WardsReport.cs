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
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string wardsText = "";
            txtWard.Text = "";

            foreach (DataRow drWard in DC.dtWard.Rows)
            {
                wardsText += "Ward ID: " + drWard["WardID"] + "      " + "Ward Name: ";
                wardsText += drWard["WardName"] + "\r\n\r\n" + "Ward Location: ";
                wardsText += drWard["WardLocation"] + "       " + "Ward Capacity: ";
                wardsText += drWard["WardCapacity"] + "\r\n\r\n";

                DataRow[] drAdmissions = drWard.GetChildRows(DC.dtWard.ChildRelations["WardAdmission"]);
                
                foreach (DataRow drAdmission in drAdmissions)
                {
                   // wardsText += drAdmission["AdmissionID"];
                    DataRow drPatient = drAdmission.GetParentRow(DC.dtAdmission.ParentRelations["PatientAdmission"]);
                    wardsText += "Patient ID: " + drPatient["PatientID"] + "         " + " Last Name: ";
                    wardsText += drPatient["LastName"] + "         " + " First Name: ";
                    wardsText += drPatient["FirstName"] + "\r\n\r\n\r\n";
                }
               
                txtWard.Text += wardsText;
                wardsText = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}


        
