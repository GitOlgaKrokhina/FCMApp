using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FCMApp.Controllers;

namespace FCMApp.Views
{
    public partial class conceptsWithChartForm : Form
    {
        public conceptsWithChartForm(double[,] matrix)
        {
            InitializeComponent();
            LoadChart(matrix);
        }
        void LoadChart(double[,] matrix)
        {
            double maxValueForChart = 0;
            double minValueForChart = 0;
            List<double> arrayOfMaxima = new List<double>();

            //for (int j = 0; j < alrorithmController.numberOfFactors; j++)
            //{
            //    for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
            //    {
            //        if(matrix[i - 1, j]> maxValueForChart) maxValueForChart= matrix[i - 1, j];
            //        if (matrix[i - 1, j] < minValueForChart) minValueForChart = matrix[i - 1, j];
            //    }
            //}


            //for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
            //{
            //    for (int j = 0; j < alrorithmController.numberOfFactors; j++)
            //    {
            //        if (matrix[i - 1, j] > maxValueForChart) maxValueForChart = matrix[i - 1, j];
            //        if (matrix[i - 1, j] < minValueForChart) minValueForChart = matrix[i - 1, j];
            //    }
            //}
            for (int i = 0; i < alrorithmController.numberOfIterations+1; i++)
            {
                for (int j = 0; j < alrorithmController.numberOfFactors; j++)
                {
                    if (matrix[i, j] > maxValueForChart) maxValueForChart = matrix[i, j];
                    if (matrix[i, j] < minValueForChart) minValueForChart = matrix[i, j];
                }
            }


            for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
            {
                double maxima = minValueForChart;
                for (int j = 0; j < alrorithmController.numberOfFactors; j++)
                {
                    if (matrix[i - 1, j] > maxima) maxima = matrix[i - 1, j];
                }
                arrayOfMaxima.Add(maxima);
            }



            chart1.ChartAreas.Add("Area");


            //chart1.ChartAreas["Area"].AxisX.Maximum = alrorithmController.numberOfIterations;
            //chart1.ChartAreas["Area"].AxisX.Interval = 1;
            //chart1.ChartAreas["Area"].AxisX.IsStartedFromZero = true;
            //chart1.ChartAreas["Area"].AxisX.MajorGrid.LineColor = Color.Gray;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = alrorithmController.numberOfIterations;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            

            chart1.ChartAreas[0].AxisY.Minimum = minValueForChart - 1;
            chart1.ChartAreas[0].AxisY.Maximum = maxValueForChart + 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            chart1.ChartAreas[0].AxisY.MajorGrid.IntervalType = DateTimeIntervalType.Number;


            chart1.ChartAreas.FindByName("ChartArea1").AxisY.Title = "Значение концепта";
            chart1.ChartAreas.FindByName("ChartArea1").AxisX.Title = "Итерация";

            for (int j = 0; j < alrorithmController.numberOfFactors; j++)
            {
                Series mySeriesOfPoint = new Series($"Фактор {j + 1} - {alrorithmController.namesForChart[j]}");
                mySeriesOfPoint.ChartType = SeriesChartType.Line;
                for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
                {
                    mySeriesOfPoint.Points.AddXY(i-1, matrix[i - 1, j]);
                }
                mySeriesOfPoint.BorderWidth = 2;
                chart1.Series.Add(mySeriesOfPoint);
            }




            for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
            {
                Series lineSeries = new Series($"Line {i}");
                lineSeries.ChartType = SeriesChartType.Line;
                lineSeries.Points.Add(new DataPoint(i - 1, minValueForChart - 1));
                lineSeries.Points.Add(new DataPoint(i - 1, arrayOfMaxima[i-1]));
                lineSeries.IsVisibleInLegend = false;
                lineSeries.Color = Color.Black;
                lineSeries.BorderDashStyle = ChartDashStyle.Dot;
                lineSeries.BorderWidth = 2;
                chart1.Series.Add(lineSeries);
            }
        }

        private void conceptsWithChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
