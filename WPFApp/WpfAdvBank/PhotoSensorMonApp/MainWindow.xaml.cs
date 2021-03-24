using LiveCharts;
using MahApps.Metro.Controls;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace PhotoSensorMonApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public class SensorData
    {
        public int Idx { get; set; }
        public DateTime CurrentDt { get; set; }
        public int Value { get; set; }
        public bool SimulFlag { get; set; }

        public SensorData(int idx, DateTime currentDt, int value, bool simulFlag)
        {
            Idx = idx;
            CurrentDt = currentDt;
            Value = value;
            SimulFlag = simulFlag;
        }
    }
    public partial class MainWindow : MetroWindow
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            InitializeComponent();

            logger.Info("PhotoSensorMonApp Initialized...");
        }

        private string connString = "Data Source=127.0.0.1;" +
            "Initial Catalog=IoTData;" +
            "Persist Security Info=True;" +
            "User ID=sa;" +
            "Password=mssql_p@ssw0rd!;";

        public SensorData GetRealTimeSensor()
        {
            SensorData result = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = @"SELECT Top 1 Idx
                                        ,CurrentDt
                                        ,Value
                                        ,SimulFlag
                                    FROM Tbl_PhotoResistor
                                   ORDER BY Idx DESC ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var temp = cmd.ExecuteReader();
                    
                    if (temp.Read())
                    {
                        result = new SensorData(Convert.ToInt32(temp["idx"]),
                                                Convert.ToDateTime(temp["CurrentDt"]),
                                                Convert.ToInt32(temp["Value"]),
                                                Convert.ToBoolean(temp["SimulFlag"]));
                    }
                }
                logger.Info("GetRealTimeSensor completed.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");
                logger.Error($"GetRealTimeSensor() error occured : {ex.Message}");
            }
            return result;
        }

        public DispatcherTimer CustomTimer { get; set; }
        public ChartValues<int> ChartValues { get; set; }
        public int SensorValue { get; set; }
        private void Window_Initialized(object sender, EventArgs e)
        {
            //var x = Enumerable.Range(0, 1001).Select(i => i / 10.0).ToArray();
            //var y = x.Select(v => Math.Abs(v) < 1e-10 ? 1 : Math.Sin(v) / v).ToArray();
            //ChtLine.Plot(x, y);
            ChartValues = new ChartValues<int>();// { 1000, 993, 986, 979, 972, 965, 958, 951, 944, 937 };
            GrdHistory.DataContext = ChartValues;

            CustomTimer = new DispatcherTimer();
            CustomTimer.Interval = TimeSpan.FromSeconds(1);
            CustomTimer.Tick += CustomTimer_Tick;
            //CustomTimer.Start();
        }

        private void CustomTimer_Tick(object sender,EventArgs e)
        {
            SensorValue = GetRealTimeSensor().Value; //new Random().Next(0,1023);
            GrdRealTime.DataContext = SensorValue;
        }

        private void MnuStart_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CustomTimer.Start();
        }

        private void MenuItem_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CustomTimer.Stop();
        }

        private void MnuExit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Environment.Exit(0);
            Application.Current.Shutdown(0);
        }

        private void MnuLoad_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            HistoryValues.ItemsSource = GetHistorySensors();
        }

        private List<DataPoint> GetHistorySensors()
        {
            List<DataPoint> result = new List<DataPoint>();

            try
            {
                using (SqlConnection conn= new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    var query = $@"SELECT Top 1000 Idx,Value
                                     FROM Tbl_PhotoResistor
                                    WHERE CurrentDt > CONVERT(datetime,'{DateTime.Now.ToString("yyyy-MM-dd")}')
                                    Order by idx";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(new DataPoint(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1])));
                    }
                }
                logger.Info("GetHistorySensors completed");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외 발생 : {ex.Message}");
                logger.Error($"GetHistorySensors() error occured : {ex.Message}");
            }
            return result;
        }
    }
}
