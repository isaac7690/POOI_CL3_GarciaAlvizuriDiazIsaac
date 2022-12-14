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
    public partial class frmActualizarEnfermero : Form
    {
        DAOEnfermero objDAO = new DAOEnfermero();
        public frmActualizarEnfermero()
        {
            InitializeComponent();
            cboEspecialidad.DataSource = objDAO.listarCboEspecialidad();
            cboEspecialidad.DisplayMember = "nom_esp";
            cboEspecialidad.ValueMember = "ide_esp";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Enfermero objE = new Enfermero()
            {
                ide_enf = int.Parse(txtCodigo.Text),
                nom_enf = txtNombres.Text,
                ape_enf = txtApellidos.Text,
                tel_enf = txtTelefono.Text,
                ide_esp = int.Parse(cboEspecialidad.SelectedValue.ToString())
            };
            try
            {
                int n = objDAO.ActualizarEnfermero(objE);
                if (n == 1)
                    MessageBox.Show(n + "Registro de Enfermero ACTUALIZADO!");
                dgEnfermeros.DataSource = objDAO.listaEnfermeros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEnfermeros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(dgEnfermeros.CurrentRow.Cells[0].Value.ToString());

            DataRow dr = objDAO.buscarEnfermeros(codigo).Rows[0];
            txtCodigo.Text = dr[0].ToString();
            txtNombres.Text = dr[1].ToString();
            txtApellidos.Text = dr[2].ToString();
            txtTelefono.Text = dr[3].ToString();
            cboEspecialidad.Text = dr[4].ToString();
        }

        private void frmActualizarEnfermero_Load(object sender, EventArgs e)
        {
            dgEnfermeros.DataSource = objDAO.listaEnfermeros();
        }       
    }
}

