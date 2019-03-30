using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SISCO.Datos
{
    class clConexion
    {
        SqlConnection conex = null;
        public clConexion()
        {
            try
            {
                conex = new SqlConnection("Data Source=DESKTOP-P480VVV;Initial Catalog=SISCO;Integrated Security=True");
            }
            catch (Exception)
            {

            }

        }
        public DataTable mtdDesconectado(string consulta)
        {
            conex.Open();
            SqlDataAdapter adactador = new SqlDataAdapter(consulta, conex);
            DataTable dtDatos = new DataTable();
            adactador.Fill(dtDatos);
            conex.Close();
            return dtDatos;

        }
        public int mtdConectado(string consulta)
        {
            conex.Open();
            SqlCommand comando = new SqlCommand(consulta, conex);
            int validar = comando.ExecuteNonQuery();
            conex.Close();
            return validar;
        }
    }
}
