
namespace SaintAlberts
{
    partial class MedicationDeleteForm
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
            this.btnDeleteMedication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstMedications = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicationCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicationID
            // 
            this.lblMedicationID.AutoSize = true;
            this.lblMedicationID.Location = new System.Drawing.Point(328, 39);
            this.lblMedicationID.Name = "lblMedicationID";
            this.lblMedicationID.Size = new System.Drawing.Size(104, 19);
            this.lblMedicationID.TabIndex = 1;
            this.lblMedicationID.Text = "Medication ID:";
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Location = new System.Drawing.Point(304, 88);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(128, 19);
            this.lblMedicationName.TabIndex = 2;
            this.lblMedicationName.Text = "Medication Name:";
            // 
            // lblMedicationCost
            // 
            this.lblMedicationCost.AutoSize = true;
            this.lblMedicationCost.Location = new System.Drawing.Point(313, 142);
            this.lblMedicationCost.Name = "lblMedicationCost";
            this.lblMedicationCost.Size = new System.Drawing.Size(119, 19);
            this.lblMedicationCost.TabIndex = 3;
            this.lblMedicationCost.Text = "Medication Cost:";
            // 
            // txtMedicationID
            // 
            this.txtMedicationID.Enabled = false;
            this.txtMedicationID.Location = new System.Drawing.Point(439, 36);
            this.txtMedicationID.MaxLength = 6;
            this.txtMedicationID.Name = "txtMedicationID";
            this.txtMedicationID.Size = new System.Drawing.Size(74, 27);
            this.txtMedicationID.TabIndex = 5;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(439, 88);
            this.txtMedicationName.MaxLength = 25;
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(342, 27);
            this.txtMedicationName.TabIndex = 6;
            // 
            // nudMedicationCost
            // 
            this.nudMedicationCost.DecimalPlaces = 2;
            this.nudMedicationCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudMedicationCost.Location = new System.Drawing.Point(439, 142);
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
            this.nudMedicationCost.Size = new System.Drawing.Size(85, 27);
            this.nudMedicationCost.TabIndex = 7;
            this.nudMedicationCost.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // btnDeleteMedication
            // 
            this.btnDeleteMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteMedication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMedication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteMedication.Location = new System.Drawing.Point(439, 258);
            this.btnDeleteMedication.Name = "btnDeleteMedication";
            this.btnDeleteMedication.Size = new System.Drawing.Size(160, 43);
            this.btnDeleteMedication.TabIndex = 8;
            this.btnDeleteMedication.Text = "Delete Medication";
            this.btnDeleteMedication.UseVisualStyleBackColor = false;
            this.btnDeleteMedication.Click += new System.EventHandler(this.btnDeleteMedication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturn.Location = new System.Drawing.Point(622, 258);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(159, 43);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstMedications
            // 
            this.lstMedications.FormattingEnabled = true;
            this.lstMedications.ItemHeight = 19;
            this.lstMedications.Location = new System.Drawing.Point(12, 12);
            this.lstMedications.Name = "lstMedications";
            this.lstMedications.Size = new System.Drawing.Size(274, 289);
            this.lstMedications.TabIndex = 10;
            // 
            // MedicationDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.lstMedications);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteMedication);
            this.Controls.Add(this.nudMedicationCost);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.txtMedicationID);
            this.Controls.Add(this.lblMedicationCost);
            this.Controls.Add(this.lblMedicationName);
            this.Controls.Add(this.lblMedicationID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicationDeleteForm";
            this.Text = "Delete Medication";
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
        private System.Windows.Forms.Button btnDeleteMedication;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstMedications;
    }
}