using System;
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
    // ------------------------------------------------------------------------
    // Constructor
    //
    // ------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    // ------------------------------------------------------------------------
    // Botón de pruebas de Hola Mundo
    //
    // ------------------------------------------------------------------------
        private void BtnHolaMundo_Click(object sender, EventArgs e)
        {
            string Mensaje = "";

            if (CbxSaludar.Checked)
                Mensaje = "Buenas días. ";

            MessageBox.Show("Hola. " + Mensaje + "Mi nombre es Cosme Fulanito.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

    // ------------------------------------------------------------------------
    // Botón para activar Mesa de Prácticas 1
    //
    // ------------------------------------------------------------------------
        private void BtnMesaPracticas1_Click(object sender, EventArgs e)
        {
            DlgMesaPracticas1 DlgMesaPracticas1;
                
            DlgMesaPracticas1 = new DlgMesaPracticas1();
            DlgMesaPracticas1.Show();
        }
    }
}
