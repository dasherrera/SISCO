using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SISCO.Datos;

namespace SISCO.Vista
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        public void MtdCargarDatagridNota()
        {

        }
        private void frmDocente_Load(object sender, EventArgs e)
        {
            // ESTA Listando el grado en el cbxCurso
            clListarD ObjDependencia = new clListarD();
            DataTable dtGrado = new DataTable();
            dtGrado = ObjDependencia.MtdListar(); // ESTA LLAMANDO MTDLISTAR
            cbxCurso.DataSource = dtGrado;
            cbxCurso.DisplayMember = "Grado";
            cbxCurso.ValueMember = "IdGrado";

            // ESTA Listando La Materia en el cbxMateria
            clListarD ObjMateria = new clListarD();
            DataTable dtMateria = new DataTable();
            dtMateria = ObjDependencia.MtdListarMateria(); // ESTA LLAMANDO MTDLISTAR
            cbxMateria.DataSource = dtMateria;
            cbxMateria.DisplayMember = "Materia";
            cbxMateria.ValueMember = "IdMateria";

            //llamar y cargar el DataGridView
            clEstudianteD objPersona = new clEstudianteD();
            objPersona.Documento = txtDocumento.Text;
            dgvEstudiantes.DataSource = objPersona.Listar();

            // cargar tabla registro 
            clEstudianteD objTablaNueva = new clEstudianteD();
            dgvNotas.DataSource = objTablaNueva.Listar1();


        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            clEstudianteD objPersona = new clEstudianteD();
            objPersona.Documento = txtDocumento.Text;
            objPersona.Nombre = txtNombre.Text;
            objPersona.Apellido = txtApellido.Text;
            objPersona.Grado = cbxCurso.Text;
            dgvEstudiantes.DataSource = objPersona.MdtBuscar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clEstudianteD objPersona = new clEstudianteD();
            objPersona.Grado = cbxCurso.Text;
            dgvEstudiantes.DataSource = objPersona.MtdRegistroModi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clEstudianteD objPersona = new clEstudianteD();
            objPersona.Materia = cbxMateria.Text;
            dgvEstudiantes.DataSource = objPersona.MtdBuscarpor();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            clExportar Obj = new clExportar();
            Obj.ExportarExcel(dgvEstudiantes);
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtDatos = new DataTable();
            clEstudianteD ObjCelda = new clEstudianteD();
            dtDatos = ObjCelda.Listar1();
            //buscamos por doble click en el documento
            try
            {
                string Documento = dgvEstudiantes.CurrentRow.Cells["Documento"].Value.ToString();
                dgvNotas.DataSource = ObjCelda.MtdSelectCelda(Documento);
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione El DOCUMENTO");
            }


            try
            {
                lblnombre.Text = ("Nombre:  " + Convert.ToString(dgvEstudiantes.CurrentRow.Cells["Nombre"].Value));
                lblapellido.Text = ("Apellido:  " + Convert.ToString(dgvEstudiantes.CurrentRow.Cells["Apellidos"].Value));
                lblGrado.Text = ("Grado:  " + Convert.ToString(dgvEstudiantes.CurrentRow.Cells["Grado"].Value));
            }
            catch (Exception)
            {

                MessageBox.Show("no se encontraron notas del estudiante");
            }
            //abir pagina 2
            this.tabCnDocente.SelectedTab = this.tabPage2;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            clEstudianteD ObjGuardar = new clEstudianteD();
            ObjGuardar.Materia = dgvNotas.CurrentRow.Cells["Materia"].Value.ToString();
            ObjGuardar.Nota = dgvNotas.CurrentRow.Cells["Nota"].Value.ToString();
            ObjGuardar.Periodo = dgvNotas.CurrentRow.Cells["Periodo"].Value.ToString();
            //dgvNotas.DataSource = ObjGuardar.MtdSelectCelda(Documento);


            int can = ObjGuardar.MtdModificar();
            if (can > 0)
            {
                MessageBox.Show("Datos Modificados");
                clEstudianteD objTablaNueva = new clEstudianteD();
                dgvNotas.DataSource = objTablaNueva.Listar1();

            }
            else MessageBox.Show("Error");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clEstudianteD objPersona = new clEstudianteD();
            objPersona.Documento = txtDocumento.Text;
            dgvEstudiantes.DataSource = objPersona.Listar();
        }
        // este evento es para editar el valor que hay en las celdas del datagridView 
        private void dgvNotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            clEstudianteD ObjModificar = new clEstudianteD();
            string Documento = dgvEstudiantes.CurrentRow.Cells["Documento"].Value.ToString();
            if (Convert.ToString(dgvNotas.CurrentRow.Cells) != "")
            {
                if (Convert.ToString(dgvNotas.CurrentRow.Cells["Materia"].Value.ToString()) != "")
                {
                    if (Convert.ToString(dgvNotas.CurrentRow.Cells["Materia"].Value.ToString()) == "Matematicas")
                    {

                    }
                }

                if (Convert.ToString(dgvNotas.CurrentRow.Cells["Nota"].Value.ToString()) != "")
                {

                    ObjModificar.Nota = dgvNotas.CurrentRow.Cells["Nota"].Value.ToString();
                    ObjModificar.IdNota = dgvNotas.CurrentRow.Cells["IdNota"].Value.ToString();
                    dgvNotas.DataSource = ObjModificar.MtdModificar();
                    clEstudianteD objTablaNueva = new clEstudianteD();
                    dgvNotas.DataSource = objTablaNueva.MtdSelectCelda(Documento);

                }



                if (Convert.ToString(dgvNotas.CurrentRow.Cells) == "")
                {
                    MessageBox.Show("Si Esta intentando Modificar:\n Por Favor Ingrese un valor");
                }
            }
        }
    }
}
