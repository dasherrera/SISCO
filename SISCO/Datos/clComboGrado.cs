using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCO.Datos
{
    class clComboGrado
    {
        public DataTable mtdListar()
        {
            clConexion objConexion = new clConexion();
            DataTable dtGrado = new DataTable();
            string consulta = "select *from Grado";
            dtGrado = objConexion.mtdDesconectado(consulta);
            return dtGrado;

        }
    }
}
