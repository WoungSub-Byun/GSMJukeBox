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
    public partial class SongRegisterForm : MetroFramework.Forms.MetroForm
    {
        public int loginnedNumber;
        string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";

        public SongRegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterSong_Load(object sender, EventArgs e)
        {
            SetDatagridView(null,null);
        }

        private void SetDatagridView(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "select Users.number,name,songtitle,songurl,registerAt from reservedsong, Users where reservedsong.number=Users.number;";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "reservedsong");
            }
            dataGridView.DataSource = ds.Tables[0];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            loginnedNumber = 0;
            this.Hide();
            GSMJukeBox gSMJukeBox = new GSMJukeBox();
            gSMJukeBox.ShowDialog();
            this.Close();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string title = TextBox_Title.Text;
            string url = TextBox_Url.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                
                using (SqlConnection sqlconn = new SqlConnection(constr))
                {
                    try
                    {
                        sqlconn.Open();

                        string sql = $"insert into reservedsong(number, songtitle, songurl, registerAt) values({loginnedNumber},'{title}','{url}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
                        SqlCommand command = new SqlCommand();
                        command.Connection = sqlconn;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();

                        MessageBox.Show("신청되었습니다.");
                        SetDatagridView(null, null);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error: " + err);
                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid Url");
            }
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_Title.Text = dataGridView.Rows[e.RowIndex].Cells["songtitle"].Value.ToString();
            TextBox_Url.Text = dataGridView.Rows[e.RowIndex].Cells["songurl"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand();

                string sql = $"DELETE FROM reservedsong WHERE number={loginnedNumber}";
                command.Connection = conn;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                MessageBox.Show("삭제 되었습니다.");
                SetDatagridView(null, null);
            }
        }
    }
}