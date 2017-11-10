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

            lblMultiplyResult.Text = "0";
            txtNumMultiplyA.Text = "0";
            txtNumMultiplyB.Text = "0";

            lblDivideResult.Text = "0";
            txtNumDivideA.Text = "0";
            txtNumDivideB.Text = "1";
        }

        void _UpdateUI()
        {
            _UpdatePlus();
            _UpdateMinus();
            _UpdateMultiply();
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
                lblPlusResult.Text = "Error, Please enter only number.";
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
                lblMinusResult.Text = "Error, Please enter only number.";
            }
        }

        void _UpdateMultiply()
        {
            decimal numA;
            decimal numB;

            var isCanParseA = decimal.TryParse(txtNumMultiplyA.Text, out numA);
            var isCanParseB = decimal.TryParse(txtNumMultiplyB.Text, out numB);

            if (isCanParseA && isCanParseB) {
                try {
                    lblMultiplyResult.Text = (numA * numB).ToString();
                }
                catch (OverflowException e) {
                    lblMultiplyResult.Text = "Overflow..";
                }
            }
            else {
                lblMultiplyResult.Text = "Error, Please enter only number.";
            }
        }

        void _UpdateDivide()
        {
            decimal numA;
            decimal numB;

            var isCanParseA = decimal.TryParse(txtNumDivideA.Text, out numA);
            var isCanParseB = decimal.TryParse(txtNumDivideB.Text, out numB);

            if (isCanParseA && isCanParseB) {
                try {
                    lblDivideResult.Text = (numA / numB).ToString();
                }
                catch (OverflowException e) {
                    lblDivideResult.Text = "Overflow..";
                }
                catch (DivideByZeroException e) {
                    lblDivideResult.Text = "Number B can't be : 0";
                }
            }
            else {
                lblDivideResult.Text = "Error, Please enter only number.";
            }
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
