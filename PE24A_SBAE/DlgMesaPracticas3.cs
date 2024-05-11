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
        // ------------------------------------------------------------------------ 
        public DlgMesaPracticas3()
        {
            InitializeComponent();
            PnlLienzo.Visible = false;
        }

        private void BtnP3Lienzo_Click(object sender, EventArgs e)
        {
            PnlLienzo.Visible = !PnlLienzo.Visible;
        }

        // Importa una hoja de Excel que contiene vectores (?)
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            // Construye aplicación

            // Crea la app
            _Application app = new Microsoft.Office.Interop.Excel.Application();

            // Importa el archivo
            _Workbook workbook = app.Workbooks.Open("C:\\Users\\cosmo\\OneDrive\\Escritorio\\MP3-datos.xlsx",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Toma la hoja en especifico del archivo de Excel
            _Worksheet worksheet = workbook.Sheets["Vectores"];
            worksheet = workbook.ActiveSheet;

            // Obtenemos detalles de la hoja de calculo
            string ProjectName = ((Range)worksheet.Cells[1, 1]).Value;
            string PropetaryName = ((Range)worksheet.Cells[2, 1]).Value;
            string PropertyUbication = ((Range)worksheet.Cells[3, 1]).Value;

            // La columna desde la que comienza la tabla con los vectores
            int row = 5;

            // Limpia la tabla (si no es lógico)
            DgvVectores.Rows.Clear();

            // Algoritmo de importación de datos
            while (((Range)worksheet.Cells[row, 1]).Value != null)
            {
                // Obtiene estos datos de la hoja de calculo
                string Vector = ((Range)worksheet.Cells[row, 1]).Value;
                double X = ((Range)worksheet.Cells[row, 2]).Value;
                double Y = ((Range)worksheet.Cells[row, 3]).Value;
                string CellColor = ((Range)worksheet.Cells[row, 4]).Value;

                // Añade dichos datos al DataGridView
                DgvVectores.Rows.Add();
                DgvVectores.Rows[row - 5].Cells[0].Value = Vector;
                DgvVectores.Rows[row - 5].Cells[1].Value = X;
                DgvVectores.Rows[row - 5].Cells[2].Value = Y;

                // Dependidendo del color especificado en la hoja de calculo, se colorea esa casilla en el DGV
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

            // Cierra la aplicación
            app.Quit();
        }

        // Dibuja el perimetro de la figura
        private void DrawPerimeter(PointF[] Points)
        {
            Pen Pencil = new Pen(Color.Red, 1);
            Graphics Graphics = PnlLienzo.CreateGraphics();
            Brush brush = new SolidBrush(Color.Red);

            Graphics.DrawPolygon(Pencil, Points);

            for (int i = 0; i < Points.Length; i++)
            {
                Graphics.DrawEllipse(new Pen(Color.Red, 5), Points[i].X - 5, Points[i].Y - 5, 10, 10);
                Graphics.DrawString(DgvVectores.Rows[i].Cells[0].Value.ToString(), Font, brush, Points[i].X + 9, Points[i].Y - 5);
            }
        }
        
        // Transforma los vectores dado en un array de puntos flotanes
        private PointF[] GetCoordinates(int X, int Y)
        {
            int NumRows = DgvVectores.RowCount - 1;
            PointF[] Points = new PointF[NumRows];

            for (int i = 0; i < NumRows; i++)
            {
                float x = float.Parse(DgvVectores.Rows[i].Cells[1].Value.ToString());
                float y = float.Parse(DgvVectores.Rows[i].Cells[2].Value.ToString());

                PointF Point = new PointF((x * 6f) + X, -(y * 6f) + Y);
                Points[i] = Point;
            }

            return Points;
        }

        // Obtiene el perimetro de la figura
        private void GetPerimeter(PointF[] Points)
        {
            double Perimeter = 0;

            // La fórmula usada es la que se utiliza para obtener la distancia
            // entre dos puntos en un plano bidimensional. Al final se suman todas
            // las distancias para formar el perimetro.
            for (int i = 0; i < Points.Length - 1; i++)
            {
                double distance = Math.Sqrt(Math.Pow(Points[i + 1].X - Points[i].X, 2) + Math.Pow(Points[i + 1].Y - Points[i].Y, 2));
                Perimeter += distance;
            }
            // Este último calculo tiene en cuenta que el último punto tiene que calcularse junto con el primero.
            Perimeter += Math.Sqrt(Math.Pow(Points[Points.Length - 1].X - Points[0].X, 2) + Math.Pow(Points[Points.Length - 1].Y - Points[0].Y, 2));
            Perimeter /= 6;

            TbxPerimetro.Text = Perimeter.ToString();
        }

        // Obtiene el área de la figura
        private void GetArea(PointF[] Points)
        {
            double Area = 0;

            // La fórmula usada es la fórmula del producto cruzado.
            for (int i = 0; i < Points.Length - 1; i++)
            {
                double product = (Points[i].X * Points[i + 1].Y) - (Points[i + 1].X * Points[i].Y);
                Area += product;
            }
            // Este último calculo tiene en cuenta que el último punto tiene que calcularse junto con el primero.
            Area += (Points[Points.Length - 1].X * Points[0].Y) - (Points[0].X * Points[Points.Length - 1].Y);
            Area = Math.Abs(Area / 2) / 36;

            TbxArea.Text = Area.ToString();
        }

        // Dibuja una poligonal en el punto origen determinado (lógicamente)
        private void DrawPolygonal(int X, int Y)
        {
            PointF[] Points = GetCoordinates(X, Y);

            DrawPerimeter(Points);
            GetPerimeter(Points);
            GetArea(Points);
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
