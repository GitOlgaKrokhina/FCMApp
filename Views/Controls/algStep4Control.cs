using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FCMApp.Models;

namespace FCMApp.Views.Controls
{
    public partial class algStep4Control : UserControl
    {
        public algStep4Control()
        {
            InitializeComponent();
            int numberOfFactors = algStep1Control.factorsChecked.Count();
            List<String> factors = algStep1Control.factorsChecked;
            //List<String> factors = new List<string>() { "ddd", "ffff", "dddd", "dd", "dd" };

            //int numberOfFactors = 5;
            dataGridViewMatrix.Columns.Add("", "");

            for (int i = 0; i < numberOfFactors; i++)
            {
                dataGridViewMatrix.Columns.Add($"F{i+1}", $"F{i+1}");
                dataGridViewMatrix.Rows.Add($"F{i + 1}");
            }
            dataGridViewMatrix.Columns[0].ReadOnly = true;

            for (int i = 0; i < numberOfFactors; i++)
            {
                dataGridViewMatrix.Rows[i].Cells[i+1].Value = 0;
                dataGridViewMatrix.Rows[i].Cells[i+1].ReadOnly = true;
            }

            
            dataGridViewFactors.Columns.Add("Номер", "Номер");
            dataGridViewFactors.Columns.Add("Название", "Название");
            for (int i = 0; i < numberOfFactors; i++)
            {
                dataGridViewFactors.Rows.Add();
            }
            for (int i = 0; i < numberOfFactors; i++)
            {
                dataGridViewFactors.Rows[i].Cells[0].Value = $"F{i+1}";
                dataGridViewFactors.Rows[i].Cells[1].Value = factors[i];
            }
        }

        private void dataGridViewMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dataGridViewMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 1 || Convert.ToDouble(dataGridViewMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < -1)
                {
                    MessageBox.Show("Значение веса должно находится в пределах от -1 до 1", "Ошибка задания веса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Значение веса должно задаваться целым числом или дробным числом с запятой", "Ошибка задания веса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
            }

            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int numberOfFactors = algStep1Control.factorsChecked.Count();
            double[,] matrix = new double[numberOfFactors, numberOfFactors];
            for (int i = 0; i < dataGridViewMatrix.Rows.Count; i++)
                for (int j = 1; j < dataGridViewMatrix.Columns.Count; j++)
                {
                    if(dataGridViewMatrix.Rows[i].Cells[j].Value == null)
                    {
                        dataGridViewMatrix.Rows[i].Cells[j].Value = "0";
                    }
                    matrix[i, j-1] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }
            fuzzyCognitiveMap.addEdgesToScheme(matrix, numberOfFactors);
            this.ParentForm.Close();


            step5Form temp = new step5Form(fuzzyCognitiveMap.returnScheme());
            temp.Show();
            //this.ParentForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            algStep1Control.factorsChecked.Clear();
            fuzzyCognitiveMap.task1 = new XDocument(new XDeclaration(null, "us-ascii", null));
            this.ParentForm.Close();
        }
    }
}
