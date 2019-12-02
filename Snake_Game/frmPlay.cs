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
    public partial class frmPlay : Form
    {
        private List<Circle> Snake = new List<Circle>();

        private Circle food = new Circle();


        public frmPlay()
        {
            InitializeComponent();
        }

        private void PnlPlay_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
