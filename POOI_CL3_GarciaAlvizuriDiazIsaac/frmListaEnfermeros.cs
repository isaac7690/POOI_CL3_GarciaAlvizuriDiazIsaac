using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POOI_CL3_GarciaAlvizuriDiazIsaac
{
    public partial class frmListaEnfermeros : Form
    {
        DAOEnfermero objDAO = new DAOEnfermero();
        public frmListaEnfermeros()
        {
            InitializeComponent();
        }

        private void frmListaEnfermeros_Load(object sender, EventArgs e)
        {
            DAOEnfermero objDAO = new DAOEnfermero();
            dgEnfermeros.DataSource = objDAO.listaEnfermeros();
            dgEnfermeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
