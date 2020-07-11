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

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnSignUpForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
