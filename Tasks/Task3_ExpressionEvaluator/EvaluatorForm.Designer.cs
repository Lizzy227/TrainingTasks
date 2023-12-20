namespace Task3_ExpressionEvaluator
{
    partial class EvaluatorForm
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
            btEvaluate = new Button();
            txbExpression = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btEvaluate
            // 
            btEvaluate.Location = new Point(206, 168);
            btEvaluate.Name = "btEvaluate";
            btEvaluate.Size = new Size(75, 23);
            btEvaluate.TabIndex = 0;
            btEvaluate.Text = "Evaluate";
            btEvaluate.UseVisualStyleBackColor = true;
            btEvaluate.Click += btEvaluate_Click;
            // 
            // txbExpression
            // 
            txbExpression.Location = new Point(149, 41);
            txbExpression.Name = "txbExpression";
            txbExpression.Size = new Size(186, 23);
            txbExpression.TabIndex = 1;
            txbExpression.KeyPress += txbExpression_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Fuchsia;
            lblResult.Location = new Point(206, 99);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 30);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // EvaluatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 236);
            Controls.Add(lblResult);
            Controls.Add(txbExpression);
            Controls.Add(btEvaluate);
            Name = "EvaluatorForm";
            Text = "Expression Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEvaluate;
        private TextBox txbExpression;
        private Label lblResult;
    }
}
