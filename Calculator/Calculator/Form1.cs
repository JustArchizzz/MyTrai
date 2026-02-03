using System.Diagnostics.Tracing;
using System.Windows.Forms;
using System.Drawing;
using System.CodeDom;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox equationBox;
        private TextBox answerBox;

        private string currentNumber;
        private int firstNumber = 0;
        private string operation;

        public Form1()
        {
            InitializeComponent();
            Text = "Calculator";
            this.BackColor = Color.Azure;
            this.Width = 570;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;


            Button Button1 = new Button();
            Button1.BackColor = Color.LightGray;
            Button1.ForeColor = Color.DarkGray;
            Button1.Location = new Point(20, 50);
            Button1.Size = new Size(100, 40);
            Button1.Text = "1";
            Button1.Click += ButtonNumber_Click;
            this.Controls.Add(Button1);

            Button Button2 = new Button();
            Button2.BackColor = Color.LightGray;
            Button2.ForeColor = Color.DarkGray;
            Button2.Location = new Point(120, 50);
            Button2.Size = new Size(100, 40);
            Button2.Text = "2";
            Button2.Click += ButtonNumber_Click;
            this.Controls.Add(Button2);

            Button Button3 = new Button();
            Button3.BackColor = Color.LightGray;
            Button3.ForeColor = Color.DarkGray;
            Button3.Location = new Point(220, 50);
            Button3.Size = new Size(100, 40);
            Button3.Text = "3";
            Button3.Click += ButtonNumber_Click;
            this.Controls.Add(Button3);

            Button Button4 = new Button();
            Button4.BackColor = Color.LightGray;
            Button4.ForeColor = Color.DarkGray;
            Button4.Location = new Point(20, 90);
            Button4.Size = new Size(100, 40);
            Button4.Text = "4";
            Button4.Click += ButtonNumber_Click;
            this.Controls.Add(Button4);

            Button Button5 = new Button();
            Button5.BackColor = Color.LightGray;
            Button5.ForeColor = Color.DarkGray;
            Button5.Location = new Point(120, 90);
            Button5.Size = new Size(100, 40);
            Button5.Text = "5";
            Button5.Click += ButtonNumber_Click;
            this.Controls.Add(Button5);

            Button Button6 = new Button();
            Button6.BackColor = Color.LightGray;
            Button6.ForeColor = Color.DarkGray;
            Button6.Location = new Point(220, 90);
            Button6.Size = new Size(100, 40);
            Button6.Text = "6";
            Button6.Click += ButtonNumber_Click;
            this.Controls.Add(Button6);

            Button Button7 = new Button();
            Button7.BackColor = Color.LightGray;
            Button7.ForeColor = Color.DarkGray;
            Button7.Location = new Point(20, 130);
            Button7.Size = new Size(100, 40);
            Button7.Text = "7";
            Button7.Click += ButtonNumber_Click;
            this.Controls.Add(Button7);

            Button Button8 = new Button();
            Button8.BackColor = Color.LightGray;
            Button8.ForeColor = Color.DarkGray;
            Button8.Location = new Point(120, 130);
            Button8.Size = new Size(100, 40);
            Button8.Text = "8";
            Button8.Click += ButtonNumber_Click;
            this.Controls.Add(Button8);

            Button Button9 = new Button();
            Button9.BackColor = Color.LightGray;
            Button9.ForeColor = Color.DarkGray;
            Button9.Location = new Point(220, 130);
            Button9.Size = new Size(100, 40);
            Button9.Text = "9";
            Button9.Click += ButtonNumber_Click;
            this.Controls.Add(Button9);

            Button Button0 = new Button();
            Button0.BackColor = Color.LightGray;
            Button0.ForeColor = Color.DarkGray;
            Button0.Location = new Point(120, 170);
            Button0.Size = new Size(100, 40);
            Button0.Text = "0";
            Button0.Click += ButtonNumber_Click;
            this.Controls.Add(Button0);

            equationBox = new TextBox();
            equationBox.Location = new Point(20, 10);
            equationBox.Size = new Size(200, 30);
            equationBox.TextAlign = HorizontalAlignment.Right;
            equationBox.ReadOnly = true;
            this.Controls.Add(equationBox);

            answerBox = new TextBox();
            answerBox.Location = new Point(225, 10);
            answerBox.Size = new Size(90, 30);
            answerBox.TextAlign = HorizontalAlignment.Center;
            answerBox.ReadOnly = true;
            this.Controls.Add(answerBox);

            Button buttonMultiply = new Button();
            buttonMultiply.BackColor = Color.LightGray;
            buttonMultiply.ForeColor = Color.DarkGray;
            buttonMultiply.Location = new Point(320, 50);
            buttonMultiply.Size = new Size(100, 40);
            buttonMultiply.Text = "*";
            buttonMultiply.Click += ButtonOperation_Click;
            this.Controls.Add(buttonMultiply);
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            try
            {
                equationBox.Text += button.Text;
                currentNumber += Convert.ToInt32(button.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            try
            {
                switch (button.Text)
                {
                    case "+":
                        break;
                    case "-":
                        break;
                    case "*":
                        break;
                    case "/":
                        break;
                    case "C":
                        break;
                    case "=":
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Calculate()
        {
            double secondNumber = double.Parse(currentNumber);
            double result = 0;

            switch(operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    try { result = firstNumber / secondNumber; } catch { answerBox.Text = "((\\infty \\)"; }
                    break;
            }
        }
    }
}
