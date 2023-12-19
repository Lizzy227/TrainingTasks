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
            tbBothEvents = new TextBox();
            btnStartLogs = new Button();
            btnStopLogs = new Button();
            btnStopEvenCallback = new Button();
            btnStartEvenCallback = new Button();
            tbEvenEvents = new TextBox();
            lbBoth = new Label();
            lbEven = new Label();
            lbOdd = new Label();
            btnStopOddCallback = new Button();
            btnStartOddCallback = new Button();
            tbOddEvents = new TextBox();
            SuspendLayout();
            // 
            // tbBothEvents
            // 
            tbBothEvents.Location = new Point(53, 110);
            tbBothEvents.Multiline = true;
            tbBothEvents.Name = "tbBothEvents";
            tbBothEvents.Size = new Size(241, 410);
            tbBothEvents.TabIndex = 0;
            // 
            // btnStartLogs
            // 
            btnStartLogs.Location = new Point(53, 71);
            btnStartLogs.Name = "btnStartLogs";
            btnStartLogs.Size = new Size(107, 23);
            btnStartLogs.TabIndex = 1;
            btnStartLogs.Text = "Start";
            btnStartLogs.UseVisualStyleBackColor = true;
            btnStartLogs.Click += btnStartBoth_Click;
            // 
            // btnStopLogs
            // 
            btnStopLogs.Location = new Point(187, 71);
            btnStopLogs.Name = "btnStopLogs";
            btnStopLogs.Size = new Size(107, 23);
            btnStopLogs.TabIndex = 2;
            btnStopLogs.Text = "Stop";
            btnStopLogs.UseVisualStyleBackColor = true;
            btnStopLogs.Click += btnStopBoth_Click;
            // 
            // btnStopEvenCallback
            // 
            btnStopEvenCallback.Location = new Point(535, 71);
            btnStopEvenCallback.Name = "btnStopEvenCallback";
            btnStopEvenCallback.Size = new Size(107, 23);
            btnStopEvenCallback.TabIndex = 5;
            btnStopEvenCallback.Text = "Stop";
            btnStopEvenCallback.UseVisualStyleBackColor = true;
            btnStopEvenCallback.Click += btnStopEven_Click;
            // 
            // btnStartEvenCallback
            // 
            btnStartEvenCallback.Location = new Point(401, 71);
            btnStartEvenCallback.Name = "btnStartEvenCallback";
            btnStartEvenCallback.Size = new Size(107, 23);
            btnStartEvenCallback.TabIndex = 4;
            btnStartEvenCallback.Text = "Start";
            btnStartEvenCallback.UseVisualStyleBackColor = true;
            btnStartEvenCallback.Click += btnStartEven_Click;
            // 
            // tbEvenEvents
            // 
            tbEvenEvents.Location = new Point(401, 110);
            tbEvenEvents.Multiline = true;
            tbEvenEvents.Name = "tbEvenEvents";
            tbEvenEvents.Size = new Size(241, 410);
            tbEvenEvents.TabIndex = 3;
            // 
            // lbBoth
            // 
            lbBoth.AutoSize = true;
            lbBoth.Location = new Point(153, 20);
            lbBoth.Name = "lbBoth";
            lbBoth.Size = new Size(32, 15);
            lbBoth.TabIndex = 6;
            lbBoth.Text = "Both";
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
            btnStopOddCallback.Click += btnStopOdd_Click;
            // 
            // btnStartOddCallback
            // 
            btnStartOddCallback.Location = new Point(749, 71);
            btnStartOddCallback.Name = "btnStartOddCallback";
            btnStartOddCallback.Size = new Size(107, 23);
            btnStartOddCallback.TabIndex = 9;
            btnStartOddCallback.Text = "Start";
            btnStartOddCallback.UseVisualStyleBackColor = true;
            btnStartOddCallback.Click += btnStartOdd_Click;
            // 
            // tbOddEvents
            // 
            tbOddEvents.Location = new Point(749, 110);
            tbOddEvents.Multiline = true;
            tbOddEvents.Name = "tbOddEvents";
            tbOddEvents.Size = new Size(241, 410);
            tbOddEvents.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 610);
            Controls.Add(lbOdd);
            Controls.Add(btnStopOddCallback);
            Controls.Add(btnStartOddCallback);
            Controls.Add(tbOddEvents);
            Controls.Add(lbEven);
            Controls.Add(lbBoth);
            Controls.Add(btnStopEvenCallback);
            Controls.Add(btnStartEvenCallback);
            Controls.Add(tbEvenEvents);
            Controls.Add(btnStopLogs);
            Controls.Add(btnStartLogs);
            Controls.Add(tbBothEvents);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBothEvents;
        private Button btnStartLogs;
        private Button btnStopLogs;
        private Button btnStopEvenCallback;
        private Button btnStartEvenCallback;
        private TextBox tbEvenEvents;
        private Label lbBoth;
        private Label lbEven;
        private Label lbOdd;
        private Button btnStopOddCallback;
        private Button btnStartOddCallback;
        private TextBox tbOddEvents;
    }
}
