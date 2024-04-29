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
            this.components = new System.ComponentModel.Container();
            this.TmrCambioHora = new System.Windows.Forms.Timer(this.components);
            this.BtnP2Lienzo = new System.Windows.Forms.Button();
            this.PnlLienzo = new System.Windows.Forms.Panel();
            this.DgvVectores = new System.Windows.Forms.DataGridView();
            this.ColVector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.BtnDibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectores)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrCambioHora
            // 
            this.TmrCambioHora.Interval = 1000;
            // 
            // BtnP2Lienzo
            // 
            this.BtnP2Lienzo.Location = new System.Drawing.Point(581, 57);
            this.BtnP2Lienzo.Name = "BtnP2Lienzo";
            this.BtnP2Lienzo.Size = new System.Drawing.Size(133, 23);
            this.BtnP2Lienzo.TabIndex = 14;
            this.BtnP2Lienzo.Text = "P2 Mostrar Lienzo";
            this.BtnP2Lienzo.UseVisualStyleBackColor = true;
            this.BtnP2Lienzo.Click += new System.EventHandler(this.BtnP2Lienzo_Click);
            // 
            // PnlLienzo
            // 
            this.PnlLienzo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLienzo.BackColor = System.Drawing.Color.White;
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
            // DlgMesaPracticas3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.BtnDibujar);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.DgvVectores);
            this.Controls.Add(this.PnlLienzo);
            this.Controls.Add(this.BtnP2Lienzo);
            this.DoubleBuffered = true;
            this.Name = "DlgMesaPracticas3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa de Prácticas 2";
            this.TransparencyKey = System.Drawing.Color.AntiqueWhite;
            this.Load += new System.EventHandler(this.DlgMesaPracticas2_Load);
            this.Resize += new System.EventHandler(this.DlgMesaPracticas2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVectores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TmrCambioHora;
        private System.Windows.Forms.Button BtnP2Lienzo;
        private System.Windows.Forms.Panel PnlLienzo;
        private System.Windows.Forms.DataGridView DgvVectores;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColY;
        private System.Windows.Forms.Button BtnDibujar;
    }
}