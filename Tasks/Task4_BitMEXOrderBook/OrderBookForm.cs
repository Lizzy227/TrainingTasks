using System;
using Task4_BitMEXOrderbook;

namespace Task4_BitMEXOrderbook
{
    public partial class OrderBookForm : Form
    {
        private readonly RestAPI apiServices;
        private readonly Orderbook orderBook;

        WebSocketAPI webAPI = WebSocketAPI.Instance;

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
            if (rbtnREST.Checked)
            {
                if (dgvBids.Rows.Count > 0 || dgvAsks.Rows.Count > 0)
                {
                    dgvBids.Rows.Clear();
                    dgvAsks.Rows.Clear();
                }
                var entries = await apiServices.GetOrderBookAsync(cbSymbols.SelectedValue.ToString());
                orderBook.UpdateGrids(dgvBids, dgvAsks, entries);
            }
            else
            {
                await webAPI.Connect("wss://ws.bitmex.com/realtime?subscribe=orderBookL2_25:XBTUSD");
            }
            


        }

        private void rbtnREST_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnREST.Checked)
                {
                    btnRefresh.Text = "Refresh via REST.";
                }
                if (rbtnWebSocket.Checked)
                {
                    btnRefresh.Text = "Refresh via WebSocket.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
