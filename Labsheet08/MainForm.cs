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
            lblPlusResult.Text = "0";
            txtNumPlusA.Text = "0";
            txtNumPlusB.Text = "0";

            lblMinusResult.Text = "0";
            txtNumMinusA.Text = "0";
            txtNumMinusB.Text = "0";
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
            decimal numA;
            decimal numB;

            var isCanParseA = decimal.TryParse(txtNumPlusA.Text, out numA);
            var isCanParseB = decimal.TryParse(txtNumPlusB.Text, out numB);

            if (isCanParseA && isCanParseB) {
                lblPlusResult.Text = (numA + numB).ToString();
            }
            else {
                lblPlusResult.Text = "Error~";
            }
        }

        void _UpdateMinus()
        {
            decimal numA;
            decimal numB;

            var isCanParseA = decimal.TryParse(txtNumMinusA.Text, out numA);
            var isCanParseB = decimal.TryParse(txtNumMinusB.Text, out numB);

            if (isCanParseA && isCanParseB) {
                lblMinusResult.Text = (numA - numB).ToString();
            }
            else {
                lblMinusResult.Text = "Error~";
            }
        }

        void _UpdateMutiply()
        {

        }

        void _UpdateDivide()
        {

        }

        void _UpdateMessage()
        {
            if (txtMessage.Text.Length > 0) {
                var message = String.Format("You enter text : \n \"{0}\"", txtMessage.Text);
                MessageBox.Show(message,
                    "Message Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("You didn't enter any text..",
                    "Message Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
