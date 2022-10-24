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
        public frmActualizarEnfermero()
        {
            InitializeComponent();
        }

       /* private void btnActualizar_Click(object sender, EventArgs e)
        {
            Enfermero objV = new Vendedor()
            {
                ide_ven = int.Parse(txtCodigo.Text),
                nom_ven = txtNombres.Text,
                ape_ven = txtApellidos.Text,
                sue_ven = double.Parse(txtSueldo.Text),
                fec_ing = dtFecha.Value,
                ide_dis = int.Parse(cboEspecialidad.SelectedValue.ToString())
            };
            try
            {
                int n = objDAO.nuevoVendedor(objV);
                if (n == 1)
                    MessageBox.Show(n + " Registro de vendedor ACTUALIZADO ");
                dgVendedores.DataSource = objDAO.listadoVendedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }*/
    }
}
