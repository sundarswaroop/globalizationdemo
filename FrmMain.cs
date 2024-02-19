using GlobalizationDemo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalizationDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetLanguageBasedText();
        }

        /// <summary>
        /// Add the controls and their text/tooltip etc.,
        /// </summary>
        private void SetLanguageBasedText()
        {
            label1.Text = Resources.lblSelectedLanguage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(label1.Text);
            label2.Text = "Copied";
        }
    }
}
