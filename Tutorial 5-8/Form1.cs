using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_5_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmToos_Click(object sender, EventArgs e)
        {
            // Create random object with time base seed
            Random rand = new Random();

            // Variable toss of coin
            int toss = rand.Next(2);

            // Display the results
            if (toss == 0)
            {
                // Display heads
                pbxHeads.Visible = true;
                pbxTails.Visible = false;
            }
            else
            {
                // Display tails
                pbxHeads.Visible = false;
                pbxTails.Visible = true;
            }
        }
    }
}
