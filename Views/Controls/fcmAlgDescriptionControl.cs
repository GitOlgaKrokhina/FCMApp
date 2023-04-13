using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FCMApp.Models;

namespace FCMApp.Views.Controls
{
    public partial class fcmAlgDescriptionControl : UserControl
    {
        public fcmAlgDescriptionControl()
        {
            InitializeComponent();
        }

        private void facmGoButton_Click(object sender, EventArgs e)
        {
            algorithmForm temp = new algorithmForm();
            temp.Show();
            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                var filePath = string.Empty;
                dialog.Filter = "XML Files (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!String.Equals(Path.GetExtension(dialog.FileName),
                       ".xml",
                       StringComparison.OrdinalIgnoreCase))
                    {
                        // Invalid file type selected; display an error.
                        MessageBox.Show("Выбран файл неверного формата (требуется XML файл, сформированый приложением)",
                                        "Неверный формат",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                        // Optionally, force the user to select another file.
                        // ...
                    }
                    else
                    {
                        filePath = dialog.FileName;
                        XDocument xDoc = XDocument.Load(filePath);
                        step5Form newForm = new step5Form(xDoc);
                        newForm.Show();
                    }
                }
            }
            
        }
    }
}
