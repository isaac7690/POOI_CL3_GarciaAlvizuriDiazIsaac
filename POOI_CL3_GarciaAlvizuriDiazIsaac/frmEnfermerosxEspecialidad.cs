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
    public partial class frmEnfermerosxEspecialidad : Form
    {
        DAOEnfermero objDAO = new DAOEnfermero();
        public frmEnfermerosxEspecialidad()
        {
            InitializeComponent();
            cboEspecialidad.DataSource = objDAO.listarCboEspecialidad();
            cboEspecialidad.DisplayMember = "nom_esp";
            cboEspecialidad.ValueMember = "ide_esp";
        }

        private void frmEnfermerosxEspecialidad_Load(object sender, EventArgs e)
        {
            dgEnfermeros.DataSource = objDAO.listaEnfermeros();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Enfermero objE = new Enfermero();
            objE.ide_esp = int.Parse(cboEspecialidad.SelectedValue.ToString());
            dgEnfermeros.DataSource = objDAO.listaEnfermerosxEspecialidad(objE);
        }
    }
}
