namespace PE24A_SBAE
{
    partial class DlgMesaPracticas1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMesaPracticas1));
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.PbxLogotipo = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.BtnP1Muestra = new System.Windows.Forms.Button();
            this.BtnPruebas = new System.Windows.Forms.Button();
            this.TbxCaptura2 = new System.Windows.Forms.TextBox();
            this.TbxCaptura1 = new System.Windows.Forms.TextBox();
            this.PnlDerecho = new System.Windows.Forms.Panel();
            this.CbOpciones = new System.Windows.Forms.ComboBox();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.DgvTabla1 = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnP1 = new System.Windows.Forms.Button();
            this.PnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogotipo)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.PnlDerecho.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(27)))), ((int)(((byte)(172)))));
            this.PnlSuperior.Controls.Add(this.PbxLogotipo);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(749, 80);
            this.PnlSuperior.TabIndex = 0;
            this.PnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSuperior_Paint);
            // 
            // PbxLogotipo
            // 
            this.PbxLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxLogotipo.BackgroundImage")));
            this.PbxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxLogotipo.Location = new System.Drawing.Point(21, 12);
            this.PbxLogotipo.Name = "PbxLogotipo";
            this.PbxLogotipo.Size = new System.Drawing.Size(53, 50);
            this.PbxLogotipo.TabIndex = 0;
            this.PbxLogotipo.TabStop = false;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(150)))));
            this.PnlIzquierdo.Controls.Add(this.BtnP1);
            this.PnlIzquierdo.Controls.Add(this.BtnP1Muestra);
            this.PnlIzquierdo.Controls.Add(this.BtnPruebas);
            this.PnlIzquierdo.Controls.Add(this.TbxCaptura2);
            this.PnlIzquierdo.Controls.Add(this.TbxCaptura1);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 80);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(150, 331);
            this.PnlIzquierdo.TabIndex = 1;
            // 
            // BtnP1Muestra
            // 
            this.BtnP1Muestra.Location = new System.Drawing.Point(21, 146);
            this.BtnP1Muestra.Name = "BtnP1Muestra";
            this.BtnP1Muestra.Size = new System.Drawing.Size(112, 25);
            this.BtnP1Muestra.TabIndex = 3;
            this.BtnP1Muestra.Text = "P1 Muestra";
            this.BtnP1Muestra.UseVisualStyleBackColor = true;
            this.BtnP1Muestra.Click += new System.EventHandler(this.BtnP1Muestra_Click);
            // 
            // BtnPruebas
            // 
            this.BtnPruebas.Location = new System.Drawing.Point(21, 75);
            this.BtnPruebas.Name = "BtnPruebas";
            this.BtnPruebas.Size = new System.Drawing.Size(112, 50);
            this.BtnPruebas.TabIndex = 2;
            this.BtnPruebas.Text = "Prueba";
            this.BtnPruebas.UseVisualStyleBackColor = true;
            this.BtnPruebas.Click += new System.EventHandler(this.BtnPruebas_Click);
            // 
            // TbxCaptura2
            // 
            this.TbxCaptura2.Location = new System.Drawing.Point(21, 49);
            this.TbxCaptura2.Name = "TbxCaptura2";
            this.TbxCaptura2.Size = new System.Drawing.Size(112, 20);
            this.TbxCaptura2.TabIndex = 1;
            this.TbxCaptura2.TextChanged += new System.EventHandler(this.TbxCaptura2_TextChanged);
            // 
            // TbxCaptura1
            // 
            this.TbxCaptura1.Location = new System.Drawing.Point(21, 23);
            this.TbxCaptura1.Name = "TbxCaptura1";
            this.TbxCaptura1.Size = new System.Drawing.Size(112, 20);
            this.TbxCaptura1.TabIndex = 0;
            this.TbxCaptura1.TextChanged += new System.EventHandler(this.TbxCaptura1_TextChanged);
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(50)))), ((int)(((byte)(157)))));
            this.PnlDerecho.Controls.Add(this.CbOpciones);
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(599, 80);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(150, 331);
            this.PnlDerecho.TabIndex = 2;
            // 
            // CbOpciones
            // 
            this.CbOpciones.FormattingEnabled = true;
            this.CbOpciones.Location = new System.Drawing.Point(17, 22);
            this.CbOpciones.Name = "CbOpciones";
            this.CbOpciones.Size = new System.Drawing.Size(121, 21);
            this.CbOpciones.TabIndex = 0;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(67)))));
            this.PnlCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlCentral.BackgroundImage")));
            this.PnlCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCentral.Controls.Add(this.DgvTabla1);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(150, 80);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(449, 331);
            this.PnlCentral.TabIndex = 3;
            // 
            // DgvTabla1
            // 
            this.DgvTabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColApellidoP,
            this.ColApellidoM});
            this.DgvTabla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTabla1.Location = new System.Drawing.Point(0, 0);
            this.DgvTabla1.Name = "DgvTabla1";
            this.DgvTabla1.RowHeadersWidth = 47;
            this.DgvTabla1.Size = new System.Drawing.Size(449, 331);
            this.DgvTabla1.TabIndex = 0;
            this.DgvTabla1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla1_CellContentClick);
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 115;
            // 
            // ColApellidoP
            // 
            this.ColApellidoP.HeaderText = "Apellido paterno";
            this.ColApellidoP.MinimumWidth = 6;
            this.ColApellidoP.Name = "ColApellidoP";
            this.ColApellidoP.Width = 115;
            // 
            // ColApellidoM
            // 
            this.ColApellidoM.HeaderText = "Apellido materno";
            this.ColApellidoM.MinimumWidth = 6;
            this.ColApellidoM.Name = "ColApellidoM";
            this.ColApellidoM.Width = 115;
            // 
            // BtnP1
            // 
            this.BtnP1.Location = new System.Drawing.Point(21, 187);
            this.BtnP1.Name = "BtnP1";
            this.BtnP1.Size = new System.Drawing.Size(112, 25);
            this.BtnP1.TabIndex = 4;
            this.BtnP1.Text = "P1 Llena";
            this.BtnP1.UseVisualStyleBackColor = true;
            this.BtnP1.Click += new System.EventHandler(this.BtnP1Llena_Click);
            // 
            // DlgMesaPracticas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 411);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlDerecho);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.PnlSuperior);
            this.Name = "DlgMesaPracticas1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesa de Prácticas 1";
            this.PnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogotipo)).EndInit();
            this.PnlIzquierdo.ResumeLayout(false);
            this.PnlIzquierdo.PerformLayout();
            this.PnlDerecho.ResumeLayout(false);
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlDerecho;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.TextBox TbxCaptura1;
        private System.Windows.Forms.PictureBox PbxLogotipo;
        private System.Windows.Forms.TextBox TbxCaptura2;
        private System.Windows.Forms.ComboBox CbOpciones;
        private System.Windows.Forms.Button BtnPruebas;
        private System.Windows.Forms.DataGridView DgvTabla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidoM;
        private System.Windows.Forms.Button BtnP1Muestra;
        private System.Windows.Forms.Button BtnP1;
    }
}