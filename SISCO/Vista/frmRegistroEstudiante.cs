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
    public partial class frmRegistroEstudiante : Form
    {

        public frmRegistroEstudiante()
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
            clComboGrado objComboGrado = new clComboGrado();
            DataTable dtDependencia = new DataTable();
            dtDependencia = objComboGrado.mtdListar();
            cmbTipoGR.DataSource = dtDependencia;
            cmbTipoGR.DisplayMember = "Grado";
            cmbTipoGR.ValueMember = "IdGrado";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "" )
            {
                MessageBox.Show("faltan campos por llenar");
            }
            else
            {
               

                clRegistroES objRegistroES = new clRegistroES();
                objRegistroES.Documento = txtDocumento.Text;
                objRegistroES.Nombre = txtNombre.Text;
                objRegistroES.Apellido = txtApellido.Text;
                objRegistroES.Telefono = txtTelefono.Text;
                objRegistroES.Direccion = txtDireccion.Text;
                objRegistroES.mtdRegistrarACU();
                lblTipo.Visible = true;
                lblDocu.Visible = true;
                lblNom.Visible = true;
                lblApe.Visible = true;
                lblEdad.Visible = true;
                lblGen.Visible = true;
                lblCorre.Visible = true;
                lblTele.Visible = true;
                lblDirecc.Visible = true;
                lblUser.Visible = true;
                lblContra.Visible = true;
                lblTitulo.Visible = true;
                ptbImagen.Visible = true;
                lblAño.Visible = true;
                cmbTipoD.Visible = true;
                txtDocu.Visible = true;
                txtNom.Visible = true;
                txtApe.Visible = true;
                txtEdad.Visible = true;
                rbtM.Visible = true;
                rbtF.Visible = true;
                txtCorre.Visible = true;
                txtTel.Visible = true;
                txtDirec.Visible = true;
                txtUser.Visible = true;
                txtContra.Visible = true;
                txtAño.Visible = true;
                btnGuardar.Visible = true;

                ptbUNO.Visible = true;
                ptbDOS.Visible = false;
                txtDocumento.Visible = false;
                txtNombre.Visible = false;
                txtApellido.Visible = false;
                txtTelefono.Visible = false;
                txtDireccion.Visible = false;
                btnSiguiente.Visible = false;
                lblducuacu.Visible = false;
                lblnomacu.Visible = false;
                lblapeacu.Visible = false;
                lbltelcau.Visible = false;
                lbldirecacu.Visible = false;
                lbltituloacu.Visible = false;
                ptbacu.Visible = false;

               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblGrado.Visible = true;
            cmbTipoGR.Visible = true;
            btnGuardar2.Visible = true;

            string buton="";
            if (rbtM.Checked == true)
            {
                buton = "M";
                rbtF.Checked.Equals(false);
            }
            else if (rbtF.Checked == true)
            {
                buton = "F";
                rbtM.Checked.Equals(false);
            }
            
            clRegistroES objRegistroEs = new clRegistroES();

            objRegistroEs.Documento = txtDocumento.Text;
            objRegistroEs.tipod = cmbTipoD.Text;
            objRegistroEs.docum = txtDocu.Text;
            objRegistroEs.nomb = txtNom.Text;
            objRegistroEs.apell = txtApe.Text;
            objRegistroEs.Edad = txtEdad.Text;
            objRegistroEs.Gene = buton;
            objRegistroEs.corre = txtCorre.Text;
            objRegistroEs.tele = txtTel.Text;
            objRegistroEs.direc = txtDirec.Text;
            objRegistroEs.user = txtUser.Text;
            objRegistroEs.contra = txtContra.Text;
            objRegistroEs.año = txtAño.Text;
           
            objRegistroEs.mtdGenerarAcu();
            objRegistroEs.mtdRegistrarEst();
            
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            
            int idGrado = int.Parse(cmbTipoGR.SelectedValue.ToString());
            clRegistroES objRegistroES = new clRegistroES();
            objRegistroES.IdGrado = idGrado;
            objRegistroES.docum = txtDocu.Text;
            objRegistroES.mtdGenerarIdEstu();
            objRegistroES.mtdRegistrarGra();
        }

        private void frmRegistroEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
