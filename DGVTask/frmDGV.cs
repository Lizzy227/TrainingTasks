using System.ComponentModel;
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

        private void PopulateBindingList(List<string> bufferPieces) //string name = "Undefined", string status = "Undefined", string avgRunTime = "Undefined",   )
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
    public class LisasDGV : DataGridView
    {
        public LisasDGV()
        {
            InitializeLisasDGV();

        }

        private void InitializeLisasDGV()
        {
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.BackgroundColor = SystemColors.Control;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle1.BackColor = SystemColors.Window;
            cellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellStyle1.ForeColor = SystemColors.ControlText;
            cellStyle1.SelectionBackColor = Color.Goldenrod;
            cellStyle1.SelectionForeColor = SystemColors.HighlightText;
            cellStyle1.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle = cellStyle1;
            this.Dock = DockStyle.Top;
            this.GridColor = SystemColors.Control;                        
            this.ReadOnly = true;
            cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle2.BackColor = SystemColors.Control;
            cellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellStyle2.ForeColor = SystemColors.WindowText;
            cellStyle2.SelectionBackColor = Color.Goldenrod;
            cellStyle2.SelectionForeColor = SystemColors.Control;
            cellStyle2.WrapMode = DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle = cellStyle2;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 25;            
            
        }
    }

    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private PropertyDescriptor _sortProperty;
        private ListSortDirection _sortDirection;

        // Core sort methods
        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> items = this.Items as List<T>;
            if (items != null)
            {
                PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
                items.Sort(pc);
                _isSorted = true;
                _sortProperty = property;
                _sortDirection = direction;
            }
            else 
            {
                _isSorted = false;
            }
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
            _sortDirection = ListSortDirection.Ascending;
        }

        // Core sort properties
        protected override bool SupportsSortingCore
        {
            get { return true; }
        }
        protected override bool IsSortedCore
        {
            get { return _isSorted; }
        }
        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }
    }

    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly PropertyDescriptor _property;
        private readonly ListSortDirection _direction;
        
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            if(property == null)
            {
                return;
            }
           
            this._property = property;
            this._direction = direction;
        }
        // IComparer<T> interface
        public int Compare(T xValue, T yValue) {
            var xPropertyValue = (IComparable)_property.GetValue(xValue);
            var yPropertyValue = (IComparable)_property.GetValue(yValue);

            return _direction == ListSortDirection.Ascending ? xPropertyValue.CompareTo(yPropertyValue) : yPropertyValue.CompareTo(xPropertyValue);
        }
         
}
}
