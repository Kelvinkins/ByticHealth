namespace ByticHealth.Forms
{
    partial class frmNewAppointment
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
            this.uscAptNew1 = new ByticHealth.UserControls.uscAptNew();
            this.SuspendLayout();
            // 
            // uscAptNew1
            // 
            this.uscAptNew1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uscAptNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAptNew1.Location = new System.Drawing.Point(0, 0);
            this.uscAptNew1.Name = "uscAptNew1";
            this.uscAptNew1.Size = new System.Drawing.Size(864, 509);
            this.uscAptNew1.TabIndex = 0;
            this.uscAptNew1.Load += new System.EventHandler(this.uscAptNew1_Load);
            // 
            // frmNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.uscAptNew1);
            this.Name = "frmNewAppointment";
            this.Text = "frmNewAppointment";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.uscAptNew uscAptNew1;
    }
}