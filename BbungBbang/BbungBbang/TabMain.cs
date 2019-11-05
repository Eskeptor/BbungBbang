using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BbungBbang
{
    public partial class TabMain : Form
    {
        public delegate void DelegateChangePage(int nPage);

        public event DelegateChangePage DelegatePage;

        public TabMain()
        {
            InitializeComponent();
        }

        private void TabMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
