namespace SISCO.Vista
{
    partial class frmSecretaria
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTUDIANTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTUDIANTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESORESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem,
            this.iNFORMACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDIANTESToolStripMenuItem,
            this.pROFESORESToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGISTROToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.rEGISTROToolStripMenuItem.Text = "REGISTRO";
            // 
            // eSTUDIANTESToolStripMenuItem
            // 
            this.eSTUDIANTESToolStripMenuItem.Name = "eSTUDIANTESToolStripMenuItem";
            this.eSTUDIANTESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eSTUDIANTESToolStripMenuItem.Text = "ESTUDIANTES";
            this.eSTUDIANTESToolStripMenuItem.Click += new System.EventHandler(this.eSTUDIANTESToolStripMenuItem_Click);
            // 
            // pROFESORESToolStripMenuItem
            // 
            this.pROFESORESToolStripMenuItem.Name = "pROFESORESToolStripMenuItem";
            this.pROFESORESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pROFESORESToolStripMenuItem.Text = "PROFESORES";
            this.pROFESORESToolStripMenuItem.Click += new System.EventHandler(this.pROFESORESToolStripMenuItem_Click);
            // 
            // iNFORMACIONToolStripMenuItem
            // 
            this.iNFORMACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDIANTESToolStripMenuItem1,
            this.pROFESORESToolStripMenuItem1});
            this.iNFORMACIONToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNFORMACIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.iNFORMACIONToolStripMenuItem.Name = "iNFORMACIONToolStripMenuItem";
            this.iNFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.iNFORMACIONToolStripMenuItem.Text = "INFORMACION";
            // 
            // eSTUDIANTESToolStripMenuItem1
            // 
            this.eSTUDIANTESToolStripMenuItem1.Name = "eSTUDIANTESToolStripMenuItem1";
            this.eSTUDIANTESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eSTUDIANTESToolStripMenuItem1.Text = "ESTUDIANTES";
            // 
            // pROFESORESToolStripMenuItem1
            // 
            this.pROFESORESToolStripMenuItem1.Name = "pROFESORESToolStripMenuItem1";
            this.pROFESORESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pROFESORESToolStripMenuItem1.Text = "PROFESORES";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1353, 680);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSecretaria";
            this.Text = "frmSecretaria";
            this.Load += new System.EventHandler(this.frmSecretaria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIANTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIANTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pROFESORESToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}