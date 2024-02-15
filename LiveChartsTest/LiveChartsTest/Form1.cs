using System;
using System.Windows.Controls;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace LiveChartsTest;

public partial class Form1 : Form
{
    private ColumnSeries DiagnosticsSeries;
    private ColumnSeries ErrorSeries;
    private ColumnSeries WarningSeries;
    private LineSeries UnsuccessfulSessions;
    private LiveCharts.WinForms.CartesianChart cartesianChart;
    private LineSeries SuccessfulSessions;




    public Form1()
    {
    
        InitializeComponent();
        InitializeChart();
        
    }

    private void InitializeChart()
    {
        cartesianChart = new LiveCharts.WinForms.CartesianChart();
        cartesianChart.Width = 800;
        cartesianChart.Height = 600;
        Controls.Add(cartesianChart);
        cartesianChart.Zoom = ZoomingOptions.Xy; // Enable zooming
        cartesianChart.Pan = PanningOptions.Xy;

        var SuccessfulRunValues = new ChartValues<double> { 0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                0
                                                };
        SuccessfulSessions = new LineSeries
        {
            Title = "Successful Session",
            Values = SuccessfulRunValues,
            PointGeometry = LiveCharts.Defaults.DefaultGeometries.Square,
            PointGeometrySize = 15,
            Stroke = System.Windows.Media.Brushes.Green,
            Fill = System.Windows.Media.Brushes.PaleGreen,
            
        };
        var UnsuccessfulRunvalues = new ChartValues<double> { 0,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                2,
                                                0,
                                                
                                                };
        UnsuccessfulSessions = new LineSeries
        {
            Title = "Step Line Series",
            Values = UnsuccessfulRunvalues,
            PointGeometry = LiveCharts.Defaults.DefaultGeometries.Square,
            PointGeometrySize = 15,
            Stroke = System.Windows.Media.Brushes.Red,
            Fill = System.Windows.Media.Brushes.MistyRose,
            
            
        };

        DiagnosticsSeries = new ColumnSeries
        {
            Values = new ChartValues<double> { 0,
                                                0,
                                                0,
                                                2,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0
                                                 },
            Title = "Diagnostics",
            MaxColumnWidth = 25,
            ColumnPadding = 0,
        };
        ErrorSeries = new ColumnSeries
        {
            Values = new ChartValues<double> { 0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0},
            Title = "Error",
            MaxColumnWidth = 25,
            ColumnPadding = 0,
        };
        WarningSeries = new ColumnSeries
        {
            Values = new ChartValues<double> {  0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                2,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                2,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                2,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0, },
            Title = "Warning",
            MaxColumnWidth = 25,
            ColumnPadding = 0,
        };


        cartesianChart.Series = new SeriesCollection
            {
             SuccessfulSessions,


            };

        var timestamps = new[] {   "2023-12-30 00:14:23,035",
                                   "2023-12-30 00:15:24,507",
                                   "2023-12-30 00:16:24,507",
                                   "2023-12-30 00:17:25,945",
                                   "2023-12-30 00:18:25,945",
                                   "2023-12-30 00:19:28,243",
                                   "2023-12-30 00:20:28,243",
                                   "2023-12-30 00:21:29,611",
                                   "2023-12-30 00:22:29,611",
                                   "2023-12-30 00:23:30,905", };
                                   
        cartesianChart.AxisX.Add(new Axis
        {
            Title = "Timestamps",
            Labels = timestamps, // Set timestamps as labels for the X-axis
            MinValue = 0
        });

        cartesianChart.AxisY.Add(new Axis
        {
            Title = "Y-axis Title",
            Labels = new[] { "1", "2", "3", "4", "5"  },
            MinValue = 0 // Set the minimum value for the Y-axis to 0
        });

        cartesianChart.Series.Add(UnsuccessfulSessions);
        cartesianChart.Series.Add(DiagnosticsSeries);
        cartesianChart.Series.Add(ErrorSeries);
        cartesianChart.Series.Add(WarningSeries);

        chkSuccessfulSessions.CheckedChanged += ToggleSuccessfulSessionsSeries;
        chkUnsuccessfulSessions.CheckedChanged += ToggleUnsuccessfulSessionsSeries;
        chkDiagnostics.CheckedChanged += ToggleDiagnosticsSeries;
        chkError.CheckedChanged += ToggleErrorSeries;
        chkWarning.CheckedChanged += ToggleWarningSeries;

        chkDiagnostics.Checked = true;
        chkError.Checked = true;
        chkWarning.Checked = true;
        chkSuccessfulSessions.Checked = true;
        chkUnsuccessfulSessions.Checked = true;

    }
    private void ClearZoom()
    {
        //to clear the current zoom/pan just set the axis limits to double.NaN

        cartesianChart.AxisX[0].MinValue = double.NaN;
        cartesianChart.AxisX[0].MaxValue = double.NaN;
        cartesianChart.AxisY[0].MinValue = double.NaN;
        cartesianChart.AxisY[0].MaxValue = double.NaN;
    }

    private void ToggleDiagnosticsSeries(object sender, EventArgs e)
    {
        DiagnosticsSeries.Visibility = chkDiagnostics.Checked ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
    }

    private void ToggleErrorSeries(object sender, EventArgs e)
    {
        ErrorSeries.Visibility = chkError.Checked ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
    }

    private void ToggleWarningSeries(object sender, EventArgs e)
    {
        WarningSeries.Visibility = chkWarning.Checked ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
    }
    private void ToggleSuccessfulSessionsSeries(object sender, EventArgs e)
    {
        SuccessfulSessions.Visibility = chkSuccessfulSessions.Checked ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
    }
    private void ToggleUnsuccessfulSessionsSeries(object sender, EventArgs e)
    {
        UnsuccessfulSessions.Visibility = chkUnsuccessfulSessions.Checked ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
    }

    private void btnResetZoomAndPan_Click(object sender, EventArgs e)
    {
        ClearZoom();
    }

    

    

}

