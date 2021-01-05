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
    public partial class FrmDrink : Form
    {
        public FrmDrink()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void button1_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data1.Revenue)
                series.Add(new PieSeries() { Title = obj.Buoi.ToString(), Values = new ChartValues<int> { obj.Mililit }, DataLabels = true, LabelPoint = labelPoint });
            pieChart1.Series = series;
        }

        private void FrmDrink_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
    }
}
