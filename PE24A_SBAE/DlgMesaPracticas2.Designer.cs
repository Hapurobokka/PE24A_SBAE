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
            this.LnlDerecha = new System.Windows.Forms.LinkLabel();
            this.PbxDerecha = new System.Windows.Forms.PictureBox();
            this.PnlFondoDePantalla = new System.Windows.Forms.Panel();
            this.LblFechaActual = new System.Windows.Forms.Label();
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.PbxInferior = new System.Windows.Forms.PictureBox();
            this.LnlInferior = new System.Windows.Forms.LinkLabel();
            this.PbxIzquierda = new System.Windows.Forms.PictureBox();
            this.LnlIzquierda = new System.Windows.Forms.LinkLabel();
            this.TmrCambioHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbxDerecha)).BeginInit();
            this.PnlFondoDePantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIzquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // LnlDerecha
            // 
            this.LnlDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LnlDerecha.AutoSize = true;
            this.LnlDerecha.BackColor = System.Drawing.Color.Transparent;
            this.LnlDerecha.LinkColor = System.Drawing.Color.GhostWhite;
            this.LnlDerecha.Location = new System.Drawing.Point(1011, 120);
            this.LnlDerecha.Name = "LnlDerecha";
            this.LnlDerecha.Size = new System.Drawing.Size(226, 13);
            this.LnlDerecha.TabIndex = 4;
            this.LnlDerecha.TabStop = true;
            this.LnlDerecha.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            // 
            // PbxDerecha
            // 
            this.PbxDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxDerecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxDerecha.BackgroundImage")));
            this.PbxDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxDerecha.Location = new System.Drawing.Point(1092, 67);
            this.PbxDerecha.Name = "PbxDerecha";
            this.PbxDerecha.Size = new System.Drawing.Size(50, 50);
            this.PbxDerecha.TabIndex = 2;
            this.PbxDerecha.TabStop = false;
            // 
            // PnlFondoDePantalla
            // 
            this.PnlFondoDePantalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlFondoDePantalla.BackgroundImage")));
            this.PnlFondoDePantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFondoDePantalla.Controls.Add(this.LblFechaActual);
            this.PnlFondoDePantalla.Controls.Add(this.LblHoraActual);
            this.PnlFondoDePantalla.Controls.Add(this.PbxInferior);
            this.PnlFondoDePantalla.Controls.Add(this.LnlInferior);
            this.PnlFondoDePantalla.Controls.Add(this.PbxIzquierda);
            this.PnlFondoDePantalla.Controls.Add(this.LnlIzquierda);
            this.PnlFondoDePantalla.Controls.Add(this.PbxDerecha);
            this.PnlFondoDePantalla.Controls.Add(this.LnlDerecha);
            this.PnlFondoDePantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFondoDePantalla.Location = new System.Drawing.Point(0, 0);
            this.PnlFondoDePantalla.Name = "PnlFondoDePantalla";
            this.PnlFondoDePantalla.Size = new System.Drawing.Size(1262, 676);
            this.PnlFondoDePantalla.TabIndex = 3;
            this.PnlFondoDePantalla.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFondoDePantalla_Paint);
            // 
            // LblFechaActual
            // 
            this.LblFechaActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFechaActual.AutoSize = true;
            this.LblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaActual.ForeColor = System.Drawing.Color.MistyRose;
            this.LblFechaActual.Location = new System.Drawing.Point(536, 194);
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
            this.LblHoraActual.Location = new System.Drawing.Point(478, 67);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(286, 122);
            this.LblHoraActual.TabIndex = 9;
            this.LblHoraActual.Text = "Hora";
            // 
            // PbxInferior
            // 
            this.PbxInferior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PbxInferior.BackColor = System.Drawing.Color.Transparent;
            this.PbxInferior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxInferior.BackgroundImage")));
            this.PbxInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxInferior.Location = new System.Drawing.Point(628, 575);
            this.PbxInferior.Name = "PbxInferior";
            this.PbxInferior.Size = new System.Drawing.Size(50, 50);
            this.PbxInferior.TabIndex = 7;
            this.PbxInferior.TabStop = false;
            // 
            // LnlInferior
            // 
            this.LnlInferior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LnlInferior.AutoSize = true;
            this.LnlInferior.BackColor = System.Drawing.Color.Transparent;
            this.LnlInferior.LinkColor = System.Drawing.Color.White;
            this.LnlInferior.Location = new System.Drawing.Point(538, 628);
            this.LnlInferior.Name = "LnlInferior";
            this.LnlInferior.Size = new System.Drawing.Size(226, 13);
            this.LnlInferior.TabIndex = 8;
            this.LnlInferior.TabStop = true;
            this.LnlInferior.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            this.LnlInferior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LnlInferior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // PbxIzquierda
            // 
            this.PbxIzquierda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxIzquierda.BackgroundImage")));
            this.PbxIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxIzquierda.Location = new System.Drawing.Point(124, 67);
            this.PbxIzquierda.Name = "PbxIzquierda";
            this.PbxIzquierda.Size = new System.Drawing.Size(50, 50);
            this.PbxIzquierda.TabIndex = 5;
            this.PbxIzquierda.TabStop = false;
            // 
            // LnlIzquierdo
            // 
            this.LnlIzquierda.AutoSize = true;
            this.LnlIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.LnlIzquierda.LinkColor = System.Drawing.Color.White;
            this.LnlIzquierda.Location = new System.Drawing.Point(39, 120);
            this.LnlIzquierda.Name = "LnlIzquierdo";
            this.LnlIzquierda.Size = new System.Drawing.Size(226, 13);
            this.LnlIzquierda.TabIndex = 6;
            this.LnlIzquierda.TabStop = true;
            this.LnlIzquierda.Text = "Soy publicidad de Microsoft. Por favor odiame.";
            // 
            // TmrCambioHora
            // 
            this.TmrCambioHora.Interval = 1000;
            this.TmrCambioHora.Tick += new System.EventHandler(this.TmrCambioHora_tick);
            // 
            // DlgMesaPracticas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.PnlFondoDePantalla);
            this.DoubleBuffered = true;
            this.Name = "DlgMesaPracticas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PE Mesa de Prácticas 2";
            this.Load += new System.EventHandler(this.DlgMesaPracticas2_Load);
            this.Resize += new System.EventHandler(this.DlgMesaPracticas2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PbxDerecha)).EndInit();
            this.PnlFondoDePantalla.ResumeLayout(false);
            this.PnlFondoDePantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIzquierda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnlDerecha;
        private System.Windows.Forms.PictureBox PbxDerecha;
        private System.Windows.Forms.Panel PnlFondoDePantalla;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.PictureBox PbxInferior;
        private System.Windows.Forms.LinkLabel LnlInferior;
        private System.Windows.Forms.PictureBox PbxIzquierda;
        private System.Windows.Forms.LinkLabel LnlIzquierda;
        private System.Windows.Forms.Label LblFechaActual;
        private System.Windows.Forms.Timer TmrCambioHora;
    }
}