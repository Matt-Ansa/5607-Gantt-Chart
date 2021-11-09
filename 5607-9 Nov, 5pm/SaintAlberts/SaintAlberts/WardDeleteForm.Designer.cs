
namespace SaintAlberts
{
    partial class WardDeleteForm
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
            this.lblWardID = new System.Windows.Forms.Label();
            this.lblWardName = new System.Windows.Forms.Label();
            this.lblWardLocation = new System.Windows.Forms.Label();
            this.lblWardCapacity = new System.Windows.Forms.Label();
            this.txtWardID = new System.Windows.Forms.TextBox();
            this.txtWardName = new System.Windows.Forms.TextBox();
            this.txtWardLocation = new System.Windows.Forms.TextBox();
            this.nudWardCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteWard = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstWards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWardCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWardID
            // 
            this.lblWardID.AutoSize = true;
            this.lblWardID.Location = new System.Drawing.Point(343, 28);
            this.lblWardID.Name = "lblWardID";
            this.lblWardID.Size = new System.Drawing.Size(65, 19);
            this.lblWardID.TabIndex = 0;
            this.lblWardID.Text = "Ward ID:";
            // 
            // lblWardName
            // 
            this.lblWardName.AutoSize = true;
            this.lblWardName.Location = new System.Drawing.Point(319, 72);
            this.lblWardName.Name = "lblWardName";
            this.lblWardName.Size = new System.Drawing.Size(89, 19);
            this.lblWardName.TabIndex = 1;
            this.lblWardName.Text = "Ward Name:";
            // 
            // lblWardLocation
            // 
            this.lblWardLocation.AutoSize = true;
            this.lblWardLocation.Location = new System.Drawing.Point(302, 119);
            this.lblWardLocation.Name = "lblWardLocation";
            this.lblWardLocation.Size = new System.Drawing.Size(106, 19);
            this.lblWardLocation.TabIndex = 2;
            this.lblWardLocation.Text = "Ward Location:";
            // 
            // lblWardCapacity
            // 
            this.lblWardCapacity.AutoSize = true;
            this.lblWardCapacity.Location = new System.Drawing.Point(301, 168);
            this.lblWardCapacity.Name = "lblWardCapacity";
            this.lblWardCapacity.Size = new System.Drawing.Size(107, 19);
            this.lblWardCapacity.TabIndex = 3;
            this.lblWardCapacity.Text = "Ward Capacity:";
            // 
            // txtWardID
            // 
            this.txtWardID.Enabled = false;
            this.txtWardID.Location = new System.Drawing.Point(414, 25);
            this.txtWardID.MaxLength = 2;
            this.txtWardID.Name = "txtWardID";
            this.txtWardID.Size = new System.Drawing.Size(47, 27);
            this.txtWardID.TabIndex = 4;
            // 
            // txtWardName
            // 
            this.txtWardName.Location = new System.Drawing.Point(415, 72);
            this.txtWardName.MaxLength = 10;
            this.txtWardName.Name = "txtWardName";
            this.txtWardName.Size = new System.Drawing.Size(143, 27);
            this.txtWardName.TabIndex = 5;
            // 
            // txtWardLocation
            // 
            this.txtWardLocation.Location = new System.Drawing.Point(415, 119);
            this.txtWardLocation.MaxLength = 8;
            this.txtWardLocation.Name = "txtWardLocation";
            this.txtWardLocation.Size = new System.Drawing.Size(120, 27);
            this.txtWardLocation.TabIndex = 6;
            // 
            // nudWardCapacity
            // 
            this.nudWardCapacity.Location = new System.Drawing.Point(415, 168);
            this.nudWardCapacity.Name = "nudWardCapacity";
            this.nudWardCapacity.Size = new System.Drawing.Size(46, 27);
            this.nudWardCapacity.TabIndex = 7;
            // 
            // btnDeleteWard
            // 
            this.btnDeleteWard.Location = new System.Drawing.Point(306, 329);
            this.btnDeleteWard.Name = "btnDeleteWard";
            this.btnDeleteWard.Size = new System.Drawing.Size(155, 42);
            this.btnDeleteWard.TabIndex = 8;
            this.btnDeleteWard.Text = "Delete Ward";
            this.btnDeleteWard.UseVisualStyleBackColor = true;
            this.btnDeleteWard.Click += new System.EventHandler(this.btnDeleteWard_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(535, 329);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 42);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstWards
            // 
            this.lstWards.FormattingEnabled = true;
            this.lstWards.ItemHeight = 19;
            this.lstWards.Location = new System.Drawing.Point(13, 25);
            this.lstWards.Name = "lstWards";
            this.lstWards.Size = new System.Drawing.Size(282, 346);
            this.lstWards.TabIndex = 10;
            // 
            // WardDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 658);
            this.Controls.Add(this.lstWards);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteWard);
            this.Controls.Add(this.nudWardCapacity);
            this.Controls.Add(this.txtWardLocation);
            this.Controls.Add(this.txtWardName);
            this.Controls.Add(this.txtWardID);
            this.Controls.Add(this.lblWardCapacity);
            this.Controls.Add(this.lblWardLocation);
            this.Controls.Add(this.lblWardName);
            this.Controls.Add(this.lblWardID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WardDeleteForm";
            this.Text = "Delete Ward";
            ((System.ComponentModel.ISupportInitialize)(this.nudWardCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWardID;
        private System.Windows.Forms.Label lblWardName;
        private System.Windows.Forms.Label lblWardLocation;
        private System.Windows.Forms.Label lblWardCapacity;
        private System.Windows.Forms.TextBox txtWardID;
        private System.Windows.Forms.TextBox txtWardName;
        private System.Windows.Forms.TextBox txtWardLocation;
        private System.Windows.Forms.NumericUpDown nudWardCapacity;
        private System.Windows.Forms.Button btnDeleteWard;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstWards;
    }
}