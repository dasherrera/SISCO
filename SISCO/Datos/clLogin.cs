using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using SISCO.Vista;

namespace SISCO.Datos
{
    class clLogin
    {
        public string USER;
        public string CONTRA;
       
        

        public DataTable mtdValidar()
        {
            clConexion objconexion = new clConexion();
            
            DataTable dtestudiante = new DataTable();
           

            string consulta = "select * from Estudiante where Usuario = '"+USER+"'AND Contraseña = '"+CONTRA+"'";
            dtestudiante = objconexion.mtdDesconectado(consulta);
            try
            {
                if (Convert.ToString(dtestudiante.Rows[0]["Usuario"]) != "" && Convert.ToString(dtestudiante.Rows[0]["Contraseña"]) != "")
                {
                    MessageBox.Show("Bienvenido");
                    frmEstudiante objestudiante = new frmEstudiante();
                   
                    objestudiante.Show();
                   
                    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o Contarseña Incorrecta");
            }
            return dtestudiante;
        }
        public DataTable mtdAdministrativo()
        {
            clConexion objConexion = new clConexion();
            frmMostrarSecretaria objMostrar = new frmMostrarSecretaria();
            DataTable dtprofesor = new DataTable();

            string consulta = "select * from Administrativo where Usuario = '" + USER + "'AND Contraseña = '" + CONTRA + "'";
            dtprofesor = objConexion.mtdDesconectado(consulta);
            string rol;
            try
            {
                if (Convert.ToString(dtprofesor.Rows[0]["Usuario"]) != "" && Convert.ToString(dtprofesor.Rows[0]["Contraseña"]) != "")
                {
                    rol = Convert.ToString(dtprofesor.Rows[0]["Rol"]);
                    if (rol == "Secretaria")
                    {
                        MessageBox.Show("Bienvenido");
                        frmSecretaria objSecretaria = new frmSecretaria();
                        objSecretaria.Show();
                    }
                    else if (rol == "Profesor")
                    {
                        MessageBox.Show("Bienvenido");
                        frmDocente objDocente = new frmDocente();
                        objDocente.Show();
                    }
                    else if (rol == "Coordinador")
                    {

                        MessageBox.Show("Bienvenido");
                        frmCoordinador objCoordinador = new frmCoordinador();
                        objCoordinador.Show();
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Usuario o Contarseña Incorrecta");
            }
            return dtprofesor;
        }



    }
}
