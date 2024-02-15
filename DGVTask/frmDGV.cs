using System.ComponentModel;

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
                            if (int.TryParse(bufferProperties[2], out length) && int.TryParse(avgRuntimeString, out avgRuntime) && int.TryParse(throughPutString, out throughPut)) 
                            {
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
