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
    public partial class SetTimeForm :  MetroFramework.Forms.MetroForm
    {

        string constr = "SERVER=127.0.0.1; DATABASE=gsmjukebox;UID=woung;PASSWORD='1234'";

        public SetTimeForm()
        {
            InitializeComponent();
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.ShowDialog();
            this.Close();
        }

        //datagridview에 playtime 테이블 값 조회
        private void SetDatagridView(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string sql = "select starttime, closetime from playtime;";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "playtime");
            }
            dataGridView.DataSource = ds.Tables[0];
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_startHour.Text = dataGridView.Rows[e.RowIndex].Cells["starttime"].Value.ToString().Split(':')[0];
            comboBox_startMin.Text = dataGridView.Rows[e.RowIndex].Cells["starttime"].Value.ToString().Split(':')[1];
            comboBox_closeHour.Text = dataGridView.Rows[e.RowIndex].Cells["closetime"].Value.ToString().Split(':')[0];
            comboBox_closeMin.Text = dataGridView.Rows[e.RowIndex].Cells["closetime"].Value.ToString().Split(':')[1];
        }

        private void Button_DeleteTime_Click(object sender, EventArgs e)
        {
            string starttime = comboBox_startHour.Text + ":" + comboBox_startMin.Text;
            string closetime = comboBox_closeHour.Text + ":" + comboBox_closeMin.Text;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand();

                string sql = $"DELETE FROM playtime WHERE starttime='{starttime}' AND closetime='{closetime}'";
                command.Connection = conn;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                MessageBox.Show("에약취소 되었습니다.");
                SetDatagridView(null, null);
            }
        }

        private void Button_SetTime_Click(object sender, EventArgs e)
        {
            string startHour = comboBox_startHour.Text;
            string startMin = comboBox_startMin.Text;
            string closeHour = comboBox_closeHour.Text;
            string closeMin = comboBox_closeMin.Text;

            string starttime = startHour + ":" + startMin;
            string closetime = closeHour + ":" + closeMin;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();

                SqlCommand command = new SqlCommand();

                string sql = $"INSERT INTO playtime(starttime, closetime) VALUES('{starttime}','{closetime}')";
                command.Connection = conn;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                MessageBox.Show("예약완료 되었습니다.");
                SetDatagridView(null, null);
            }

        }

        private void SetTimeForm_Load(object sender, EventArgs e)
        {
            SetDatagridView(null, null);
        }
    }
}