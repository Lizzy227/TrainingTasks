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
            dgvBuffers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuffers).BeginInit();
            SuspendLayout();
            // 
            // dgvBuffers
            // 
            dgvBuffers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBuffers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuffers.Dock = DockStyle.Fill;
            dgvBuffers.Location = new Point(0, 0);
            dgvBuffers.Name = "dgvBuffers";
            dgvBuffers.ReadOnly = true;
            dgvBuffers.RowTemplate.Height = 25;
            dgvBuffers.Size = new Size(970, 590);
            dgvBuffers.TabIndex = 0;
            // 
            // frmDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 590);
            Controls.Add(dgvBuffers);
            Name = "frmDGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Grid View Task";
            ((System.ComponentModel.ISupportInitialize)dgvBuffers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuffers;
    }
}
