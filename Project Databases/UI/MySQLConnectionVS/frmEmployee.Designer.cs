
namespace MySQLConnectionVS
{
    partial class frmEmployee
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
            this.file = new System.Windows.Forms.Label();
            this.labelApply = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.empFile = new System.Windows.Forms.DataGridView();
            this.activeUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empApply = new System.Windows.Forms.DataGridView();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.txtChangeBio = new System.Windows.Forms.TextBox();
            this.labelBio = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.txtapplyJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdeleteJob = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empApply)).BeginInit();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(12, 48);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(72, 13);
            this.file.TabIndex = 0;
            this.file.Text = "Employee File";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // labelApply
            // 
            this.labelApply.AutoSize = true;
            this.labelApply.Location = new System.Drawing.Point(12, 135);
            this.labelApply.Name = "labelApply";
            this.labelApply.Size = new System.Drawing.Size(90, 13);
            this.labelApply.TabIndex = 1;
            this.labelApply.Text = "Employee Applies";
            this.labelApply.Click += new System.EventHandler(this.empApply_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 245);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Change Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // empFile
            // 
            this.empFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empFile.Location = new System.Drawing.Point(105, 48);
            this.empFile.Name = "empFile";
            this.empFile.Size = new System.Drawing.Size(431, 68);
            this.empFile.TabIndex = 3;
            // 
            // activeUser
            // 
            this.activeUser.Location = new System.Drawing.Point(105, 12);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(114, 20);
            this.activeUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connected User";
            // 
            // empApply
            // 
            this.empApply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empApply.Location = new System.Drawing.Point(105, 135);
            this.empApply.Name = "empApply";
            this.empApply.Size = new System.Drawing.Size(170, 68);
            this.empApply.TabIndex = 6;
            // 
            // txtChangePass
            // 
            this.txtChangePass.Location = new System.Drawing.Point(105, 242);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(100, 20);
            this.txtChangePass.TabIndex = 7;
            // 
            // txtChangeBio
            // 
            this.txtChangeBio.Location = new System.Drawing.Point(105, 277);
            this.txtChangeBio.Name = "txtChangeBio";
            this.txtChangeBio.Size = new System.Drawing.Size(100, 20);
            this.txtChangeBio.TabIndex = 8;
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Location = new System.Drawing.Point(12, 280);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(62, 13);
            this.labelBio.TabIndex = 9;
            this.labelBio.Text = "Change Bio";
            this.labelBio.Click += new System.EventHandler(this.labelBio_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(236, 12);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 20);
            this.logoutbtn.TabIndex = 10;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(12, 318);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(79, 13);
            this.applicationLabel.TabIndex = 11;
            this.applicationLabel.Text = "Job Application";
            this.applicationLabel.Click += new System.EventHandler(this.applicationLabel_Click);
            // 
            // txtapplyJob
            // 
            this.txtapplyJob.Location = new System.Drawing.Point(105, 315);
            this.txtapplyJob.Name = "txtapplyJob";
            this.txtapplyJob.Size = new System.Drawing.Size(100, 20);
            this.txtapplyJob.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Delete Job Application";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdeleteJob
            // 
            this.txtdeleteJob.Location = new System.Drawing.Point(131, 355);
            this.txtdeleteJob.Name = "txtdeleteJob";
            this.txtdeleteJob.Size = new System.Drawing.Size(100, 20);
            this.txtdeleteJob.TabIndex = 14;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdeleteJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapplyJob);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.labelBio);
            this.Controls.Add(this.txtChangeBio);
            this.Controls.Add(this.txtChangePass);
            this.Controls.Add(this.empApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activeUser);
            this.Controls.Add(this.empFile);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelApply);
            this.Controls.Add(this.file);
            this.Name = "frmEmployee";
            this.Text = "Employee Commands";
      
            ((System.ComponentModel.ISupportInitialize)(this.empFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empApply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file;
        private System.Windows.Forms.Label labelApply;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.DataGridView empFile;
        private System.Windows.Forms.TextBox activeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView empApply;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.TextBox txtChangeBio;
        private System.Windows.Forms.Label labelBio;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.TextBox txtapplyJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdeleteJob;
    }
}