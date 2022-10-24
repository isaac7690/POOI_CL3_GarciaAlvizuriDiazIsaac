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
    public partial class frmListaEspecialidades : Form
    {
        public frmListaEspecialidades()
        {
            InitializeComponent();
        }

        private void frmListaEspecialidades_Load(object sender, EventArgs e)
        {
            DAOEnfermero objDAO = new DAOEnfermero();
            dgEspecialidades.DataSource = objDAO.listaEspecialidad();
            dgEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
