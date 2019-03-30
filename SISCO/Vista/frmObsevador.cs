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
    public partial class frmObsevador : Form
    {
        public frmObsevador()
        {
            InitializeComponent();
        }

        private void frmObsevador_Load(object sender, EventArgs e)
        {
            ClObservador objObservador = new ClObservador();
            //dgvVehiculo.DataSource = objVehiculo.mtdListar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClEstudiante objpersona = new ClEstudiante();
            objpersona.Documento = txtDocumento.Text;
            dgvObservador.DataSource = objpersona.mtdBuscar();
        }
    }
}
