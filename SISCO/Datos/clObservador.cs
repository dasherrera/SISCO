using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCO.Datos
{
    class ClObservador
    {
        ClConexion objconexion = new ClConexion();

        public DataTable MtdListar()
        {
            DataTable dt = new DataTable();
            string consulta = "select *, Administrativo.Rol, Nombres, Apellidos,  from Observador, Administrativo where idAdministrativo = Observador.IdAdministrativo ";
            dt = objconexion.MtdDesconectado(consulta);
            return dt;
            
        }
    }
}
