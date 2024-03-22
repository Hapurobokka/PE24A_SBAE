namespace PE24A_SBAE
{
    partial class DlgMesaPracticas2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMesaPracticas2));
            this.TmrCambioHora = new System.Windows.Forms.Timer(this.components);
            this.PbxDerecha = new System.Windows.Forms.PictureBox();
            this.PbxIzquierda = new System.Windows.Forms.PictureBox();
            this.PbxInferior = new System.Windows.Forms.PictureBox();
            this.LnlIzquierda = new System.Windows.Forms.LinkLabel();
            this.LnlDerecha = new System.Windows.Forms.LinkLabel();
            this.LnlInferior = new System.Windows.Forms.LinkLabel();
            this.LblFechaActual = new System.Windows.Forms.Label();
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.BtnP2Lienzo = new System.Windows.Forms.Button();
            this.PnlLienzo = new System.Windows.Forms.Panel();
            this.BtnP2Limpiar = new System.Windows.Forms.Button();
            this.BtnP3MostrarCuadrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIzquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInferior)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrCambioHora
            // 
            this.TmrCambioHora.Interval = 1000;
            this.TmrCambioHora.Tick += new System.EventHandler(this.TmrCambioHora_tick);
            // 
            // PbxDerecha
            // 
            this.PbxDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxDerecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxDerecha.BackgroundImage")));
            this.PbxDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxDerecha.Location = new System.Drawing.Point(1127, 41);
            this.PbxDerecha.Name = "PbxDerecha";
            this.PbxDerecha.Size = new System.Drawing.Size(50, 50);
            this.PbxDerecha.TabIndex = 2;
            this.PbxDerecha.TabStop = false;
            // 
            // PbxIzquierda
            // 
            this.PbxIzquierda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxIzquierda.BackgroundImage")));
            this.PbxIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIzquierda.Location = new System.Drawing.Point(125, 76);
            this.PbxIzquierda.Name = "PbxIzquierda";
            this.PbxIzquierda.Size = new System.Drawing.Size(50, 50);
            this.PbxIzquierda.TabIndex = 5;
            this.PbxIzquierda.TabStop = false;
            this.PbxIzquierda.Click += new System.EventHandler(this.PbxIzquierda_Click);
            // 
            // PbxInferior
            // 
            this.PbxInferior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PbxInferior.BackColor = System.Drawing.Color.Transparent;
            this.PbxInferior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxInferior.BackgroundImage")));
            this.PbxInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxInferior.Location = new System.Drawing.Point(654, 533);
            this.PbxInferior.Name = "PbxInferior";
            this.PbxInferior.Size = new System.Drawing.Size(50, 50);
            this.PbxInferior.TabIndex = 7;
            this.PbxInferior.TabStop = false;
            // 
            // LnlIzquierda
            // 
            this.LnlIzquierda.AutoSize = true;
            this.LnlIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.LnlIzquierda.LinkColor = System.Drawing.Color.White;
            this.LnlIzquierda.Location = new System.Drawing.Point(39, 129);
            this.LnlIzquierda.Name = "LnlIzquierda";
            this.LnlIzquierda.Size = new System.Drawing.Size(226, 13);
            this.LnlIzquierda.TabIndex = 13;
            this.LnlIzquierda.TabStop = true;
            this.LnlIzquierda.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            this.LnlIzquierda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnlIzquierda_LinkClicked);
            // 
            // LnlDerecha
            // 
            this.LnlDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnlDerecha.AutoSize = true;
            this.LnlDerecha.BackColor = System.Drawing.Color.Transparent;
            this.LnlDerecha.LinkColor = System.Drawing.Color.GhostWhite;
            this.LnlDerecha.Location = new System.Drawing.Point(1013, 111);
            this.LnlDerecha.Name = "LnlDerecha";
            this.LnlDerecha.Size = new System.Drawing.Size(226, 13);
            this.LnlDerecha.TabIndex = 4;
            this.LnlDerecha.TabStop = true;
            this.LnlDerecha.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            // 
            // LnlInferior
            // 
            this.LnlInferior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LnlInferior.AutoSize = true;
            this.LnlInferior.BackColor = System.Drawing.Color.Transparent;
            this.LnlInferior.LinkColor = System.Drawing.Color.White;
            this.LnlInferior.Location = new System.Drawing.Point(578, 586);
            this.LnlInferior.Name = "LnlInferior";
            this.LnlInferior.Size = new System.Drawing.Size(226, 13);
            this.LnlInferior.TabIndex = 8;
            this.LnlInferior.TabStop = true;
            this.LnlInferior.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            this.LnlInferior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnlInferior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // LblFechaActual
            // 
            this.LblFechaActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFechaActual.AutoSize = true;
            this.LblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaActual.ForeColor = System.Drawing.Color.MistyRose;
            this.LblFechaActual.Location = new System.Drawing.Point(632, 321);
            this.LblFechaActual.Name = "LblFechaActual";
            this.LblFechaActual.Size = new System.Drawing.Size(72, 25);
            this.LblFechaActual.TabIndex = 10;
            this.LblFechaActual.Text = "Fecha";
            this.LblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHoraActual
            // 
            this.LblHoraActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHoraActual.AutoSize = true;
            this.LblHoraActual.BackColor = System.Drawing.Color.Transparent;
            this.LblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.14545F);
            this.LblHoraActual.ForeColor = System.Drawing.Color.MistyRose;
            this.LblHoraActual.Location = new System.Drawing.Point(518, 199);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(286, 122);
            this.LblHoraActual.TabIndex = 9;
            this.LblHoraActual.Text = "Hora";
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
            this.PnlLienzo.Location = new System.Drawing.Point(12, 162);
            this.PnlLienzo.Name = "PnlLienzo";
            this.PnlLienzo.Size = new System.Drawing.Size(1238, 488);
            this.PnlLienzo.TabIndex = 15;
            this.PnlLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlLienzo_MouseMove);
            // 
            // BtnP2Limpiar
            // 
            this.BtnP2Limpiar.Location = new System.Drawing.Point(581, 86);
            this.BtnP2Limpiar.Name = "BtnP2Limpiar";
            this.BtnP2Limpiar.Size = new System.Drawing.Size(133, 23);
            this.BtnP2Limpiar.TabIndex = 16;
            this.BtnP2Limpiar.Text = "P2 Limpiar Lienzo";
            this.BtnP2Limpiar.UseVisualStyleBackColor = true;
            this.BtnP2Limpiar.Click += new System.EventHandler(this.BtnP2Limpiar_Click);
            // 
            // BtnP3MostrarCuadrado
            // 
            this.BtnP3MostrarCuadrado.Location = new System.Drawing.Point(500, 56);
            this.BtnP3MostrarCuadrado.Name = "BtnP3MostrarCuadrado";
            this.BtnP3MostrarCuadrado.Size = new System.Drawing.Size(75, 53);
            this.BtnP3MostrarCuadrado.TabIndex = 17;
            this.BtnP3MostrarCuadrado.Text = "Mostrar Cuadrado";
            this.BtnP3MostrarCuadrado.UseVisualStyleBackColor = true;
            this.BtnP3MostrarCuadrado.Click += new System.EventHandler(this.BtnP3MostrarCuadrado_Click);
            // 
            // DlgMesaPracticas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.BtnP3MostrarCuadrado);
            this.Controls.Add(this.BtnP2Limpiar);
            this.Controls.Add(this.PnlLienzo);
            this.Controls.Add(this.BtnP2Lienzo);
            this.Controls.Add(this.LnlIzquierda);
            this.Controls.Add(this.LnlInferior);
            this.Controls.Add(this.LblFechaActual);
            this.Controls.Add(this.PbxInferior);
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.PbxDerecha);
            this.Controls.Add(this.LnlDerecha);
            this.Controls.Add(this.PbxIzquierda);
            this.DoubleBuffered = true;
            this.Name = "DlgMesaPracticas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa de Prácticas 2";
            this.TransparencyKey = System.Drawing.Color.AntiqueWhite;
            this.Load += new System.EventHandler(this.DlgMesaPracticas2_Load);
            this.Resize += new System.EventHandler(this.DlgMesaPracticas2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PbxDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIzquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInferior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmrCambioHora;
        private System.Windows.Forms.PictureBox PbxDerecha;
        private System.Windows.Forms.PictureBox PbxIzquierda;
        private System.Windows.Forms.PictureBox PbxInferior;
        private System.Windows.Forms.LinkLabel LnlIzquierda;
        private System.Windows.Forms.LinkLabel LnlDerecha;
        private System.Windows.Forms.LinkLabel LnlInferior;
        private System.Windows.Forms.Label LblFechaActual;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.Button BtnP2Lienzo;
        private System.Windows.Forms.Panel PnlLienzo;
        private System.Windows.Forms.Button BtnP2Limpiar;
        private System.Windows.Forms.Button BtnP3MostrarCuadrado;
    }
}