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
    public partial class AdminMainForm : MetroFramework.Forms.MetroForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnPlaySongForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SongPlayForm songPlayForm = new SongPlayForm();
            songPlayForm.ShowDialog();
        }

        private void btnGoReservedSongForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReservedSongForm reservedSongForm = new ReservedSongForm();
            reservedSongForm.ShowDialog();
        }

        private void btnGoSetTimeForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SetTimeForm setTimeForm = new SetTimeForm();
            setTimeForm.ShowDialog();
        }
    }
}
