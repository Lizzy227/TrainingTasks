using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BytesMonitoringApp
{
    public abstract class GetNetworkInterfaces
    {
        public static void ShowNetworkInterfaces(TextBox textBox)
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            // Clear existing text in the TextBox
            textBox.Clear();

            // Append text to the TextBox
            AppendText(textBox, $"Interface information for {computerProperties.HostName}.{computerProperties.DomainName}");

            if (nics == null || nics.Length < 1)
            {
                AppendText(textBox, "No network interfaces found.");
                return;
            }

            AppendText(textBox, $"Number of interfaces: {nics.Length}");

            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();

                // Append text to the TextBox for each network interface
                AppendText(textBox, "");
                AppendText(textBox, adapter.Description);
                AppendText(textBox, new string('=', adapter.Description.Length));
                AppendText(textBox, $"Interface type: {adapter.NetworkInterfaceType}");
                AppendText(textBox, $"Physical Address: {adapter.GetPhysicalAddress().ToString()}");
                AppendText(textBox, $"Operational status: {adapter.OperationalStatus}");

                string versions = "";

                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }

                AppendText(textBox, $"IP version: {versions}");

                if (adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    AppendText(textBox, $"DNS suffix: {properties.DnsSuffix}");

                    if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                    {
                        IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                        AppendText(textBox, $"MTU: {ipv4.Mtu}");

                        if (ipv4.UsesWins)
                        {
                            IPAddressCollection winsServers = properties.WinsServersAddresses;
                            if (winsServers.Count > 0)
                            {
                                AppendText(textBox, "WINS Servers:");
                                // Append code to show WINS Servers if needed
                            }
                        }
                    }

                    AppendText(textBox, $"DNS enabled: {properties.IsDnsEnabled}");
                    AppendText(textBox, $"Dynamically configured DNS: {properties.IsDynamicDnsEnabled}");
                    AppendText(textBox, $"Receive Only: {adapter.IsReceiveOnly}");
                    AppendText(textBox, $"Multicast: {adapter.SupportsMulticast}");
                }
            }
        }

        // Helper method to append text to the TextBox
        private static void AppendText(TextBox textBox, string text)
        {
            textBox.AppendText(text + Environment.NewLine);
        }
    }
}
