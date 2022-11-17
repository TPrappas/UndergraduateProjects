using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLConnectionVS
{
    public partial class frmEvaluator : Form
    {
        public frmEvaluator(string username)
        {
            InitializeComponent();
            activeUser.Text = username;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }

        private void labelEvaluator_Click(object sender, EventArgs e)
        {

            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalfile = new MySqlCommand("evaluatorFile", db.getConnection());
            evalfile.CommandType = CommandType.StoredProcedure;
            evalfile.Parameters.AddWithValue("evaluator", activeUser.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalfile;

            da.Fill(dt);
            dataEvaluator.DataSource = dt;
        }

       
        private void labelPassword_Click(object sender, EventArgs e)
        {

            database db = new database();


            String newpassword = txtChangePass.Text;


            DataTable dt = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtChangePass.Text != null && !string.IsNullOrWhiteSpace(txtChangePass.Text))
            {

                MySqlCommand changePass = new MySqlCommand("UPDATE `user` SET  `password` = @pass where `username` = @usn ", db.getConnection());


                changePass.Parameters.Add("@pass", MySqlDbType.VarChar).Value = newpassword;
                changePass.Parameters.Add("@usn", MySqlDbType.VarChar).Value = activeUser.Text;


                adapter.SelectCommand = changePass;

                adapter.Fill(dt);
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Insert Password");
            }
        }

        private void labelChangeEmail_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();


            if (txtChangeEmail.Text != null && !string.IsNullOrWhiteSpace(txtChangeEmail.Text))
            {

                MySqlCommand changeEmail = new MySqlCommand("changeDataEmailEvaluator", db.getConnection());
                changeEmail.CommandType = CommandType.StoredProcedure;
                changeEmail.Parameters.AddWithValue("eval", activeUser.Text);
                changeEmail.Parameters.AddWithValue("eml", txtChangeEmail.Text);

                da.SelectCommand = changeEmail;

                da.Fill(dt);

                MessageBox.Show("Email Changed");
            }
            else
            {
                MessageBox.Show("Insert Email");
            }
        }

        private void lableViewJobs_Click(object sender, EventArgs e)
        {

            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalJobs = new MySqlCommand("evaluatorJobs", db.getConnection());
            evalJobs.CommandType = CommandType.StoredProcedure;
            evalJobs.Parameters.AddWithValue("evaluat", activeUser.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalJobs;

            da.Fill(dt);
            dataGridViewJob.DataSource = dt;
        }

        private void labelCreateJob_Click(object sender, EventArgs e)
        {
            database db = new database();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtSubmission.Text != null && !string.IsNullOrWhiteSpace(txtSubmission.Text)
                && txtAnnouncement.Text != null && !string.IsNullOrWhiteSpace(txtAnnouncement.Text)
                && txtSalary.Text != null && !string.IsNullOrWhiteSpace(txtSalary.Text)
                && txtEdra.Text != null && !string.IsNullOrWhiteSpace(txtEdra.Text)
                && txtPosition.Text != null && !string.IsNullOrWhiteSpace(txtPosition.Text)
                && txtJobID.Text != null && !string.IsNullOrWhiteSpace(txtJobID.Text)
                )
            {

                MySqlCommand createJob = new MySqlCommand("createJob", db.getConnection());
                createJob.CommandType = CommandType.StoredProcedure;
                createJob.Parameters.AddWithValue("evaluator", activeUser.Text);
                createJob.Parameters.AddWithValue("job_id", txtJobID.Text);
                createJob.Parameters.AddWithValue("newsalary", txtSalary.Text);
                createJob.Parameters.AddWithValue("newposition", txtPosition.Text);
                createJob.Parameters.AddWithValue("newedra", txtEdra.Text);
                createJob.Parameters.AddWithValue("announcement", txtAnnouncement.Text);
                createJob.Parameters.AddWithValue("submission", txtSubmission.Text);
                adapter.SelectCommand = createJob;

                adapter.Fill(dt);
                MessageBox.Show("Job Added");
            }
            else
            {
                MessageBox.Show("Check Missing Box");
            }
        }

        private void labelUpdateJob_Click(object sender, EventArgs e)
        {
            database db = new database();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtSubmission.Text != null && !string.IsNullOrWhiteSpace(txtSubmission.Text)
                && txtAnnouncement.Text != null && !string.IsNullOrWhiteSpace(txtAnnouncement.Text)
                && txtSalary.Text != null && !string.IsNullOrWhiteSpace(txtSalary.Text)
                && txtJobID.Text != null && !string.IsNullOrWhiteSpace(txtJobID.Text)
                )
            {

                MySqlCommand updateJob = new MySqlCommand("updateJob", db.getConnection());
                updateJob.CommandType = CommandType.StoredProcedure;
                updateJob.Parameters.AddWithValue("evaluator", activeUser.Text);
                updateJob.Parameters.AddWithValue("newsalary", txtSalary.Text);
                updateJob.Parameters.AddWithValue("announcement", txtAnnouncement.Text);
                updateJob.Parameters.AddWithValue("submission", txtSubmission.Text);
                updateJob.Parameters.AddWithValue("job_id", txtJobID.Text);
                adapter.SelectCommand = updateJob;

                adapter.Fill(dt);
                MessageBox.Show("Job Updated");
            }
            else
            {
                MessageBox.Show("Check Missing Box");
            }
        }

        private void labelEvaluationProgress_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalProcedure = new MySqlCommand("evaluationProcedure", db.getConnection());
            evalProcedure.CommandType = CommandType.StoredProcedure;
            evalProcedure.Parameters.AddWithValue("evaluat", activeUser.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalProcedure;

            da.Fill(dt);
            dataGridViewEvaluationProgress.DataSource = dt;
        }

       

        private void txtGradeB_Click(object sender, EventArgs e)
        {
            database db = new database();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtEvaluationID.Text != null && !string.IsNullOrWhiteSpace(txtEvaluationID.Text)
                && txtGradeB.Text != null && !string.IsNullOrWhiteSpace(txtGradeB.Text)
                )
            {

                MySqlCommand updateGradeB = new MySqlCommand("insertGradeB", db.getConnection());
                updateGradeB.CommandType = CommandType.StoredProcedure;
                updateGradeB.Parameters.AddWithValue("evaluator", activeUser.Text);
                updateGradeB.Parameters.AddWithValue("evaluationID", txtEvaluationID.Text);
                updateGradeB.Parameters.AddWithValue("gradeB", txtGradeB.Text);

                adapter.SelectCommand = updateGradeB;

                adapter.Fill(dt);
                MessageBox.Show("Grade Report Changed");
            }
            else
            {
                MessageBox.Show("Check Missing Box");
            }
        }

        private void txtGradeC_Click(object sender, EventArgs e)
        {
            database db = new database();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtEvaluationID.Text != null && !string.IsNullOrWhiteSpace(txtEvaluationID.Text)
                && txtGradeC.Text != null && !string.IsNullOrWhiteSpace(txtGradeC.Text)
                )
            {

                MySqlCommand updateGradeC = new MySqlCommand("insertGradeC", db.getConnection());
                updateGradeC.CommandType = CommandType.StoredProcedure;
                updateGradeC.Parameters.AddWithValue("evaluator", activeUser.Text);
                updateGradeC.Parameters.AddWithValue("evaluationID", txtEvaluationID.Text);
                updateGradeC.Parameters.AddWithValue("gradeC", txtGradeC.Text);

                adapter.SelectCommand = updateGradeC;

                adapter.Fill(dt);
                MessageBox.Show("Grade Total Evaluation Changed");
            }
            else
            {
                MessageBox.Show("Check Missing Box");
            }
        }

        private void labelGradeA_Click(object sender, EventArgs e)
        {
            database db = new database();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            if (txtEvaluationID.Text != null && !string.IsNullOrWhiteSpace(txtEvaluationID.Text)
                && txtGradeA.Text != null && !string.IsNullOrWhiteSpace(txtGradeA.Text)
                )
            {

                MySqlCommand updateGradeA = new MySqlCommand("insertGradeA", db.getConnection());
                updateGradeA.CommandType = CommandType.StoredProcedure;
                updateGradeA.Parameters.AddWithValue("evaluator", activeUser.Text);
                updateGradeA.Parameters.AddWithValue("evaluationID", txtEvaluationID.Text);
                updateGradeA.Parameters.AddWithValue("gradeA", txtGradeA.Text);
 
                adapter.SelectCommand = updateGradeA;

                adapter.Fill(dt);
                MessageBox.Show("Grade Evaluator Changed");
            }
            else
            {
                MessageBox.Show("Check Missing Box");
            }
        }

        private void labelFinalize_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalProcedure = new MySqlCommand("Procedure2", db.getConnection());
            evalProcedure.CommandType = CommandType.StoredProcedure;
            evalProcedure.Parameters.AddWithValue("evalUsername", activeUser.Text);
            evalProcedure.Parameters.AddWithValue("id", txtFinalize.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalProcedure;

            da.Fill(dt);
            dataGridViewFinalize.DataSource = dt;
        }

        private void labelMyJobs_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalProcedure = new MySqlCommand("Procedure3", db.getConnection());
            evalProcedure.CommandType = CommandType.StoredProcedure;
            
            evalProcedure.Parameters.AddWithValue("JobID", txtmyJobs.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalProcedure;

            da.Fill(dt);
            dataGridViewmyJobs.DataSource = dt;
        }

        private void labelAllJobs_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand evalProcedure = new MySqlCommand("myCompanyPositions", db.getConnection());
            evalProcedure.CommandType = CommandType.StoredProcedure;

            evalProcedure.Parameters.AddWithValue("edra", txtCompanySelect.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = evalProcedure;

            da.Fill(dt);
            dataGridAllCompanyJobs.DataSource = dt;
        }

        private void labelSearchUser_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand searchUser = new MySqlCommand("SearchUser", db.getConnection());
            searchUser.CommandType = CommandType.StoredProcedure;

            searchUser.Parameters.AddWithValue("username", txtUsernameInfo.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = searchUser;

            da.Fill(dt);
            dataGridViewUserInfo.DataSource = dt;
        }

        private void labelApplyCount_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand count = new MySqlCommand("applyCount", db.getConnection());
            count.CommandType = CommandType.StoredProcedure;

            count.Parameters.AddWithValue("evaluator", activeUser.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = count;

            da.Fill(dt);
            dataGridViewApplyCount.DataSource = dt;
        }
    }
}
