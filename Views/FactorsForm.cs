using FCMApp.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCMApp.Views
{
    public partial class FactorsForm : Form
    {
        public FactorsForm(List<String> checkedFactors)
        {
            InitializeComponent();
            algStep2Control step2temp = new algStep2Control(checkedFactors);
            step2temp.Location = new Point(12, 9);
            step2temp.Visible = true;
            Controls.Add(step2temp);
        }
    }
}
