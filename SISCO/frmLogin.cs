using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISCO.Datos;

namespace SISCO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            if (rbtEstudiante.Checked == true)
            {

                rbtAdministrativo.Checked.Equals(false);


            }

            if (rbtAdministrativo.Checked == true)
            {

                rbtEstudiante.Checked.Equals(false);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clConexion ObjConexion = new clConexion();
            
            
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            clListar objListar = new clListar();
            if (rbtEstudiante.Checked)
            {
                
               

                DataTable dtEstudiante = new DataTable();
                dtEstudiante = objListar.mtdlistarestudiante();
                clLogin objLogin = new clLogin();
                objLogin.USER = txtUsuario.Text;
                objLogin.CONTRA = txtContraseña.Text;
                objLogin.mtdValidar();
                
            }
            else if (rbtAdministrativo.Checked)
            {
               
                
               

                DataTable dtprofesor = new DataTable();
                dtprofesor = objListar.mtdlistarprofesor();
                clLogin objLogin = new clLogin();
                objLogin.USER = txtUsuario.Text;
                objLogin.CONTRA = txtContraseña.Text;
                objLogin.mtdAdministrativo();
            }
           
            else
            {
                MessageBox.Show("debe seleccionar algun rol");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
