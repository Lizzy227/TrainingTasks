namespace Task4_BitMEXOrderbook
{
    partial class OrderBookForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnRefresh = new Button();
            dgvBids = new DataGridView();
            colBidsPrice = new DataGridViewTextBoxColumn();
            colBidsSize = new DataGridViewTextBoxColumn();
            colBidsTotal = new DataGridViewTextBoxColumn();
            lblSymbol = new Label();
            cbSymbols = new ComboBox();
            lblMarketPrice = new Label();
            panel1 = new Panel();
            rbtnWebSocket = new RadioButton();
            rbtnREST = new RadioButton();
            dgvAsks = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            rtxtEvents = new RichTextBox();
            btnSub = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBids).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsks).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(228, 443);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(168, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Load Data";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvBids
            // 
            dgvBids.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBids.BorderStyle = BorderStyle.Fixed3D;
            dgvBids.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvBids.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBids.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBids.Columns.AddRange(new DataGridViewColumn[] { colBidsPrice, colBidsSize, colBidsTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBids.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBids.GridColor = SystemColors.Menu;
            dgvBids.Location = new Point(90, 81);
            dgvBids.Name = "dgvBids";
            dgvBids.ReadOnly = true;
            dgvBids.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Menu;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBids.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBids.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBids.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBids.Size = new Size(463, 150);
            dgvBids.TabIndex = 1;
            // 
            // colBidsPrice
            // 
            colBidsPrice.HeaderText = "Price";
            colBidsPrice.Name = "colBidsPrice";
            colBidsPrice.ReadOnly = true;
            // 
            // colBidsSize
            // 
            colBidsSize.HeaderText = "Size (USD)";
            colBidsSize.Name = "colBidsSize";
            colBidsSize.ReadOnly = true;
            // 
            // colBidsTotal
            // 
            colBidsTotal.HeaderText = "Total (USD)";
            colBidsTotal.Name = "colBidsTotal";
            colBidsTotal.ReadOnly = true;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Location = new Point(379, 36);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(47, 15);
            lblSymbol.TabIndex = 3;
            lblSymbol.Text = "Symbol";
            // 
            // cbSymbols
            // 
            cbSymbols.FormattingEnabled = true;
            cbSymbols.Location = new Point(432, 33);
            cbSymbols.Name = "cbSymbols";
            cbSymbols.Size = new Size(121, 23);
            cbSymbols.TabIndex = 4;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Location = new Point(292, 251);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(70, 15);
            lblMarketPrice.TabIndex = 5;
            lblMarketPrice.Text = "MarketPrice";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnWebSocket);
            panel1.Controls.Add(rbtnREST);
            panel1.Location = new Point(90, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 23);
            panel1.TabIndex = 6;
            // 
            // rbtnWebSocket
            // 
            rbtnWebSocket.AutoSize = true;
            rbtnWebSocket.Location = new Point(70, 2);
            rbtnWebSocket.Name = "rbtnWebSocket";
            rbtnWebSocket.Size = new Size(84, 19);
            rbtnWebSocket.TabIndex = 1;
            rbtnWebSocket.TabStop = true;
            rbtnWebSocket.Text = "WebSocket";
            rbtnWebSocket.UseVisualStyleBackColor = true;
            // 
            // rbtnREST
            // 
            rbtnREST.AutoSize = true;
            rbtnREST.Location = new Point(5, 2);
            rbtnREST.Name = "rbtnREST";
            rbtnREST.Size = new Size(50, 19);
            rbtnREST.TabIndex = 0;
            rbtnREST.TabStop = true;
            rbtnREST.Text = "REST";
            rbtnREST.UseVisualStyleBackColor = true;
            rbtnREST.CheckedChanged += rbtnREST_CheckedChanged;
            // 
            // dgvAsks
            // 
            dgvAsks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsks.BorderStyle = BorderStyle.Fixed3D;
            dgvAsks.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvAsks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = SystemColors.Menu;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAsks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAsks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsks.ColumnHeadersVisible = false;
            dgvAsks.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAsks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAsks.GridColor = SystemColors.Menu;
            dgvAsks.Location = new Point(90, 287);
            dgvAsks.Name = "dgvAsks";
            dgvAsks.ReadOnly = true;
            dgvAsks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Menu;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvAsks.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvAsks.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAsks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvAsks.Size = new Size(463, 150);
            dgvAsks.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Price";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Size (USD)";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Total (USD)";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // rtxtEvents
            // 
            rtxtEvents.Location = new Point(598, 81);
            rtxtEvents.Name = "rtxtEvents";
            rtxtEvents.Size = new Size(376, 362);
            rtxtEvents.TabIndex = 8;
            rtxtEvents.Text = "";
            // 
            // btnSub
            // 
            btnSub.Location = new Point(270, 472);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 9;
            btnSub.Text = "Subscribe";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // OrderBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 517);
            Controls.Add(btnSub);
            Controls.Add(rtxtEvents);
            Controls.Add(dgvAsks);
            Controls.Add(panel1);
            Controls.Add(lblMarketPrice);
            Controls.Add(cbSymbols);
            Controls.Add(lblSymbol);
            Controls.Add(dgvBids);
            Controls.Add(btnRefresh);
            Name = "OrderBookForm";
            Text = "Order Book";
            ((System.ComponentModel.ISupportInitialize)dgvBids).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvBids;
        private Label lblSymbol;
        private ComboBox cbSymbols;
        private Label lblMarketPrice;
        private Panel panel1;
        private RadioButton rbtnWebSocket;
        private RadioButton rbtnREST;
        private DataGridViewTextBoxColumn colBidsPrice;
        private DataGridViewTextBoxColumn colBidsSize;
        private DataGridViewTextBoxColumn colBidsTotal;
        private DataGridView dgvAsks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private RichTextBox rtxtEvents;
        private Button btnSub;
    }
}
