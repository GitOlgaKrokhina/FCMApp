using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCMApp.Views.Controls;
using FCMApp.Models;

namespace FCMApp.Views.Controls
{
    public partial class algStep3Control : UserControl
    {
        public algStep3Control()
        {
            InitializeComponent();
            labelVector.Text = $"Введите вектор в формате 1;1;0;1... по количеству выбранных факторов: {algStep1Control.factorsChecked.Count()}";
        }

        private void algStep3Control_Load(object sender, EventArgs e)
        {
            vectorTextBox.Text = "Введите вектор активации";//подсказка
            vectorTextBox.ForeColor = Color.Gray;
        }

        private void vectorTextBox_Enter(object sender, EventArgs e)
        {
            vectorTextBox.Text = null;
            vectorTextBox.ForeColor = Color.Black;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string act ="";
            if (ComboBoxActivationFunction.Text == "бивалентная") act = "bivalentFunction";
            if (ComboBoxActivationFunction.Text == "тривалентная") act = "trivalentFunction";
            if (ComboBoxActivationFunction.Text == "сигмоидальная") act = "sigmoidFunction";
            if (ComboBoxActivationFunction.Text == "гиперболический тангенс") act = "hyperbolicTangentFunction";

            string inference = "";
            if (ComboBoxInferenceEquation.Text == "схема вывода Коско") inference = "coscoOutputCircuit";
            if (ComboBoxInferenceEquation.Text == "модифицированная схема вывода Коско") inference = "modifiedCoscoOutputCircuit";
            if (ComboBoxInferenceEquation.Text == "масштабированный вывод") inference = "scaledOutputCircuit";

            if (act == "" || inference == "" || vectorTextBox.Text == "" || iterTextBox.Text == "")
            {
                MessageBox.Show("Заполнены не все поля параметров алгоритма", "Ошибка",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                fuzzyCognitiveMap.addParametersToScheme(act, vectorTextBox.Text, iterTextBox.Text, inference);


                step4Form temp = new step4Form();
                temp.Show();
                this.ParentForm.Close();
            }

            
        }
    }
}
