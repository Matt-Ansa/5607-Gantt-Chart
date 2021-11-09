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
    public partial class MainForm : Form
    {
        private DataController DC;                          // the reference to the form that holds the data controls
        private MedicationAddForm frmMedicationAdd;         // the reference to the add medication form
        private MedicationUpdateForm frmMedicationUpdate;   // the reference to the update medication form
        private MedicationDeleteForm frmMedicationDelete;   // the reference to the delete medication form  
        private WardAddForm frmWardAdd;                     // the reference to the add ward form
        private WardUpdateForm frmWardUpdate;               // the reference to the update ward form
        private WardDeleteForm frmWardDelete;               // the reference to the delete ward form
        private WardsReportForm frmWardsReport;             // the refercen to the wards report form
        private AdmissionCloseForm frmAdmissionClose;       // the reference to the close admission form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); // create the data controller and load the dataset
        }

        private void btnWardsReport_Click(object sender, EventArgs e) // the referecne to the data controller and main form
        {
            if (frmWardsReport == null)
            {
                frmWardsReport = new WardsReportForm(DC, this);
            }
            frmWardsReport.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateMedication_Click(object sender, EventArgs e)
        {
            if (frmMedicationUpdate == null)
            {
                frmMedicationUpdate = new MedicationUpdateForm(DC, this);
            }
            frmMedicationUpdate.ShowDialog();
        }

        private void btnDeleteMedication_Click(object sender, EventArgs e)
        {
            if (frmMedicationDelete == null)
            {
                frmMedicationDelete = new MedicationDeleteForm(DC, this);
            }
            frmMedicationDelete.ShowDialog();
        }

        private void btnUpdateWard_Click(object sender, EventArgs e)
        {
            if (frmWardUpdate == null)
            {
                frmWardUpdate = new WardUpdateForm(DC, this);
            }
            frmWardUpdate.ShowDialog();

        }
    }
}
