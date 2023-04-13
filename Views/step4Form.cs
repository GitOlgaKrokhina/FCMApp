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
    public partial class step4Form : Form
    {
        public step4Form()
        {
            InitializeComponent();
            algStep4Control step4temp = new algStep4Control();
            step4temp.Location = new Point(12, 9);
            step4temp.Visible = true;
            Controls.Add(step4temp);
        }
    }
}
