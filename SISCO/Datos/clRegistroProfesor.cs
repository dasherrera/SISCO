using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCO.Datos
{
    class clRegistroProfesor
    {
        public string docum;
        public string nomb;
        public string apell;
        public string Gene;
        public string corre;
        public string tele;
        public string año;
        public string direc;
        public string user;
        public string contra;

        public int mtdRegistrarPROF()
        {
            string profesor = "profesor";
            int canreg = 0;
            try
            {
                clConexion objConexion = new clConexion();
                string consulta = "INSERT INTO Administrativo(Rol,Documento,Nombre,Apellido,Genero,Correo,Telefono,Año,Usuario,Contraseña)" +
                                  " VALUES('" + profesor + "','" + docum + "','" + nomb + "','" + apell + "','" + Gene + "','" + corre + "','" + tele + "','" + año + "','" + user + "','" + contra + "')";
                canreg = objConexion.mtdConectado(consulta);
                MessageBox.Show("datos ingresados");
            }
            catch (Exception ex)
            {

                MessageBox.Show("datos no ingresados" + ex);
            }
            return canreg;
        }
    }
}
