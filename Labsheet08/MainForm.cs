using System;
using System.Windows.Forms;

namespace Labsheet08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void btnRun_Click(object sender, EventArgs e)
        {
            _UpdateUI();
        }

        void _UpdateUI()
        {
            _UpdatePlus();
            _UpdateMinus();
            _UpdateMutiply();
            _UpdateDivide();
            _UpdateMessage();
        }

        void _UpdatePlus()
        {

        }

        void _UpdateMinus()
        {

        }

        void _UpdateMutiply()
        {

        }

        void _UpdateDivide()
        {

        }

        void _UpdateMessage()
        {

        }
    }
}
