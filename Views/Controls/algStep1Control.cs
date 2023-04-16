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
using FCMApp.Models.Library;
using FCMApp.Views;

namespace FCMApp.Views.Controls
{
    public partial class algStep1Control : UserControl
    {
        public static List<String> factorsChecked = new List<string>();
        public algStep1Control()
        {
            InitializeComponent();
            successFactors[] output = successFactors.listOfSuccessFactors.ToArray();
            string[] factors = new string[output.Length];
            for (int i=0; i<output.Length;i++)
            {
                factors[i] = output[i].NAME_FACTOR;
            }
            FactorsListBox.Items.AddRange(factors);
            FactorsListBox.CheckOnClick = true;
        }

        private void addFactorButton_Click(object sender, EventArgs e)
        {
            addFactorForm temp = new addFactorForm();
            temp.ShowDialog();
            FactorsListBox.Items.Add(temp.name_factor);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            factorsChecked = FactorsListBox.CheckedItems.OfType<String>().ToList();
            if(factorsChecked.Count() == 0)
            {
                MessageBox.Show("Не выбраны факторы успеха", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (factorsChecked.Count() == 1)
            {
                MessageBox.Show("Минимальное количество факторов - 2", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                FactorsForm newFactorsForm = new FactorsForm(factorsChecked);
                newFactorsForm.Show();
                this.ParentForm.Close();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            factorsChecked.Clear();
            this.ParentForm.Close();
        }
    }
}
