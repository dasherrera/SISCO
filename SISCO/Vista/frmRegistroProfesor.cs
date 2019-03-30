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

namespace SISCO.Vista
{
    public partial class frmRegistroProfesor : Form
    {
        public frmRegistroProfesor()
        {
            InitializeComponent();
            if (rbtM.Checked == true)
            {
                rbtF.Checked.Equals(false);
               
            }
            else if (rbtF.Checked == true)
            {
                rbtM.Checked.Equals(false);
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string buton = "";
            if (rbtM.Checked == true)
            {
                rbtF.Checked.Equals(false);
                buton = "M";
            }
            else if (rbtF.Checked == true)
            {
                rbtM.Checked.Equals(false);
                buton = "F";
            }
            clRegistroProfesor objRegisPro = new clRegistroProfesor();
            objRegisPro.docum = txtDocu.Text;
            objRegisPro.nomb = txtNom.Text;
            objRegisPro.apell = txtApe.Text;
            objRegisPro.Gene = buton;
            objRegisPro.corre = txtCorre.Text;
            objRegisPro.tele = txtTel.Text;
            objRegisPro.año = txtAño.Text;
            objRegisPro.direc = txtDirec.Text;
            objRegisPro.user = txtUser.Text;
            objRegisPro.contra = txtContra.Text;
            objRegisPro.mtdRegistrarPROF();
        }
    }
}
