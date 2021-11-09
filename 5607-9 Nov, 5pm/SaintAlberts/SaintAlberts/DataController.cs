using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SaintAlberts
{
    public partial class DataController : Form
    {
        public DataTable dtAdmission;
        public DataTable dtAllocation;
        public DataTable dtDoctor;
        public DataTable dtWard;
        public DataTable dtPatient;
        public DataTable dtPayment;
        public DataTable dtResearchProject;
        public DataTable dtResearchTopic;
        public DataTable dtMedication;
        public DataTable dtPrescription;
        public DataView admissionView;
        public DataView allocationView;
        public DataView doctorView;
        public DataView wardView;
        public DataView patientView;
        public DataView paymentView;
        public DataView researchProjectView;
        public DataView researchTopicView;
        public DataView medicationView;
        public DataView prescriptionView;
        public DataController()
        {
            InitializeComponent();
            dsSaintAlberts.EnforceConstraints = false;
            daAdmission.Fill(dsSaintAlberts);
            daAllocation.Fill(dsSaintAlberts);
            daDoctor.Fill(dsSaintAlberts);
            daMedication.Fill(dsSaintAlberts);
            daPatient.Fill(dsSaintAlberts);
            daPayment.Fill(dsSaintAlberts);
            daPrescription.Fill(dsSaintAlberts);
            // daResearchProject.Fill(dsSaintAlberts);
            daResearchTopic.Fill(dsSaintAlberts);
            daWard.Fill(dsSaintAlberts);
            dtAdmission = dsSaintAlberts.Tables["Admission"];
            dtAllocation = dsSaintAlberts.Tables["Allocation"];
            dtDoctor = dsSaintAlberts.Tables["Doctor"];
            dtMedication = dsSaintAlberts.Tables["Medication"];
            dtPatient = dsSaintAlberts.Tables["Patient"];
            dtPayment = dsSaintAlberts.Tables["Payment"];
            dtPrescription = dsSaintAlberts.Tables["Prescription"];
            dtResearchProject = dsSaintAlberts.Tables["ResearchProject"];
            dtResearchTopic = dsSaintAlberts.Tables["ResearchTopic"];
            dtWard = dsSaintAlberts.Tables["Ward"];
            admissionView = new DataView(dtAdmission);
            admissionView.Sort = "AdmissionID";
            allocationView = new DataView(dtAllocation);
            allocationView.Sort = "AdmissionID,DoctorID";
            doctorView = new DataView(dtDoctor);
            doctorView.Sort = "DoctorID";
            medicationView = new DataView(dtMedication);
            medicationView.Sort = "MedicationID";
            patientView = new DataView(dtPatient);
            patientView.Sort = "PatientID";
            paymentView = new DataView(dtPayment);
            paymentView.Sort = "PaymentCode";
            prescriptionView = new DataView(dtPrescription);
            prescriptionView.Sort = "AdmissionID,MedicationID";
            // researchProjectView = new DataView(dtResearchProject);
            // researchProjectView.Sort = "ResearchProjectID";
            // researchTopicView = new DataView(dtResearchTopic);
            // researchTopicView.Sort = "ResearchTopicID";
            wardView = new DataView(dtWard);
            wardView.Sort = "WardID";
            dsSaintAlberts.EnforceConstraints = true;
        }

        public void UpdateMedication()
        {
            daMedication.Update(dsSaintAlberts, "Medication");
        }

        private void daMedication_RowUpdate(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnSaintAlberts);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["MedicationID"] = newID;
            }
        }

        public void UpdateWard()
        {
            daWard.Update(dsSaintAlberts, "Ward");
        }

        private void daWard_RowUpdate(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnSaintAlberts);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["WardID"] = newID;
            }
        }
    }
}
