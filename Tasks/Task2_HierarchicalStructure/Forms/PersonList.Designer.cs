namespace Task2_HierarchicalStructure
{
    partial class PersonList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            addPersonButton = new ReaLTaiizor.Controls.CrownButton();
            removePersonButton = new ReaLTaiizor.Controls.CrownButton();
            editPersonButton = new ReaLTaiizor.Controls.CrownButton();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            personDataGridView = new DataGridView();
            manageRelationshipsButton = new ReaLTaiizor.Controls.CrownButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(57, 48);
            addPersonButton.Margin = new Padding(2, 1, 2, 1);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Padding = new Padding(3, 2, 3, 2);
            addPersonButton.Size = new Size(137, 23);
            addPersonButton.TabIndex = 0;
            addPersonButton.Text = "Add Person";
            addPersonButton.Click += addPersonButton_Click;
            // 
            // removePersonButton
            // 
            removePersonButton.Location = new Point(211, 48);
            removePersonButton.Margin = new Padding(2, 1, 2, 1);
            removePersonButton.Name = "removePersonButton";
            removePersonButton.Padding = new Padding(3, 2, 3, 2);
            removePersonButton.Size = new Size(137, 23);
            removePersonButton.TabIndex = 1;
            removePersonButton.Text = "Remove Person";
            removePersonButton.Click += removePersonButton_Click;
            // 
            // editPersonButton
            // 
            editPersonButton.Location = new Point(366, 48);
            editPersonButton.Margin = new Padding(2, 1, 2, 1);
            editPersonButton.Name = "editPersonButton";
            editPersonButton.Padding = new Padding(3, 2, 3, 2);
            editPersonButton.Size = new Size(137, 23);
            editPersonButton.TabIndex = 3;
            editPersonButton.Text = "Edit Person";
            editPersonButton.Click += editPersonButton_Click;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(58, 90);
            crownLabel1.Margin = new Padding(2, 0, 2, 0);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(67, 15);
            crownLabel1.TabIndex = 4;
            crownLabel1.Text = "Person List:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 21);
            panel1.TabIndex = 5;
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
            nightControlBox1.Location = new Point(653, 0);
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
            label1.Location = new Point(7, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 2;
            label1.Text = "Person List";
            // 
            // personDataGridView
            // 
            personDataGridView.BackgroundColor = Color.FromArgb(23, 24, 29);
            personDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            personDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            personDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            personDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            personDataGridView.GridColor = SystemColors.ControlDarkDark;
            personDataGridView.Location = new Point(57, 127);
            personDataGridView.Margin = new Padding(2, 1, 2, 1);
            personDataGridView.Name = "personDataGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            personDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            personDataGridView.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(23, 24, 29);
            personDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            personDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            personDataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.Control;
            personDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.MenuHighlight;
            personDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Control;
            personDataGridView.RowTemplate.Height = 37;
            personDataGridView.Size = new Size(620, 161);
            personDataGridView.TabIndex = 6;
            personDataGridView.SelectionChanged += personDataGridView_SelectionChanged;
            // 
            // manageRelationshipsButton
            // 
            manageRelationshipsButton.Location = new Point(522, 48);
            manageRelationshipsButton.Margin = new Padding(2, 1, 2, 1);
            manageRelationshipsButton.Name = "manageRelationshipsButton";
            manageRelationshipsButton.Padding = new Padding(3, 2, 3, 2);
            manageRelationshipsButton.Size = new Size(155, 23);
            manageRelationshipsButton.TabIndex = 7;
            manageRelationshipsButton.Text = "Manage Relationships";
            manageRelationshipsButton.Click += manageRelationshipsButton_Click;
            // 
            // PersonList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(727, 314);
            Controls.Add(manageRelationshipsButton);
            Controls.Add(personDataGridView);
            Controls.Add(panel1);
            Controls.Add(crownLabel1);
            Controls.Add(editPersonButton);
            Controls.Add(removePersonButton);
            Controls.Add(addPersonButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "PersonList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2_HierarchicalStructure";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton addPersonButton;
        private ReaLTaiizor.Controls.CrownButton removePersonButton;
        private ReaLTaiizor.Controls.CrownButton editPersonButton;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private DataGridView personDataGridView;
        private ReaLTaiizor.Controls.CrownButton editRelationshipsButton;
        private ReaLTaiizor.Controls.CrownButton manageRelationshipsButton;
    }
}