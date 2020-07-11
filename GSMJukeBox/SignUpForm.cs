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

namespace GSMJukeBox
{
    public partial class SignUpForm : MetroFramework.Forms.MetroForm
    {
        private SqlConnection sqlconn = null;
        private string constr = "SERVER=127.0.0.1; DATABASE=gsmjukebox;UID=woung;PASSWORD='1234'";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            try
            {
                sqlconn = new SqlConnection(constr);
                sqlconn.Open();

                MessageBox.Show("connection success");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            
                /*using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string sql = $"insert into Users (id,number,name,pwd) values ({id},{number},{name},{pwd})";
                    // Sql 새연결정보 생성
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.CommandText = sql;
                    sqlComm.ExecuteNonQuery();
                }*/
            
        }

        private void btnCheckId_Click(object sender, EventArgs e)
        {
            
            /*using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = $"SELECT * FROM BOOKS WHERE id={id}";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.Connection = conn;
                sqlComm.CommandText = sql;
                conn.Open();
                using (SqlDataReader SqlRs = sqlComm.ExecuteReader())
                {
                    while (SqlRs.Read())
                    {
                        if (SqlRs == null)
                        {
                            MessageBox.Show("사용가능한 아이디입니다.");
                            checkId = true;
                        }
                        else
                        {
                            MessageBox.Show("이미 존재하는 아이디입니다.");
                        }
                    }
                }
            }*/
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
