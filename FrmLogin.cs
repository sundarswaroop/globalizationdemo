using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalizationDemo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Show();
        }

        private void SetTheLanguage(string selectedLanguage = "en-EN")
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedLanguage);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(selectedLanguage);
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            SetTheLanguage(((RadioButton)(sender)).Tag.ToString());
        }
    }
}
