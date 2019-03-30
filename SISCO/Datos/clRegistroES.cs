using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCO.Datos
{
    class clRegistroES
    {
        public string tipod;
        public string docum;
        public string nomb;
        public string apell;
        public string Edad;
        public string Gene;
        public string corre;
        public string tele;
        public string direc;
        public string user;
        public string contra;
        public string año;
        public string Documento;
        public string Nombre;
        public string Apellido;
        public string Telefono;
        public string Direccion;
        public int IdGrado;

        string validar;

        public int mtdRegistrarACU()
        {
            int canreg = 0;
            try
            {
                clConexion objConexion = new clConexion();
                string consulta = "INSERT INTO Acudiente(Documento,Nombre,Apellido,Telefono,Direccion)" +
                                  " VALUES('" + Documento + "','" + Nombre + "','" + Apellido + "','" + Telefono + "','" + Direccion + "')";
                 canreg = objConexion.mtdConectado(consulta);
            }
            catch (Exception ex)
            {

                MessageBox.Show("datos no ingresados" +ex);
            }
                return canreg;


        }
        public DataTable mtdGenerarAcu()
        {
            clConexion objConexion = new clConexion();
            DataTable dtestudiante = new DataTable();
            string consulta = "select IdAcudiente from Acudiente where Documento = '" + Documento + "'";
            dtestudiante = objConexion.mtdDesconectado(consulta);
           
            return dtestudiante;
        }
       
        public int mtdRegistrarEst()
        {
            int canreg = 0;
            try
            {

                clConexion objConexion = new clConexion();
                clRegistroES objRegis = new clRegistroES();
                objRegis.mtdGenerarAcu();
                validar = Convert.ToString(mtdGenerarAcu().Rows[0]["IdAcudiente"]);
                string consulta = "INSERT INTO Estudiante(TipoDocumento,Documento,Nombre,Apellidos,Edad,Genero,Correo,Telefono,Direccion,Usuario,Contraseña,Año,IdAcudiente)" +
                                      " VALUES('" + tipod + "','" + docum + "','" + nomb + "','" + apell + "','" + Edad + "','" + Gene + "','" + corre + "','" + tele + "','" + direc + "','" + user + "','" + contra + "','" + año + "','" + Convert.ToInt32(validar) + "')";
                canreg = objConexion.mtdConectado(consulta);
                MessageBox.Show("datos ingresados correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("error al ingresar los datos");
            }
            
            
            return canreg;


        }
        public DataTable mtdBuscarIdEstu()
        {
            clConexion objConexion = new clConexion();
            DataTable dtestudiante = new DataTable();

            string consulta = "select IdEstudiante from Estudiante where Documento = '" + docum + "'";
            dtestudiante = objConexion.mtdDesconectado(consulta);

            return dtestudiante;
        }
        public DataTable mtdGenerarIdEstu()
        {
            clConexion objConexion = new clConexion();
            DataTable dtestudiante = new DataTable();
            
            string consulta = "select IdEstudiante from Estudiante where Documento = '" + docum + "'";
            dtestudiante = objConexion.mtdDesconectado(consulta);

            return dtestudiante;
        }
        public int mtdRegistrarGra()
        {
            int canreg = 0;
          
                clConexion objConexion = new clConexion();
                clRegistroES objRegis = new clRegistroES();
            try
            {
                objRegis.mtdGenerarIdEstu();
                validar = Convert.ToString(mtdGenerarIdEstu().Rows[0]["IdEstudiante"]);
                string consulta = "INSERT INTO EstudianteGrado(IdEstudiante,IdGrado)" +
                                      " VALUES('" + validar + "','" + IdGrado + "')";
                canreg = objConexion.mtdConectado(consulta);
               MessageBox.Show("datos ingresados correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("error al ingresar los datos");
            }







            return canreg;


        }


    }
}
