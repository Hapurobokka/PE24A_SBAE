using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Timers;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace PE24A_SBAE
{
    // ------------------------------------------------------------------------
    // Código del menú principal del proyecto Programación Estructurada 24A
    // SBAE 29/01/2024.
    // ------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        private System.Timers.Timer timer;
        private System.Timers.Timer drawer; 
        private DataGridView DgvPreview;
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
            BtnMesaPracticas1.Location = new Point(12, this.Height - BtnMesaPracticas1.Height - 56);
            BtnMesaPracticas2.Location = new Point(52, this.Height - BtnMesaPracticas2.Height - 56);
            BtnMesaPracticas3.Location = new Point(92, this.Height - BtnMesaPracticas3.Height - 56);
            BtnMesaPracticas4.Location = new Point(132, this.Height - BtnMesaPracticas4.Height - 56);
            BtnMesaPracticas5.Location = new Point(172, this.Height - BtnMesaPracticas5.Height - 56);
            BtnMesaPracticas6.Location = new Point(212, this.Height - BtnMesaPracticas6.Height - 56);
            BtnAcercaDe.Location = new Point(this.Width - BtnAcercaDe.Width - 30, this.Height - BtnMesaPracticas6.Height - 56);
        }

        // ------------------------------------------------------------------------
        // Función principal que se encarga de reposicionar los controles de la
        // ventana.
        // ------------------------------------------------------------------------
        private void DlgPrincipal_Resize(object sender, EventArgs e)
        {
            int[] WindowCenter = { this.Width / 2, this.Height / 2 };
            ResizeButtons();
            PbxPeces.Location = new Point((WindowCenter[0] - PbxPeces.Width / 2) - 8, (WindowCenter[1] - PbxPeces.Height / 2) - 22);
            TbxPrueba.Location = new Point((WindowCenter[0] - TbxPrueba.Width / 2) - 8, this.Height - BtnMesaPracticas1.Height - TbxPrueba.Height * 2);
            PnlPreview.Location = new Point((this.Width /  2 - PnlPreview.Width / 2) - 8, (this.Height / 2 - PnlPreview.Height / 2) - 70);
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
            timer.Interval = 30;
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
                    this.BackColor = Color.FromArgb(Convert.ToInt32(69 - count * 2.5), Convert.ToInt32(97 - count * 3.5), Convert.ToInt32(147 - count * 5.2));
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
            MiniDlg1(
                "Genera tablas de un tamaño n * n. Suma todos sus números pares, impares, diagonales y repetidos adyacentes"
            );
        }

        private void BtnMesaPracticas1_MouseLeave(object sender, EventArgs e)
        {
            ResetTimer();
            DgvPreview.Visible = false;
            PnlPreview.Visible = false;
            TbxPrueba.Visible = false;
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
            drawer = new System.Timers.Timer();
            drawer.Interval = 1000;
            drawer.Elapsed += DrawFigure;
            drawer.AutoReset = true;
            drawer.Enabled = true;
            MiniDlg2(
                "Imitación del menú de inicio de sesión de Windows 11. Dispone de un lienzo para dibujar con figuras generadas de manera procedural"
            );
        }

        private void BtnMesaPracticas2_MouseLeave(object sender, EventArgs e)
        {
            if (drawer != null)
            {
                drawer.Stop();
                drawer.Dispose();
            }
            PnlPreview.Visible = false;
            TbxPrueba.Visible = false;
            ResetTimer();
            ResetWindow();  
        }

        // ------------------------------------------------------------------------
        // Botón para activar Mesa de Prácticas 3
        // ------------------------------------------------------------------------
        private void BtnMesaPracticas3_MouseHover(object sender, EventArgs e)
        {
            EstablishTimer();
            DisplayDlgContent("No implementado", "images\\noimplementado.jpg");
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
            DisplayDlgContent("No implementado", "images\\noimplementado.jpg");
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
            DisplayDlgContent("No implementado", "images\\noimplementado.jpg");
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
            DisplayDlgContent("No implementado", "images\\noimplementado.jpg");
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
            MessageBox.Show("Programado por:" +
                            "\nAlan Engelberto Sánchez Becerra. " +
                            "\n\nPara la clase de Programación Estructurada" +
                            "\nSemestre A. 2024.");
        }

        // ------------------------------------------------------------------------
        //  ???     
        // ------------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void MiniDlg1(string description)
        {
            Func<int, int> scale43 = x => x + (x / 3);
            Random rnd = new Random(); 
            DgvPreview = new DataGridView();
            TbxPrueba.Visible = true;
            PbxPeces.Visible = false;
            PnlPreview.Visible = true;
            TbxPrueba.Text = description;
            PnlPreview.Controls.Add(DgvPreview);
            DgvPreview.Dock = DockStyle.Fill;
            DgvPreview.RowTemplate.Height = PnlPreview.Height / 5;
            DgvPreview.Name = "Preview";
            DgvPreview.TabIndex = 0;

            PnlPreview.Size = new System.Drawing.Size(scale43(Convert.ToInt32(this.Height * 0.7)), Convert.ToInt32(this.Height * 0.7));
            PnlPreview.Location = new System.Drawing.Point((this.Width /  2 - PnlPreview.Width / 2) - 8, (this.Height / 2 - PnlPreview.Height / 2) - 70);

            for (int i = 0; i < 10; i++)
            {
                DgvPreview.Columns.Add($"C{i}", $"C{i+1}");
                DgvPreview.Columns[i].Width = (PnlPreview.Width / 5) + 4;
                DgvPreview.Rows.Add();
            }

            for (int i = 0; i < DgvPreview.ColumnCount; i++)
            {
                for (int j = 0; j < DgvPreview.ColumnCount; j++)
                {
                    DgvPreview.Rows[i].Cells[j].Value = $"{rnd.Next(0, 9)}";
                }
            }
            
            for (int i = 0; i < DgvPreview.RowCount - 1; i++)
            {
                for (int j = 0; j < DgvPreview.RowCount - 1; j++)
                {
                    if (int.TryParse(DgvPreview.Rows[i].Cells[j].Value.ToString(), out int value))
                    {
                        if (value % 2 == 0)
                            DgvPreview.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        else
                            DgvPreview.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;

                        if ((j - 1 >= 0) && (value == int.Parse(DgvPreview.Rows[i].Cells[j - 1].Value.ToString())))
                        {
                            DgvPreview.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            DgvPreview.Rows[i].Cells[j - 1].Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void MiniDlg2(string description)
        {
            Func<int, int> scale43 = x => x + (x / 3);
            PnlPreview.Size = new System.Drawing.Size(scale43(Convert.ToInt32(this.Height * 0.7)), Convert.ToInt32(this.Height * 0.7));
            PnlPreview.Location = new System.Drawing.Point((this.Width /  2 - PnlPreview.Width / 2) - 8, (this.Height / 2 - PnlPreview.Height / 2) - 70);
            TbxPrueba.Text = description;

            TbxPrueba.Visible = true;
            PbxPeces.Visible = false;
            PnlPreview.Visible = true;
        }

        private void DrawFigure(Object source, ElapsedEventArgs e)
        {
            Random rnd = new Random(); 
            Color Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pen Pluma = new Pen(Color, rnd.Next(1, 11));
            Graphics Graficos = PnlPreview.CreateGraphics();
            int random1 = rnd.Next(1, 100);
            int random2 = rnd.Next(1, 100);
            int randomX = rnd.Next(PnlPreview.Width);
            int randomY = rnd.Next(PnlPreview.Height);

            switch (rnd.Next(1, 4)) {
                case 1:
                    Graficos.DrawRectangle(Pluma, randomX, randomY, random1, random2);
                    break;
                case 2:
                    Graficos.DrawLine(Pluma, randomX, randomY, rnd.Next(randomX), rnd.Next(randomY));
                    break;
                case 3:
                    Graficos.DrawEllipse(Pluma, randomX, randomY, random1, random2);
                    break;
            }
        }
    }
}
