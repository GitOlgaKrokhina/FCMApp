using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCMApp.Models.Library;

namespace FCMApp.Views
{
    public partial class addFactorForm : Form
    {
        public string name_factor;
        public string description_factor;
        public addFactorForm()
        {
            InitializeComponent();
            addFactorButton.Enabled = false;
        }

        private void addFactorButton_Click(object sender, EventArgs e)
        {
            name_factor = textBoxName.Text;
            if (textBoxDescription.Text == "")
            {
                description_factor = "Описание не задано";
            }
            else
            {
                description_factor = textBoxDescription.Text;
            }
            successFactors.addToList(name_factor, description_factor);
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "") && (textBoxName.Text.Length > 0))
            {
                addFactorButton.Enabled = true;
            }
            else addFactorButton.Enabled = false;
        }
    }
}
