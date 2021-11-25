
namespace SaintAlberts
{
    partial class MedicationAddForm
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
            this.btnAddMedication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtMedications = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedicationCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicationID
            // 
            this.lblMedicationID.AutoSize = true;
            this.lblMedicationID.Location = new System.Drawing.Point(321, 40);
            this.lblMedicationID.Name = "lblMedicationID";
            this.lblMedicationID.Size = new System.Drawing.Size(104, 19);
            this.lblMedicationID.TabIndex = 0;
            this.lblMedicationID.Text = "Medication ID:";
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Location = new System.Drawing.Point(297, 98);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(128, 19);
            this.lblMedicationName.TabIndex = 1;
            this.lblMedicationName.Text = "Medication Name:";
            // 
            // lblMedicationCost
            // 
            this.lblMedicationCost.AutoSize = true;
            this.lblMedicationCost.Location = new System.Drawing.Point(306, 165);
            this.lblMedicationCost.Name = "lblMedicationCost";
            this.lblMedicationCost.Size = new System.Drawing.Size(119, 19);
            this.lblMedicationCost.TabIndex = 2;
            this.lblMedicationCost.Text = "Medication Cost:";
            // 
            // txtMedicationID
            // 
            this.txtMedicationID.Enabled = false;
            this.txtMedicationID.Location = new System.Drawing.Point(432, 40);
            this.txtMedicationID.MaxLength = 6;
            this.txtMedicationID.Name = "txtMedicationID";
            this.txtMedicationID.Size = new System.Drawing.Size(71, 27);
            this.txtMedicationID.TabIndex = 3;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(431, 98);
            this.txtMedicationName.MaxLength = 25;
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(325, 27);
            this.txtMedicationName.TabIndex = 4;
            // 
            // nudMedicationCost
            // 
            this.nudMedicationCost.Location = new System.Drawing.Point(432, 165);
            this.nudMedicationCost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMedicationCost.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudMedicationCost.Name = "nudMedicationCost";
            this.nudMedicationCost.Size = new System.Drawing.Size(81, 27);
            this.nudMedicationCost.TabIndex = 5;
            this.nudMedicationCost.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMedication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMedication.Location = new System.Drawing.Point(395, 280);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(152, 37);
            this.btnAddMedication.TabIndex = 7;
            this.btnAddMedication.Text = "Add Medication";
            this.btnAddMedication.UseVisualStyleBackColor = false;
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturn.Location = new System.Drawing.Point(574, 280);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(152, 37);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtMedications
            // 
            this.txtMedications.Location = new System.Drawing.Point(13, 28);
            this.txtMedications.Multiline = true;
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMedications.Size = new System.Drawing.Size(278, 289);
            this.txtMedications.TabIndex = 9;
            // 
            // MedicationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 341);
            this.Controls.Add(this.txtMedications);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddMedication);
            this.Controls.Add(this.nudMedicationCost);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.txtMedicationID);
            this.Controls.Add(this.lblMedicationCost);
            this.Controls.Add(this.lblMedicationName);
            this.Controls.Add(this.lblMedicationID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicationAddForm";
            this.Text = "Add Medication";
            this.Load += new System.EventHandler(this.MedicationAddForm_Load);
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
        private System.Windows.Forms.Button btnAddMedication;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtMedications;
    }
}