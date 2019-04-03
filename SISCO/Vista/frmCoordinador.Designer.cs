namespace SISCO.Vista
{
    partial class frmCoordinador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoordinador));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.gbxinfo = new System.Windows.Forms.GroupBox();
            this.cbxgrado = new System.Windows.Forms.ComboBox();
            this.lblgrado = new System.Windows.Forms.Label();
            this.btnbuscargrado = new System.Windows.Forms.Button();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.gbxnotas = new System.Windows.Forms.GroupBox();
            this.dgvcuarto = new System.Windows.Forms.DataGridView();
            this.dgvtercero = new System.Windows.Forms.DataGridView();
            this.dgvsegundo = new System.Windows.Forms.DataGridView();
            this.dgvprimero = new System.Windows.Forms.DataGridView();
            this.dgvobservador = new System.Windows.Forms.DataGridView();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldocu = new System.Windows.Forms.Label();
            this.btnbuscardocu = new System.Windows.Forms.Button();
            this.dgvnotas = new System.Windows.Forms.DataGridView();
            this.txtdocu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.gbxnotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtercero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprimero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvobservador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(228, 33);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(1103, 55);
            this.lbltitulo.TabIndex = 41;
            this.lbltitulo.Text = "INSTITUCION EDUCATIVA TERESA DE JESUS";
            // 
            // gbxinfo
            // 
            this.gbxinfo.Controls.Add(this.cbxgrado);
            this.gbxinfo.Controls.Add(this.lblgrado);
            this.gbxinfo.Controls.Add(this.btnbuscargrado);
            this.gbxinfo.Controls.Add(this.dgvinfo);
            this.gbxinfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxinfo.ForeColor = System.Drawing.Color.White;
            this.gbxinfo.Location = new System.Drawing.Point(19, 202);
            this.gbxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbxinfo.Name = "gbxinfo";
            this.gbxinfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbxinfo.Size = new System.Drawing.Size(505, 492);
            this.gbxinfo.TabIndex = 39;
            this.gbxinfo.TabStop = false;
            this.gbxinfo.Text = "Informacion Estudiante-Acudiente";
            // 
            // cbxgrado
            // 
            this.cbxgrado.FormattingEnabled = true;
            this.cbxgrado.Location = new System.Drawing.Point(112, 54);
            this.cbxgrado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxgrado.Name = "cbxgrado";
            this.cbxgrado.Size = new System.Drawing.Size(92, 26);
            this.cbxgrado.TabIndex = 32;
            // 
            // lblgrado
            // 
            this.lblgrado.AutoSize = true;
            this.lblgrado.Location = new System.Drawing.Point(27, 57);
            this.lblgrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrado.Name = "lblgrado";
            this.lblgrado.Size = new System.Drawing.Size(58, 18);
            this.lblgrado.TabIndex = 31;
            this.lblgrado.Text = "Grado";
            // 
            // btnbuscargrado
            // 
            this.btnbuscargrado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscargrado.ForeColor = System.Drawing.Color.Black;
            this.btnbuscargrado.Location = new System.Drawing.Point(260, 48);
            this.btnbuscargrado.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscargrado.Name = "btnbuscargrado";
            this.btnbuscargrado.Size = new System.Drawing.Size(100, 36);
            this.btnbuscargrado.TabIndex = 30;
            this.btnbuscargrado.Text = "Buscar";
            this.btnbuscargrado.UseVisualStyleBackColor = true;
            this.btnbuscargrado.Click += new System.EventHandler(this.btnbuscargrado_Click);
            // 
            // dgvinfo
            // 
            this.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Location = new System.Drawing.Point(4, 154);
            this.dgvinfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvinfo.Name = "dgvinfo";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            this.dgvinfo.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvinfo.RowTemplate.Height = 24;
            this.dgvinfo.Size = new System.Drawing.Size(497, 242);
            this.dgvinfo.TabIndex = 28;
            // 
            // gbxnotas
            // 
            this.gbxnotas.Controls.Add(this.dgvcuarto);
            this.gbxnotas.Controls.Add(this.dgvtercero);
            this.gbxnotas.Controls.Add(this.dgvsegundo);
            this.gbxnotas.Controls.Add(this.dgvprimero);
            this.gbxnotas.Controls.Add(this.dgvobservador);
            this.gbxnotas.Controls.Add(this.lblapellido);
            this.gbxnotas.Controls.Add(this.lblnombre);
            this.gbxnotas.Controls.Add(this.lbldocu);
            this.gbxnotas.Controls.Add(this.btnbuscardocu);
            this.gbxnotas.Controls.Add(this.dgvnotas);
            this.gbxnotas.Controls.Add(this.txtdocu);
            this.gbxnotas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxnotas.ForeColor = System.Drawing.Color.White;
            this.gbxnotas.Location = new System.Drawing.Point(549, 211);
            this.gbxnotas.Margin = new System.Windows.Forms.Padding(2);
            this.gbxnotas.Name = "gbxnotas";
            this.gbxnotas.Padding = new System.Windows.Forms.Padding(2);
            this.gbxnotas.Size = new System.Drawing.Size(768, 492);
            this.gbxnotas.TabIndex = 38;
            this.gbxnotas.TabStop = false;
            this.gbxnotas.Text = "Notas y Observador";
            // 
            // dgvcuarto
            // 
            this.dgvcuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcuarto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvcuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuarto.Location = new System.Drawing.Point(342, 145);
            this.dgvcuarto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcuarto.Name = "dgvcuarto";
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.dgvcuarto.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvcuarto.RowTemplate.Height = 24;
            this.dgvcuarto.Size = new System.Drawing.Size(40, 242);
            this.dgvcuarto.TabIndex = 42;
            // 
            // dgvtercero
            // 
            this.dgvtercero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtercero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvtercero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtercero.Location = new System.Drawing.Point(298, 145);
            this.dgvtercero.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtercero.Name = "dgvtercero";
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            this.dgvtercero.RowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvtercero.RowTemplate.Height = 24;
            this.dgvtercero.Size = new System.Drawing.Size(40, 242);
            this.dgvtercero.TabIndex = 41;
            // 
            // dgvsegundo
            // 
            this.dgvsegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsegundo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvsegundo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsegundo.Location = new System.Drawing.Point(254, 145);
            this.dgvsegundo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsegundo.Name = "dgvsegundo";
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.dgvsegundo.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvsegundo.RowTemplate.Height = 24;
            this.dgvsegundo.Size = new System.Drawing.Size(40, 242);
            this.dgvsegundo.TabIndex = 40;
            // 
            // dgvprimero
            // 
            this.dgvprimero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprimero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvprimero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprimero.Location = new System.Drawing.Point(209, 145);
            this.dgvprimero.Margin = new System.Windows.Forms.Padding(2);
            this.dgvprimero.Name = "dgvprimero";
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            this.dgvprimero.RowsDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvprimero.RowTemplate.Height = 24;
            this.dgvprimero.Size = new System.Drawing.Size(40, 242);
            this.dgvprimero.TabIndex = 39;
            // 
            // dgvobservador
            // 
            this.dgvobservador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvobservador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvobservador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvobservador.Location = new System.Drawing.Point(416, 145);
            this.dgvobservador.Margin = new System.Windows.Forms.Padding(2);
            this.dgvobservador.Name = "dgvobservador";
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.dgvobservador.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvobservador.RowTemplate.Height = 24;
            this.dgvobservador.Size = new System.Drawing.Size(322, 242);
            this.dgvobservador.TabIndex = 38;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(46, 110);
            this.lblapellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(77, 18);
            this.lblapellido.TabIndex = 37;
            this.lblapellido.Text = "Apellido:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(46, 85);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(76, 18);
            this.lblnombre.TabIndex = 36;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbldocu
            // 
            this.lbldocu.AutoSize = true;
            this.lbldocu.Location = new System.Drawing.Point(37, 45);
            this.lbldocu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldocu.Name = "lbldocu";
            this.lbldocu.Size = new System.Drawing.Size(100, 18);
            this.lbldocu.TabIndex = 35;
            this.lbldocu.Text = "Documento";
            // 
            // btnbuscardocu
            // 
            this.btnbuscardocu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscardocu.ForeColor = System.Drawing.Color.Black;
            this.btnbuscardocu.Location = new System.Drawing.Point(416, 40);
            this.btnbuscardocu.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscardocu.Name = "btnbuscardocu";
            this.btnbuscardocu.Size = new System.Drawing.Size(106, 36);
            this.btnbuscardocu.TabIndex = 34;
            this.btnbuscardocu.Text = "Buscar";
            this.btnbuscardocu.UseVisualStyleBackColor = true;
            this.btnbuscardocu.Click += new System.EventHandler(this.btnbuscardocu_Click);
            // 
            // dgvnotas
            // 
            this.dgvnotas.AllowUserToOrderColumns = true;
            this.dgvnotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotas.Location = new System.Drawing.Point(25, 145);
            this.dgvnotas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvnotas.Name = "dgvnotas";
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            this.dgvnotas.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvnotas.RowTemplate.Height = 24;
            this.dgvnotas.Size = new System.Drawing.Size(180, 242);
            this.dgvnotas.TabIndex = 32;
            // 
            // txtdocu
            // 
            this.txtdocu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocu.Location = new System.Drawing.Point(189, 42);
            this.txtdocu.Margin = new System.Windows.Forms.Padding(2);
            this.txtdocu.Name = "txtdocu";
            this.txtdocu.Size = new System.Drawing.Size(152, 26);
            this.txtdocu.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1328, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxinfo);
            this.Controls.Add(this.gbxnotas);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCoordinador";
            this.Text = "frmCoordinador";
            this.gbxinfo.ResumeLayout(false);
            this.gbxinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.gbxnotas.ResumeLayout(false);
            this.gbxnotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtercero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprimero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvobservador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxinfo;
        private System.Windows.Forms.ComboBox cbxgrado;
        private System.Windows.Forms.Label lblgrado;
        private System.Windows.Forms.Button btnbuscargrado;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.GroupBox gbxnotas;
        private System.Windows.Forms.DataGridView dgvcuarto;
        private System.Windows.Forms.DataGridView dgvtercero;
        private System.Windows.Forms.DataGridView dgvsegundo;
        private System.Windows.Forms.DataGridView dgvprimero;
        private System.Windows.Forms.DataGridView dgvobservador;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldocu;
        private System.Windows.Forms.Button btnbuscardocu;
        private System.Windows.Forms.DataGridView dgvnotas;
        private System.Windows.Forms.TextBox txtdocu;
    }
}