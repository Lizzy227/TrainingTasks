namespace Task4_BitMEXOrderbook
{
    public partial class OrderBookForm : Form
    {
        private readonly RestAPI apiServices;
        private readonly Orderbook orderBook;
        public OrderBookForm()
        {
            InitializeComponent();
            apiServices = new RestAPI();
            cbSymbols.DataSource = Enum.GetValues(typeof(CurrencySymbols.Currency));
            rbtnREST.Checked = true;
            orderBook = new Orderbook();
            
            
            
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dgvBids.Rows.Count > 0 || dgvAsks.Rows.Count > 0)
            {
                dgvBids.Rows.Clear();
                dgvAsks.Rows.Clear();
            }
            var entries = await apiServices.GetOrderBookAsync(cbSymbols.SelectedValue.ToString());
            orderBook.UpdateGrids(dgvBids, dgvAsks, entries);


        }

        private void rbtnREST_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnREST.Checked)
                {
                    btnRefresh.Show();
                    btnRefresh.Enabled = true;
                }
                if (rbtnWebSocket.Checked)
                {
                    btnRefresh.Hide();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
