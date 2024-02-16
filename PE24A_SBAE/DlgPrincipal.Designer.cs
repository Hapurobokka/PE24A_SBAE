namespace PE24A_SBAE
{
    partial class DlgPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnHolaMundo = new System.Windows.Forms.Button();
            this.CbxSaludar = new System.Windows.Forms.CheckBox();
            this.BtnMesaPracticas1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHolaMundo
            // 
            this.BtnHolaMundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHolaMundo.Location = new System.Drawing.Point(25, 22);
            this.BtnHolaMundo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHolaMundo.Name = "BtnHolaMundo";
            this.BtnHolaMundo.Size = new System.Drawing.Size(185, 86);
            this.BtnHolaMundo.TabIndex = 0;
            this.BtnHolaMundo.Text = "Hola Mundo";
            this.BtnHolaMundo.UseVisualStyleBackColor = true;
            this.BtnHolaMundo.Click += new System.EventHandler(this.BtnHolaMundo_Click);
            // 
            // CbxSaludar
            // 
            this.CbxSaludar.AutoSize = true;
            this.CbxSaludar.Location = new System.Drawing.Point(32, 122);
            this.CbxSaludar.Margin = new System.Windows.Forms.Padding(2);
            this.CbxSaludar.Name = "CbxSaludar";
            this.CbxSaludar.Size = new System.Drawing.Size(109, 17);
            this.CbxSaludar.TabIndex = 1;
            this.CbxSaludar.Text = "Saludos terricolas";
            this.CbxSaludar.UseVisualStyleBackColor = true;
            this.CbxSaludar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BtnMesaPracticas1
            // 
            this.BtnMesaPracticas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMesaPracticas1.Location = new System.Drawing.Point(226, 22);
            this.BtnMesaPracticas1.Name = "BtnMesaPracticas1";
            this.BtnMesaPracticas1.Size = new System.Drawing.Size(155, 86);
            this.BtnMesaPracticas1.TabIndex = 2;
            this.BtnMesaPracticas1.Text = "Mesa de Prácticas 1";
            this.BtnMesaPracticas1.UseVisualStyleBackColor = true;
            this.BtnMesaPracticas1.Click += new System.EventHandler(this.BtnMesaPracticas1_Click);
            // 
            // DlgPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 421);
            this.Controls.Add(this.BtnMesaPracticas1);
            this.Controls.Add(this.CbxSaludar);
            this.Controls.Add(this.BtnHolaMundo);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DlgPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programación Estructurada 24A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHolaMundo;
        private System.Windows.Forms.CheckBox CbxSaludar;
        private System.Windows.Forms.Button BtnMesaPracticas1;
    }
}

