using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCO.Datos
{
    class clValidacionLogin
    {
        ClConexion ObjConexion = new ClConexion();
        public void MtdListar()
        {
            DataTable dtBuscar = new DataTable();
            string Consulta = "Select Estudiante.Usuario, Estudiante.Contraseña,Administrativo.Usuario, Administrativo.Contraseña  From Estudiante, Administrativo ";
            ObjConexion.MtdDesconectado(Consulta);
        }

    }
}
