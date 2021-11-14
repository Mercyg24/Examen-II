using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tiposDeSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipos frm = new frmTipos();
            frm.Show();
        }

        private void tiketesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiketes frm = new frmTiketes();
            frm.Show();
        }

        private void estadoDeSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado frm = new Estado();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalle frm = new frmDetalle();
            frm.Show();
        }
    }
}
