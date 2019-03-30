using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SISCO.Datos;

namespace SISCO.Datos
{
    class clAdministrativo
    {
        public DataTable mtdlistar()
        {
            ClConexion objconexion = new ClConexion();
            DataTable dtdependencia = new DataTable();
            string consulta = "select*from dependencia";
            dtdependencia = objconexion.MtdDesconectado(consulta);
            return dtdependencia;
        }
    }
}
