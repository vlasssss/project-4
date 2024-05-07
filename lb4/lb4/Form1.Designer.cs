namespace lb4
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
            Speed = new PictureBox();
            start = new Button();
            about = new Button();
            exit = new Button();
            main = new Label();
            a = new Label();
            b = new Label();
            V1aIn = new TextBox();
            V2aIn = new TextBox();
            V1bIn = new TextBox();
            resultText = new Label();
            result = new TextBox();
            V2bIn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Speed).BeginInit();
            SuspendLayout();
            // 
            // Speed
            // 
            Speed.Location = new Point(38, 72);
            Speed.Name = "Speed";
            Speed.Size = new Size(207, 272);
            Speed.TabIndex = 0;
            Speed.TabStop = false;
            Speed.Click += Tringle_Click;
            // 
            // start
            // 
            start.Location = new Point(456, 383);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 1;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += run_Click;
            // 
            // about
            // 
            about.Location = new Point(170, 383);
            about.Name = "about";
            about.Size = new Size(75, 23);
            about.TabIndex = 2;
            about.Text = "about";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // exit
            // 
            exit.Location = new Point(38, 383);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 3;
            exit.Text = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // main
            // 
            main.AutoSize = true;
            main.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            main.ForeColor = Color.Blue;
            main.Location = new Point(284, 41);
            main.Name = "main";
            main.Size = new Size(123, 21);
            main.TabIndex = 4;
            main.Text = "Швидкість V1";
            main.Click += label1_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 20.25F);
            a.ForeColor = Color.Purple;
            a.Location = new Point(284, 70);
            a.Name = "a";
            a.Size = new Size(71, 37);
            a.TabIndex = 5;
            a.Text = "км\\с";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 20.25F);
            b.ForeColor = Color.Purple;
            b.Location = new Point(285, 107);
            b.Name = "b";
            b.Size = new Size(70, 37);
            b.TabIndex = 7;
            b.Text = "мс\\с";
            b.Click += label4_Click;
            // 
            // V1aIn
            // 
            V1aIn.Location = new Point(361, 84);
            V1aIn.Name = "V1aIn";
            V1aIn.Size = new Size(46, 23);
            V1aIn.TabIndex = 8;
            V1aIn.TextChanged += textBox1_TextChanged;
            // 
            // V2aIn
            // 
            V2aIn.Location = new Point(361, 199);
            V2aIn.Name = "V2aIn";
            V2aIn.Size = new Size(46, 23);
            V2aIn.TabIndex = 9;
            V2aIn.TextChanged += V2aIn_TextChanged;
            // 
            // V1bIn
            // 
            V1bIn.Location = new Point(361, 122);
            V1bIn.Name = "V1bIn";
            V1bIn.Size = new Size(47, 23);
            V1bIn.TabIndex = 10;
            V1bIn.TextChanged += V1bIn_TextChanged;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultText.ForeColor = Color.Blue;
            resultText.Location = new Point(285, 164);
            resultText.Name = "resultText";
            resultText.Size = new Size(123, 21);
            resultText.TabIndex = 11;
            resultText.Text = "Швидкість V2";
            // 
            // result
            // 
            result.Location = new Point(283, 321);
            result.Name = "result";
            result.Size = new Size(247, 23);
            result.TabIndex = 12;
            // 
            // V2bIn
            // 
            V2bIn.Location = new Point(361, 238);
            V2bIn.Name = "V2bIn";
            V2bIn.Size = new Size(47, 23);
            V2bIn.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(284, 224);
            label1.Name = "label1";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 19;
            label1.Text = "мс\\с";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(283, 187);
            label2.Name = "label2";
            label2.Size = new Size(71, 37);
            label2.TabIndex = 18;
            label2.Text = "км\\с";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(285, 285);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 20;
            label3.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(V2bIn);
            Controls.Add(result);
            Controls.Add(resultText);
            Controls.Add(V1bIn);
            Controls.Add(V2aIn);
            Controls.Add(V1aIn);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(main);
            Controls.Add(exit);
            Controls.Add(about);
            Controls.Add(start);
            Controls.Add(Speed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Speed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Speed;
        private Button start;
        private Button about;
        private Button exit;
        private Label main;
        private Label a;
        private Label b;
        private TextBox V1aIn;
        private TextBox V2aIn;
        private TextBox V1bIn;
        private Label resultText;
        private TextBox result;
        private TextBox V2bIn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
