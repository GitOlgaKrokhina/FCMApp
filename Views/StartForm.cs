using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FCMApp.Views.Controls;
using FCMApp.Controllers;

namespace FCMApp.Views
{
    public partial class StartForm : KryptonForm
    {
        public StartForm()
        {
            InitializeComponent();
            welcomeControl1.Visible = true;

            libraryViewControl1.Visible = false;

            successFactorsLibControl1.Visible = false;
            mfLibControl1.Visible = false;
            activationFunLibControl1.Visible = false;
            defuzLibControl1.Visible = false;
            inferenceEqLibControl1.Visible = false;

            fcmAlgDescriptionControl1.Visible = false;

            //algStep1Control1.Visible = false;
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            libraryViewControl1.Visible = true;

            fcmAlgDescriptionControl1.Visible = false;
            welcomeControl1.Visible = false;

            successFactorsLibControl1.Visible = false;
            mfLibControl1.Visible = false;
            activationFunLibControl1.Visible = false;
            defuzLibControl1.Visible = false;
            inferenceEqLibControl1.Visible = false;

        }

        private void algorithmButton_Click(object sender, EventArgs e)
        {
            fcmAlgDescriptionControl1.Visible = true;

            libraryViewControl1.Visible = false;
            welcomeControl1.Visible = false;

            successFactorsLibControl1.Visible = false;
            mfLibControl1.Visible = false;
            activationFunLibControl1.Visible = false;
            defuzLibControl1.Visible = false;
            inferenceEqLibControl1.Visible = false;
        }

        private void aboutProgramButton_Click(object sender, EventArgs e)
        {
            aboutProgramBox aboutForm = new aboutProgramBox();
            aboutForm.Show();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            instructionController.loadInstruction();
        }
    }
}
