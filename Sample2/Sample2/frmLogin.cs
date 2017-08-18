using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DBConnection.Instance.getConn();
            string connetionString = "SELECT COUNT(*) from users where user_name like 'Adam' AND password like '123456'";
            ///SqlConnection cnn;"
            //connetionString = "Data Source=(local);Initial Catalog=Glam;User ID="+this.textBox9.Text+";Password="+this.textBox8.Text;
            //cnn = new SqlConnection(connetionString);
            try
            {
                var conn = DBConnection.Instance.getConn();
                    conn.Open();
                int userCount = 0;
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from EMPLOYEE where Username like @username AND EmployeePassword like @password", conn))
                {
                    //sqlConnection.Open();
                    sqlCommand.Parameters.AddWithValue("@username", this.textBox9.Text);
                    sqlCommand.Parameters.AddWithValue("@password", this.textBox8.Text);
                    userCount = (int)sqlCommand.ExecuteScalar();
                }
                if (userCount > 0)
                {
                    MessageBox.Show("Logged in ! ");
                    this.Hide();
                    frmDashboard frmDash = new frmDashboard();
                    frmDash.ShowDialog();
                    DBConnection.Instance.getConn().Close();
                } else {
                    MessageBox.Show("Wrong username or password ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failure ! ");
            }
        }
    }
}
