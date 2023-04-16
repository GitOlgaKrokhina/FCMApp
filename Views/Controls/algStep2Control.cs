using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCMApp.Views;
using FCMApp.Models;
using FCMApp.Controllers;
using System.Xml.Linq;

namespace FCMApp.Views.Controls
{
    public partial class algStep2Control : UserControl
    {
        public static List<String> factors = new List<string>();
        public int lengthOfFactors = 0;
        public String nowFactor = "";
        public int numToCount = 0;
        public int idFactor = 1;

        public algStep2Control(List<String> factorsChecked)
        {
            InitializeComponent();
            nextButton.Visible = false;

            factors = factorsChecked;
            lengthOfFactors = factors.Count();
            nowFactor = factors[numToCount];

            labelNameOfFactor.Text = nowFactor;
            fuzzyCognitiveMap.LoadScheme();
        }

        private void algStep2Control_Load(object sender, EventArgs e)
        {
            parametersTextBox.Text = "Введите указанные параметры через точку с запятой";//подсказка
            parametersTextBox.ForeColor = Color.Gray;

            domainTextBox.Text = "Границы через точку с запятой";//подсказка
            domainTextBox.ForeColor = Color.Gray;

            ToolTip t = new ToolTip();
            t.SetToolTip(domainTextBox, "Два числа через точку с запятой");
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(parametersTextBox, "Перечисленные параметры в формате чисел через точку с запятой");

        }

        private void parametersTextBox_Enter(object sender, EventArgs e)
        {
            parametersTextBox.Text = null;
            parametersTextBox.ForeColor = Color.Black;
        }

        private void parametersTextBox_Leave(object sender, EventArgs e)
        {
            if (parametersTextBox.Text =="")
            {
                parametersTextBox.Text = "Введите указанные параметры через точку с запятой";//подсказка
                parametersTextBox.ForeColor = Color.Gray;
            }
        }

        private void nextFactorButton_Click(object sender, EventArgs e)
        {
            if (nowFactor == factors[lengthOfFactors-2].ToString())
            {
                string MF = "";
                MF = successFactorController.returnValueOfMembershipFunction(ComboBoxMF.Text);

                string defuzzification = "";
                defuzzification = successFactorController.returnValueOfDefuzzification(mfComboBox.Text);

                if (MF == "" || parametersTextBox.Text == "" || domainTextBox.Text == "" || defuzzification == "")
                {
                    MessageBox.Show("Заполнены не все поля описания фактора", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    fuzzyCognitiveMap.addFactorToScheme(idFactor, labelNameOfFactor.Text, MF, parametersTextBox.Text, domainTextBox.Text, defuzzification);
                    idFactor += 1;

                    nextButton.Visible = true;
                    nextFactorButton.Visible = false;

                    numToCount += 1;
                    nowFactor = factors[numToCount];
                    labelNameOfFactor.Text = nowFactor;

                    ComboBoxMF.Text = "";
                    parametersTextBox.Text = "";
                    domainTextBox.Text = "";
                    mfComboBox.Text = "";
                    labelParameters.Text = "Выберите функцию принадлежности";
                    parametersTextBox.Text = "Введите указанные параметры через точку с запятой";//подсказка
                    parametersTextBox.ForeColor = Color.Gray;
                }

                

            }
            else
            {
                string MF = "";
                MF = successFactorController.returnValueOfMembershipFunction(ComboBoxMF.Text);

                string defuzzification = "";
                defuzzification = successFactorController.returnValueOfDefuzzification(mfComboBox.Text);

                if (MF == "" || parametersTextBox.Text == "" || domainTextBox.Text == "" || defuzzification == "")
                {
                    MessageBox.Show("Заполнены не все поля описания фактора", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    fuzzyCognitiveMap.addFactorToScheme(idFactor, labelNameOfFactor.Text, MF, parametersTextBox.Text, domainTextBox.Text, defuzzification);
                    idFactor += 1;

                    numToCount += 1;
                    nowFactor = factors[numToCount];
                    labelNameOfFactor.Text = nowFactor;

                    ComboBoxMF.Text = "";
                    parametersTextBox.Text = "";
                    domainTextBox.Text = "";
                    mfComboBox.Text = "";
                    labelParameters.Text = "Выберите функцию принадлежности";
                    parametersTextBox.Text = "Введите указанные параметры через точку с запятой";//подсказка
                    parametersTextBox.ForeColor = Color.Gray;
                }

                
            }
        }

        private void ComboBoxMF_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboBoxMF.SelectedItem.ToString() == "треугольная") { labelParameters.Text = "a (левая граница); c (точка максимума); b (правая граница)"; }
            if (ComboBoxMF.SelectedItem.ToString() == "трапециевидная") { labelParameters.Text = "a (левая граница); c (левая точка максимума); d (правая точка максимума); b (правая граница)"; }
            if (ComboBoxMF.SelectedItem.ToString() == "квадратичная S-сплайн") { labelParameters.Text = "a (левая граница); b (правая граница)"; }
            if (ComboBoxMF.SelectedItem.ToString() == "квадратичная Z-сплайн") { labelParameters.Text = "a (левая граница); b (правая граница)"; }
            if (ComboBoxMF.SelectedItem.ToString() == "экспоненциальная (гауссова)") { labelParameters.Text = "a (координата максимума); b (коэффициент концентрации)"; }
            if (ComboBoxMF.SelectedItem.ToString() == "колоколообразная") { labelParameters.Text = "a (коэффициент концентрации); b (коэффициент крутизны); c (координата максимума)"; }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            string MF = "";
            MF = successFactorController.returnValueOfMembershipFunction(ComboBoxMF.Text);

            string defuzzification = "";
            defuzzification = successFactorController.returnValueOfDefuzzification(mfComboBox.Text);

            if (MF=="" || parametersTextBox.Text == "" || domainTextBox.Text==""|| defuzzification=="")
            {
                MessageBox.Show("Заполнены не все поля описания фактора", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fuzzyCognitiveMap.addFactorToScheme(idFactor, labelNameOfFactor.Text, MF, parametersTextBox.Text, domainTextBox.Text, defuzzification);

                step3Form step3temp = new step3Form();
                step3temp.Show();
                this.ParentForm.Close();
            }

            
        }

        private void domainTextBox_Enter(object sender, EventArgs e)
        {
            domainTextBox.Text = null;
            domainTextBox.ForeColor = Color.Black;
        }

        private void domainTextBox_Leave(object sender, EventArgs e)
        {
            if (domainTextBox.Text == "")
            {
                domainTextBox.Text = "Границы через точку с запятой";//подсказка
                domainTextBox.ForeColor = Color.Gray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            algStep1Control.factorsChecked.Clear();
            fuzzyCognitiveMap.task1 = new XDocument(new XDeclaration(null, "us-ascii", null));
            this.ParentForm.Close();
        }
    }
}
