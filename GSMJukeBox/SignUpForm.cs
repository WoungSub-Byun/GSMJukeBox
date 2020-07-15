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
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(comboBox_Grade.SelectedItem.ToString() 
                    + comboBox_Class.SelectedItem.ToString() 
                    + comboBox_Num.SelectedItem.ToString());

                string name = TextBox_Name.Text;
                string pwd = TextBox_Pwd.Text;
                string checkPwd = TextBox_checkPwd.Text;
                if(pwd == checkPwd)
                {
                    string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";
                    using (SqlConnection sqlconn = new SqlConnection(constr))
                    {
                        try
                        {
                            sqlconn.Open();

                            string sql = $"insert into Users(number, name, pwd) values ({number},'{name}','{pwd}');";
                            SqlCommand command = new SqlCommand();
                            command.Connection = sqlconn;
                            command.CommandText = sql;
                            command.ExecuteNonQuery();

                            MessageBox.Show("회원가입에 성공했습니다");
                            this.Hide();
                            GSMJukeBox gSMJukeBox = new GSMJukeBox();
                            gSMJukeBox.ShowDialog();
                            this.Close();

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Error:" + err);
                        }
                        
                    }
                }
                else { 
                    MessageBox.Show("비밀번호가 틀립니다."); 
                }
                
            } catch(Exception err)
            {
                MessageBox.Show("학번을 숫자로 입력해주세요");
            }
           

        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            GSMJukeBox gSMJukeBox = new GSMJukeBox();
            gSMJukeBox.ShowDialog();
            this.Close();
        }
    }
}
