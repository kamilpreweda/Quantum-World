using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantum_World
{
    public partial class Dock : UserControl
    {
        public Dock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnShip1_Click(object sender, EventArgs e)
        {
            btnShip1.Text = "Ship 1 completed";
        }
        private void BtnShip2_Click(object sender, EventArgs e)
        {
            btnShip2.Text = "Ship 2 completed";
        }
        private void BtnShip3_Click(object sender, EventArgs e)
        {
            btnShip3.Text = "Ship 3 completed";
        }
        private void BtnShip4_Click(object sender, EventArgs e)
        {
            btnShip4.Text = "Ship 4 completed";
        }
    }
}
