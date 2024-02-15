using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace DGVTask
{
    public partial class frmDGV : Form
    {

        private BindingList<Buffer> bufferList = new BindingList<Buffer>();
        public frmDGV()
        {
            InitializeComponent();                        
            LoadDataFile();
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
                    string[] buffers = line.Split(',');
                    foreach (string buffer in buffers)
                    {
                        if (buffer.Contains(":\\"))
                        {
                            List<string> specialBuffers = new List<string>();
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
                                    specialBuffers.Add(sb.ToString());
                                    sb.Clear();
                            }
                                else 
                                {
                                    sb.Append(buffer[i]);
                                }
                        }
                       specialBuffers.Add(sb.ToString());
                            if (specialBuffers.Count == 5)
                            {
                                string name = specialBuffers[0];
                                string status = specialBuffers[1];
                                string avgRuntimeString = specialBuffers[3].TrimEnd('m', 's', ' ');
                                string throughPutString = specialBuffers[4].TrimEnd('/', 'm', 'i', 'n');
                                int length;
                                int avgRuntime;
                                int throughPut;

                                if (!int.TryParse(specialBuffers[2], out length))
                                {
                                    return;
                                }

                                if (!int.TryParse(avgRuntimeString, out avgRuntime))
                                {
                                    return;
                                }

                                if (!int.TryParse(throughPutString, out throughPut))
                                {
                                    return;
                                }

                                bufferList.Add(new Buffer { Name = name, Status = status, Length = length, AvgRuntime = avgRuntime, Throughput = throughPut });
                            }
                        }
                        else 
                        {
                            string[] bufferProperties = buffer.Split(':');
                            if (bufferProperties.Length == 5)
                            {
                                string name = bufferProperties[0].Trim();
                                string status = bufferProperties[1].Trim();
                                string avgRuntimeString = bufferProperties[3].TrimEnd('m', 's', ' ');
                                string throughPutString = bufferProperties[4].TrimEnd('/', 'm', 'i', 'n');
                                int length;
                                int avgRuntime;
                                int throughPut;

                                if (!int.TryParse(bufferProperties[2], out length))
                                {
                                    return;
                                }

                                if (!int.TryParse(avgRuntimeString, out avgRuntime))
                                {
                                    return;
                                }

                                if (!int.TryParse(throughPutString, out throughPut))
                                {
                                    return;
                                }

                                bufferList.Add(new Buffer { Name = name, Status = status, Length = length, AvgRuntime = avgRuntime, Throughput = throughPut });


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
    }
}
