﻿using System;
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
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            ClEstudiante objEstudiante = new ClEstudiante();
            DataColumn dtEstudiante = new DataColumn();
            //dtEstudiante = objEstudiante.mtdListar();
            //cmbDependencia.DataSource = dtEstudiante;
            //cmbDependencia.DisplayMember = "Nombre";
            //cmbDependencia.ValueMember = "idDependencia";
        }
    }
}
