using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCMApp.Controllers;

namespace FCMApp.Views
{
    public partial class FCMView : Form
    {
        public List<VertexDraw> Vertexes; //Лист вершин
        public List<EdgeDraw> Edges; //Лист ребер
        DrawGraph GraphVisualAndAlgoritmics; //Создаем визуальный граф 

        public static List<int> SelectedVertex = new List<int>();

        public static Dictionary<char, double> forVertexes = new Dictionary<char, double>();

        int vertexSelected1; //Первая вершина для соединения ребром
        int vertexSelected2; //Вторая вершина для соединения ребром
        public FCMView()
        {
            InitializeComponent();
            Vertexes = new List<VertexDraw>();
            GraphVisualAndAlgoritmics = new DrawGraph(sheet.Width, sheet.Height);
            Edges = new List<EdgeDraw>();
            sheet.Image = GraphVisualAndAlgoritmics.GetBitmap();

            loadGraph();
        }
        void loadGraph()
        {
            
            GraphVisualAndAlgoritmics.clearAllSheet();
            GraphVisualAndAlgoritmics.drawALLGraph(Vertexes, Edges);
            sheet.Image = GraphVisualAndAlgoritmics.GetBitmap();


            double R = 130, xc = sheet.Width/2, yc = sheet.Height/2;
            int numberOfFactors = alrorithmController.numberOfFactors;
            double fi0 = -Math.PI / 2.0;

            for (int i = 0; i < numberOfFactors; i++)
            {
                double xi = xc + R * Math.Cos(fi0 + (2 * Math.PI * i) / numberOfFactors);
                double yi = yc + R * Math.Sin(fi0 + (2 * Math.PI * i) / numberOfFactors);

                //WriteLine($"x{i} = {xi,-10:0.0}y{i} = {yi:0.0}");
                Vertexes.Add(new VertexDraw(Convert.ToInt32(xi),Convert.ToInt32(yi)));
                GraphVisualAndAlgoritmics.drawVertex(Convert.ToInt32(xi), Convert.ToInt32(yi), $"F  {Vertexes.Count.ToString()}");
                sheet.Image = GraphVisualAndAlgoritmics.GetBitmap();
            }
            ArrayList edgesWeigths = alrorithmController.listOfWeigthsForGraph;
            foreach (List<double> weight in edgesWeigths)
            {
                GraphVisualAndAlgoritmics.drawSelectedVertex(Vertexes[Convert.ToInt32(weight[0])-1].x, Vertexes[Convert.ToInt32(weight[0])-1].y);
                vertexSelected1 = Convert.ToInt32(weight[0])-1;
                sheet.Image = GraphVisualAndAlgoritmics.GetBitmap();
                

                GraphVisualAndAlgoritmics.drawSelectedVertex(Vertexes[Convert.ToInt32(weight[1])-1].x, Vertexes[Convert.ToInt32(weight[1])-1].y);
                vertexSelected2 = Convert.ToInt32(weight[1])-1;
                Edges.Add(new EdgeDraw(vertexSelected1, vertexSelected2));
                

                GraphVisualAndAlgoritmics.drawEdge(Vertexes[vertexSelected1], Vertexes[vertexSelected2], Edges[Edges.Count - 1], Edges.Count - 1, weight[2]);
                
                SelectedVertex.Add(Convert.ToInt32(vertexSelected1.ToString()+ vertexSelected2.ToString()));
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sheet.Image != null)
            {
                SaveFileDialog dialogForSavingGraph = new SaveFileDialog();
                dialogForSavingGraph.Title = "Сохранить картинку как...";
                dialogForSavingGraph.OverwritePrompt = true;
                dialogForSavingGraph.CheckPathExists = true;
                dialogForSavingGraph.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG";
                dialogForSavingGraph.ShowHelp = true;
                if (dialogForSavingGraph.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet.Image.Save(dialogForSavingGraph.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FCMView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vertexes.Clear();
            Edges.Clear();
            GraphVisualAndAlgoritmics.clearAllSheet();
            sheet.Image = GraphVisualAndAlgoritmics.GetBitmap();
            forVertexes.Clear();
            SelectedVertex.Clear();
        }
    }
}
