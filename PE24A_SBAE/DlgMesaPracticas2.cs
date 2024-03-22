using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_SBAE
{
    //  ----------------------------------------------------------------------- 
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // SBAE. 28/02/2024.
    // ------------------------------------------------------------------------ 
    public partial class DlgMesaPracticas2 : Form
    {
        int NumRectangles = 0;
        // ------------------------------------------------------------------------ 
        // Constructor
        //
        // ------------------------------------------------------------------------ 
        public DlgMesaPracticas2()
        {
            InitializeComponent();

            // ------------------------------------------------------------------------ 
            // Inicialización de la hora y la fecha actual
            //
            // ------------------------------------------------------------------------ 
            PnlLienzo.Visible = false;
            LblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
            LblFechaActual.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            
            // ------------------------------------------------------------------------ 
            // Acomodar los componentes de la ventana a sus lugares apropiados
            //
            // ------------------------------------------------------------------------ 
            DlgMesaPracticas2_Resize(null, null);

        }

        private void DlgMesaPracticas2_Load(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------ 
            // Permitimos que nuestro objeto TmrCambioHora comience a trabajar
            //
            // ------------------------------------------------------------------------ 
            TmrCambioHora.Enabled = true;
        }

        // --------------------------------------------------------------------
        // Cambiar la posición de los componentes al cambiar el tamaño de la
        // ventana
        // SBAE
        // --------------------------------------------------------------------
        private void DlgMesaPracticas2_Resize(object sender, EventArgs e)
        {
            // --------------------------------------------------------------------
            // Obtenemos el punto medio de la resolución actual de la pantalla,
            // tanto del largo como del ancho
            // --------------------------------------------------------------------
            int[] WindowCenter = { this.Width / 2, this.Height / 2 };

            // --------------------------------------------------------------------
            // Obtenemos el valor necesario para centrar el componente en el eje X
            // restando la posición central de la pantalla a su longitud entre 2
            // --------------------------------------------------------------------
            int XLblHoraActual = WindowCenter[0] - LblHoraActual.Width / 2;
            int XLblFechaActual = WindowCenter[0] - LblFechaActual.Width / 2;
            int XLnlInferior = WindowCenter[0] - LnlInferior.Width / 2;
            int XPbxInferior = WindowCenter[0] - PbxInferior.Width / 2;

            // --------------------------------------------------------------------
            // Para los componentes que van en las esquinas superiores, el proceso
            // es diferente, porque los queremos en otra parte que no es el centro
            // de la pantalla.
            // Lo que haremos sera restarle a la resolución de la pantalla el valor
            // del centro de la pantalla dividido entre 3 y tambien la longitud del
            // componente dividida entre 2.
            // --------------------------------------------------------------------
            int XLnlDerecha = this.Width - WindowCenter[0] / 3 - LnlDerecha.Width / 2;
            int XPbxDerecha = this.Width - WindowCenter[0] / 3 - PbxDerecha.Width / 2;

            // --------------------------------------------------------------------
            // No es necesario realizar los calculos para los componentes en la
            // izquierda, pues su posición en realidad no es alterada cuando
            // se cambia la resolución, pero así queda mas consistente con
            // los cambios que realizamos a la derecha. La unica diferencia es que
            // la resolución del largo no entra a la formula.
            // --------------------------------------------------------------------
            int XLnlIzquierda = WindowCenter[0] / 3 - LnlIzquierda.Width / 2;
            int XPbxIzquierda = WindowCenter[0] / 3 - PbxIzquierda.Width / 2;

            // --------------------------------------------------------------------
            // Para obtener los valores del eje Y del reloj y la fecha, solo
            // haremos la misma operación que para el eje X, solo cambiando
            // el centro desde el cual realizamos la operación.
            // --------------------------------------------------------------------
            int YLblHoraActual = WindowCenter[1] + 80 - LblHoraActual.Width / 2;
            // Sumamos 80, solo para que quede exactamente abajo de la hora.
            int YLblFechaActual = WindowCenter[1] + 100 - LblFechaActual.Width / 2;

            // --------------------------------------------------------------------
            // Para el resto es bastante simple. Para los componentes inferiores
            // restamos la posición de la resolución total para que se queden ahí
            // abajo, y para los superiores el valor no necesita ser alterado.
            // --------------------------------------------------------------------
            int YLnlInferior = this.Height - 85;
            int YPbxInferior = this.Height - 150;
            int YLnlIzquierda = 110;
            int YPbxIzquierda = 50;
            int YLnlDerecha = 110;
            int YPbxDerecha = 50;

            // --------------------------------------------------------------------
            // Ejecutamos todos los cambios a los componentes
            // --------------------------------------------------------------------
            LblHoraActual.Location = new System.Drawing.Point(XLblHoraActual, YLblHoraActual);
            LblFechaActual.Location = new System.Drawing.Point(XLblFechaActual, YLblFechaActual);

            LnlInferior.Location = new System.Drawing.Point(XLnlInferior, YLnlInferior);
            PbxInferior.Location = new System.Drawing.Point(XPbxInferior, YPbxInferior);

            LnlIzquierda.Location = new System.Drawing.Point(XLnlIzquierda, YLnlIzquierda);
            PbxIzquierda.Location = new System.Drawing.Point(XPbxIzquierda, YPbxIzquierda);

            LnlDerecha.Location = new System.Drawing.Point(XLnlDerecha, YLnlDerecha);
            PbxDerecha.Location = new System.Drawing.Point(XPbxDerecha, YPbxDerecha);

            BtnP2Lienzo.Location = new System.Drawing.Point(WindowCenter[0] - 9 - BtnP2Lienzo.Width / 2, 40);
            BtnP2Limpiar.Location = new System.Drawing.Point(WindowCenter[0] - 9 - BtnP2Limpiar.Width / 2, 70);
            BtnP3MostrarCuadrado.Location = new System.Drawing.Point(WindowCenter[0] - 70 - BtnP2Limpiar.Width / 2, 40);

        }

        // --------------------------------------------------------------------
        // Actualizar la fecha y la hora con cada tick (1000 ms) del contador
        //
        // --------------------------------------------------------------------
        private void TmrCambioHora_tick(object sender, EventArgs e)
        {
            LblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
            LblFechaActual.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void PnlFondoDePantalla_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PbxIzquierda_Click(object sender, EventArgs e)
        {

        }

        private void LnlIzquierda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        // --------------------------------------------------------------------
        // Activa la practica 2
        // --------------------------------------------------------------------
        private void BtnP2Lienzo_Click(object sender, EventArgs e)
        {
            PnlLienzo.Visible = !PnlLienzo.Visible;
            NumRectangles = 0;
            LnlIzquierda.Text = $"Rectangulos = {NumRectangles}";
        }
        
        private void BtnP2Limpiar_Click(object sender, EventArgs e)
        {

        }

        // --------------------------------------------------------------------
        // Al moverse sobre el lienzo
        // --------------------------------------------------------------------
        private void PnlLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            //LnlDerecha.Text = $"X = {e.X}, Y = {e.Y}";
            //DrawRectangle(e.X, e.Y);
            GenerateSquares(e.X, e.Y, 20);
        }

        // --------------------------------------------------------------------
        // Dibuja un rectangujo en la coordenada x, y.
        // --------------------------------------------------------------------
        private void DrawRectangle(int X, int Y)
        {
            Random rnd = new Random();
            Color Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pen Pluma = new Pen(Color, rnd.Next(1, 100));
            int x = X;
            int y = Y;
            int Ancho = 10;
            int Alto = 10;
            Graphics Graficos = PnlLienzo.CreateGraphics();
            Graficos.DrawRectangle(Pluma, x, y, Ancho, Alto);
            //Graficos.DrawEllipse(Pluma, x, y, Ancho, Alto);
            NumRectangles = 0;
            LnlIzquierda.Text = $"Rectangulos = {NumRectangles}";
        }

        // --------------------------------------------------------------------
        // Dibuja un cuadrado en la coordenada x, y.
        // --------------------------------------------------------------------
        private void DrawSquare(int x, int y, int side)
        {
            Random rnd = new Random();
            Color Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pen Pluma = new Pen(Color, 1);

            Graphics Graficos = PnlLienzo.CreateGraphics();
            //Graficos.DrawRectangle(Pluma, x, y, Ancho, Alto);
            //Pluma.Color = Color.Blue;
            //Graficos.DrawLine(Pluma, x, y, x+side, y);
            //Pluma.Color = Color.Red;
            //Graficos.DrawLine(Pluma, x+side, y, x+side, y+side);
            //Pluma.Color = Color.Yellow;
            //Graficos.DrawLine(Pluma, x+side, y+side, x, y+side);
            //Pluma.Color = Color.Green;
            //Graficos.DrawLine(Pluma, x, y+side, x, y);
            Graficos.DrawRectangle(Pluma, x, y, side, side);

            NumRectangles = 0;
            LnlIzquierda.Text = $"Rectangulos = {NumRectangles}";
        }

        private void GenerateSquares(int x, int y, int side)
        {
            int NumCuadrados = 0;
            while (NumCuadrados < 300)
            {
                int factor1 = (NumCuadrados * 5) - 10;
                DrawSquare(x - factor1/2, y - factor1/2, side + factor1);
                NumCuadrados++;
            }
        }

        private void BtnP3MostrarCuadrado_Click(object sender, EventArgs e)
        {
            GenerateSquares(PnlLienzo.Width / 2, PnlLienzo.Height / 2, 20);
        }
    }
}
