namespace Task4_BitMEXOrderbook
{
    public partial class OrderBookForm : Form
    {
        private readonly RestAPI apiServices;
        public OrderBookForm()
        {
            InitializeComponent();
            apiServices = new RestAPI();
            cbSymbols.DataSource = Enum.GetValues(typeof(CurrencySymbols.Currency));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            apiServices.GetOrderBookAsync("XBT");
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
