namespace Task3_ExpressionEvaluator
{
    partial class ExpressionEvaluatorMain
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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            EvaluateButton = new ReaLTaiizor.Controls.CrownButton();
            expressionTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            EvaluationBoolLabel = new ReaLTaiizor.Controls.CrownLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 6;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(661, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(231, 32);
            label1.TabIndex = 2;
            label1.Text = "Expression Evaluator";
            // 
            // EvaluateButton
            // 
            EvaluateButton.Location = new Point(269, 285);
            EvaluateButton.Name = "EvaluateButton";
            EvaluateButton.Padding = new Padding(5);
            EvaluateButton.Size = new Size(234, 46);
            EvaluateButton.TabIndex = 8;
            EvaluateButton.Text = "Evaluate";
            EvaluateButton.Click += EvaluateButton_Click;
            // 
            // expressionTextbox
            // 
            expressionTextbox.BackColor = Color.FromArgb(69, 73, 74);
            expressionTextbox.BorderStyle = BorderStyle.FixedSingle;
            expressionTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            expressionTextbox.Location = new Point(211, 145);
            expressionTextbox.Name = "expressionTextbox";
            expressionTextbox.Size = new Size(365, 35);
            expressionTextbox.TabIndex = 9;
            // 
            // EvaluationBoolLabel
            // 
            EvaluationBoolLabel.AutoSize = true;
            EvaluationBoolLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EvaluationBoolLabel.ForeColor = Color.FromArgb(220, 220, 220);
            EvaluationBoolLabel.Location = new Point(346, 210);
            EvaluationBoolLabel.Name = "EvaluationBoolLabel";
            EvaluationBoolLabel.Size = new Size(69, 30);
            EvaluationBoolLabel.TabIndex = 10;
            EvaluationBoolLabel.Text = "Result";
            // 
            // ExpressionEvaluatorMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(800, 450);
            Controls.Add(EvaluationBoolLabel);
            Controls.Add(expressionTextbox);
            Controls.Add(EvaluateButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExpressionEvaluatorMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expression Evaluator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CrownButton EvaluateButton;
        private ReaLTaiizor.Controls.CrownTextBox expressionTextbox;
        private ReaLTaiizor.Controls.CrownLabel EvaluationBoolLabel;
    }
}