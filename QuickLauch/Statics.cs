using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using DevExpress.XtraCharts;

namespace QuickLauch
{
    public partial class Statics : Form
    {
        public Dictionary<String, int> dictFrequency;
        public Statics()
        {
            InitializeComponent();
        }
        
        public void LoadStatic()
        {
            // Create a new chart.
            ChartControl DoughnutChart = new ChartControl();

            // Create a doughnut series.
            Series series1 = new Series("Series 1", ViewType.Doughnut);

            // Populate the series with points.
            foreach (var element in dictFrequency)
            {
                series1.Points.Add(new SeriesPoint(element.Key, element.Value));
                
            }

            // Add the series to the chart.
            DoughnutChart.Series.Add(series1);

            // Specify the text pattern of series labels.
            series1.Label.TextPattern = "{A}: {VP:P0}";

            // Specify how series points are sorted.
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // Specify the behavior of series labels.
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            // Adjust the view-type-specific options of the series.
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 30;

            // Access the diagram's options.
            ((SimpleDiagram)DoughnutChart.Diagram).Dimension = 2;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Frequency Application Using";
            DoughnutChart.Titles.Add(chartTitle1);
            DoughnutChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            DoughnutChart.Dock = DockStyle.Fill;
            this.Controls.Add(DoughnutChart);
        }
    }
}
