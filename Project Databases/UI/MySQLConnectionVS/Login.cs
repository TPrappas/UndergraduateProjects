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

 
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            database db = new database();

            String username = txtUsername.Text;
            String password = txtPassword.Text;

            DataTable managTable = new DataTable();
            DataTable emplTable = new DataTable();
            DataTable evalTable = new DataTable();

            MySqlDataAdapter managAdapter = new MySqlDataAdapter();
            MySqlDataAdapter emplAdapter = new MySqlDataAdapter();
            MySqlDataAdapter evalAdapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from `user` where `username` = @usn and `password` = @pass", db.getConnection());
            MySqlCommand getManager = new MySqlCommand("select * from `manager`INNER JOIN user ON manager.managerUsername = user.username where `managerUsername` = @usn and password = @pass ", db.getConnection());
            MySqlCommand getEmployee = new MySqlCommand("select * from `employee` INNER JOIN user ON employee.emplUsername = user.username where `emplUsername` = @usn and password = @pass", db.getConnection());
            MySqlCommand getEvaluator = new MySqlCommand("select * from `evaluator` INNER JOIN user ON evaluator.evaluatorUsername = user.username where `evaluatorUsername` = @usn and password = @pass", db.getConnection());

            
            getManager.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            getManager.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            getEmployee.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            getEmployee.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            getEvaluator.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            getEvaluator.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

           
            managAdapter.SelectCommand = getManager;

        
            emplAdapter.SelectCommand = getEmployee;

          
            evalAdapter.SelectCommand = getEvaluator;
            

            managAdapter.Fill(managTable);
            emplAdapter.Fill(emplTable);
            evalAdapter.Fill(evalTable);

            if (managTable.Rows.Count > 0)
            {
                frmManager objFrmManager = new frmManager();
                this.Hide();
                objFrmManager.Show();
            }
            else if (emplTable.Rows.Count >0)
            {
                frmEmployee objFrmEmployee = new frmEmployee(txtUsername.Text);
                this.Hide();
                objFrmEmployee.Show();
            }
            else if (evalTable.Rows.Count > 0)
            {
                frmEvaluator objFrmEvaluator = new frmEvaluator(txtUsername.Text);
                this.Hide();
                objFrmEvaluator.Show();
            }
            else
            {
                MessageBox.Show("Check Username And Password");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
