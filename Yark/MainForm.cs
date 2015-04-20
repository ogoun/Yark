using System;
using System.Windows.Forms;

namespace Yark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bCompress_Click(object sender, EventArgs e)
        {
            new CompressForm().ShowDialog();
        }

        private void bDecompress_Click(object sender, EventArgs e)
        {
            new DecompressForm().ShowDialog();
        }
    }
}
