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

namespace FCMApp.Views
{
    public partial class step3Form : Form
    {
        public step3Form()
        {
            InitializeComponent();
            algStep3Control step3temp = new algStep3Control();
            step3temp.Location = new Point(12, 9);
            step3temp.Visible = true;
            Controls.Add(step3temp);
        }
    }
}
