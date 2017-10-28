namespace ByticHealth.Forms
{
    partial class frmPatAdmission
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
            this.uscAdmission1 = new ByticHealth.UserControls.uscAdmission();
            this.SuspendLayout();
            // 
            // uscAdmission1
            // 
            this.uscAdmission1.BackColor = System.Drawing.Color.White;
            this.uscAdmission1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uscAdmission1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAdmission1.Location = new System.Drawing.Point(0, 0);
            this.uscAdmission1.Name = "uscAdmission1";
            this.uscAdmission1.Size = new System.Drawing.Size(833, 504);
            this.uscAdmission1.TabIndex = 0;
            // 
            // frmPatAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 504);
            this.Controls.Add(this.uscAdmission1);
            this.Name = "frmPatAdmission";
            this.Text = "frmPatAdmission";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.uscAdmission uscAdmission1;
    }
}