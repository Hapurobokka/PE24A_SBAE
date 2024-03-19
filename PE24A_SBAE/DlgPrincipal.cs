using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Timers;



//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_SBAE
{
    // ------------------------------------------------------------------------
    // Código del menú principal del proyecto Programación Estructurada 24A
    // SBAE 29/01/2024.
    // ------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        private System.Timers.Timer timer;
        private int count = 0;

        // ------------------------------------------------------------------------
        // Constructor
        // ------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            DlgPrincipal_Resize(null, null);
            TbxPrueba.SelectionAlignment = HorizontalAlignment.Center;

        }

        // ------------------------------------------------------------------------
        // Reposiciona los botones dependiendo del tamaño de la ventana        
        // ------------------------------------------------------------------------

        private void ResizeButtons()
        {
            BtnMesaPracticas1.Location = new System.Drawing.Point(12, this.Height - BtnMesaPracticas1.Height - 56);
            BtnMesaPracticas2.Location = new System.Drawing.Point(52, this.Height - BtnMesaPracticas2.Height - 56);
            BtnMesaPracticas3.Location = new System.Drawing.Point(92, this.Height - BtnMesaPracticas3.Height - 56);
            BtnMesaPracticas4.Location = new System.Drawing.Point(132, this.Height - BtnMesaPracticas4.Height - 56);
            BtnMesaPracticas5.Location = new System.Drawing.Point(172, this.Height - BtnMesaPracticas5.Height - 56);
            BtnMesaPracticas6.Location = new System.Drawing.Point(212, this.Height - BtnMesaPracticas6.Height - 56);
            BtnAcercaDe.Location = new System.Drawing.Point(this.Width - BtnAcercaDe.Width - 30, this.Height - BtnMesaPracticas6.Height - 56);
        }

        // ------------------------------------------------------------------------
        // Función principal que se encarga de reposicionar los controles de la
        // ventana.
        // ------------------------------------------------------------------------
        private void DlgPrincipal_Resize(object sender, EventArgs e)
        {
            int[] WindowCenter = { this.Width / 2, this.Height / 2 };
            ResizeButtons();
            PbxPeces.Location = new System.Drawing.Point((WindowCenter[0] - PbxPeces.Width / 2) - 8, (WindowCenter[1] - PbxPeces.Height / 2) - 22);
            TbxPrueba.Location = new System.Drawing.Point((WindowCenter[0] - TbxPrueba.Width / 2) - 8, this.Height - BtnMesaPracticas1.Height - TbxPrueba.Height * 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ------------------------------------------------------------------------
        // Muestra una imagen y descripción de una ventana.         
        // ------------------------------------------------------------------------
        private void DisplayDlgContent(string description, string imageFile)
        {
            Func<int, int> scale169 = x => x + ((x / 9) * 7);

            TbxPrueba.Visible = true;
            PbxPeces.Visible = false;
            PbxPreview.Visible = true;

            TbxPrueba.Text = description;

            PbxPreview.Size = new System.Drawing.Size(scale169(Convert.ToInt32(this.Height * 0.7)), Convert.ToInt32(this.Height * 0.7));
            PbxPreview.Location = new System.Drawing.Point((this.Width /  2 - PbxPreview.Width / 2) - 8, (this.Height / 2 - PbxPreview.Height / 2) - 70);
            PbxPreview.BackgroundImageLayout = ImageLayout.Stretch;
            PbxPreview.BackgroundImage = System.Drawing.Image.FromFile(imageFile);
        }

        // ------------------------------------------------------------------------
        //  Establece un timer que se encargara de cambiar el color del fondo de 
        //  la ventana.
        // ------------------------------------------------------------------------
        private void EstablishTimer()
        {
            count = 0;
            timer = new System.Timers.Timer();
            timer.Interval = 5;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        // ------------------------------------------------------------------------
        //  Detiene el timer, libera los recursos que usaba y devuelve el color de 
        //  la ventana a la normalidad.
        // ------------------------------------------------------------------------
        private void ResetTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
            this.BackColor = Color.FromArgb(69, 97, 147);
        }

        // ------------------------------------------------------------------------
        // Reinicia los contenidos de los elementos de la ventana        
        // ------------------------------------------------------------------------
        private void ResetWindow()
        {
            PbxPreview.Visible = false;
            TbxPrueba.Visible = false;
            PbxPreview.Image = null;
            PbxPeces.Visible = true;
            TbxPrueba.Text = " ";
        }


        // ------------------------------------------------------------------------
        // Cambia de manera asincrona el color de la ventana
        // ------------------------------------------------------------------------
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (count < 10)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    this.BackColor = Color.FromArgb(69 - count * 2, 25 - count * 2, 147 - count * 2);
                });
                count++;
            }
            else
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 1
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas1_Click(object sender, EventArgs e)
        {
            DlgMesaPracticas1 DlgMesaPracticas1;
                
            DlgMesaPracticas1 = new DlgMesaPracticas1();
            DlgMesaPracticas1.Show();
        }

        private void BtnMesaPracticas1_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("Genera tablas de un tamaño n * n. Suma todos sus números pares, impares, diagonales y repetidos adyacentes.", "images\\dlg1captura.png");
        }

        private void BtnMesaPracticas1_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();  
        }

        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 2
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas2_Click(object sender, EventArgs e)
        {
            DlgMesaPracticas2 DlgMesaPracticas2;
                
            DlgMesaPracticas2 = new DlgMesaPracticas2();
            DlgMesaPracticas2.Show();
        }
        private void BtnMesaPracticas2_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("Imitación del menú de inicio de sesión de Windows 11. Dispone de un lienzo para dibujar con figuras generadas de manera procedural.", "images\\dlg2captura.png");
        }

        private void BtnMesaPracticas2_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();  
        }

        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 3
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas3_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("No implementado.", "images\\noimplementado.jpg");
        }

        private void BtnMesaPracticas3_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();  
        }


        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 4
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas4_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("No implementado.", "images\\noimplementado.jpg");
        }

        private void BtnMesaPracticas4_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();  
        }

        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 5
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas5_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("No implementado.", "images\\noimplementado.jpg");
        }

        private void BtnMesaPracticas5_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();  
        }
        
        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 6
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas6_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("No implementado.", "images\\noimplementado.jpg");
        }

        private void BtnMesaPracticas6_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            ResetWindow();
        }

        // ------------------------------------------------------------------------
        // Botón para activar Acerca De       
        // ------------------------------------------------------------------------
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            PbxPeces.Visible = !PbxPeces.Visible;
        }

        // ------------------------------------------------------------------------
        //  ???     
        // ------------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
