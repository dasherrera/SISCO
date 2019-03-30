using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCO.Datos
{
    class ClEstudiante
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public string Edad { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        ClConexion objconexion = new ClConexion();

        public DataTable MtdListar()
        {
            DataTable dtPersona = new DataTable();
            string consulta = "select *from Estudiante";
            dtPersona = objconexion.MtdDesconectado(consulta);
            return dtPersona;
        }
        public DataTable mtdBuscar()
        {
            DataTable dtBuscar = new DataTable();
            string Buscar = "select *from Estudiante where Documento='" + Documento + "'";
            objconexion.MtdDesconectado(Buscar);
            return dtBuscar;

        }
    }
}
