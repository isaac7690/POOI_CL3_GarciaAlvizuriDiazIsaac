using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOI_CL3_GarciaAlvizuriDiazIsaac
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }
      

        private void lISTADODEESPECIALIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmListaEspecialidades childForm = new frmListaEspecialidades();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void lISTADODEENFERMEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmListaEnfermeros childForm = new frmListaEnfermeros();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ACTUALIZARENFERMEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmActualizarEnfermero childForm = new frmActualizarEnfermero();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void NUEVOENFERMEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmNuevoEnfermero childForm = new frmNuevoEnfermero();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
