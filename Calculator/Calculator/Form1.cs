using static System.Windows.Forms.AxHost;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox equationBox;
        private TextBox answerBox;

        private string currentNumber = "";
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewOperation = true;

        public Form1()
        {
            InitializeComponent();
            Text = "Calculator";
            this.BackColor = Color.Azure;
            this.Width = 570;
            this.Height = 700;
            this.StartPosition = FormStartPosition.CenterScreen;

            equationBox = new TextBox();
            equationBox.Location = new Point(20, 10);
            equationBox.Size = new Size(300, 30);
            equationBox.TextAlign = HorizontalAlignment.Right;
            equationBox.ReadOnly = true;
            equationBox.Font = new Font("Arial", 12);
            this.Controls.Add(equationBox);

            answerBox = new TextBox();
            answerBox.Location = new Point(325, 10);
            answerBox.Size = new Size(100, 30);
            answerBox.TextAlign = HorizontalAlignment.Center;
            answerBox.ReadOnly = true;
            answerBox.Font = new Font("Arial", 12);
            this.Controls.Add(answerBox);

            string[,] numArr =
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" },
                {"","0",""}
            };

            int startX = 20;
            int startY = 50;
            int buttonWidth = 100;
            int buttonHeight = 40;
            int spacing = 10;

            for(int row = 0; row < 4; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    string num = numArr[row, column];
                    Button numButton = new Button();
                    numButton.BackColor = Color.LightGray;
                    numButton.ForeColor = Color.DarkGray;
                    numButton.Font = new Font("Arial", 12);
                    numButton.Location = new Point
                        (
                        startX + column * (buttonWidth + spacing),
                        startY + row * (buttonHeight + spacing)
                        );
                    numButton.Size = new Size(buttonWidth, buttonHeight);
                    numButton.Text = num;
                    numButton.Click += numButton_Click;
                    this.Controls.Add(numButton);
                }
            }

            string[] operArr = { "+", "-", "*", "/", "=", "C" };

            int operStartX = 350;
            int operStartY = 50;

            for(int i = 0; i < operArr.Length; i++)
            {
                Button operationButton = new Button();
                operationButton.ForeColor = Color.DarkGray;
                operationButton.BackColor = Color.Black;
                operationButton.Location = new Point(operStartX, operStartY + i * (buttonHeight + spacing));
                operationButton.Size = new Size(100, buttonHeight);
                operationButton.Text = operArr[i];
                operationButton.Click += OperationButton_Click;
                this.Controls.Add(operationButton);
            }

            Button decimalButton = new Button();
            decimalButton.BackColor = Color.LightGray;
            decimalButton.ForeColor = Color.Black;
            decimalButton.Font = new Font("Arial", 12);
            decimalButton.Location = new Point(20, startY + 4 * (buttonHeight + spacing));
            decimalButton.Size = new Size(buttonWidth, buttonHeight);
            decimalButton.Text = ".";
            decimalButton.Click += numButton_Click;
            this.Controls.Add(decimalButton);

            Button signButton = new Button();
            signButton.BackColor = Color.LightGray;
            signButton.ForeColor = Color.Black;
            signButton.Font = new Font("Arial", 12);
            signButton.Location = new Point(120, startY + 4 * (buttonHeight + spacing));
            signButton.Size = new Size(buttonWidth, buttonHeight);
            signButton.Text = "+/-";
            signButton.Click += SignButton_Click;
            this.Controls.Add(signButton);
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                currentNumber += button.Text;
                equationBox.Text += button.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            switch (button.Text)
            {
                case "C":
                    ClearCalculator();
                    break;

                case "=":
                    CalculateResult();
                    break;

                default:
                    if (!string.IsNullOrEmpty(currentNumber))
                    {
                        if (isNewOperation)
                        {
                            firstNumber = double.Parse(currentNumber);
                            operation = button.Text;
                            equationBox.Text += " " + button.Text + " ";
                            currentNumber = "";
                            isNewOperation = false;
                        }
                        else
                        {
                            CalculateResult();
                            firstNumber = double.Parse(answerBox.Text);
                            operation = button.Text;
                            equationBox.Text = answerBox.Text + " " + button.Text + " ";
                            currentNumber = "";
                        }
                    }
                    break;
            }
        }

        private void CalculateResult()
        {
            if (!string.IsNullOrEmpty(currentNumber) && !string.IsNullOrEmpty(operation))
            {
                double secondNumber = double.Parse(currentNumber);
                double result = 0;

                switch (operation)
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
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            answerBox.Text = "Error";
                            return;
                        }
                        break;
                }
                answerBox.Text = result.ToString();
                equationBox.Text = $"{firstNumber} {operation} {secondNumber} =";
                currentNumber = result.ToString();
                isNewOperation = true;
            }
        }

        private void ClearCalculator()
        {
            equationBox.Text = "";
            answerBox.Text = "";
            currentNumber = "";
            firstNumber = 0;
            operation = "";
            isNewOperation = true;
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber))
            {
                if (currentNumber.StartsWith("-"))
                {
                    currentNumber = currentNumber.Substring(1);
                }
                else
                {
                    currentNumber = "-" + currentNumber;
                }

                string currentEquation = equationBox.Text;
                int lastSpaceIndex = currentEquation.LastIndexOf(' ');

                if (lastSpaceIndex > 0)
                {
                    equationBox.Text = currentEquation.Substring(0, lastSpaceIndex + 1) + currentNumber;
                }
                else
                {
                    equationBox.Text = currentNumber;
                }
            }
        }
    }
}
