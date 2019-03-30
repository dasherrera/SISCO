using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SISCO.Datos
{
    class clListarD
    {
        public DataTable MtdListar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "select * from Grado";
            DataTable dtDependencia = new DataTable();
            dtDependencia = objConexion.mtdDesconectado(consulta);
            return dtDependencia;

        }
        public DataTable MtdListarMateria()
        {
            clConexion objConexion = new clConexion();
            string consulta = "select * from Materia";
            DataTable dtDependencia = new DataTable();
            dtDependencia = objConexion.mtdDesconectado(consulta);
            return dtDependencia;

        }
        public DataTable mtdlistarestudiante()
        {
            clConexion objconexion = new clConexion();
            DataTable dtestudiante = new DataTable();
            string consulta = "select*from Estudiante";
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
