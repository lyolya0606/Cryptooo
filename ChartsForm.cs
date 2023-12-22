using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Cryptooo {
    public partial class ChartsForm : Form {
        List<double> _timeAES = new List<double>();
        List<double> _timeFish = new List<double>();
        public ChartsForm(List<double> timeAES, List<double> timeFish) {
            InitializeComponent();
            _timeAES = timeAES;
            _timeFish = timeFish;
            DrawChart();
            FillTable();
        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        private void DrawChart() {
            var pointsAES = new ChartValues<ObservablePoint>();
            var pointsFish = new ChartValues<ObservablePoint>();

            for (int i = 0; i < _timeAES.Count; i++) {

                pointsAES.Add(new ObservablePoint {
                    X = i + 1,
                    Y = _timeAES[i]
                });
                pointsFish.Add(new ObservablePoint {
                    X = i + 1,
                    Y = _timeFish[i]
                });
            }

            cartesianChart.AxisX.Add(new Axis { Title = "Количество блоков, 128 бит", FontSize = 15 });
            cartesianChart.AxisY.Add(new Axis { Title = "Среднее время шифрования, миллисекунда", FontSize = 15 });
            PointLabel = chartPoint => $"{"Количество блоков, 128 бит"}: {chartPoint.X}, {"Среднее время шифрования, миллисекунда"}: {Math.Round(chartPoint.Y, 3)}";

            cartesianChart.Series.Add(new LineSeries {
                Values = new ChartValues<ObservablePoint>(pointsAES),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "AES",
                LabelPoint = PointLabel,
            }); ;
            cartesianChart.Series.Add(new LineSeries {
                Values = new ChartValues<ObservablePoint>(pointsFish),
                Fill = System.Windows.Media.Brushes.Transparent,
                Title = "Twofish",
                LabelPoint = PointLabel,
            }); ;
            cartesianChart.LegendLocation = LegendLocation.Bottom;

        }

        private void FillTable() {
            DataTable dotTable = new DataTable();
            dotTable.Columns.Add("Количество блоков", typeof(double));
            dotTable.Columns.Add("Среднее время AES, миллисекунда", typeof(double));
            dotTable.Columns.Add("Среднее время Twofish, миллисекунда", typeof(double));


            for (int i = 0; i < _timeFish.Count; i++) {
                dotTable.Rows.Add(i + 1, _timeAES[i], _timeFish[i]);
            }


            dataGridView.DataSource = dotTable;
            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
