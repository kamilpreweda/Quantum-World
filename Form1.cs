using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Quantum_World
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideAll();
            overview1.Show();
            overview1.BringToFront();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            HideAll();
            overview1.Show();
            overview1.BringToFront();
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {
            HideAll();
            buildings1.Show();
            buildings1.BringToFront();
        }
        private void btnResources_Click(object sender, EventArgs e)
        {
            HideAll();
            resources1.Show();
            resources1.BringToFront();
        }
        private void btnResearch_Click(object sender, EventArgs e)
        {
            HideAll();
            research1.Show();
            research1.BringToFront();
        }
        private void btnDock_Click(object sender, EventArgs e)
        {
            HideAll();
            dock1.Show();
            dock1.BringToFront();
        }
        private void btnMap_Click(object sender, EventArgs e)
        {
            HideAll();
            map1.Show();
            map1.BringToFront();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            HideAll();
            logout1.Show();
            logout1.BringToFront();
        }

        private void HideAll()
        {
            overview1.Hide();
            buildings1.Hide();
            resources1.Hide();
            research1.Hide();
            dock1.Hide();
            map1.Hide();
            logout1.Hide();
        }

        private void resources1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* private void CarbonFiber()
{
lblCarbonFiber.Text = "test"; */


    }
}

