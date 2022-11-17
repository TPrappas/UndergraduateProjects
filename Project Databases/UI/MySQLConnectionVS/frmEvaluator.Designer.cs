
namespace MySQLConnectionVS
{
    partial class frmEvaluator
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
            this.logoutbtn = new System.Windows.Forms.Button();
            this.txtConnected = new System.Windows.Forms.Label();
            this.activeUser = new System.Windows.Forms.TextBox();
            this.dataEvaluator = new System.Windows.Forms.DataGridView();
            this.labelEvaluator = new System.Windows.Forms.Label();
            this.labelChangeEmail = new System.Windows.Forms.Label();
            this.txtChangeEmail = new System.Windows.Forms.TextBox();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.lableViewJobs = new System.Windows.Forms.Label();
            this.dataGridViewJob = new System.Windows.Forms.DataGridView();
            this.labelCreateJob = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtEdra = new System.Windows.Forms.TextBox();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.txtSubmission = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUpdateJob = new System.Windows.Forms.Label();
            this.labelEvaluationProgress = new System.Windows.Forms.Label();
            this.dataGridViewEvaluationProgress = new System.Windows.Forms.DataGridView();
            this.labelStartEval = new System.Windows.Forms.Label();
            this.labelEditEval = new System.Windows.Forms.Label();
            this.labelGradeA = new System.Windows.Forms.Label();
            this.txtGradeB = new System.Windows.Forms.Label();
            this.txtGradeC = new System.Windows.Forms.Label();
            this.txtGradeA = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtEvaluationID = new System.Windows.Forms.TextBox();
            this.labelFinalize = new System.Windows.Forms.Label();
            this.labelMyJobs = new System.Windows.Forms.Label();
            this.dataGridViewFinalize = new System.Windows.Forms.DataGridView();
            this.dataGridViewmyJobs = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFinalize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmyJobs = new System.Windows.Forms.TextBox();
            this.labelAllJobs = new System.Windows.Forms.Label();
            this.dataGridAllCompanyJobs = new System.Windows.Forms.DataGridView();
            this.txtCompanySelect = new System.Windows.Forms.TextBox();
            this.labelSearchUser = new System.Windows.Forms.Label();
            this.dataGridViewUserInfo = new System.Windows.Forms.DataGridView();
            this.txtUsernameInfo = new System.Windows.Forms.TextBox();
            this.labelApplyCount = new System.Windows.Forms.Label();
            this.dataGridViewApplyCount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvaluator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvaluationProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmyJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllCompanyJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(241, 12);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 20);
            this.logoutbtn.TabIndex = 13;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // txtConnected
            // 
            this.txtConnected.AutoSize = true;
            this.txtConnected.Location = new System.Drawing.Point(12, 15);
            this.txtConnected.Name = "txtConnected";
            this.txtConnected.Size = new System.Drawing.Size(84, 13);
            this.txtConnected.TabIndex = 12;
            this.txtConnected.Text = "Connected User";
            // 
            // activeUser
            // 
            this.activeUser.Location = new System.Drawing.Point(102, 12);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(114, 20);
            this.activeUser.TabIndex = 11;
            // 
            // dataEvaluator
            // 
            this.dataEvaluator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEvaluator.Location = new System.Drawing.Point(102, 75);
            this.dataEvaluator.Name = "dataEvaluator";
            this.dataEvaluator.Size = new System.Drawing.Size(579, 61);
            this.dataEvaluator.TabIndex = 14;
            // 
            // labelEvaluator
            // 
            this.labelEvaluator.AutoSize = true;
            this.labelEvaluator.Location = new System.Drawing.Point(12, 75);
            this.labelEvaluator.Name = "labelEvaluator";
            this.labelEvaluator.Size = new System.Drawing.Size(71, 13);
            this.labelEvaluator.TabIndex = 15;
            this.labelEvaluator.Text = "Evaluator File";
            this.labelEvaluator.Click += new System.EventHandler(this.labelEvaluator_Click);
            // 
            // labelChangeEmail
            // 
            this.labelChangeEmail.AutoSize = true;
            this.labelChangeEmail.Location = new System.Drawing.Point(10, 180);
            this.labelChangeEmail.Name = "labelChangeEmail";
            this.labelChangeEmail.Size = new System.Drawing.Size(72, 13);
            this.labelChangeEmail.TabIndex = 19;
            this.labelChangeEmail.Text = "Change Email";
            this.labelChangeEmail.Click += new System.EventHandler(this.labelChangeEmail_Click);
            // 
            // txtChangeEmail
            // 
            this.txtChangeEmail.Location = new System.Drawing.Point(102, 177);
            this.txtChangeEmail.Name = "txtChangeEmail";
            this.txtChangeEmail.Size = new System.Drawing.Size(100, 20);
            this.txtChangeEmail.TabIndex = 18;
            // 
            // txtChangePass
            // 
            this.txtChangePass.Location = new System.Drawing.Point(102, 142);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(100, 20);
            this.txtChangePass.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 145);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 13);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Change Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // lableViewJobs
            // 
            this.lableViewJobs.AutoSize = true;
            this.lableViewJobs.Location = new System.Drawing.Point(10, 215);
            this.lableViewJobs.Name = "lableViewJobs";
            this.lableViewJobs.Size = new System.Drawing.Size(78, 13);
            this.lableViewJobs.TabIndex = 20;
            this.lableViewJobs.Text = "View your Jobs";
            this.lableViewJobs.Click += new System.EventHandler(this.lableViewJobs_Click);
            // 
            // dataGridViewJob
            // 
            this.dataGridViewJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJob.Location = new System.Drawing.Point(102, 215);
            this.dataGridViewJob.Name = "dataGridViewJob";
            this.dataGridViewJob.Size = new System.Drawing.Size(686, 63);
            this.dataGridViewJob.TabIndex = 21;
            // 
            // labelCreateJob
            // 
            this.labelCreateJob.AutoSize = true;
            this.labelCreateJob.Location = new System.Drawing.Point(30, 304);
            this.labelCreateJob.Name = "labelCreateJob";
            this.labelCreateJob.Size = new System.Drawing.Size(58, 13);
            this.labelCreateJob.TabIndex = 22;
            this.labelCreateJob.Text = "Create Job";
            this.labelCreateJob.Click += new System.EventHandler(this.labelCreateJob_Click);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(102, 320);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(100, 20);
            this.txtJobID.TabIndex = 23;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(208, 320);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 24;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(314, 320);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 25;
            // 
            // txtEdra
            // 
            this.txtEdra.Location = new System.Drawing.Point(420, 320);
            this.txtEdra.Name = "txtEdra";
            this.txtEdra.Size = new System.Drawing.Size(100, 20);
            this.txtEdra.TabIndex = 26;
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Location = new System.Drawing.Point(526, 320);
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.Size = new System.Drawing.Size(100, 20);
            this.txtAnnouncement.TabIndex = 27;
            // 
            // txtSubmission
            // 
            this.txtSubmission.Location = new System.Drawing.Point(632, 320);
            this.txtSubmission.Name = "txtSubmission";
            this.txtSubmission.Size = new System.Drawing.Size(100, 20);
            this.txtSubmission.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Job ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Edra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Announcement ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Submission";
            // 
            // labelUpdateJob
            // 
            this.labelUpdateJob.AutoSize = true;
            this.labelUpdateJob.Location = new System.Drawing.Point(30, 337);
            this.labelUpdateJob.Name = "labelUpdateJob";
            this.labelUpdateJob.Size = new System.Drawing.Size(62, 13);
            this.labelUpdateJob.TabIndex = 36;
            this.labelUpdateJob.Text = "Update Job";
            this.labelUpdateJob.Click += new System.EventHandler(this.labelUpdateJob_Click);
            // 
            // labelEvaluationProgress
            // 
            this.labelEvaluationProgress.AutoSize = true;
            this.labelEvaluationProgress.Location = new System.Drawing.Point(8, 386);
            this.labelEvaluationProgress.Name = "labelEvaluationProgress";
            this.labelEvaluationProgress.Size = new System.Drawing.Size(101, 13);
            this.labelEvaluationProgress.TabIndex = 37;
            this.labelEvaluationProgress.Text = "Evaluation Progress";
            this.labelEvaluationProgress.Click += new System.EventHandler(this.labelEvaluationProgress_Click);
            // 
            // dataGridViewEvaluationProgress
            // 
            this.dataGridViewEvaluationProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvaluationProgress.Location = new System.Drawing.Point(115, 386);
            this.dataGridViewEvaluationProgress.Name = "dataGridViewEvaluationProgress";
            this.dataGridViewEvaluationProgress.Size = new System.Drawing.Size(955, 111);
            this.dataGridViewEvaluationProgress.TabIndex = 38;
            // 
            // labelStartEval
            // 
            this.labelStartEval.AutoSize = true;
            this.labelStartEval.Location = new System.Drawing.Point(8, 523);
            this.labelStartEval.Name = "labelStartEval";
            this.labelStartEval.Size = new System.Drawing.Size(107, 13);
            this.labelStartEval.TabIndex = 39;
            this.labelStartEval.Text = "Start New Evaluation";
            // 
            // labelEditEval
            // 
            this.labelEditEval.AutoSize = true;
            this.labelEditEval.Location = new System.Drawing.Point(8, 548);
            this.labelEditEval.Name = "labelEditEval";
            this.labelEditEval.Size = new System.Drawing.Size(107, 13);
            this.labelEditEval.TabIndex = 40;
            this.labelEditEval.Text = "Edit Evaluation for ID";
            // 
            // labelGradeA
            // 
            this.labelGradeA.AutoSize = true;
            this.labelGradeA.Location = new System.Drawing.Point(232, 548);
            this.labelGradeA.Name = "labelGradeA";
            this.labelGradeA.Size = new System.Drawing.Size(84, 13);
            this.labelGradeA.TabIndex = 41;
            this.labelGradeA.Text = "Grade Evaluator";
            this.labelGradeA.Click += new System.EventHandler(this.labelGradeA_Click);
            // 
            // txtGradeB
            // 
            this.txtGradeB.AutoSize = true;
            this.txtGradeB.Location = new System.Drawing.Point(437, 548);
            this.txtGradeB.Name = "txtGradeB";
            this.txtGradeB.Size = new System.Drawing.Size(71, 13);
            this.txtGradeB.TabIndex = 42;
            this.txtGradeB.Text = "Grade Report";
            this.txtGradeB.Click += new System.EventHandler(this.txtGradeB_Click);
            // 
            // txtGradeC
            // 
            this.txtGradeC.AutoSize = true;
            this.txtGradeC.Location = new System.Drawing.Point(629, 548);
            this.txtGradeC.Name = "txtGradeC";
            this.txtGradeC.Size = new System.Drawing.Size(84, 13);
            this.txtGradeC.TabIndex = 43;
            this.txtGradeC.Text = "Total Evaluation";
            this.txtGradeC.Click += new System.EventHandler(this.txtGradeC_Click);
            // 
            // txtGradeA
            // 
            this.txtGradeA.Location = new System.Drawing.Point(322, 545);
            this.txtGradeA.Name = "txtGradeA";
            this.txtGradeA.Size = new System.Drawing.Size(100, 20);
            this.txtGradeA.TabIndex = 44;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 545);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 45;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(719, 545);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 46;
            // 
            // txtEvaluationID
            // 
            this.txtEvaluationID.Location = new System.Drawing.Point(121, 545);
            this.txtEvaluationID.Name = "txtEvaluationID";
            this.txtEvaluationID.Size = new System.Drawing.Size(95, 20);
            this.txtEvaluationID.TabIndex = 47;
            // 
            // labelFinalize
            // 
            this.labelFinalize.AutoSize = true;
            this.labelFinalize.Location = new System.Drawing.Point(8, 602);
            this.labelFinalize.Name = "labelFinalize";
            this.labelFinalize.Size = new System.Drawing.Size(63, 13);
            this.labelFinalize.TabIndex = 48;
            this.labelFinalize.Text = "Finalazation";
            this.labelFinalize.Click += new System.EventHandler(this.labelFinalize_Click);
            // 
            // labelMyJobs
            // 
            this.labelMyJobs.AutoSize = true;
            this.labelMyJobs.Location = new System.Drawing.Point(8, 710);
            this.labelMyJobs.Name = "labelMyJobs";
            this.labelMyJobs.Size = new System.Drawing.Size(46, 13);
            this.labelMyJobs.TabIndex = 49;
            this.labelMyJobs.Text = "My Jobs";
            this.labelMyJobs.Click += new System.EventHandler(this.labelMyJobs_Click);
            // 
            // dataGridViewFinalize
            // 
            this.dataGridViewFinalize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinalize.Location = new System.Drawing.Point(235, 585);
            this.dataGridViewFinalize.Name = "dataGridViewFinalize";
            this.dataGridViewFinalize.Size = new System.Drawing.Size(508, 98);
            this.dataGridViewFinalize.TabIndex = 50;
            // 
            // dataGridViewmyJobs
            // 
            this.dataGridViewmyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmyJobs.Location = new System.Drawing.Point(235, 704);
            this.dataGridViewmyJobs.Name = "dataGridViewmyJobs";
            this.dataGridViewmyJobs.Size = new System.Drawing.Size(508, 85);
            this.dataGridViewmyJobs.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Job ID";
            // 
            // txtFinalize
            // 
            this.txtFinalize.Location = new System.Drawing.Point(115, 620);
            this.txtFinalize.Name = "txtFinalize";
            this.txtFinalize.Size = new System.Drawing.Size(100, 20);
            this.txtFinalize.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 710);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Job ID";
            // 
            // txtmyJobs
            // 
            this.txtmyJobs.Location = new System.Drawing.Point(115, 726);
            this.txtmyJobs.Name = "txtmyJobs";
            this.txtmyJobs.Size = new System.Drawing.Size(100, 20);
            this.txtmyJobs.TabIndex = 54;
            // 
            // labelAllJobs
            // 
            this.labelAllJobs.AutoSize = true;
            this.labelAllJobs.Location = new System.Drawing.Point(8, 815);
            this.labelAllJobs.Name = "labelAllJobs";
            this.labelAllJobs.Size = new System.Drawing.Size(124, 13);
            this.labelAllJobs.TabIndex = 56;
            this.labelAllJobs.Text = "See All Jobs In Company";
            this.labelAllJobs.Click += new System.EventHandler(this.labelAllJobs_Click);
            // 
            // dataGridAllCompanyJobs
            // 
            this.dataGridAllCompanyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllCompanyJobs.Location = new System.Drawing.Point(256, 795);
            this.dataGridAllCompanyJobs.Name = "dataGridAllCompanyJobs";
            this.dataGridAllCompanyJobs.Size = new System.Drawing.Size(252, 122);
            this.dataGridAllCompanyJobs.TabIndex = 57;
            // 
            // txtCompanySelect
            // 
            this.txtCompanySelect.Location = new System.Drawing.Point(138, 812);
            this.txtCompanySelect.Name = "txtCompanySelect";
            this.txtCompanySelect.Size = new System.Drawing.Size(100, 20);
            this.txtCompanySelect.TabIndex = 58;
            // 
            // labelSearchUser
            // 
            this.labelSearchUser.AutoSize = true;
            this.labelSearchUser.Location = new System.Drawing.Point(762, 15);
            this.labelSearchUser.Name = "labelSearchUser";
            this.labelSearchUser.Size = new System.Drawing.Size(87, 13);
            this.labelSearchUser.TabIndex = 59;
            this.labelSearchUser.Text = "Search User Info";
            this.labelSearchUser.Click += new System.EventHandler(this.labelSearchUser_Click);
            // 
            // dataGridViewUserInfo
            // 
            this.dataGridViewUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInfo.Location = new System.Drawing.Point(855, 12);
            this.dataGridViewUserInfo.Name = "dataGridViewUserInfo";
            this.dataGridViewUserInfo.Size = new System.Drawing.Size(373, 57);
            this.dataGridViewUserInfo.TabIndex = 60;
            // 
            // txtUsernameInfo
            // 
            this.txtUsernameInfo.Location = new System.Drawing.Point(765, 31);
            this.txtUsernameInfo.Name = "txtUsernameInfo";
            this.txtUsernameInfo.Size = new System.Drawing.Size(87, 20);
            this.txtUsernameInfo.TabIndex = 61;
            // 
            // labelApplyCount
            // 
            this.labelApplyCount.AutoSize = true;
            this.labelApplyCount.Location = new System.Drawing.Point(817, 602);
            this.labelApplyCount.Name = "labelApplyCount";
            this.labelApplyCount.Size = new System.Drawing.Size(64, 13);
            this.labelApplyCount.TabIndex = 62;
            this.labelApplyCount.Text = "Apply Count";
            this.labelApplyCount.Click += new System.EventHandler(this.labelApplyCount_Click);
            // 
            // dataGridViewApplyCount
            // 
            this.dataGridViewApplyCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplyCount.Location = new System.Drawing.Point(909, 601);
            this.dataGridViewApplyCount.Name = "dataGridViewApplyCount";
            this.dataGridViewApplyCount.Size = new System.Drawing.Size(226, 81);
            this.dataGridViewApplyCount.TabIndex = 63;
            // 
            // frmEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 929);
            this.Controls.Add(this.dataGridViewApplyCount);
            this.Controls.Add(this.labelApplyCount);
            this.Controls.Add(this.txtUsernameInfo);
            this.Controls.Add(this.dataGridViewUserInfo);
            this.Controls.Add(this.labelSearchUser);
            this.Controls.Add(this.txtCompanySelect);
            this.Controls.Add(this.dataGridAllCompanyJobs);
            this.Controls.Add(this.labelAllJobs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmyJobs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFinalize);
            this.Controls.Add(this.dataGridViewmyJobs);
            this.Controls.Add(this.dataGridViewFinalize);
            this.Controls.Add(this.labelMyJobs);
            this.Controls.Add(this.labelFinalize);
            this.Controls.Add(this.txtEvaluationID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtGradeA);
            this.Controls.Add(this.txtGradeC);
            this.Controls.Add(this.txtGradeB);
            this.Controls.Add(this.labelGradeA);
            this.Controls.Add(this.labelEditEval);
            this.Controls.Add(this.labelStartEval);
            this.Controls.Add(this.dataGridViewEvaluationProgress);
            this.Controls.Add(this.labelEvaluationProgress);
            this.Controls.Add(this.labelUpdateJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubmission);
            this.Controls.Add(this.txtAnnouncement);
            this.Controls.Add(this.txtEdra);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.labelCreateJob);
            this.Controls.Add(this.dataGridViewJob);
            this.Controls.Add(this.lableViewJobs);
            this.Controls.Add(this.labelChangeEmail);
            this.Controls.Add(this.txtChangeEmail);
            this.Controls.Add(this.txtChangePass);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEvaluator);
            this.Controls.Add(this.dataEvaluator);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.txtConnected);
            this.Controls.Add(this.activeUser);
            this.Name = "frmEvaluator";
            this.Text = "frmEvaluator";
            ((System.ComponentModel.ISupportInitialize)(this.dataEvaluator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvaluationProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmyJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllCompanyJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplyCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label txtConnected;
        private System.Windows.Forms.TextBox activeUser;
        private System.Windows.Forms.DataGridView dataEvaluator;
        private System.Windows.Forms.Label labelEvaluator;
        private System.Windows.Forms.Label labelChangeEmail;
        private System.Windows.Forms.TextBox txtChangeEmail;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label lableViewJobs;
        private System.Windows.Forms.DataGridView dataGridViewJob;
        private System.Windows.Forms.Label labelCreateJob;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtEdra;
        private System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.TextBox txtSubmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUpdateJob;
        private System.Windows.Forms.Label labelEvaluationProgress;
        private System.Windows.Forms.DataGridView dataGridViewEvaluationProgress;
        private System.Windows.Forms.Label labelStartEval;
        private System.Windows.Forms.Label labelEditEval;
        private System.Windows.Forms.Label labelGradeA;
        private System.Windows.Forms.Label txtGradeB;
        private System.Windows.Forms.Label txtGradeC;
        private System.Windows.Forms.TextBox txtGradeA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtEvaluationID;
        private System.Windows.Forms.Label labelFinalize;
        private System.Windows.Forms.Label labelMyJobs;
        private System.Windows.Forms.DataGridView dataGridViewFinalize;
        private System.Windows.Forms.DataGridView dataGridViewmyJobs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFinalize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmyJobs;
        private System.Windows.Forms.Label labelAllJobs;
        private System.Windows.Forms.DataGridView dataGridAllCompanyJobs;
        private System.Windows.Forms.TextBox txtCompanySelect;
        private System.Windows.Forms.Label labelSearchUser;
        private System.Windows.Forms.DataGridView dataGridViewUserInfo;
        private System.Windows.Forms.TextBox txtUsernameInfo;
        private System.Windows.Forms.Label labelApplyCount;
        private System.Windows.Forms.DataGridView dataGridViewApplyCount;
    }
}