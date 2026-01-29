namespace Calculator
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonDot = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonClear = new Button();
            buttonDel = new Button();
            buttonR = new Button();
            label1 = new Label();
            buttonUm = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(458, 48);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 121);
            button1.Name = "button1";
            button1.Size = new Size(87, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(105, 121);
            button2.Name = "button2";
            button2.Size = new Size(87, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(198, 121);
            button3.Name = "button3";
            button3.Size = new Size(87, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(12, 177);
            button4.Name = "button4";
            button4.Size = new Size(87, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F);
            button5.Location = new Point(105, 177);
            button5.Name = "button5";
            button5.Size = new Size(87, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(198, 177);
            button6.Name = "button6";
            button6.Size = new Size(87, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(12, 233);
            button7.Name = "button7";
            button7.Size = new Size(87, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(105, 233);
            button8.Name = "button8";
            button8.Size = new Size(87, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F);
            button9.Location = new Point(198, 233);
            button9.Name = "button9";
            button9.Size = new Size(87, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14F);
            button10.Location = new Point(105, 289);
            button10.Name = "button10";
            button10.Size = new Size(87, 50);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Segoe UI", 14F);
            buttonDot.Location = new Point(198, 289);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(87, 50);
            buttonDot.TabIndex = 11;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 14F);
            buttonPlus.Location = new Point(291, 121);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(87, 50);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 14F);
            buttonMinus.Location = new Point(291, 177);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(87, 50);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += button11_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14F);
            buttonClear.Location = new Point(383, 121);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 50);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Segoe UI", 14F);
            buttonDel.Location = new Point(383, 233);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(87, 50);
            buttonDel.TabIndex = 15;
            buttonDel.Text = "/";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonR
            // 
            buttonR.Font = new Font("Segoe UI", 14F);
            buttonR.Location = new Point(291, 233);
            buttonR.Name = "buttonR";
            buttonR.Size = new Size(87, 50);
            buttonR.TabIndex = 16;
            buttonR.Text = "=";
            buttonR.UseVisualStyleBackColor = true;
            buttonR.Click += buttonR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(389, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 17;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // buttonUm
            // 
            buttonUm.Font = new Font("Segoe UI", 14F);
            buttonUm.Location = new Point(384, 177);
            buttonUm.Name = "buttonUm";
            buttonUm.Size = new Size(87, 50);
            buttonUm.TabIndex = 18;
            buttonUm.Text = "*";
            buttonUm.UseVisualStyleBackColor = true;
            buttonUm.Click += buttonUm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 350);
            Controls.Add(buttonUm);
            Controls.Add(label1);
            Controls.Add(buttonR);
            Controls.Add(buttonDel);
            Controls.Add(buttonClear);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDot);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonDot;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonClear;
        private Button buttonDel;
        private Button buttonR;
        private Label label1;
        private Button buttonUm;
    }
}
