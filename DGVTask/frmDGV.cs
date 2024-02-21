using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace DGVTask
{
    public partial class frmDGV : Form
    {

        private SortableBindingList<Buffer> bufferList = new SortableBindingList<Buffer>();
        public frmDGV()
        {
            InitializeComponent();
            LoadDataFile();                      
            this.dgvLisa.DataSource = bufferList;
            dgvBuffers.DataSource = bufferList;
        }


        private void LoadDataFile()
        {
            try
            {
                string filepath = "C:\\Users\\lisa\\Documents\\GitHub\\TrainingTasks\\DGVTask\\BuffersDGV.txt";

                if (!File.Exists(filepath)) { return; }

                string[] lines = File.ReadAllLines(filepath);
                foreach (string line in lines)
                {
                    List<string> buffers = line.Split(',').ToList();
                    foreach (string buffer in buffers)
                    {
                        if (buffer.Contains(":\\"))
                        {
                            List<string> buffersWithColonInName = new List<string>();
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                if (buffer[i] == ':' && i + 1 < buffer.Length && buffer[i + 1] == '\\')
                                {
                                    sb.Append(":\\");
                                    i++;
                                }
                                else if (buffer[i] == ':')
                                {
                                    buffersWithColonInName.Add(sb.ToString());
                                    sb.Clear();
                                }
                                else
                                {
                                    sb.Append(buffer[i]);
                                }
                            }

                            buffersWithColonInName.Add(sb.ToString());

                            if (buffersWithColonInName.Count == 5)
                            {
                                PopulateBindingList(buffersWithColonInName);
                            }
                        }
                        else
                        {
                            List<string> bufferProperties = buffer.Split(':').ToList();
                            if (bufferProperties.Count == 5)
                            {
                                PopulateBindingList(bufferProperties);
                            }
                        }

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong.");
            }
        }
        private void PopulateBindingList(List<string> bufferPieces) 
        {
            string name = bufferPieces[0].Trim();
            string status = bufferPieces[1].Trim();
            string avgRuntimeString = bufferPieces[3].TrimEnd('m', 's', ' ');
            string throughPutString = bufferPieces[4].TrimEnd('/', 'm', 'i', 'n');
            int length;
            int avgRuntime;
            int throughPut;

            if (!int.TryParse(bufferPieces[2], out length))
            {
                MessageBox.Show("Error: Couldn't parse length");
                return;
            }

            if (!int.TryParse(avgRuntimeString, out avgRuntime))
            {
                MessageBox.Show("Error: Couldn't parse average runtime");
                return;
            }

            if (!int.TryParse(throughPutString, out throughPut))
            {
                MessageBox.Show("Error: Couldn't parse throughput");
                return;
            }

            bufferList.Add(new Buffer { Name = name, Status = status, Length = length, AvgRuntime = avgRuntime, Throughput = throughPut });
        }
    }
}
