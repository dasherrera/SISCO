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
    public partial class frmCoordinador : Form
    {
        public frmCoordinador()
        {
          
            InitializeComponent();
            clCoordinadores objcoordinador = new clCoordinadores();
            DataTable dtgrado = new DataTable();
            dtgrado = objcoordinador.mtdgrado();
            cbxgrado.DataSource = dtgrado;
            cbxgrado.DisplayMember = "Grado";
        }

        private void btnbuscargrado_Click(object sender, EventArgs e)
        {
            clCoordinadores objcoordinador = new clCoordinadores();
            objcoordinador.grado = cbxgrado.Text;
            objcoordinador.mtdbuscargrado();
            dgvinfo.DataSource = objcoordinador.mtdbuscargrado();
        }

        private void btnbuscardocu_Click(object sender, EventArgs e)
        {
            clCoordinadores objcoordinador = new clCoordinadores();
            objcoordinador.documento = txtdocu.Text;

            dgvnotas.DataSource = objcoordinador.mtdbuscardos();
            dgvobservador.DataSource = objcoordinador.mtdobservaciones();
            dgvprimero.DataSource = objcoordinador.mtdPRIMERO();
            dgvsegundo.DataSource = objcoordinador.mtdSEGUNDO();
            dgvtercero.DataSource = objcoordinador.mtdTERCERO();
            dgvcuarto.DataSource = objcoordinador.mtdCUARTO();


            DataTable dtcoordi = new DataTable();
            dtcoordi = objcoordinador.mtdbuscar();
            try
            {
                lblnombre.Text = ("Nombre:  " + Convert.ToString(dtcoordi.Rows[0]["Nombre"]));
                lblapellido.Text = ("Apellido:  " + Convert.ToString(dtcoordi.Rows[0]["Apellidos"]));
            }
            catch (Exception)
            {

                MessageBox.Show("no se encontraron notas del estudiante");
            }
            
        }

       
    }
}
