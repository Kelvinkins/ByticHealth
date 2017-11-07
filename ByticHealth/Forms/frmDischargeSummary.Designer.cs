namespace ByticHealth.Forms
{
    partial class frmDischargeSummary
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
            this.uscDischargeSummary1 = new ByticHealth.UserControls.uscDischargeSummary();
            this.SuspendLayout();
            // 
            // uscDischargeSummary1
            // 
            this.uscDischargeSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscDischargeSummary1.Location = new System.Drawing.Point(0, 0);
            this.uscDischargeSummary1.Name = "uscDischargeSummary1";
            this.uscDischargeSummary1.Size = new System.Drawing.Size(707, 491);
            this.uscDischargeSummary1.TabIndex = 0;
            // 
            // frmDischargeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 491);
            this.Controls.Add(this.uscDischargeSummary1);
            this.Name = "frmDischargeSummary";
            this.Text = "frmDischargeSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.uscDischargeSummary uscDischargeSummary1;
    }
}