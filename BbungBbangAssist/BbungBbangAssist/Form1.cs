using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BbungBbangAssist
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Login mLoginDlg = null;
        public Form1()
        {
            InitializeComponent();


            mLoginDlg = new Login();
            mLoginDlg.SetParent(this);
            mLoginDlg.ShowDialog();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mLoginDlg != null)
                mLoginDlg.Dispose();
        }
    }
}
