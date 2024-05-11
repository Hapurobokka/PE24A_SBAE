using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
namespace PE24A_SBAE
{
    //  ----------------------------------------------------------------------- 
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // SBAE. 06/04/2024.
    // ------------------------------------------------------------------------ 
    public partial class DlgMesaPracticas3 : Form
    {
        // ------------------------------------------------------------------------ 
        // Constructor
        //
        // ------------------------------------------------------------------------ 
        public DlgMesaPracticas3()
        {
            InitializeComponent();

            // ------------------------------------------------------------------------ 
            // Inicialización de la hora y la fecha actual
            //
            // ------------------------------------------------------------------------ 
            PnlLienzo.Visible = false;
            
            // ------------------------------------------------------------------------ 
            // Acomodar los componentes de la ventana a sus lugares apropiados
            //
            // ------------------------------------------------------------------------ 
            DlgMesaPracticas2_Resize(null, null);

        }

        private void DlgMesaPracticas2_Load(object sender, EventArgs e)
        {
        }

        // --------------------------------------------------------------------
        // Cambiar la posición de los componentes al cambiar el tamaño de la
        // ventana
        // SBAE
        // --------------------------------------------------------------------
        private void DlgMesaPracticas2_Resize(object sender, EventArgs e)
        {
        }

        // --------------------------------------------------------------------
        // Actualizar la fecha y la hora con cada tick (1000 ms) del contador
        //
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        // Activa la practica 2
        // --------------------------------------------------------------------
        private void BtnP2Lienzo_Click(object sender, EventArgs e)
        {
            PnlLienzo.Visible = !PnlLienzo.Visible;
        }

        // Importa una hoja de Excel que contiene vectores (?)
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            // Construye aplicación
            _Application app;
            _Workbook workbook;
            _Worksheet worksheet;
            int row;
            string ProjectName;
            string PropetaryName;
            string PropertyUbication;

            // Limpia la tabla (si no es lógico)
            DgvVectores.Rows.Clear();

            // Crea la app
            app = new Microsoft.Office.Interop.Excel.Application();

            // Importa el archivo
            workbook = app.Workbooks.Open("C:\\Users\\cosmo\\OneDrive\\Escritorio\\MP3-datos.xlsx",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            worksheet = workbook.Sheets["Vectores"];
            worksheet = workbook.ActiveSheet;

            // Algoritmo de importación de datos

            ProjectName = ((Range)worksheet.Cells[1, 1]).Value;
            PropetaryName = ((Range)worksheet.Cells[2, 1]).Value;
            PropertyUbication = ((Range)worksheet.Cells[3, 1]).Value;

            row = 5;

            while (((Range)worksheet.Cells[row, 1]).Value != null)
            {
                string Vector = ((Range)worksheet.Cells[row, 1]).Value;
                double X = ((Range)worksheet.Cells[row, 2]).Value;
                double Y = ((Range)worksheet.Cells[row, 3]).Value;
                string CellColor = ((Range)worksheet.Cells[row, 4]).Value;

                DgvVectores.Rows.Add();
                DgvVectores.Rows[row - 5].Cells[0].Value = Vector;
                DgvVectores.Rows[row - 5].Cells[1].Value = X;
                DgvVectores.Rows[row - 5].Cells[2].Value = Y;

                switch (CellColor) {
                    case "R":
                        DgvVectores.Rows[row - 5].Cells[0].Style.BackColor = Color.Red;
                        break;
                    case "G":
                        DgvVectores.Rows[row - 5].Cells[0].Style.BackColor = Color.Green;
                        break;
                    case "B":
                        DgvVectores.Rows[row - 5].Cells[0].Style.BackColor = Color.Blue;
                        break;
                }
                row++;
            }

            //TbxPerimetro.Text = ((Range)worksheet.Cells[20, 9]).Value.ToString();
            //TbxArea.Text = ((Range)worksheet.Cells[21, 9]).Value.ToString();

            app.Quit();
        }

        // Obtiene la distancia entre dos puntos
        private float GetDistanceBetweenPoints(PointF Point1, PointF Point2)
        {
            return (float)Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2));
        }

        // Obtiene un producto cruzado
        private float GetCrossedProduct(PointF Point1, PointF Point2)
        {
            return (float)((Point1.X - Point2.Y) * (Point2.X - Point1.Y));
        }

        // Dibuja el perimetro de la figura
        private void DrawPerimeter(PointF[] Points)
        {
            Pen Pencil;
            Pen PencilPoint;
            Graphics Graphics;
            Color Color;

            Color = Color.Red;
            Pencil = new Pen(Color, 1);
            PencilPoint = new Pen(Color, 5);
            Graphics = PnlLienzo.CreateGraphics();
            Graphics.DrawPolygon(Pencil, Points);

            for (int i = 0; i < Points.Length; i++)
            {
                Graphics.DrawEllipse(PencilPoint, Points[i].X - 5, Points[i].Y - 5, 10, 10);
            }
        }
        
        // Transforma los vectores dado en un array de puntos flotanes
        private PointF[] GetCoordinates(int X, int Y)
        {
            PointF[] Points;
            int NumRows;

            NumRows = DgvVectores.RowCount - 1;
            Points = new PointF[NumRows];

            for (int i = 0; i < NumRows; i++)
            {
                PointF Point;
                string xS;
                string yS;
                float x; 
                float y;

                xS = DgvVectores.Rows[i].Cells[1].Value.ToString();
                yS = DgvVectores.Rows[i].Cells[2].Value.ToString();

                x = float.Parse(xS);
                y = float.Parse(yS);

                Point = new PointF((x * 6f) + X, -(y * 6f) + Y);
                Points[i] = Point;
            }

            float Perimeter = 0;
            float Product = 0;

            for (int i = 0; i < NumRows - 1; i++)
            {
                Perimeter += GetDistanceBetweenPoints(Points[i], Points[i + 1]);
                Product += GetCrossedProduct(Points[i], Points[i + 1]);
            }

            Perimeter += GetDistanceBetweenPoints(Points[NumRows - 1], Points[0]);
            Product += GetCrossedProduct(Points[NumRows - 1], Points[0]);

            TbxPerimetro.Text = Perimeter.ToString();
            TbxArea.Text = (Product / 2).ToString();

            return Points;
        }

        // Dibuja una poligonal en el punto origen determinado (lógicamente)
        private void DrawPolygonal(int X, int Y)
        {
            PointF[] Points = GetCoordinates(X, Y);

            DrawPerimeter(Points);

        }

        // Dibuja el plano del terreno sobre el lienzo.
        private void BtnDibujar_Click(object sender, EventArgs e)
        {
            int X = 40;
            int Y = 500;
            DrawPolygonal(X, Y);
        }
    }
}
