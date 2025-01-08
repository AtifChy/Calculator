using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendText(string text)
        {
            txtDisplay.Text += text;
            ScrollToEnd();
        }

        private void ScrollToEnd()
        {
            txtDisplay.SelectionStart = txtDisplay.Text.Length;
            txtDisplay.ScrollToCaret();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AppendText("9");
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            AppendText("00");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendText("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            AppendText(".");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            AppendText("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AppendText("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AppendText("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AppendText("/");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(txtDisplay.Text, null);
                var numericResult = Convert.ToDouble(result);

                // Display the result with 6 decimal places
                txtDisplay.Text = numericResult.ToString("G6");
            }
            catch
            {
                txtDisplay.Text = @"Error";
            }

            ScrollToEnd();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnResult.PerformClick();
            }
        }
    }
}
