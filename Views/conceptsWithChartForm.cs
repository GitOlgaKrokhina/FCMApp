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
            for (int j = 0; j < alrorithmController.numberOfFactors; j++)
            {
                for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
                {
                    if(matrix[i - 1, j]> maxValueForChart) maxValueForChart= matrix[i - 1, j];
                }
            }
            chart1.ChartAreas.Add("Area");
            chart1.ChartAreas["Area"].AxisX.Minimum = 0;
            chart1.ChartAreas["Area"].AxisX.Maximum = alrorithmController.numberOfIterations;
            chart1.ChartAreas["Area"].AxisX.Interval = 1;
            chart1.ChartAreas["Area"].AxisY.Minimum = 1;
            chart1.ChartAreas["Area"].AxisY.Maximum = maxValueForChart;
            chart1.ChartAreas["Area"].AxisY.Interval = 0.5;

            for (int j = 0; j < alrorithmController.numberOfFactors; j++)
            {
                Series mySeriesOfPoint = new Series($"Фактор {j + 1} - {alrorithmController.namesForChart[j]}");
                mySeriesOfPoint.ChartType = SeriesChartType.Line;
                for (int i = 1; i < alrorithmController.numberOfIterations + 2; i++)
                {
                    mySeriesOfPoint.Points.AddXY(i-1, matrix[i - 1, j]);
                }
                chart1.Series.Add(mySeriesOfPoint);
            }
            
        }
    }
}
