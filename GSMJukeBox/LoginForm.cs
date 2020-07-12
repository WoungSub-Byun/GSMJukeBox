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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        bool isAdmin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            TextBox_SndPwd.Visible = false;
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            GSMJukeBox gSMJukeBox = new GSMJukeBox();
            gSMJukeBox.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(TextBox_Id.Text);
                string pwd = TextBox_Pwd.Text;

                //Sql연결
                string constr = "SERVER=127.0.0.1; DATABASE=gsmjukebox;UID=woung;PASSWORD='1234'";
                using (SqlConnection sqlconn = new SqlConnection(constr))
                {
                    try
                    {
                        sqlconn.Open();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error:" + err);
                    }

                    string sql;

                    if (isAdmin)
                    {
                        string sndpwd = TextBox_SndPwd.Text;
                        sql = $"select number, pwd, sndpwd from dbo.Users where number={number} AND pwd='{pwd}' AND sndpwd='{sndpwd}'";
                    }
                    else
                    {
                        sql = $"select number, pwd from dbo.Users where number={number} and pwd='{pwd}'";
                    }


                    SqlCommand command = new SqlCommand(sql, sqlconn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (isAdmin)
                        {
                            this.Hide();
                            AdminMainForm adminMainForm = new AdminMainForm();
                            adminMainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            SongRegisterForm songRegisterForm = new SongRegisterForm();
                            songRegisterForm.loginnedNumber = number;
                            songRegisterForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패");
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("아이디를 다시 입력해주세요");
            }
            
            
        }

        private void radioButton_Admin_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = true;
            label3.Visible = true;
            TextBox_SndPwd.Visible = true;
        }

        private void radioButton_Student_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            TextBox_SndPwd.Visible = false;
        }
    }
}
