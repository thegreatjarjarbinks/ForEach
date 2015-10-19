/*
 * Created by: Alex Mathias
 * Created on: 19-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-12
 * This program changes text colour of all objects
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnThisOne_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.ForeColor = Color.Green;
            }
        }

        private void btnNoMe_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                control.ForeColor = Color.Blue;
            }
        }

        private void btnDoMe_Click(object sender, EventArgs e)
        {
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Orange;
                }
            }
        }

        private void btnCoolButton_Click(object sender, EventArgs e)
        {
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = Color.Red;
                }
            }
        }
    }
}
