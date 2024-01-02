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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
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
            btnSub = new Button();
            btnStartQueueProcessing = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBids).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsks).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(423, 945);
            btnRefresh.Margin = new Padding(6, 6, 6, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(312, 49);
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Menu;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBids.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBids.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBids.Columns.AddRange(new DataGridViewColumn[] { colBidsPrice, colBidsSize, colBidsTotal });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvBids.DefaultCellStyle = dataGridViewCellStyle10;
            dgvBids.GridColor = SystemColors.Menu;
            dgvBids.Location = new Point(167, 173);
            dgvBids.Margin = new Padding(6, 6, 6, 6);
            dgvBids.Name = "dgvBids";
            dgvBids.ReadOnly = true;
            dgvBids.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Menu;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvBids.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvBids.RowHeadersVisible = false;
            dgvBids.RowHeadersWidth = 82;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBids.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvBids.Size = new Size(860, 320);
            dgvBids.TabIndex = 1;
            // 
            // colBidsPrice
            // 
            colBidsPrice.HeaderText = "Price";
            colBidsPrice.MinimumWidth = 10;
            colBidsPrice.Name = "colBidsPrice";
            colBidsPrice.ReadOnly = true;
            // 
            // colBidsSize
            // 
            colBidsSize.HeaderText = "Size (USD)";
            colBidsSize.MinimumWidth = 10;
            colBidsSize.Name = "colBidsSize";
            colBidsSize.ReadOnly = true;
            // 
            // colBidsTotal
            // 
            colBidsTotal.HeaderText = "Total (USD)";
            colBidsTotal.MinimumWidth = 10;
            colBidsTotal.Name = "colBidsTotal";
            colBidsTotal.ReadOnly = true;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Location = new Point(704, 77);
            lblSymbol.Margin = new Padding(6, 0, 6, 0);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(93, 32);
            lblSymbol.TabIndex = 3;
            lblSymbol.Text = "Symbol";
            // 
            // cbSymbols
            // 
            cbSymbols.FormattingEnabled = true;
            cbSymbols.Location = new Point(802, 70);
            cbSymbols.Margin = new Padding(6, 6, 6, 6);
            cbSymbols.Name = "cbSymbols";
            cbSymbols.Size = new Size(221, 40);
            cbSymbols.TabIndex = 4;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Location = new Point(542, 535);
            lblMarketPrice.Margin = new Padding(6, 0, 6, 0);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(140, 32);
            lblMarketPrice.TabIndex = 5;
            lblMarketPrice.Text = "MarketPrice";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnWebSocket);
            panel1.Controls.Add(rbtnREST);
            panel1.Location = new Point(167, 70);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 49);
            panel1.TabIndex = 6;
            // 
            // rbtnWebSocket
            // 
            rbtnWebSocket.AutoSize = true;
            rbtnWebSocket.Location = new Point(130, 4);
            rbtnWebSocket.Margin = new Padding(6, 6, 6, 6);
            rbtnWebSocket.Name = "rbtnWebSocket";
            rbtnWebSocket.Size = new Size(164, 36);
            rbtnWebSocket.TabIndex = 1;
            rbtnWebSocket.TabStop = true;
            rbtnWebSocket.Text = "WebSocket";
            rbtnWebSocket.UseVisualStyleBackColor = true;
            // 
            // rbtnREST
            // 
            rbtnREST.AutoSize = true;
            rbtnREST.Location = new Point(9, 4);
            rbtnREST.Margin = new Padding(6, 6, 6, 6);
            rbtnREST.Name = "rbtnREST";
            rbtnREST.Size = new Size(97, 36);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.BackColor = SystemColors.Menu;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvAsks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvAsks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsks.ColumnHeadersVisible = false;
            dgvAsks.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvAsks.DefaultCellStyle = dataGridViewCellStyle14;
            dgvAsks.GridColor = SystemColors.Menu;
            dgvAsks.Location = new Point(167, 612);
            dgvAsks.Margin = new Padding(6, 6, 6, 6);
            dgvAsks.Name = "dgvAsks";
            dgvAsks.ReadOnly = true;
            dgvAsks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Menu;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvAsks.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvAsks.RowHeadersVisible = false;
            dgvAsks.RowHeadersWidth = 82;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAsks.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvAsks.Size = new Size(860, 320);
            dgvAsks.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Price";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Size (USD)";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Total (USD)";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(501, 1007);
            btnSub.Margin = new Padding(6, 6, 6, 6);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(139, 49);
            btnSub.TabIndex = 9;
            btnSub.Text = "Subscribe";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnStartQueueProcessing
            // 
            btnStartQueueProcessing.Location = new Point(695, 1009);
            btnStartQueueProcessing.Name = "btnStartQueueProcessing";
            btnStartQueueProcessing.Size = new Size(219, 46);
            btnStartQueueProcessing.TabIndex = 10;
            btnStartQueueProcessing.Text = "Queue Process";
            btnStartQueueProcessing.UseVisualStyleBackColor = true;
            btnStartQueueProcessing.Click += btnStartQueueProcessing_Click;
            // 
            // OrderBookForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1892, 1103);
            Controls.Add(btnStartQueueProcessing);
            Controls.Add(btnSub);
            Controls.Add(dgvAsks);
            Controls.Add(panel1);
            Controls.Add(lblMarketPrice);
            Controls.Add(cbSymbols);
            Controls.Add(lblSymbol);
            Controls.Add(dgvBids);
            Controls.Add(btnRefresh);
            Margin = new Padding(6, 6, 6, 6);
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
        private Button btnSub;
        private Button btnStartQueueProcessing;
    }
}
