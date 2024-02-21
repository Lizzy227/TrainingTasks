namespace DGVTask
{
    public class swSortableDGV : DataGridView
    {
        public swSortableDGV()
        {
            InitializeswSortableDGV();

        }

        private void InitializeswSortableDGV()
        {
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.BackgroundColor = SystemColors.Control;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle1.BackColor = SystemColors.Window;
            cellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellStyle1.ForeColor = SystemColors.ControlText;
            cellStyle1.SelectionBackColor = Color.Goldenrod;
            cellStyle1.SelectionForeColor = SystemColors.HighlightText;
            cellStyle1.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle = cellStyle1;
            this.Dock = DockStyle.Top;
            this.GridColor = SystemColors.Control;                        
            this.ReadOnly = true;
            cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle2.BackColor = SystemColors.Control;
            cellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellStyle2.ForeColor = SystemColors.WindowText;
            cellStyle2.SelectionBackColor = Color.Goldenrod;
            cellStyle2.SelectionForeColor = SystemColors.Control;
            cellStyle2.WrapMode = DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle = cellStyle2;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 25;            
            
        }
    }
}
