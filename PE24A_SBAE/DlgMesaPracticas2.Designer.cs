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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFondoDePantalla = new System.Windows.Forms.Panel();
            this.LblFechaActual = new System.Windows.Forms.Label();
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LnlInferior = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.TmrCambioHora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlFondoDePantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1092, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFondoDePantalla
            // 
            this.PnlFondoDePantalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlFondoDePantalla.BackgroundImage")));
            this.PnlFondoDePantalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFondoDePantalla.Controls.Add(this.LblFechaActual);
            this.PnlFondoDePantalla.Controls.Add(this.LblHoraActual);
            this.PnlFondoDePantalla.Controls.Add(this.pictureBox3);
            this.PnlFondoDePantalla.Controls.Add(this.LnlInferior);
            this.PnlFondoDePantalla.Controls.Add(this.pictureBox2);
            this.PnlFondoDePantalla.Controls.Add(this.linkLabel2);
            this.PnlFondoDePantalla.Controls.Add(this.pictureBox1);
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(628, 575);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(124, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(39, 120);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(226, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Soy publicidad de Microsoft. Por favor odiame.";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlFondoDePantalla.ResumeLayout(false);
            this.PnlFondoDePantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnlDerecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlFondoDePantalla;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel LnlInferior;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label LblFechaActual;
        private System.Windows.Forms.Timer TmrCambioHora;
    }
}