namespace ByticHealth.UserControls
{
    partial class uscPatientMaintenance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePatientVitals = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerPatientVital = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePatientVitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPatientVital)).BeginInit();
            this.splitContainerPatientVital.Panel1.SuspendLayout();
            this.splitContainerPatientVital.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePatientVitals);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePatientVitals
            // 
            this.tabPagePatientVitals.Controls.Add(this.splitContainerPatientVital);
            this.tabPagePatientVitals.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatientVitals.Name = "tabPagePatientVitals";
            this.tabPagePatientVitals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientVitals.Size = new System.Drawing.Size(659, 577);
            this.tabPagePatientVitals.TabIndex = 0;
            this.tabPagePatientVitals.Text = "Vitals";
            this.tabPagePatientVitals.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainerPatientVital
            // 
            this.splitContainerPatientVital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPatientVital.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPatientVital.Name = "splitContainerPatientVital";
            this.splitContainerPatientVital.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPatientVital.Panel1
            // 
            this.splitContainerPatientVital.Panel1.Controls.Add(this.panel3);
            this.splitContainerPatientVital.Size = new System.Drawing.Size(653, 571);
            this.splitContainerPatientVital.SplitterDistance = 29;
            this.splitContainerPatientVital.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 29);
            this.panel3.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(361, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "PATIENT VITALS";
            // 
            // uscPatientMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uscPatientMaintenance";
            this.Size = new System.Drawing.Size(667, 603);
            this.Load += new System.EventHandler(this.uscPatientMaintenance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePatientVitals.ResumeLayout(false);
            this.splitContainerPatientVital.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPatientVital)).EndInit();
            this.splitContainerPatientVital.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePatientVitals;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainerPatientVital;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
    }
}
