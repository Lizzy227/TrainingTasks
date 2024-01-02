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
            btnSub = new Button();
            btnStartQueueProcessing = new Button();
            pnlSubscribe = new Panel();
            pnlProcessQueue = new Panel();
            pnlSocketConnection = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBids).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsks).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(325, 738);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(240, 38);
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
            dgvBids.Location = new Point(128, 135);
            dgvBids.Margin = new Padding(5);
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
            dgvBids.RowHeadersWidth = 82;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBids.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBids.Size = new Size(662, 250);
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
            lblSymbol.Location = new Point(542, 60);
            lblSymbol.Margin = new Padding(5, 0, 5, 0);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(72, 25);
            lblSymbol.TabIndex = 3;
            lblSymbol.Text = "Symbol";
            // 
            // cbSymbols
            // 
            cbSymbols.FormattingEnabled = true;
            cbSymbols.Location = new Point(617, 55);
            cbSymbols.Margin = new Padding(5);
            cbSymbols.Name = "cbSymbols";
            cbSymbols.Size = new Size(171, 33);
            cbSymbols.TabIndex = 4;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Location = new Point(417, 418);
            lblMarketPrice.Margin = new Padding(5, 0, 5, 0);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(104, 25);
            lblMarketPrice.TabIndex = 5;
            lblMarketPrice.Text = "MarketPrice";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnWebSocket);
            panel1.Controls.Add(rbtnREST);
            panel1.Location = new Point(128, 55);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 38);
            panel1.TabIndex = 6;
            // 
            // rbtnWebSocket
            // 
            rbtnWebSocket.AutoSize = true;
            rbtnWebSocket.Location = new Point(100, 3);
            rbtnWebSocket.Margin = new Padding(5);
            rbtnWebSocket.Name = "rbtnWebSocket";
            rbtnWebSocket.Size = new Size(126, 29);
            rbtnWebSocket.TabIndex = 1;
            rbtnWebSocket.TabStop = true;
            rbtnWebSocket.Text = "WebSocket";
            rbtnWebSocket.UseVisualStyleBackColor = true;
            // 
            // rbtnREST
            // 
            rbtnREST.AutoSize = true;
            rbtnREST.Location = new Point(7, 3);
            rbtnREST.Margin = new Padding(5);
            rbtnREST.Name = "rbtnREST";
            rbtnREST.Size = new Size(76, 29);
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
            dgvAsks.Location = new Point(128, 478);
            dgvAsks.Margin = new Padding(5);
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
            dgvAsks.RowHeadersWidth = 82;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAsks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvAsks.Size = new Size(662, 250);
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
            btnSub.Location = new Point(385, 787);
            btnSub.Margin = new Padding(5);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(107, 38);
            btnSub.TabIndex = 9;
            btnSub.Text = "Subscribe";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnStartQueueProcessing
            // 
            btnStartQueueProcessing.Location = new Point(353, 832);
            btnStartQueueProcessing.Margin = new Padding(2);
            btnStartQueueProcessing.Name = "btnStartQueueProcessing";
            btnStartQueueProcessing.Size = new Size(168, 36);
            btnStartQueueProcessing.TabIndex = 10;
            btnStartQueueProcessing.Text = "Queue Process";
            btnStartQueueProcessing.UseVisualStyleBackColor = true;
            btnStartQueueProcessing.Click += btnStartQueueProcessing_Click;
            // 
            // pnlSubscribe
            // 
            pnlSubscribe.BackColor = Color.Red;
            pnlSubscribe.Location = new Point(580, 787);
            pnlSubscribe.Name = "pnlSubscribe";
            pnlSubscribe.Size = new Size(22, 24);
            pnlSubscribe.TabIndex = 11;
            pnlSubscribe.Visible = false;
            // 
            // pnlProcessQueue
            // 
            pnlProcessQueue.BackColor = Color.Red;
            pnlProcessQueue.Location = new Point(580, 832);
            pnlProcessQueue.Name = "pnlProcessQueue";
            pnlProcessQueue.Size = new Size(22, 24);
            pnlProcessQueue.TabIndex = 12;
            pnlProcessQueue.Visible = false;
            // 
            // pnlSocketConnection
            // 
            pnlSocketConnection.BackColor = Color.Red;
            pnlSocketConnection.Location = new Point(580, 738);
            pnlSocketConnection.Name = "pnlSocketConnection";
            pnlSocketConnection.Size = new Size(22, 24);
            pnlSocketConnection.TabIndex = 12;
            pnlSocketConnection.Visible = false;
            // 
            // OrderBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 926);
            Controls.Add(pnlSocketConnection);
            Controls.Add(pnlProcessQueue);
            Controls.Add(pnlSubscribe);
            Controls.Add(btnStartQueueProcessing);
            Controls.Add(btnSub);
            Controls.Add(dgvAsks);
            Controls.Add(panel1);
            Controls.Add(lblMarketPrice);
            Controls.Add(cbSymbols);
            Controls.Add(lblSymbol);
            Controls.Add(dgvBids);
            Controls.Add(btnRefresh);
            Margin = new Padding(5);
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
        private Panel pnlSubscribe;
        private Panel pnlProcessQueue;
        private Panel pnlSocketConnection;
    }
}
