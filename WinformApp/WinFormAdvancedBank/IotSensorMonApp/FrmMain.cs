using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IotSensorMonApp
{
    public partial class FrmMain : Form
    {
        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>();//차트,리스트박스 출력
        private string connString = "Data Source=127.0.0.1;" +
            "Initial Catalog=IoTData;Persist Security Info=True;" +
            "User ID=sa;Password=mssql_p@ssw0rd!";
        private double xCount = 200;//차트에 보이는 데이터 수
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //combobox 초기화
            foreach (var port in SerialPort.GetPortNames())
            {
                CmbSerialPort.Items.Add(port);
            }
            CmbSerialPort.Text = "Select Port";
            //iot 장비에서 받을 값의 범위
            PrbPhotoResistor.Minimum = 0;
            PrbPhotoResistor.Maximum = 1023;
            PrbPhotoResistor.Value = 0;

            //차트모양 초기화
            InitCharStyle();
            //BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "Unknown";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            //나머지 초기화
            LblConnectTime.Text = "Connection Time :";
            TxtSensorNumber.TextAlign = HorizontalAlignment.Right;
            TxtSensorNumber.Text = "0";
            BtnCon.Enabled = BtnDiscon.Enabled = false;
        }
        /// <summary>
        /// 차트 초기설정
        /// </summary>
        private void InitCharStyle()
        {
            ChtPhotoResistors.ChartAreas[0].BackColor = Color.Blue;

            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisY.Maximum = 1024;
            ChtPhotoResistors.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResistors.Series.Clear();//Series1 값 지움
            ChtPhotoResistors.Series.Add("PhotoValue");
            ChtPhotoResistors.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResistors.Series[0].Color = Color.LightCoral;
            ChtPhotoResistors.Series[0].BorderWidth = 3;

            //범례 삭제
            if (ChtPhotoResistors.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResistors.Legends.Count; i++)
                {
                    ChtPhotoResistors.Legends.RemoveAt(i);
                }
            }
        }

        private void MnuStartSimul_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000;// 1000 1second
            timerSimul.Tick += TimerSimul_tick;
            timerSimul.Start();
        }

        private long timeSpan = 0; // 시간 흐름 값
        private int randMaxVal = 0; // 랜덤값 담을 변수

        private void TimerSimul_tick(object sender, EventArgs e)
        {
            timeSpan += 1;
            var temp = timeSpan % 30; // 1~29
            if (temp.ToString().Length == 2)
                randMaxVal = 980;
            else
                randMaxVal = 120;
            int value = randPhoto.Next(randMaxVal - 40, randMaxVal);
            ShowSensorValue(value.ToString());
        }
        /// <summary>
        /// 센서값 화면 출력메서드
        /// </summary>
        /// <param name="value"></param>
        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(currentTime, v, IsSimulation);
            sensors.Add(data);
            InsertTable(data);

            //센서값 개수
            TxtSensorNumber.Text = sensors.Count.ToString();
            //프로그래스바 현재값 출력
            PrbPhotoResistor.Value = v;
            //리스트박스에 데이터 출력
            var item =$"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1;//스크롤 처리
            //차트에 데이터 출력
            ChtPhotoResistors.Series[0].Points.Add(v);
            //200개 넘으면
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = (sensors.Count >= xCount) ? sensors.Count : xCount;
            //zoom처리
            if (sensors.Count > xCount)
                ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            else
                ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount);
            //BtnDisplay 표시
            if (IsSimulation)
                BtnDisplay.Text = v.ToString();
            else
                BtnDisplay.Text = "~" + "\n" + v.ToString();
        }

        private void InsertTable(SensorData data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    var query = $"insert into Tbl_PhotoResistor " +
                        $"(CurrentDt, Value, SimulFlag) " +
                        $"values ('{data.Current.ToString("yyyy-MM-dd HH:mm:ss")}','{data.Value}','{(data.SimulFlag == true? "1" : "0")}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");
            }
        }

        private void MnuEndSimul_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();
        }

        private void BtnCon_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiscon_Click(object sender, EventArgs e)
        {

        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘 후 프로그램을 종료하세요", "종료",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Environment.Exit(0);
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(0, sensors.Count);
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = sensors.Count / 4;
        }

        private void BtnZoom_Click(object sender, EventArgs e)
        {
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = sensors.Count;

            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count-xCount, sensors.Count);
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;
        }
    }
}
