using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCO.Vista
{
    public partial class frmSecretaria : Form
    {
        public frmSecretaria()
        {
            InitializeComponent();
            frmMostrarSecretaria objSecretaria = new frmMostrarSecretaria();
            objSecretaria.MdiParent = this;


            foreach (Form Abierto in MdiChildren)
            {
                if (Abierto.Name != "frmMostrarSecretaria")
                {
                    Abierto.Hide();
                }
                else
                {
                    objSecretaria.WindowState = FormWindowState.Maximized;
                    objSecretaria.Show();
                }
            }

        }

        private void eSTUDIANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEstudiante objRegisEstudiante = new frmRegistroEstudiante();
            objRegisEstudiante.MdiParent = this;


            foreach (Form Abierto in MdiChildren)
            {
                if (Abierto.Name != "frmRegistroEstudiante")
                {
                    Abierto.Hide();
                }
                else
                {
                    objRegisEstudiante.WindowState = FormWindowState.Maximized;
                    objRegisEstudiante.Show();
                }
            }
        }

        private void pROFESORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProfesor objRegisProfesor = new frmRegistroProfesor();
            objRegisProfesor.MdiParent = this;


            foreach (Form Abierto in MdiChildren)
            {
                if (Abierto.Name != "frmRegistroProfesor")
                {
                    Abierto.Hide();
                }
                else
                {
                    objRegisProfesor.WindowState = FormWindowState.Maximized;
                    objRegisProfesor.Show();
                }
            }
        }

        private void frmSecretaria_Load(object sender, EventArgs e)
        {
            frmMostrarSecretaria objSecretaria = new frmMostrarSecretaria();
            objSecretaria.MdiParent = this;


            foreach (Form Abierto in MdiChildren)
            {
                if (Abierto.Name != "frmMostrarSecretaria")
                {
                    Abierto.Hide();
                }
                else
                {
                    objSecretaria.WindowState = FormWindowState.Maximized;
                    objSecretaria.Show();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmMostrarSecretaria objSecretaria = new frmMostrarSecretaria();
            objSecretaria.MdiParent = this;


            foreach (Form Abierto in MdiChildren)
            {
                if (Abierto.Name != "frmMostrarSecretaria")
                {
                    Abierto.Hide();
                }
                else
                {
                    objSecretaria.WindowState = FormWindowState.Maximized;
                    objSecretaria.Show();
                }
            }
        }
    }
}
