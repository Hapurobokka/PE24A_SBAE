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
        public DlgMesaPracticas1()
        {
            InitializeComponent();
        }

        private void PnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TbxCaptura1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxCaptura2_TextChanged(object sender, EventArgs e)
        {

        }

        // --------------------------------------------------------------------
        // Botón de pruebas de la Mesa de Trabajo 1
        //
        // --------------------------------------------------------------------
        private void BtnPruebas_Click(object sender, EventArgs e)
        {
            int Sumando1;
            int Sumando2;
            bool IsNumber1;
            bool IsNumber2;

            IsNumber1 = int.TryParse(TbxCaptura1.Text, out Sumando1);
            IsNumber2 = int.TryParse(TbxCaptura2.Text, out Sumando2);

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

        private void DgvTabla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // --------------------------------------------------------------------
        // Muestra la tabla de la práctica 1
        //
        // --------------------------------------------------------------------
        private void BtnP1Muestra_Click(object sender, EventArgs e)
        {
            DgvTabla1.Visible = !DgvTabla1.Visible;
        }

        // --------------------------------------------------------------------
        // Llena la tabla de la práctica 1
        //
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
    } 
}
