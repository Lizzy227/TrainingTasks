namespace Tasks
{
    partial class TasksMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksMenu));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            Task1Button = new ReaLTaiizor.Controls.CrownButton();
            crownButton2 = new ReaLTaiizor.Controls.CrownButton();
            crownButton3 = new ReaLTaiizor.Controls.CrownButton();
            crownButton4 = new ReaLTaiizor.Controls.CrownButton();
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
            panel1.Size = new Size(731, 41);
            panel1.TabIndex = 0;
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
            nightControlBox1.Location = new Point(592, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 2;
            label1.Text = "TASKS";
            label1.Click += label1_Click;
            // 
            // Task1Button
            // 
            Task1Button.Image = (Image)resources.GetObject("Task1Button.Image");
            Task1Button.Location = new Point(143, 177);
            Task1Button.Name = "Task1Button";
            Task1Button.Padding = new Padding(5);
            Task1Button.Size = new Size(194, 164);
            Task1Button.TabIndex = 1;
            Task1Button.Text = "Timer with Two Methods";
            Task1Button.TextImageRelation = TextImageRelation.ImageAboveText;
            Task1Button.Click += Task1Button_Click;
            // 
            // crownButton2
            // 
            crownButton2.Image = (Image)resources.GetObject("crownButton2.Image");
            crownButton2.Location = new Point(353, 177);
            crownButton2.Name = "crownButton2";
            crownButton2.Padding = new Padding(5);
            crownButton2.Size = new Size(194, 164);
            crownButton2.TabIndex = 2;
            crownButton2.Text = "Hierarchical Structure";
            crownButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // crownButton3
            // 
            crownButton3.Image = (Image)resources.GetObject("crownButton3.Image");
            crownButton3.Location = new Point(143, 360);
            crownButton3.Name = "crownButton3";
            crownButton3.Padding = new Padding(5);
            crownButton3.Size = new Size(194, 164);
            crownButton3.TabIndex = 3;
            crownButton3.Text = "Expression Evaluator";
            crownButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // crownButton4
            // 
            crownButton4.Image = (Image)resources.GetObject("crownButton4.Image");
            crownButton4.Location = new Point(353, 360);
            crownButton4.Name = "crownButton4";
            crownButton4.Padding = new Padding(5);
            crownButton4.Size = new Size(194, 164);
            crownButton4.TabIndex = 4;
            crownButton4.Text = "Orderbook";
            crownButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TasksMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(731, 674);
            Controls.Add(crownButton4);
            Controls.Add(crownButton3);
            Controls.Add(crownButton2);
            Controls.Add(Task1Button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TasksMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private ReaLTaiizor.Controls.CrownButton Task1Button;
        private ReaLTaiizor.Controls.CrownButton crownButton2;
        private ReaLTaiizor.Controls.CrownButton crownButton3;
        private ReaLTaiizor.Controls.CrownButton crownButton4;
    }
}