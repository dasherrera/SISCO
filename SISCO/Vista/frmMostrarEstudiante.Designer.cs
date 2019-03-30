namespace SISCO.Vista
{
    partial class frmMostrarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblducuacu = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbTipoGR = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ptbacu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbacu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblducuacu
            // 
            this.lblducuacu.AutoSize = true;
            this.lblducuacu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblducuacu.ForeColor = System.Drawing.Color.White;
            this.lblducuacu.Location = new System.Drawing.Point(30, 359);
            this.lblducuacu.Name = "lblducuacu";
            this.lblducuacu.Size = new System.Drawing.Size(154, 16);
            this.lblducuacu.TabIndex = 30;
            this.lblducuacu.Text = "Numero de Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(202, 352);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(196, 22);
            this.txtDocumento.TabIndex = 29;
            // 
            // cmbTipoGR
            // 
            this.cmbTipoGR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoGR.FormattingEnabled = true;
            this.cmbTipoGR.Items.AddRange(new object[] {
            "cedula",
            "tarjeta",
            "registro civil",
            "otro"});
            this.cmbTipoGR.Location = new System.Drawing.Point(202, 401);
            this.cmbTipoGR.Name = "cmbTipoGR";
            this.cmbTipoGR.Size = new System.Drawing.Size(56, 24);
            this.cmbTipoGR.TabIndex = 51;
            this.cmbTipoGR.Visible = false;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.White;
            this.lblGrado.Location = new System.Drawing.Point(137, 409);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(47, 16);
            this.lblGrado.TabIndex = 50;
            this.lblGrado.Text = "Grado";
            this.lblGrado.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 402);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // ptbacu
            // 
            this.ptbacu.Image = global::SISCO.Properties.Resources.TERESA_COLOR;
            this.ptbacu.Location = new System.Drawing.Point(116, 30);
            this.ptbacu.Name = "ptbacu";
            this.ptbacu.Size = new System.Drawing.Size(223, 185);
            this.ptbacu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbacu.TabIndex = 53;
            this.ptbacu.TabStop = false;
            // 
            // frmMostrarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1328, 609);
            this.Controls.Add(this.ptbacu);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbTipoGR);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblducuacu);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarEstudiante";
            this.Text = "frmMostrarEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbacu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblducuacu;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbTipoGR;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox ptbacu;
    }
}