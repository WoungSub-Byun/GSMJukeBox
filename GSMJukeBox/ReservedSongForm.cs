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
    public partial class ReservedSongForm : MetroFramework.Forms.MetroForm
    {
        string constr = "SERVER=127.0.0.1,1234; DATABASE=gsmjukebox;UID=shin;PASSWORD='1234'";
        string number;
        public ReservedSongForm()
        {
            InitializeComponent();
        }

        private void ReservedSongForm_Load(object sender, EventArgs e)
        {
            SetDatagridView(null, null);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_Applicant.Text = dataGridView.Rows[e.RowIndex].Cells["number"].Value.ToString() + " " + dataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
            TextBox_Title.Text = dataGridView.Rows[e.RowIndex].Cells["songtitle"].Value.ToString();
            number = dataGridView.Rows[e.RowIndex].Cells["number"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand();

                string sql = $"DELETE FROM reservedsong WHERE number={number}";
                command.Connection = conn;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                MessageBox.Show("삭제 되었습니다.");
                SetDatagridView(null, null);
            }
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.ShowDialog();
            this.Close();
        }
    }
}
