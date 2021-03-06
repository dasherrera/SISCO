﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SISCO.Datos
{
    class clEstudianteD
    {
        clConexion objConexion = new clConexion();
        string Consulta = "";
        public string IdNota { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Grado { get; set; }
        public string Materia { get; set; }
        public string Celdas { get; set; }
        public string Nota { get; set; }
        public string Periodo { get; set; }

        public DataTable Listar()
        {
            DataTable dtBuscar = new DataTable();
            Consulta = " select TipoDocumento, Documento, Nombre, Apellidos, Edad, Grado from Estudiante, Grado, EstudianteGrado where EstudianteGrado.IdEstudiante= Estudiante.IdEstudiante and EstudianteGrado.IdGrado= Grado.IdGrado";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;
        }

        public DataTable Listar1()
        {
            DataTable dtBuscar = new DataTable();
            Consulta = "select Grado, Documento, Nombre, Apellidos from Estudiante INNER JOIN EstudianteGrado ON(Estudiante.IdEstudiante= EstudianteGrado.IdEstudiante) inner join Grado on(Grado.IdGrado= EstudianteGrado.IdGrado) ";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;

        }
        public DataTable MdtBuscar()
        {
            DataTable dtBuscar = new DataTable();
            //Consulta = "Select * from Persona where Documento like '%" + cedula + "%'";
            Consulta = " select Materia, Periodo from Materia, Estudiante, Periodo where Documento= '"+Documento+"'  order by IdPeriodo";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;
        }   
        public DataTable MtdBuscarpor()
        {
            DataTable dtBuscar = new DataTable();
            Consulta = "   Select Grado,  Nombre, Apellidos,  Materia FROM Estudiante, Grado, Materia, MateriaGrado WHERE Materia = '" + Materia + "' and MateriaGrado.IdGrado = Grado.IdGrado  AND MateriaGrado.IdMateria = Materia.IdMateria";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;
        }
        public DataTable MtdRegistroModi()
        {
            DataTable dtRegistro = new DataTable();
            Consulta = "select Materia, Nombre, Apellidos from Materia inner join MateriaGrado on (Materia.IdMateria = MateriaGrado.IdMateria) inner join Grado on (MateriaGrado.IdGrado = Grado.IdGrado), Estudiante  where Grado = '"+Grado+"'";
            dtRegistro = objConexion.mtdDesconectado(Consulta);
            return dtRegistro;
        }

        public DataTable MtdIdNota()
        {
            DataTable dtEnvio = new DataTable();
            Consulta = "Select IdNota from Nota";
            return dtEnvio;
        }
        public int MtdModificar()
        {
            string consulta = "Update Nota set  Nota ='" + Nota + "'   where idNota ='" + IdNota + "';";
            int cantREG = objConexion.mtdConectado(consulta);
            return cantREG;
        }
        public DataTable MtdSelectCelda(string Documento)
        {
            DataTable DtCelda = new DataTable();
            Consulta = "SELECT Materia, Periodo,Nota, IdNota  fROM Nota INNER JOIN Periodo ON (Nota.IdPeriodo= Periodo.IdPeriodo)inner join Estudiante on (Nota.IdEstudiante= Estudiante.IdEstudiante) INNER Join Materia on (Materia.IdMateria= Nota.IdMateriaGrado) where Documento='"+Documento+"'";
            DtCelda = objConexion.mtdDesconectado(Consulta);
            return DtCelda;
        }
        
        public DataTable MtdIngresar()
        {
            DataTable dtEnvio = new DataTable();
            Consulta = "Insert Materia ";
            return dtEnvio;
        }
    }
}
