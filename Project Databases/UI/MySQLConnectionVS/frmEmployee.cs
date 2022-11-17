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
    public partial class frmEmployee : Form
    {
        public frmEmployee(string username)
        {
            InitializeComponent();
            activeUser.Text = username;
        }

    


        private void file_Click(object sender, EventArgs e)
        {

          
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand empfile = new MySqlCommand("employeeFile", db.getConnection());
            empfile.CommandType = CommandType.StoredProcedure;
            empfile.Parameters.AddWithValue("employee", activeUser.Text );
           

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = empfile;

            da.Fill(dt);
            empFile.DataSource = dt;
        }

        private void empApply_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand empapply = new MySqlCommand("vlepeAitiseis", db.getConnection());
            empapply.CommandType = CommandType.StoredProcedure;
            empapply.Parameters.AddWithValue("employee", activeUser.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = empapply;

            da.Fill(dt);
            empApply.DataSource = dt;
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            database db = new database();

         
            String newpassword = txtChangePass.Text;
           

            DataTable dt = new DataTable();
          

            MySqlDataAdapter adapter = new MySqlDataAdapter();
           
         
            if(txtChangePass.Text != null && !string.IsNullOrWhiteSpace(txtChangePass.Text))
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

        private void labelBio_Click(object sender, EventArgs e)
        {
            database db = new database();
            DataTable dt = new DataTable();

            MySqlCommand changeBio = new MySqlCommand("changeDataBioEmployee", db.getConnection());
            changeBio.CommandType = CommandType.StoredProcedure;
            changeBio.Parameters.AddWithValue("employee", activeUser.Text);
            changeBio.Parameters.AddWithValue("newbio", txtChangeBio.Text);


            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = changeBio;

            da.Fill(dt);

            MessageBox.Show("Bio Changed");
          

        }

        private void applicationLabel_Click(object sender, EventArgs e)
        {
            string jobid = txtapplyJob.Text;

            database db = new database();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            if (txtapplyJob.Text != null && !string.IsNullOrWhiteSpace(txtapplyJob.Text))
            {
                MySqlCommand applyJob = new MySqlCommand("JobApplication", db.getConnection());
                applyJob.CommandType = CommandType.StoredProcedure;
                applyJob.Parameters.AddWithValue("employee", activeUser.Text);
                applyJob.Parameters.AddWithValue("job", txtapplyJob.Text);

                da.SelectCommand = applyJob;

                da.Fill(dt);

                MessageBox.Show("Applied for Job");
            }
            else
            {
                MessageBox.Show("Inset Job ID");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

            database db = new database();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            if (txtdeleteJob.Text != null && !string.IsNullOrWhiteSpace(txtdeleteJob.Text))
            {
                MySqlCommand deleteapplyJob = new MySqlCommand("DeleteJobApplication", db.getConnection());
                deleteapplyJob.CommandType = CommandType.StoredProcedure;
                deleteapplyJob.Parameters.AddWithValue("employ", activeUser.Text);
                deleteapplyJob.Parameters.AddWithValue("jb", txtdeleteJob.Text);

                da.SelectCommand = deleteapplyJob;

                da.Fill(dt);

                MessageBox.Show("Deleted Job Application");
            }
            else
            {
                MessageBox.Show("Inset Job ID");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }
    }
}
