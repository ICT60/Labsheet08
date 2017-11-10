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

        void MainForm_Load(object sender, EventArgs e)
        {
            _Initialize();
        }

        void btnRun_Click(object sender, EventArgs e)
        {
            _UpdateUI();
        }

        void _Initialize()
        {
            lblPlusResult.Text = String.Empty;
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
            if (txtMessage.Text.Length > 0)
            {
                var message = String.Format("You enter text : \n \"{0}\"", txtMessage.Text);
                MessageBox.Show(message,
                    "Message Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You didn't enter any text..",
                    "Message Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
