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
using FCMApp.Views.Controls;

namespace FCMApp.Views
{
    public partial class step5Form : Form
    {
        public step5Form(XDocument xDoc)
        {
            InitializeComponent();
            algStep5Control step5temp = new algStep5Control(xDoc);
            step5temp.Location = new Point(12, 9);
            step5temp.Visible = true;
            Controls.Add(step5temp);
        }

        private void step5Form_Load(object sender, EventArgs e)
        {

        }
    }
}
