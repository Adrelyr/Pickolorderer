using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pickolorderer
{
    public partial class Pickolorderer : Form
    {
        PicHandler picHandler;
        public Pickolorderer()
        {
            InitializeComponent();
        }

        private void fileChooserBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                fileList.Items.Clear();
                fileList.Items.AddRange(openFileDialog1.FileNames);
            }
        }

        private void sortColorsBtn_Click(object sender, EventArgs e)
        {
            picHandler = new PicHandler(openFileDialog1.FileNames.ToList(), this);
        }
    }
}
