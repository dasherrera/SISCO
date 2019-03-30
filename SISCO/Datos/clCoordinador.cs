using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SISCO.Datos;

namespace SISCO.Datos
{
    class clCoordinador
    {
        public string documento { get; set; }
        public string grado { get; set; }

        clConexion objconexion = new clConexion();

        public DataTable mtdbuscargrado()//BUSCAR POR GRADO
        {
            DataTable dtbuscargrado = new DataTable();
            string buscargrado = " select estudiante.Documento as Documento_Estudiante,estudiante.Nombre as Nombre_Estudiante,estudiante.Apellidos as Apellidos_Estudiante,Acudiente.Nombre as Nombre_Acudiente,Acudiente.Apellido as Apellido_Acudiente,Acudiente.Direccion as Direccion_Acudiente,Acudiente.Telefono as Telefono_Acudiente from Estudiante inner join Acudiente on Acudiente.IdAcudiente=Estudiante.IdAcudiente inner join EstudianteGrado on Estudiante.IdEstudiante =EstudianteGrado.IdEstudiante inner join Grado on Grado.IdGrado=EstudianteGrado.IdGrado  where grado = '" + grado + "'";
            dtbuscargrado = objconexion.mtdDesconectado(buscargrado);
            return dtbuscargrado;
        }


        public DataTable mtdbuscar()//BUSCAR POR DOCUMENTO
        {
            DataTable dtbuscar = new DataTable();
            string buscar = "select nombre,apellidos,materia,nota from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante where Estudiante.Documento ='" + documento + "'";
            dtbuscar = objconexion.mtdDesconectado(buscar);
            return dtbuscar;

        }
        public DataTable mtdbuscardos()//BUSCAR POR DOCUMENTO
        {
            DataTable dtbuscar = new DataTable();
            string buscar = "select  materia from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante INNER JOIN periodo on periodo.idperiodo=nota.idperiodo where Estudiante.Documento ='" + documento + "'and Periodo.Periodo = 'Primero'";
            dtbuscar = objconexion.mtdDesconectado(buscar);
            return dtbuscar;

        }
        public DataTable mtdPRIMERO()//BUSCAR POR DOCUMENTO
        {
            DataTable dtbuscar = new DataTable();
            string buscar = "select  materia from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante INNER JOIN periodo on periodo.idperiodo=nota.idperiodo where Estudiante.Documento ='" + documento + "'and Periodo.Periodo = 'Primero'";
            dtbuscar = objconexion.mtdDesconectado(buscar);
            return dtbuscar;

        }
        public DataTable mtdSEGUNDO()//BUSCAR POR DOCUMENTO
        {
            DataTable dtbuscar = new DataTable();
            string buscar = "select  materia from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante INNER JOIN periodo on periodo.idperiodo=nota.idperiodo where Estudiante.Documento ='" + documento + "'and Periodo.Periodo = 'Primero'";
            dtbuscar = objconexion.mtdDesconectado(buscar);
            return dtbuscar;

        }
        public DataTable mtdTERCERO)//BUSCAR POR DOCUMENTO
        {
            DataTable dtbuscar = new DataTable();
           string buscar = "select  materia from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante INNER JOIN periodo on periodo.idperiodo=nota.idperiodo where Estudiante.Documento ='" + documento + "'and Periodo.Periodo = 'Primero'";
            dtbuscar = objconexion.mtdDesconectado(buscar);
            return dtbuscar;
        }
        public DataTable mtdCUARTO()//BUSCAR POR DOCUMENTO
        {
           DataTable dtbuscar = new DataTable();
           string buscar = "select  materia from Nota inner join MateriaGrado on MateriaGrado.IdMateriaGrado= Nota.IdMateriaGrado inner join Materia on Materia.IdMateria=MateriaGrado.IdMateria inner join Estudiante on Nota.IdEstudiante=Estudiante.IdEstudiante INNER JOIN periodo on periodo.idperiodo=nota.idperiodo where Estudiante.Documento ='" + documento + "'and Periodo.Periodo = 'Primero'";
           dtbuscar = objconexion.mtdDesconectado(buscar);
           return dtbuscar;

        }


         public DataTable mtdobservaciones()
         {
           DataTable dtobservaciones = new DataTable();
           string observaciones = " select  Observador from Observador inner join Estudiante on Estudiante.IdEstudiante=Observador.IdEstudiante  where documento = '" + documento + "'";
           dtobservaciones = objconexion.mtdDesconectado(observaciones);
           return dtobservaciones;
         }
     }
}




    
