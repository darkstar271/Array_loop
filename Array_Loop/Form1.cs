using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            lbxNames.Items.Clear();
            // Create an array of names
            string[] names =
            {
                "Arthur", "Daniel", "Jane", "Darren", "Ethan", "Jeff", "Judah", "Kyle", "Sonya", "Josh",
                "Keum"
            };
            //using a For Loop.
            for (int i = 0; i < names.Length; i++)
            {
                lbxNames.Items.Add(names[i]);
            }
            foreach (string name in names)
            {
                lbxNames.Items.Add(name);
            }
            Random myRandom = new Random();
            int winner = myRandom.Next(0, names.Length - 1);
            lblwinner.Text = "And the winner is..." + names[winner] + "!";
            lbxWinners.Items.Add(names[winner]);

            if (names.Contains("Daniel"))
            {
                this.Text = "Daniel is in the list";

            }
            

        }

        private void lbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxWinners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
