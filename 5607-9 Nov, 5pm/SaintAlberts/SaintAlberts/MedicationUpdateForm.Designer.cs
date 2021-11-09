
namespace SaintAlberts
{
    partial class MedicationUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMedicationID = new System.Windows.Forms.Label();
            this.lblMedicationName = new System.Windows.Forms.Label();
            this.lblMedicationCost = new System.Windows.Forms.Label();
            this.txtMedicationID = new System.Windows.Forms.TextBox();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.nudMedicationCost = new System.Windows.Forms.NumericUpDown();
            this.lstMedications = new System.Windows.Forms.ListBox();
            this.btnUpdateMedication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicationCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicationID
            // 
            this.lblMedicationID.AutoSize = true;
            this.lblMedicationID.Location = new System.Drawing.Point(369, 20);
            this.lblMedicationID.Name = "lblMedicationID";
            this.lblMedicationID.Size = new System.Drawing.Size(104, 19);
            this.lblMedicationID.TabIndex = 0;
            this.lblMedicationID.Text = "Medication ID:";
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Location = new System.Drawing.Point(345, 70);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(128, 19);
            this.lblMedicationName.TabIndex = 1;
            this.lblMedicationName.Text = "Medication Name:";
            // 
            // lblMedicationCost
            // 
            this.lblMedicationCost.AutoSize = true;
            this.lblMedicationCost.Location = new System.Drawing.Point(354, 117);
            this.lblMedicationCost.Name = "lblMedicationCost";
            this.lblMedicationCost.Size = new System.Drawing.Size(119, 19);
            this.lblMedicationCost.TabIndex = 2;
            this.lblMedicationCost.Text = "Medication Cost:";
            // 
            // txtMedicationID
            // 
            this.txtMedicationID.Enabled = false;
            this.txtMedicationID.Location = new System.Drawing.Point(479, 17);
            this.txtMedicationID.MaxLength = 6;
            this.txtMedicationID.Name = "txtMedicationID";
            this.txtMedicationID.Size = new System.Drawing.Size(74, 27);
            this.txtMedicationID.TabIndex = 3;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(479, 67);
            this.txtMedicationName.MaxLength = 25;
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(333, 27);
            this.txtMedicationName.TabIndex = 4;
            // 
            // nudMedicationCost
            // 
            this.nudMedicationCost.DecimalPlaces = 2;
            this.nudMedicationCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudMedicationCost.Location = new System.Drawing.Point(480, 117);
            this.nudMedicationCost.Maximum = new decimal(new int[] {
            999900,
            0,
            0,
            131072});
            this.nudMedicationCost.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudMedicationCost.Name = "nudMedicationCost";
            this.nudMedicationCost.Size = new System.Drawing.Size(83, 27);
            this.nudMedicationCost.TabIndex = 5;
            this.nudMedicationCost.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // lstMedications
            // 
            this.lstMedications.FormattingEnabled = true;
            this.lstMedications.ItemHeight = 19;
            this.lstMedications.Location = new System.Drawing.Point(13, 20);
            this.lstMedications.Name = "lstMedications";
            this.lstMedications.Size = new System.Drawing.Size(326, 270);
            this.lstMedications.TabIndex = 6;
            // 
            // btnUpdateMedication
            // 
            this.btnUpdateMedication.Location = new System.Drawing.Point(358, 249);
            this.btnUpdateMedication.Name = "btnUpdateMedication";
            this.btnUpdateMedication.Size = new System.Drawing.Size(161, 41);
            this.btnUpdateMedication.TabIndex = 7;
            this.btnUpdateMedication.Text = "Update Medication";
            this.btnUpdateMedication.UseVisualStyleBackColor = true;
            this.btnUpdateMedication.Click += new System.EventHandler(this.btnUpdateMedication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(651, 249);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 41);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MedicationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 316);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateMedication);
            this.Controls.Add(this.lstMedications);
            this.Controls.Add(this.nudMedicationCost);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.txtMedicationID);
            this.Controls.Add(this.lblMedicationCost);
            this.Controls.Add(this.lblMedicationName);
            this.Controls.Add(this.lblMedicationID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicationUpdateForm";
            this.Text = "Update Medication";
            this.Load += new System.EventHandler(this.MedicationUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicationCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicationID;
        private System.Windows.Forms.Label lblMedicationName;
        private System.Windows.Forms.Label lblMedicationCost;
        private System.Windows.Forms.TextBox txtMedicationID;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.NumericUpDown nudMedicationCost;
        private System.Windows.Forms.ListBox lstMedications;
        private System.Windows.Forms.Button btnUpdateMedication;
        private System.Windows.Forms.Button btnReturn;
    }
}