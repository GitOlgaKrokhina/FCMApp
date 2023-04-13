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
    public partial class algorithmForm : Form
    {
        public algorithmForm()
        {
            InitializeComponent();
            algStep1Control step1temp = new algStep1Control();
            step1temp.Location = new Point(12, 9);
            step1temp.Visible = true;
            Controls.Add(step1temp);
        }
    }
}
