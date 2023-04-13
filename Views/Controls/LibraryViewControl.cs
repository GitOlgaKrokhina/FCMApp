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
    public partial class LibraryViewControl : UserControl
    {
        public LibraryViewControl()
        {
            InitializeComponent();
        }
 
        private void mfButton_Click(object sender, EventArgs e)
        {
            StartForm.mfLibControl1.Visible = true;
            this.Visible = false;
        }

        private void activationfButton_Click(object sender, EventArgs e)
        {
            StartForm.activationFunLibControl1.Visible = true;
            this.Visible = false;
        }

        private void defuzzButton_Click(object sender, EventArgs e)
        {
            StartForm.defuzLibControl1.Visible = true;
            this.Visible = false;
        }

        private void inferenceButton_Click(object sender, EventArgs e)
        {
            StartForm.inferenceEqLibControl1.Visible = true;
            this.Visible = false;
        }

        private void successFactorsButton_Click(object sender, EventArgs e)
        {
            StartForm.successFactorsLibControl1.Visible = true;
            this.Visible = false;
        }
    }
}
