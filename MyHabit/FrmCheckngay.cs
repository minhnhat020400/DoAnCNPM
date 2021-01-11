using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHabit
{
    public partial class FrmCheckngay : Form
    {
        public FrmCheckngay()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue)
                series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = labelPoint });
            pieChart1.Series = series;
        }

        private void FrmCheckngay_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
