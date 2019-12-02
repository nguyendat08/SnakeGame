using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure!!!", "Warning");
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            frmPlay frmplay = new frmPlay();
            frmplay.ShowDialog();
            this.Close();

        }
    }
}
