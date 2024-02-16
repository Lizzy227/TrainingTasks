namespace DGVTask
{
    partial class frmDGV
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvBuffers = new DataGridView();
            dgvLisa = new LisasDGV();
            ((System.ComponentModel.ISupportInitialize)dgvBuffers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLisa).BeginInit();
            SuspendLayout();
            // 
            // dgvBuffers
            // 
            dgvBuffers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBuffers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBuffers.BackgroundColor = SystemColors.Control;
            dgvBuffers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBuffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBuffers.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBuffers.Dock = DockStyle.Top;
            dgvBuffers.GridColor = SystemColors.Control;
            dgvBuffers.Location = new Point(0, 0);
            dgvBuffers.Name = "dgvBuffers";
            dgvBuffers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBuffers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBuffers.RowHeadersVisible = false;
            dgvBuffers.RowTemplate.Height = 25;
            dgvBuffers.Size = new Size(1157, 213);
            dgvBuffers.TabIndex = 0;
            // 
            // dgvLisa
            // 
            dgvLisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLisa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLisa.BackgroundColor = SystemColors.Control;
            dgvLisa.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLisa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLisa.Dock = DockStyle.Bottom;
            dgvLisa.GridColor = SystemColors.Control;
            dgvLisa.Location = new Point(0, 219);
            dgvLisa.Name = "dgvLisa";
            dgvLisa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLisa.RowHeadersVisible = false;
            dgvLisa.RowTemplate.Height = 25;
            dgvLisa.Size = new Size(1157, 576);
            dgvLisa.TabIndex = 1;
            // 
            // frmDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 795);
            Controls.Add(dgvLisa);
            Controls.Add(dgvBuffers);
            Name = "frmDGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Grid View Task";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvBuffers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLisa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuffers;
        private LisasDGV dgvLisa;
    }
}
