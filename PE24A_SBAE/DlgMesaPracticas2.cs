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
    public partial class DlgMesaPracticas2 : Form
    {
        public DlgMesaPracticas2()
        {
            // Atributos
            InitializeComponent();

            // Fecha
            LblHoraActual.Text = DateTime.Now.ToString("HH:mm");
            LblFechaActual.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            
            DlgMesaPracticas2_Resize(null, null);
        }

        private void DlgMesaPracticas2_Load(object sender, EventArgs e)
        {
            TmrCambioHora.Enabled = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
        // --------------------------------------------------------------------
        // Mira bro cambia el tamaño de los componentes de la ventana
        //
        // --------------------------------------------------------------------
        private void DlgMesaPracticas2_Resize(object sender, EventArgs e)
        {
            //LnlInferior.Location = new System.Drawing.Point(this.Width - (int)(this.Width * 0.63), this.Height - 100);
        }

        private void TmrCambioHora_tick(object sender, EventArgs e)
        {
            LblHoraActual.Text = DateTime.Now.ToString("HH:mm");
            LblFechaActual.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void PnlFondoDePantalla_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
