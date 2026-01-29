namespace Calculator
{
    public partial class Form1 : Form
    {
        float a, b;
        string oper;
        bool znak = true;

        private void Do()
        {
            switch (oper)
            {
                case "+":
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "-":
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "*":
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "/":

                    if (float.Parse(textBox1.Text) == 0)
                    { textBox1.Text = "Делить на 0 нельзя!"; }
                    else
                    {
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                default:
                    break;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            oper = "-";
            label1.Text = a.ToString() + " - ";
            znak = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            oper = "/";
            label1.Text = a.ToString() + " / ";
            znak = true;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            Do();
            label1.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            oper = "+";
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            oper = "*";
            label1.Text = a.ToString() + "*";
            znak = true;
        }
    }
}
