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
using FCMApp.Views;

namespace FCMApp.Views.Controls
{
    public partial class successFactorsLibControl : UserControl
    {
        public successFactorsLibControl()
        {
            InitializeComponent();
        }

        private void sfLoadButton_Click(object sender, EventArgs e)
        {
            listFactorsView.DataSource = null;
            listFactorsView.DataSource = successFactors.listOfSuccessFactors;
        }

        private void addFactorButton_Click(object sender, EventArgs e)
        {
            addFactorForm temp = new addFactorForm();
            temp.Show();
        }
    }
}
