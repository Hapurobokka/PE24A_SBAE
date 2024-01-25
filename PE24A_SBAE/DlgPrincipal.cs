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
    public partial class DlgPrincipal : Form
    {
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnHolaMundo_Click(object sender, EventArgs e)
        {
            string Mensaje = "";

            if (CbxSaludar.Checked)
                Mensaje = "Buenas tardes. ";

            MessageBox.Show("Hola. " + Mensaje + "Mi nombre es Cosme Fulanito.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
