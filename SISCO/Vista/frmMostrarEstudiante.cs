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
    public partial class frmMostrarEstudiante : Form
    {
        public frmMostrarEstudiante()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Fila Selecionada:");
        }
        
    }
}
