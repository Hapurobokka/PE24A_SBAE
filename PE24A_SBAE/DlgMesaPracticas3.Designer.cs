namespace PE24A_SBAE
{
    partial class DlgMesaPracticas3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMesaPracticas3));
            this.BtnP3Lienzo = new System.Windows.Forms.Button();
            this.PnlLienzo = new System.Windows.Forms.Panel();
            this.DgvVectores = new System.Windows.Forms.DataGridView();
            this.ColVector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.BtnDibujar = new System.Windows.Forms.Button();
            this.TbxPerimetro = new System.Windows.Forms.TextBox();
            this.TbxArea = new System.Windows.Forms.TextBox();
            this.LblPerimetro = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.PbxRosaDeLosVientos = new System.Windows.Forms.PictureBox();
            this.BtnMostrarRosa = new System.Windows.Forms.Button();
            this.BtnRotar = new System.Windows.Forms.Button();
            this.BtnArriba = new System.Windows.Forms.Button();
            this.BtnAbajo = new System.Windows.Forms.Button();
            this.BtnIzquierda = new System.Windows.Forms.Button();
            this.BtnDerecha = new System.Windows.Forms.Button();
            this.PnlLienzo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRosaDeLosVientos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnP3Lienzo
            // 
            this.BtnP3Lienzo.Location = new System.Drawing.Point(581, 57);
            this.BtnP3Lienzo.Name = "BtnP3Lienzo";
            this.BtnP3Lienzo.Size = new System.Drawing.Size(133, 23);
            this.BtnP3Lienzo.TabIndex = 14;
            this.BtnP3Lienzo.Text = "P3 Mostrar Lienzo";
            this.BtnP3Lienzo.UseVisualStyleBackColor = true;
            this.BtnP3Lienzo.Click += new System.EventHandler(this.BtnP3Lienzo_Click);
            // 
            // PnlLienzo
            // 
            this.PnlLienzo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLienzo.BackColor = System.Drawing.Color.White;
            this.PnlLienzo.Controls.Add(this.PbxRosaDeLosVientos);
            this.PnlLienzo.Location = new System.Drawing.Point(270, 86);
            this.PnlLienzo.Name = "PnlLienzo";
            this.PnlLienzo.Size = new System.Drawing.Size(980, 578);
            this.PnlLienzo.TabIndex = 15;
            // 
            // DgvVectores
            // 
            this.DgvVectores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvVectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColVector,
            this.ColX,
            this.ColY});
            this.DgvVectores.Location = new System.Drawing.Point(12, 86);
            this.DgvVectores.Name = "DgvVectores";
            this.DgvVectores.RowHeadersWidth = 47;
            this.DgvVectores.Size = new System.Drawing.Size(252, 578);
            this.DgvVectores.TabIndex = 0;
            // 
            // ColVector
            // 
            this.ColVector.HeaderText = "Vector";
            this.ColVector.MinimumWidth = 6;
            this.ColVector.Name = "ColVector";
            this.ColVector.Width = 115;
            // 
            // ColX
            // 
            this.ColX.FillWeight = 50F;
            this.ColX.HeaderText = "X";
            this.ColX.MinimumWidth = 6;
            this.ColX.Name = "ColX";
            this.ColX.Width = 50;
            // 
            // ColY
            // 
            this.ColY.FillWeight = 50F;
            this.ColY.HeaderText = "Y";
            this.ColY.MinimumWidth = 6;
            this.ColY.Name = "ColY";
            this.ColY.Width = 50;
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(478, 57);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(97, 23);
            this.BtnImportar.TabIndex = 16;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // BtnDibujar
            // 
            this.BtnDibujar.Location = new System.Drawing.Point(720, 57);
            this.BtnDibujar.Name = "BtnDibujar";
            this.BtnDibujar.Size = new System.Drawing.Size(97, 23);
            this.BtnDibujar.TabIndex = 17;
            this.BtnDibujar.Text = "Dibujar";
            this.BtnDibujar.UseVisualStyleBackColor = true;
            this.BtnDibujar.Click += new System.EventHandler(this.BtnDibujar_Click);
            // 
            // TbxPerimetro
            // 
            this.TbxPerimetro.Location = new System.Drawing.Point(13, 57);
            this.TbxPerimetro.Name = "TbxPerimetro";
            this.TbxPerimetro.Size = new System.Drawing.Size(100, 20);
            this.TbxPerimetro.TabIndex = 18;
            // 
            // TbxArea
            // 
            this.TbxArea.Location = new System.Drawing.Point(119, 57);
            this.TbxArea.Name = "TbxArea";
            this.TbxArea.Size = new System.Drawing.Size(100, 20);
            this.TbxArea.TabIndex = 19;
            // 
            // LblPerimetro
            // 
            this.LblPerimetro.AutoSize = true;
            this.LblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LblPerimetro.Location = new System.Drawing.Point(12, 37);
            this.LblPerimetro.Name = "LblPerimetro";
            this.LblPerimetro.Size = new System.Drawing.Size(69, 17);
            this.LblPerimetro.TabIndex = 20;
            this.LblPerimetro.Text = "Perimetro";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LblArea.Location = new System.Drawing.Point(119, 37);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(38, 17);
            this.LblArea.TabIndex = 21;
            this.LblArea.Text = "Área";
            // 
            // PbxRosaDeLosVientos
            // 
            this.PbxRosaDeLosVientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxRosaDeLosVientos.BackColor = System.Drawing.Color.Transparent;
            this.PbxRosaDeLosVientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxRosaDeLosVientos.BackgroundImage")));
            this.PbxRosaDeLosVientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxRosaDeLosVientos.Image = ((System.Drawing.Image)(resources.GetObject("PbxRosaDeLosVientos.Image")));
            this.PbxRosaDeLosVientos.Location = new System.Drawing.Point(829, 20);
            this.PbxRosaDeLosVientos.Name = "PbxRosaDeLosVientos";
            this.PbxRosaDeLosVientos.Size = new System.Drawing.Size(119, 112);
            this.PbxRosaDeLosVientos.TabIndex = 0;
            this.PbxRosaDeLosVientos.TabStop = false;
            // 
            // BtnMostrarRosa
            // 
            this.BtnMostrarRosa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMostrarRosa.Location = new System.Drawing.Point(1138, 57);
            this.BtnMostrarRosa.Name = "BtnMostrarRosa";
            this.BtnMostrarRosa.Size = new System.Drawing.Size(112, 23);
            this.BtnMostrarRosa.TabIndex = 22;
            this.BtnMostrarRosa.Text = "Mostrar Rosa";
            this.BtnMostrarRosa.UseVisualStyleBackColor = true;
            this.BtnMostrarRosa.Click += new System.EventHandler(this.BtnMostrarRosa_Click);
            // 
            // BtnRotar
            // 
            this.BtnRotar.Location = new System.Drawing.Point(1057, 57);
            this.BtnRotar.Name = "BtnRotar";
            this.BtnRotar.Size = new System.Drawing.Size(75, 23);
            this.BtnRotar.TabIndex = 23;
            this.BtnRotar.Text = "Rotar";
            this.BtnRotar.UseVisualStyleBackColor = true;
            this.BtnRotar.Click += new System.EventHandler(this.BtnRotar_Click);
            // 
            // BtnArriba
            // 
            this.BtnArriba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnArriba.Location = new System.Drawing.Point(916, 31);
            this.BtnArriba.Name = "BtnArriba";
            this.BtnArriba.Size = new System.Drawing.Size(75, 23);
            this.BtnArriba.TabIndex = 24;
            this.BtnArriba.Text = "Arriba";
            this.BtnArriba.UseVisualStyleBackColor = true;
            this.BtnArriba.Click += new System.EventHandler(this.BtnArriba_Click);
            // 
            // BtnAbajo
            // 
            this.BtnAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbajo.Location = new System.Drawing.Point(916, 57);
            this.BtnAbajo.Name = "BtnAbajo";
            this.BtnAbajo.Size = new System.Drawing.Size(75, 23);
            this.BtnAbajo.TabIndex = 25;
            this.BtnAbajo.Text = "Abajo";
            this.BtnAbajo.UseVisualStyleBackColor = true;
            this.BtnAbajo.Click += new System.EventHandler(this.BtnAbajo_Click);
            // 
            // BtnIzquierda
            // 
            this.BtnIzquierda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzquierda.Location = new System.Drawing.Point(870, 29);
            this.BtnIzquierda.Name = "BtnIzquierda";
            this.BtnIzquierda.Size = new System.Drawing.Size(40, 51);
            this.BtnIzquierda.TabIndex = 26;
            this.BtnIzquierda.Text = "Izquierda";
            this.BtnIzquierda.UseVisualStyleBackColor = true;
            this.BtnIzquierda.Click += new System.EventHandler(this.BtnIzquierda_Click);
            // 
            // BtnDerecha
            // 
            this.BtnDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDerecha.Location = new System.Drawing.Point(997, 26);
            this.BtnDerecha.Name = "BtnDerecha";
            this.BtnDerecha.Size = new System.Drawing.Size(40, 51);
            this.BtnDerecha.TabIndex = 27;
            this.BtnDerecha.Text = "Derecha";
            this.BtnDerecha.UseVisualStyleBackColor = true;
            this.BtnDerecha.Click += new System.EventHandler(this.BtnDerecha_Click);
            // 
            // DlgMesaPracticas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.BtnDerecha);
            this.Controls.Add(this.BtnIzquierda);
            this.Controls.Add(this.BtnAbajo);
            this.Controls.Add(this.BtnArriba);
            this.Controls.Add(this.BtnRotar);
            this.Controls.Add(this.BtnMostrarRosa);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblPerimetro);
            this.Controls.Add(this.TbxArea);
            this.Controls.Add(this.TbxPerimetro);
            this.Controls.Add(this.BtnDibujar);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.DgvVectores);
            this.Controls.Add(this.PnlLienzo);
            this.Controls.Add(this.BtnP3Lienzo);
            this.DoubleBuffered = true;
            this.Name = "DlgMesaPracticas3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa de Prácticas 2";
            this.TransparencyKey = System.Drawing.Color.AntiqueWhite;
            this.PnlLienzo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRosaDeLosVientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnP3Lienzo;
        private System.Windows.Forms.Panel PnlLienzo;
        private System.Windows.Forms.DataGridView DgvVectores;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY;
        private System.Windows.Forms.Button BtnDibujar;
        private System.Windows.Forms.TextBox TbxPerimetro;
        private System.Windows.Forms.TextBox TbxArea;
        private System.Windows.Forms.Label LblPerimetro;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.PictureBox PbxRosaDeLosVientos;
        private System.Windows.Forms.Button BtnMostrarRosa;
        private System.Windows.Forms.Button BtnRotar;
        private System.Windows.Forms.Button BtnArriba;
        private System.Windows.Forms.Button BtnAbajo;
        private System.Windows.Forms.Button BtnIzquierda;
        private System.Windows.Forms.Button BtnDerecha;
    }
}