using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SISCO.Datos
{
    class clListar
    {
        public DataTable mtdlistarestudiante()
        {
            clConexion objconexion = new clConexion();
            DataTable dtestudiante = new DataTable();
            string consulta = "select*from estudiante";
            dtestudiante = objconexion.mtdDesconectado(consulta);
            return dtestudiante;
        }
        public DataTable mtdlistarprofesor()
        {

            clConexion objconexion = new clConexion();
            DataTable dtprofesor = new DataTable();
            string consulta = "select*from Administrativo";
            dtprofesor = objconexion.mtdDesconectado(consulta);
            return dtprofesor;
        }
    }
}
