namespace BytesMonitoringApp
{
    public partial class frmBytesMonitor : Form
    {
        public frmBytesMonitor()
        {
            InitializeComponent();
        }

        private void btnGetNetworkInterfaces_Click(object sender, EventArgs e)
        {
            GetNetworkInterfaces.ShowNetworkInterfaces(textBox3);
        }


    }
}
