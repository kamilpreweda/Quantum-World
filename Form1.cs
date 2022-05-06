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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Overview";
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Buildings";
        }
        private void btnResources_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Resources";
        }
        private void btnResearch_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Research";
        }
        private void btnDock_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Dock";
        }
        private void btnMap_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're seeing Map";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "You're logged out";
        }
    }
}
