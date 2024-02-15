namespace LiveChartsTest
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
            chkDiagnostics = new CheckBox();
            panel1 = new Panel();
            chkUnsuccessfulSessions = new CheckBox();
            chkSuccessfulSessions = new CheckBox();
            chkWarning = new CheckBox();
            chkError = new CheckBox();
            lblVisibility = new Label();
            btnResetZoomAndPan = new Button();
            lblZoomAndPan = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkDiagnostics
            // 
            chkDiagnostics.AutoSize = true;
            chkDiagnostics.Location = new Point(3, 13);
            chkDiagnostics.Name = "chkDiagnostics";
            chkDiagnostics.Size = new Size(87, 19);
            chkDiagnostics.TabIndex = 0;
            chkDiagnostics.Text = "Diagnostics";
            chkDiagnostics.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(chkUnsuccessfulSessions);
            panel1.Controls.Add(chkSuccessfulSessions);
            panel1.Controls.Add(chkWarning);
            panel1.Controls.Add(chkError);
            panel1.Controls.Add(chkDiagnostics);
            panel1.Location = new Point(776, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 174);
            panel1.TabIndex = 1;
            // 
            // chkUnsuccessfulSessions
            // 
            chkUnsuccessfulSessions.AutoSize = true;
            chkUnsuccessfulSessions.Location = new Point(3, 152);
            chkUnsuccessfulSessions.Name = "chkUnsuccessfulSessions";
            chkUnsuccessfulSessions.Size = new Size(142, 19);
            chkUnsuccessfulSessions.TabIndex = 4;
            chkUnsuccessfulSessions.Text = "Unsuccessful Sessions";
            chkUnsuccessfulSessions.UseVisualStyleBackColor = true;
            // 
            // chkSuccessfulSessions
            // 
            chkSuccessfulSessions.AutoSize = true;
            chkSuccessfulSessions.Location = new Point(3, 116);
            chkSuccessfulSessions.Name = "chkSuccessfulSessions";
            chkSuccessfulSessions.Size = new Size(128, 19);
            chkSuccessfulSessions.TabIndex = 3;
            chkSuccessfulSessions.Text = "Successful Sessions";
            chkSuccessfulSessions.UseVisualStyleBackColor = true;
            // 
            // chkWarning
            // 
            chkWarning.AutoSize = true;
            chkWarning.Location = new Point(3, 82);
            chkWarning.Name = "chkWarning";
            chkWarning.Size = new Size(71, 19);
            chkWarning.TabIndex = 2;
            chkWarning.Text = "Warning";
            chkWarning.UseVisualStyleBackColor = true;
            // 
            // chkError
            // 
            chkError.AutoSize = true;
            chkError.Location = new Point(3, 47);
            chkError.Name = "chkError";
            chkError.Size = new Size(51, 19);
            chkError.TabIndex = 1;
            chkError.Text = "Error";
            chkError.UseVisualStyleBackColor = true;
            // 
            // lblVisibility
            // 
            lblVisibility.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVisibility.AutoSize = true;
            lblVisibility.Location = new Point(802, 31);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(89, 15);
            lblVisibility.TabIndex = 2;
            lblVisibility.Text = "Toggle Visibility";
            // 
            // btnResetZoomAndPan
            // 
            btnResetZoomAndPan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetZoomAndPan.Location = new Point(776, 271);
            btnResetZoomAndPan.Name = "btnResetZoomAndPan";
            btnResetZoomAndPan.Size = new Size(143, 23);
            btnResetZoomAndPan.TabIndex = 3;
            btnResetZoomAndPan.Text = "Reset";
            btnResetZoomAndPan.UseVisualStyleBackColor = true;
            btnResetZoomAndPan.Click += btnResetZoomAndPan_Click;
            // 
            // lblZoomAndPan
            // 
            lblZoomAndPan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblZoomAndPan.AutoSize = true;
            lblZoomAndPan.Location = new Point(802, 244);
            lblZoomAndPan.Name = "lblZoomAndPan";
            lblZoomAndPan.Size = new Size(85, 15);
            lblZoomAndPan.TabIndex = 4;
            lblZoomAndPan.Text = "Zoom and Pan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 596);
            Controls.Add(lblZoomAndPan);
            Controls.Add(btnResetZoomAndPan);
            Controls.Add(lblVisibility);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMaria;
        private Panel panel1;
        private CheckBox chkJohn;
        private CheckBox chkCharles;
        private Label lblVisibility;
        private CheckBox chkDiagnostics;
        private CheckBox chkWarning;
        private CheckBox chkError;
        private CheckBox chkUnsuccessfulSessions;
        private CheckBox chkSuccessfulSessions;
        private Button btnResetZoomAndPan;
        private Label lblZoomAndPan;
    }
}
