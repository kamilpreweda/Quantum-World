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
    public partial class Buildings : UserControl
    {
        public Buildings()
        {
            InitializeComponent();


        }
       
        private void BtnBuilding1Upgrade_Click(object sender, EventArgs e)
        {
            btnBuilding1Upgrade.Text = "Building 1 upgraded";
        }
        private void BtnBuilding2Upgrade_Click(object sender, EventArgs e)
        {
            btnBuilding2Upgrade.Text = "Building 2 upgraded";
        }
        private void BtnBuilding3Upgrade_Click(object sender, EventArgs e)
        {
            btnBuilding3Upgrade.Text = "Building 3 upgraded";
        }
        private void BtnBuilding4Upgrade_Click(object sender, EventArgs e)
        {
            btnBuilding4Upgrade.Text = "Building 4 upgraded";
        }

        private void Buildings_Load(object sender, EventArgs e)
        {

        }
    }
}
