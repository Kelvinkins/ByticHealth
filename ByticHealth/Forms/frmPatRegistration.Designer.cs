namespace ByticHealth.Forms
{
    partial class frmPatRegistration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePatientBio = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageRelative = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.Diagnosis = new System.Windows.Forms.TabPage();
            this.Prescriptions = new System.Windows.Forms.TabPage();
            this.Insurance = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabPagePatientHistory = new System.Windows.Forms.TabPage();
            this.uscInsuranceInfo1 = new ByticHealth.UserControls.uscInsuranceInfo();
            this.tabControl1.SuspendLayout();
            this.Insurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPagePatientHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePatientBio);
            this.tabControl1.Controls.Add(this.tabPagePatientHistory);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPageRelative);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.Diagnosis);
            this.tabControl1.Controls.Add(this.Prescriptions);
            this.tabControl1.Controls.Add(this.Insurance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 608);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPagePatientBio
            // 
            this.tabPagePatientBio.AutoScroll = true;
            this.tabPagePatientBio.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatientBio.Name = "tabPagePatientBio";
            this.tabPagePatientBio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientBio.Size = new System.Drawing.Size(1031, 582);
            this.tabPagePatientBio.TabIndex = 0;
            this.tabPagePatientBio.Text = "Patient\'s Bio Data";
            this.tabPagePatientBio.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1031, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Documents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageRelative
            // 
            this.tabPageRelative.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelative.Name = "tabPageRelative";
            this.tabPageRelative.Size = new System.Drawing.Size(1031, 582);
            this.tabPageRelative.TabIndex = 3;
            this.tabPageRelative.Text = "Relatives";
            this.tabPageRelative.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1031, 582);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dependants";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1031, 582);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Vitals";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1031, 582);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Bills";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1031, 582);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Appointments";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1031, 582);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Reports";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1031, 582);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Health Monitor";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.Location = new System.Drawing.Point(4, 22);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(1031, 582);
            this.Diagnosis.TabIndex = 10;
            this.Diagnosis.Text = "Diagnosis";
            this.Diagnosis.UseVisualStyleBackColor = true;
            // 
            // Prescriptions
            // 
            this.Prescriptions.Location = new System.Drawing.Point(4, 22);
            this.Prescriptions.Name = "Prescriptions";
            this.Prescriptions.Size = new System.Drawing.Size(1031, 582);
            this.Prescriptions.TabIndex = 11;
            this.Prescriptions.Text = "Prescriptions";
            this.Prescriptions.UseVisualStyleBackColor = true;
            // 
            // Insurance
            // 
            this.Insurance.Controls.Add(this.uscInsuranceInfo1);
            this.Insurance.Location = new System.Drawing.Point(4, 22);
            this.Insurance.Name = "Insurance";
            this.Insurance.Padding = new System.Windows.Forms.Padding(3);
            this.Insurance.Size = new System.Drawing.Size(1031, 582);
            this.Insurance.TabIndex = 12;
            this.Insurance.Text = "Insurance";
            this.Insurance.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 576);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 30);
            this.panel1.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(361, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(150, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "MEDICAL HISTORY";
            // 
            // tabPagePatientHistory
            // 
            this.tabPagePatientHistory.Controls.Add(this.splitContainer1);
            this.tabPagePatientHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatientHistory.Name = "tabPagePatientHistory";
            this.tabPagePatientHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatientHistory.Size = new System.Drawing.Size(1031, 582);
            this.tabPagePatientHistory.TabIndex = 1;
            this.tabPagePatientHistory.Text = "Medical History";
            this.tabPagePatientHistory.UseVisualStyleBackColor = true;
            // 
            // uscInsuranceInfo1
            // 
            this.uscInsuranceInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscInsuranceInfo1.Location = new System.Drawing.Point(3, 3);
            this.uscInsuranceInfo1.Name = "uscInsuranceInfo1";
            this.uscInsuranceInfo1.Size = new System.Drawing.Size(1025, 576);
            this.uscInsuranceInfo1.TabIndex = 0;
            // 
            // frmPatRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPatRegistration";
            this.Text = "frmPatRegistration";
            this.Load += new System.EventHandler(this.frmPatRegistration_Load);
            this.tabControl1.ResumeLayout(false);
            this.Insurance.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPagePatientHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePatientBio;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageRelative;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage Diagnosis;
        private System.Windows.Forms.TabPage Prescriptions;
        private System.Windows.Forms.TabPage Insurance;
        private UserControls.uscInsuranceInfo uscInsuranceInfo1;
        private System.Windows.Forms.TabPage tabPagePatientHistory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label1;

        #endregion

        //private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlPatientBio;
        //private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdvPatientRegistration;
        //private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        //private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        //private UserControls.uscPatientRegistration uscPatientRegistration;
        //private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
    }
}