using System;
using Task4_BitMEXOrderbook.REST;
using Task4_BitMEXOrderbook.WebSocket;

namespace Task4_BitMEXOrderbook
{
    public partial class OrderBookForm : Form
    {
        private readonly RestAPI apiServices;
        private readonly Orderbook orderBook;

        WebSocketAPI webAPIInstance = WebSocketAPI.Instance;
        WebSocketHandler webHandlerInstance = WebSocketHandler.Instance;

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
                orderBook.UpdateGridsForREST(dgvBids, dgvAsks, entries);
            }
            else
            {
                await webAPIInstance.Connect("wss://ws.bitmex.com/realtime?subscribe=orderBookL2_25:XBTUSD");
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

        bool subOrUnsub = true;
        private void btnSub_Click(object sender, EventArgs e)
        {
            SubOrUnsub();
        }
        void SubOrUnsub()
        {
            if (subOrUnsub)
            {
                webHandlerInstance.Subscribe("update", MessageHandler.HandleUpdateMessage);
                webHandlerInstance.Subscribe("insert", MessageHandler.HandleInsertMessage);
                webHandlerInstance.Subscribe("delete", MessageHandler.HandleDeleteMessage);
                webHandlerInstance.Subscribe("partial", MessageHandler.HandleOrderbookSnapshot);
                subOrUnsub = false;
            }
            else
            {
                webHandlerInstance.Unsubscribe("update");
                webHandlerInstance.Unsubscribe("insert");
                webHandlerInstance.Unsubscribe("delete");
                webHandlerInstance.Unsubscribe("partial");
                subOrUnsub = true;
            }
        }

        private async void btnStartQueueProcessing_Click(object sender, EventArgs e)
        {
            await webAPIInstance.ProcessQueueEvents();

        }
    }
}
