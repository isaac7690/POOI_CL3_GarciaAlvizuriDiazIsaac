using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POOI_CL3_GarciaAlvizuriDiazIsaac
{
    internal class DAOEnfermero
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        public int generaCodigo()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOCODIGO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            cn.Close();
            return n;
        }
        //1.Lista Enfermeros
        public DataTable listaEnfermeros()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARENFERMERO", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //2.Lista especialidad
        public DataTable listaEspecialidad()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARESPECIALIDAD", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //CBOBOX ESPECIALIDAD
        public DataTable listarCboEspecialidad()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_CBOESPECIALIDAD", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //3.ActualizarEnfermero
        public int ActualizarEnfermero(Enfermero objE)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOENFERMERO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ide", objE.ide_enf);
            cmd.Parameters.AddWithValue("@nom", objE.nom_enf);
            cmd.Parameters.AddWithValue("@ape", objE.ape_enf);
            cmd.Parameters.AddWithValue("@tel", objE.tel_enf);
            cmd.Parameters.AddWithValue("@esp", objE.ide_esp);

            try
            {
                int n = cmd.ExecuteNonQuery();
                return n;
            }
            catch (Exception)
            {
            }
            cn.Close();
            return 0;
        }

        //4.NuevoEnfermero
        public int nuevoEnfermero(Enfermero objE)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOENFERMERO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", objE.nom_enf);
            cmd.Parameters.AddWithValue("@ape", objE.ape_enf);
            cmd.Parameters.AddWithValue("@tel", objE.tel_enf);
            cmd.Parameters.AddWithValue("@esp", objE.ide_esp);
            
            try
            {
                int n = cmd.ExecuteNonQuery();
                return n;
            }
            catch (Exception)
            {
            }
            cn.Close();
            return 0;
        }
        public DataTable buscarEnfermeros(int ide)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_BUSQUEDAENFERMERO", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@ide",SqlDbType.Int).Value=ide;
            da.SelectCommand.Parameters.AddWithValue("@ide", ide);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        //lista de enfermeros x especialidad
        public DataTable listaEnfermerosxEspecialidad(Enfermero objE)
        {
            cn = objCon.getConecta();

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_ENFERMEROSXESPECIALIDAD", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@esp", objE.ide_esp);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }

    }
}
