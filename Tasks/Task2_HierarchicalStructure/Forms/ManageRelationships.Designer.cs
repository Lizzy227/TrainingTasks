namespace Task2_HierarchicalStructure.Forms
{
    partial class ManageRelationships
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            mainPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            relationshipTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            relationshipTypeLabel = new ReaLTaiizor.Controls.CrownLabel();
            relatedPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            toLabel = new ReaLTaiizor.Controls.CrownLabel();
            cancelRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            removeRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            addRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            mainPersonTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            cbxNames = new ComboBox();
            mpRelationshipDataGridView = new DataGridView();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mpRelationshipDataGridView).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(686, 21);
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
            nightControlBox1.Location = new Point(547, 0);
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
            label1.Size = new Size(143, 19);
            label1.TabIndex = 2;
            label1.Text = "Manage Relationships";
            // 
            // mainPersonLabel
            // 
            mainPersonLabel.AutoSize = true;
            mainPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonLabel.Location = new Point(90, 117);
            mainPersonLabel.Margin = new Padding(2, 0, 2, 0);
            mainPersonLabel.Name = "mainPersonLabel";
            mainPersonLabel.Size = new Size(73, 15);
            mainPersonLabel.TabIndex = 16;
            mainPersonLabel.Text = "Main person";
            // 
            // relationshipTypeComboBox
            // 
            relationshipTypeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            relationshipTypeComboBox.FormattingEnabled = true;
            relationshipTypeComboBox.Items.AddRange(new object[] { "Female", "Male" });
            relationshipTypeComboBox.Location = new Point(240, 149);
            relationshipTypeComboBox.Margin = new Padding(2, 1, 2, 1);
            relationshipTypeComboBox.Name = "relationshipTypeComboBox";
            relationshipTypeComboBox.Size = new Size(115, 24);
            relationshipTypeComboBox.TabIndex = 19;
            // 
            // relationshipTypeLabel
            // 
            relationshipTypeLabel.AutoSize = true;
            relationshipTypeLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relationshipTypeLabel.Location = new Point(240, 117);
            relationshipTypeLabel.Margin = new Padding(2, 0, 2, 0);
            relationshipTypeLabel.Name = "relationshipTypeLabel";
            relationshipTypeLabel.Size = new Size(99, 15);
            relationshipTypeLabel.TabIndex = 18;
            relationshipTypeLabel.Text = "Relationship Type";
            // 
            // relatedPersonLabel
            // 
            relatedPersonLabel.AutoSize = true;
            relatedPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relatedPersonLabel.Location = new Point(429, 117);
            relatedPersonLabel.Margin = new Padding(2, 0, 2, 0);
            relatedPersonLabel.Name = "relatedPersonLabel";
            relatedPersonLabel.Size = new Size(85, 15);
            relatedPersonLabel.TabIndex = 20;
            relatedPersonLabel.Text = "Related person";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(220, 220, 220);
            toLabel.Location = new Point(382, 152);
            toLabel.Margin = new Padding(2, 0, 2, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(19, 15);
            toLabel.TabIndex = 22;
            toLabel.Text = "To";
            // 
            // cancelRelationshipButton
            // 
            cancelRelationshipButton.Location = new Point(463, 49);
            cancelRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            cancelRelationshipButton.Name = "cancelRelationshipButton";
            cancelRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            cancelRelationshipButton.Size = new Size(137, 23);
            cancelRelationshipButton.TabIndex = 25;
            cancelRelationshipButton.Text = "Cancel";
            cancelRelationshipButton.Click += cancelRelationshipButton_Click;
            // 
            // removeRelationshipButton
            // 
            removeRelationshipButton.Location = new Point(273, 49);
            removeRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            removeRelationshipButton.Name = "removeRelationshipButton";
            removeRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            removeRelationshipButton.Size = new Size(137, 23);
            removeRelationshipButton.TabIndex = 24;
            removeRelationshipButton.Text = "Remove Relationship";
            removeRelationshipButton.Click += removeRelationshipButton_Click;
            // 
            // addRelationshipButton
            // 
            addRelationshipButton.Location = new Point(83, 49);
            addRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            addRelationshipButton.Name = "addRelationshipButton";
            addRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            addRelationshipButton.Size = new Size(137, 23);
            addRelationshipButton.TabIndex = 23;
            addRelationshipButton.Text = "Add Relationship";
            addRelationshipButton.Click += addRelationshipButton_Click;
            // 
            // mainPersonTextbox
            // 
            mainPersonTextbox.BackColor = Color.FromArgb(69, 73, 74);
            mainPersonTextbox.BorderStyle = BorderStyle.FixedSingle;
            mainPersonTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonTextbox.Location = new Point(90, 149);
            mainPersonTextbox.Margin = new Padding(2, 1, 2, 1);
            mainPersonTextbox.Name = "mainPersonTextbox";
            mainPersonTextbox.Size = new Size(117, 23);
            mainPersonTextbox.TabIndex = 26;
            // 
            // cbxNames
            // 
            cbxNames.BackColor = SystemColors.ControlDarkDark;
            cbxNames.FormattingEnabled = true;
            cbxNames.Location = new Point(429, 149);
            cbxNames.Name = "cbxNames";
            cbxNames.Size = new Size(171, 23);
            cbxNames.TabIndex = 28;
            // 
            // mpRelationshipDataGridView
            // 
            mpRelationshipDataGridView.BackgroundColor = Color.FromArgb(23, 24, 29);
            mpRelationshipDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            mpRelationshipDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            mpRelationshipDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            mpRelationshipDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            mpRelationshipDataGridView.GridColor = SystemColors.ControlDarkDark;
            mpRelationshipDataGridView.Location = new Point(35, 250);
            mpRelationshipDataGridView.Margin = new Padding(2, 1, 2, 1);
            mpRelationshipDataGridView.Name = "mpRelationshipDataGridView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            mpRelationshipDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            mpRelationshipDataGridView.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(23, 24, 29);
            mpRelationshipDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            mpRelationshipDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            mpRelationshipDataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.Control;
            mpRelationshipDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.MenuHighlight;
            mpRelationshipDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Control;
            mpRelationshipDataGridView.RowTemplate.Height = 37;
            mpRelationshipDataGridView.Size = new Size(620, 161);
            mpRelationshipDataGridView.TabIndex = 30;
            mpRelationshipDataGridView.SelectionChanged += mpRelationshipDataGridView_SelectionChanged_1;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(35, 215);
            crownLabel1.Margin = new Padding(2, 0, 2, 0);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(149, 15);
            crownLabel1.TabIndex = 31;
            crownLabel1.Text = "Main Person Relationships:";
            // 
            // ManageRelationships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(686, 444);
            Controls.Add(crownLabel1);
            Controls.Add(mpRelationshipDataGridView);
            Controls.Add(cbxNames);
            Controls.Add(mainPersonTextbox);
            Controls.Add(cancelRelationshipButton);
            Controls.Add(removeRelationshipButton);
            Controls.Add(addRelationshipButton);
            Controls.Add(toLabel);
            Controls.Add(relatedPersonLabel);
            Controls.Add(relationshipTypeComboBox);
            Controls.Add(relationshipTypeLabel);
            Controls.Add(mainPersonLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManageRelationships";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Relationships";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mpRelationshipDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private ReaLTaiizor.Controls.CrownLabel mainPersonLabel;
        private ReaLTaiizor.Controls.CrownComboBox relationshipTypeComboBox;
        private ReaLTaiizor.Controls.CrownLabel relationshipTypeLabel;
        private ReaLTaiizor.Controls.CrownLabel relatedPersonLabel;
        private ReaLTaiizor.Controls.CrownLabel toLabel;
        private ReaLTaiizor.Controls.CrownButton cancelRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton removeRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton addRelationshipButton;
        private ReaLTaiizor.Controls.CrownTextBox mainPersonTextbox;
        private ComboBox cbxNames;
        private DataGridView mpRelationshipDataGridView;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
    }
}