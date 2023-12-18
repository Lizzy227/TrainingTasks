namespace CallbacksTask
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
            textBoxLogs = new TextBox();
            btnStartLogs = new Button();
            btnStopLogs = new Button();
            btnStopEvenCallback = new Button();
            btnStartEvenCallback = new Button();
            textBox1 = new TextBox();
            lbAll = new Label();
            lbEven = new Label();
            lbOdd = new Label();
            btnStopOddCallback = new Button();
            btnStartOddCallback = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBoxLogs
            // 
            textBoxLogs.Location = new Point(53, 110);
            textBoxLogs.Multiline = true;
            textBoxLogs.Name = "textBoxLogs";
            textBoxLogs.Size = new Size(241, 410);
            textBoxLogs.TabIndex = 0;
            // 
            // btnStartLogs
            // 
            btnStartLogs.Location = new Point(53, 71);
            btnStartLogs.Name = "btnStartLogs";
            btnStartLogs.Size = new Size(107, 23);
            btnStartLogs.TabIndex = 1;
            btnStartLogs.Text = "Start";
            btnStartLogs.UseVisualStyleBackColor = true;
            btnStartLogs.Click += btnStartLogs_Click;
            // 
            // btnStopLogs
            // 
            btnStopLogs.Location = new Point(187, 71);
            btnStopLogs.Name = "btnStopLogs";
            btnStopLogs.Size = new Size(107, 23);
            btnStopLogs.TabIndex = 2;
            btnStopLogs.Text = "Stop";
            btnStopLogs.UseVisualStyleBackColor = true;
            btnStopLogs.Click += btnStopLogs_Click;
            // 
            // btnStopEvenCallback
            // 
            btnStopEvenCallback.Location = new Point(535, 71);
            btnStopEvenCallback.Name = "btnStopEvenCallback";
            btnStopEvenCallback.Size = new Size(107, 23);
            btnStopEvenCallback.TabIndex = 5;
            btnStopEvenCallback.Text = "Stop";
            btnStopEvenCallback.UseVisualStyleBackColor = true;
            btnStopEvenCallback.Click += btnStopEvenCallback_Click;
            // 
            // btnStartEvenCallback
            // 
            btnStartEvenCallback.Location = new Point(401, 71);
            btnStartEvenCallback.Name = "btnStartEvenCallback";
            btnStartEvenCallback.Size = new Size(107, 23);
            btnStartEvenCallback.TabIndex = 4;
            btnStartEvenCallback.Text = "Start";
            btnStartEvenCallback.UseVisualStyleBackColor = true;
            btnStartEvenCallback.Click += btnStartEvenCallback_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 110);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 410);
            textBox1.TabIndex = 3;
            // 
            // lbAll
            // 
            lbAll.AutoSize = true;
            lbAll.Location = new Point(153, 20);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(21, 15);
            lbAll.TabIndex = 6;
            lbAll.Text = "All";
            // 
            // lbEven
            // 
            lbEven.AutoSize = true;
            lbEven.Location = new Point(500, 20);
            lbEven.Name = "lbEven";
            lbEven.Size = new Size(32, 15);
            lbEven.TabIndex = 7;
            lbEven.Text = "Even";
            // 
            // lbOdd
            // 
            lbOdd.AutoSize = true;
            lbOdd.Location = new Point(846, 20);
            lbOdd.Name = "lbOdd";
            lbOdd.Size = new Size(30, 15);
            lbOdd.TabIndex = 11;
            lbOdd.Text = "Odd";
            // 
            // btnStopOddCallback
            // 
            btnStopOddCallback.Location = new Point(883, 71);
            btnStopOddCallback.Name = "btnStopOddCallback";
            btnStopOddCallback.Size = new Size(107, 23);
            btnStopOddCallback.TabIndex = 10;
            btnStopOddCallback.Text = "Stop";
            btnStopOddCallback.UseVisualStyleBackColor = true;
            // 
            // btnStartOddCallback
            // 
            btnStartOddCallback.Location = new Point(749, 71);
            btnStartOddCallback.Name = "btnStartOddCallback";
            btnStartOddCallback.Size = new Size(107, 23);
            btnStartOddCallback.TabIndex = 9;
            btnStartOddCallback.Text = "Start";
            btnStartOddCallback.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(749, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 410);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 610);
            Controls.Add(lbOdd);
            Controls.Add(btnStopOddCallback);
            Controls.Add(btnStartOddCallback);
            Controls.Add(textBox2);
            Controls.Add(lbEven);
            Controls.Add(lbAll);
            Controls.Add(btnStopEvenCallback);
            Controls.Add(btnStartEvenCallback);
            Controls.Add(textBox1);
            Controls.Add(btnStopLogs);
            Controls.Add(btnStartLogs);
            Controls.Add(textBoxLogs);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogs;
        private Button btnStartLogs;
        private Button btnStopLogs;
        private Button btnStopEvenCallback;
        private Button btnStartEvenCallback;
        private TextBox textBox1;
        private Label lbAll;
        private Label lbEven;
        private Label lbOdd;
        private Button btnStopOddCallback;
        private Button btnStartOddCallback;
        private TextBox textBox2;
    }
}
