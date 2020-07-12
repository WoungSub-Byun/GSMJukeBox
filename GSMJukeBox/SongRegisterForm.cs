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

        public SongRegisterForm()
        {
            InitializeComponent();
        }


        private void RegisterSong_Load(object sender, EventArgs e)
        {

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
            string constr = "SERVER=127.0.0.1; DATABASE=gsmjukebox;UID=woung;PASSWORD='1234'";
            using (SqlConnection sqlconn = new SqlConnection(constr))
            {
                try
                {
                    sqlconn.Open();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
            }
        }



    }
}