
namespace SaintAlberts
{
    partial class WardsReportForm
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
            this.txtWards = new System.Windows.Forms.TextBox();
            this.btnDisplayWards = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWards
            // 
            this.txtWards.Location = new System.Drawing.Point(25, 39);
            this.txtWards.Multiline = true;
            this.txtWards.Name = "txtWards";
            this.txtWards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWards.Size = new System.Drawing.Size(591, 340);
            this.txtWards.TabIndex = 0;
            // 
            // btnDisplayWards
            // 
            this.btnDisplayWards.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayWards.Location = new System.Drawing.Point(25, 411);
            this.btnDisplayWards.Name = "btnDisplayWards";
            this.btnDisplayWards.Size = new System.Drawing.Size(162, 41);
            this.btnDisplayWards.TabIndex = 1;
            this.btnDisplayWards.Text = "Display Wards";
            this.btnDisplayWards.UseVisualStyleBackColor = true;
            this.btnDisplayWards.Click += new System.EventHandler(this.btnDisplayWards_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(454, 411);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(162, 41);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // WardsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 658);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayWards);
            this.Controls.Add(this.txtWards);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WardsReportForm";
            this.Text = "Wards Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWards;
        private System.Windows.Forms.Button btnDisplayWards;
        private System.Windows.Forms.Button btnReturn;
    }
}