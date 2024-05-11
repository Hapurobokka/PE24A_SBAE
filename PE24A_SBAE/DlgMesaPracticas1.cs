using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_SBAE
{
    // ------------------------------------------------------------------------
    // Código de la mesa de practicas 1 del proyecto Programación Estructurada 24A
    // SBAE 31/01/2024.
    // ------------------------------------------------------------------------
    public partial class DlgMesaPracticas1 : Form
    {
        DataGridView DgvTabla2;
        System.Timers.Timer Timer;

        public DlgMesaPracticas1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Timer = new System.Timers.Timer(3000);
            Timer.Elapsed += new System.Timers.ElapsedEventHandler(EventoTimer);
            Timer.AutoReset = true;
        }

        public void EventoTimer(object source, System.Timers.ElapsedEventArgs e)
        {
            BtnP2Calcular_Click(null, null);
            BtnP2Diagonal_Click(null, null);
        }

        // --------------------------------------------------------------------
        // Botón de pruebas de la Mesa de Trabajo 1
        // --------------------------------------------------------------------
        private void BtnPruebas_Click(object sender, EventArgs e)
        {
            bool IsNumber1 = int.TryParse(TbxCaptura1.Text, out int Sumando1);
            bool IsNumber2 = int.TryParse(TbxCaptura2.Text, out int Sumando2);

            if (!IsNumber1)
            {
                MessageBox.Show("Debe capturar un número en la primer caja");
                TbxCaptura1.Focus();
                return;
            }
            if (!IsNumber2)
            {
                MessageBox.Show("Debe capturar un número en la segunda caja");
                TbxCaptura2.Focus();
                return;
            }

            MessageBox.Show($"La suma es {Sumando1 + Sumando2}");
        }

        // --------------------------------------------------------------------
        // Muestra la tabla de la práctica 1
        // --------------------------------------------------------------------
        private void BtnP1Muestra_Click(object sender, EventArgs e)
        {
            DgvTabla1.Visible = !DgvTabla1.Visible;
        }

        // --------------------------------------------------------------------
        // Llena la tabla de la práctica 1
        // --------------------------------------------------------------------
        private void BtnP1Llena_Click(object sender, EventArgs e)
        {
            int row = 0;
            DgvTabla1.Rows.Clear();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        DgvTabla1.Rows.Add();
                        DgvTabla1.Rows[row].Cells[0].Value = $"{x}";
                        DgvTabla1.Rows[row].Cells[1].Value = $"{y}";
                        DgvTabla1.Rows[row].Cells[2].Value = $"{z}";
                        row++;
                    }
                }
            }
        }

        // --------------------------------------------------------------------
        // Activa la práctica 2
        // --------------------------------------------------------------------
        private void BtnP2Activar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Validaciones iniciales

            bool IsNumber = int.TryParse(TbxCaptura1.Text, out int NumCols);

            if (!IsNumber)
            {
                MessageBox.Show("Debe capturar un número de columnas.");
                TbxCaptura1.Focus();
                return;
            }

            // Construye la tabla de la practica 2 (en tiempo de ejecución)

            DgvTabla2 = new System.Windows.Forms.DataGridView();
            PnlCentral.Controls.Add(DgvTabla2);

            // Configura propiedades de la tabla

            DgvTabla2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTabla2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DgvTabla2.Dock = DockStyle.Fill;
            DgvTabla2.Name = "DgvTabla2";
            DgvTabla2.RowHeadersWidth = 30;
            DgvTabla2.RowTemplate.Height = 28;
            DgvTabla2.TabIndex = 0;
            DgvTabla1.Visible = false;
            DgvTabla1.SendToBack();

            // Se agregan las columnas deseadas

            for (int i = 0; i < NumCols; i++)
            {
                DgvTabla2.Columns.Add($"C{i}", $"C{i+1}");
                DgvTabla2.Rows.Add();
            }

            // Se agregan los renglones (matriz cuadrada)

            RefillMatrix();
        }

        // ------------------------------------------------------------------------------------
        // Calcula la practica 2 
        //  - suma de todos los numeros aleatorios de la matriz
        //  - suma de los numeros pares
        // ------------------------------------------------------------------------------------
        private void BtnP2Calcular_Click(object sender, EventArgs e)
        {
            int NumRows = DgvTabla2.RowCount - 1;
            int TotalParSum = 0;
            int TotalImparSum = 0;
            int RedAmount = 0;
            int value = 0;

            RefillMatrix();

            // Este bucle procesa la información de la tabla ya sabes
            for (int i = 0; i < NumRows; i++) 
            { 
                for (int j = 0; j < NumRows; j++)
                {
                    // Acumula el valor actual de la celda
                    if (int.TryParse(DgvTabla2.Rows[i].Cells[j].Value.ToString(), out value))
                    {

                        // Verifica si el numero es par o impar, y lo almacena en la variable correcta
                        if (value % 2 == 0)
                        {
                            TotalParSum += value;
                            DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            TotalImparSum += value;
                            DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                        }

                        if ((j - 1 >= 0) && (value == int.Parse(DgvTabla2.Rows[i].Cells[j - 1].Value.ToString())))
                        {
                            if (DgvTabla2.Rows[i].Cells[j - 1].Style.BackColor == Color.Red)
                            {
                                RedAmount--;
                            }

                            DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            DgvTabla2.Rows[i].Cells[j - 1].Style.BackColor = Color.Red;
                            RedAmount++;
                        }
                    }
                }

            }

            // Muestra los resultados y los colorea

            TbxSalida1.Text = $"{TotalImparSum + TotalParSum}";
            TbxSalida2.Text = $"{TotalParSum}";
            TbxSalida3.Text = $"{TotalImparSum}";
            TbxSalida6.Text = $"{RedAmount}";

            TbxSalida2.BackColor = Color.Yellow;
            TbxSalida3.BackColor = Color.LightGreen;
            TbxSalida6.BackColor = Color.Red;
        }
        
        //------------------------------------------------------------------------
        // Lo que dice el nombre de la función
        // Rellena una matriz con nuevos números aleatorios 
        //------------------------------------------------------------------------
        private void RefillMatrix()
        {
            Random rnd = new Random();
            int NumCols = DgvTabla2.ColumnCount;

            for (int i = 0; i < NumCols; i++)
            {
                for (int j = 0; j < NumCols; j++)
                {
                    DgvTabla2.Rows[i].Cells[j].Value = $"{rnd.Next(0, 10)}";
                }
            }
        }

        private void BtnP2Diagonal_Click(object sender, EventArgs e)
        {
            int NumRows = DgvTabla2.RowCount - 1;
            int DiagSum = 0;
            int InvDiagSum = 0;

            for (int i = 0; i < NumRows; i++)
            {
                for (int j = 0; j < NumRows; j++)
                {
                    if (i == j)
                    {
                        DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                        DiagSum += int.Parse(DgvTabla2.Rows[i].Cells[j].Value.ToString());
                        DgvTabla2.Rows[i].Cells[NumRows - j - 1].Style.BackColor = Color.Magenta;
                        InvDiagSum += int.Parse(DgvTabla2.Rows[i].Cells[NumRows - j - 1].Value.ToString());
                    }
                }
            }

            TbxSalida4.Text = $"{DiagSum}";
            TbxSalida4.BackColor = Color.Blue;
            TbxSalida5.Text = $"{InvDiagSum}";
            TbxSalida5.BackColor = Color.Magenta;
        }

        private void DlgMesaPracticas1_Load(object sender, EventArgs e)
        {
            DgvTabla1.Visible = false;
            DgvTabla1.SendToBack();
        }

        private void BtnP2Temporizador_Click(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
            if (Timer.Enabled)
            {
                BtnP2Temporizador.BackColor = Color.Green;
            }
            else
            {
                BtnP2Temporizador.BackColor = Color.Red;
            }
        }
    } 
}
