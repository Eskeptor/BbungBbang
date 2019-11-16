using System.Windows.Forms;

namespace BbungBbang
{
    public partial class TabMain : Form
    {
        public delegate void DelegateChangePage(int nPage);
        public delegate void DelegateTerminateProgram();

        public event DelegateChangePage DelegatePage;
        public event DelegateTerminateProgram DelegateTerminate;

        public TabMain()
        {
            InitializeComponent();
        }

        private void TabMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 종료 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtnExit_Click(object sender, System.EventArgs e)
        {
            DialogResult dResult = MessageBox.Show(Properties.Resources.String_Login_Main_Msg_Exit, Properties.Resources.String_Login_Msg_Warning, MessageBoxButtons.YesNo);
            
            if (dResult == DialogResult.Yes)
            {
                DelegateTerminate();
            }
        }
    }
}
