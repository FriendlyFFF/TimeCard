using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCard
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSShift_Click(object sender, EventArgs e)
        {
            tbxSShift.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblSBreak1.Visible = true;
            tbxSBreak1.Visible = true;
            lblSLunch.Visible = true;
            tbxSLunch.Visible = true;
            lblEShift.Visible = true;
            tbxEShift.Visible = true;
        }

        // When form loads, only 'Start Shift' option should be visible.
        // =============================================================
        private void frm1_Load(object sender, EventArgs e)
        {
            lblSBreak1.Visible = false;
            tbxSBreak1.Visible = false;
            lblEBreak1.Visible = false;
            tbxEBreak1.Visible = false;
            lblSLunch.Visible  = false;
            tbxSLunch.Visible  = false;
            lblELunch.Visible  = false;
            tbxELunch.Visible  = false;
            lblSBreak2.Visible = false;
            tbxSBreak2.Visible = false;
            lblEBreak2.Visible = false;
            tbxEBreak2.Visible = false;
            lblEShift.Visible  = false;
            tbxEShift.Visible  = false;
        }

        private void lblSBreak1_Click(object sender, EventArgs e)
        {
            tbxSBreak1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblEBreak1.Visible = true;
            tbxEBreak1.Visible = true;
            lblSLunch.Visible = false;
            tbxSLunch.Visible = false;
            lblEShift.Visible = false;
            tbxEShift.Visible = false;
        }

        private void lblEBreak1_Click(object sender, EventArgs e)
        {
            tbxEBreak1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblSLunch.Visible = true;
            tbxSLunch.Visible = true;
            lblEShift.Visible = true;
            tbxEShift.Visible = true;
        }

        private void lblSLunch_Click(object sender, EventArgs e)
        {
            tbxSLunch.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            if (tbxSBreak1.Text == "")
            {
                lblSBreak1.Visible = false;
                tbxSBreak1.Visible = false;
                lblEBreak1.Visible = false;
                tbxEBreak1.Visible = false;
            }
            lblELunch.Visible = true;
            tbxELunch.Visible = true;
            lblEShift.Visible = false;
            tbxEShift.Visible = false;
        }

        private void lblELunch_Click(object sender, EventArgs e)
        {
            tbxELunch.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblSBreak2.Visible = true;
            tbxSBreak2.Visible = true;
            lblEShift.Visible = true;
            tbxEShift.Visible = true;
        }

        private void lblSBreak2_Click(object sender, EventArgs e)
        {
            tbxSBreak2.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblEBreak2.Visible = true;
            tbxEBreak2.Visible = true;
            lblEShift.Visible = false;
            tbxEShift.Visible = false;
        }

        private void lblEBreak2_Click(object sender, EventArgs e)
        {
            tbxEBreak2.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            lblEShift.Visible = true;
            tbxEShift.Visible = true;
        }

        private void lblEShift_Click(object sender, EventArgs e)
        {
            tbxEShift.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            if (tbxSBreak2.Text == "")
            {
                lblSBreak2.Visible = false;
                tbxSBreak2.Visible = false;
                lblEBreak2.Visible = false;
                tbxEBreak2.Visible = false;
            }
        }
    }
}
