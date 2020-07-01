using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMJukeBox
{
    public partial class GSMJukeBox : MetroFramework.Forms.MetroForm
    {
        public GSMJukeBox()
        {
            InitializeComponent();
        }

        private void GSMJukeBox_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterSong registerForm = new RegisterSong();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
