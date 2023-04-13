using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCMApp.Models;
using FCMApp.Controllers;
using System.Xml.Linq;

namespace FCMApp.Views.Controls
{
    public partial class algStep5Control : UserControl
    {
        public double[,] matrixForChart;
        public static XDocument xDocForSave = new XDocument();
        public algStep5Control(XDocument xDoc)
        {
            InitializeComponent();
            xDocForSave = xDoc;
            int numIterations = alrorithmController.getNumberOfIterations(xDoc);
            double[,] matrix = alrorithmController.loadSchemeAndDoAlgorithm(xDoc);
            matrixForChart = matrix;

            int numberOfFactors = alrorithmController.numberOfFactors;

            dataGridViewConcepts.Columns.Add("", "");

            for (int i = 0; i < numberOfFactors; i++)
            {
                dataGridViewConcepts.Rows.Add($"F{i + 1}");
            }
            for (int i = 0; i < numIterations + 1; i++)
            {
                dataGridViewConcepts.Columns.Add($"{i}", $"{i}");
            }

            for (int j = 0; j < numberOfFactors; j++) //строки 
            {
                for (int i = 1; i < numIterations+2; i++) //столбцы
                {
                    dataGridViewConcepts.Rows[j].Cells[i].Value = matrix[i - 1, j];
                }
            }

            //dataGridViewConcepts.Rows.Add("A1", 2.61,  0.87, 0.66, 0.62, 0.62, 0.62);
            //dataGridViewConcepts.Rows.Add("A2", 3.20, 0.96, 0.75, 0.70, 0.69, 0.68);
            //dataGridViewConcepts.Rows.Add("A3", 2.61, 0.97, 0.78, 0.73, 0.72, 0.71);
            //dataGridViewConcepts.Rows.Add("A4", 3.75, 0.99, 0.78, 0.73, 0.72 ,0.72);
            //dataGridViewConcepts.Rows.Add("A5", 2.77, 0.94, 0.72, 0.67, 0.66, 0.66);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FCMView frm = new FCMView();
            frm.Show();
        }

        private void showConceptsButton_Click(object sender, EventArgs e)
        {
            conceptsWithChartForm frm = new conceptsWithChartForm(matrixForChart);
            frm.Show();
        }

        private void saveXMLButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogForSavingGraph = new SaveFileDialog();
            dialogForSavingGraph.Title = "Сохранить документ как...";
            dialogForSavingGraph.OverwritePrompt = true;
            dialogForSavingGraph.CheckPathExists = true;
            dialogForSavingGraph.Filter = "XML Files (*.xml)|*.xml";
            dialogForSavingGraph.ShowHelp = true;
            if (dialogForSavingGraph.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xDocForSave.Save(dialogForSavingGraph.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить документ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabelExample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            instructionController.loadInstruction();
        }
    }
}
