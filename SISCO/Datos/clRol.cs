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
    class ClRol
    {
        ClConexion ObjConexion = new ClConexion();
        string consulta = "";
        public void MtdRol()
        {
            
            consulta = "Select Genero From Estudiante";

        }
    }
}
