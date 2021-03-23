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

namespace IoTSensorMonApp
{
    public partial class FrmMain : Form
    {
        private double xCount = 200; // 차트에 보이는 데이터 수
        private Timer timerSimul = new Timer();
        private Random randPhoto = new Random();
        private bool IsSimulation = false;
        private List<SensorData> sensors = new List<SensorData>(); // 차트, 리스트박스 출력
        private string ConnString = "Data Source=127.0.0.1;" +
                                    "Initial Catalog=IoTData;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;" +
                                    "Password=mssql_p@ssw0rd!";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // ComboBox 초기화
            foreach (var port in SerialPort.GetPortNames())
            {
                CboSerialPort.Items.Add(port);
            }
            CboSerialPort.Text = "Select Port";

            // IoT장비에서 받을 값의 범위
            PrbPhotoResistor.Minimum = 0;
            PrbPhotoResistor.Maximum = 1023;
            PrbPhotoResistor.Value = 0;

            // 차트모양 초기화
            InitChartStyle();

            // BtnDisplay 초기화
            BtnDisplay.BackColor = Color.BlueViolet;
            BtnDisplay.ForeColor = Color.WhiteSmoke;
            BtnDisplay.Text = "NONE";
            BtnDisplay.Font = new Font("맑은 고딕", 14, FontStyle.Bold);

            // 나머지 초기화
            LblConnectTime.Text = "Connection TIme :";
            TxtSensorNum.TextAlign = HorizontalAlignment.Right;
            TxtSensorNum.Text = "0";
            BtnConnect.Enabled = BtnDisconnect.Enabled = false;
        }

        /// <summary>
        /// 차트 초기설정
        /// </summary>
        private void InitChartStyle()
        {
            ChtPhotoResistors.ChartAreas[0].BackColor = Color.Blue;
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = 200;
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].AxisY.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisY.Maximum = 1023;
            ChtPhotoResistors.ChartAreas[0].AxisY.Interval = xCount;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;
            ChtPhotoResistors.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            ChtPhotoResistors.ChartAreas[0].CursorX.AutoScroll = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            ChtPhotoResistors.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            ChtPhotoResistors.Series.Count(); // Series1 값 지움
            ChtPhotoResistors.Series.Add("PhotoValue");
            ChtPhotoResistors.Series[0].ChartType = SeriesChartType.Line;
            ChtPhotoResistors.Series[0].Color = Color.LightCoral;
            ChtPhotoResistors.Series[0].BorderWidth = 3;

            // 범례 삭제
            if (ChtPhotoResistors.Legends.Count > 0)
            {
                for (int i = 0; i < ChtPhotoResistors.Legends.Count; i++)
                {
                    ChtPhotoResistors.Legends.RemoveAt(i);
                }
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // TODO 나중에 실제 작업시 작성
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            // TODO 나중에 실제 작업시 설정
        }
        /// <summary>
        /// 시뮬레이션 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuBeginSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            timerSimul.Enabled = true;
            timerSimul.Interval = 1000; // 1초
            timerSimul.Tick += TimerSimul_Tick;
            timerSimul.Start();
        }

        private long timeSpan = 0; // 시간흐름값
        private int randMaxVal = 0; // 랜덤값을 담을 변수

        private void TimerSimul_Tick(object sender, EventArgs e)
        {
            timeSpan += 1;
            var temp = timeSpan % 30; // 10, 11, 12 29, 30 --> 0
            
            if (temp.ToString().Length == 2)
            {
                randMaxVal = 980;
            }
            else
            {
                randMaxVal = 120;
            }

            int value = randPhoto.Next(randMaxVal - 40, randMaxVal); // 1부터 1023까지 사이의 값
            ShowSensorValue(value.ToString());
        }

        private void ShowSensorValue(string value)
        {
            int.TryParse(value, out int v);

            var currentTime = DateTime.Now;
            SensorData data = new SensorData(DateTime.Now, v, IsSimulation);
            sensors.Add(data);
            InsertTable(data);

            // 센서값 갯수
            TxtSensorNum.Text = sensors.Count.ToString(); // $"{sensors.Count}" 같은 값 다른 표현
            // 프로그래스바 현재값 출력
            PrbPhotoResistor.Value = v;
            // 리스트박스에 데이터 출력
            var item = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")}\t{v}";
            LsbPhotoResistors.Items.Add(item);
            LsbPhotoResistors.SelectedIndex = LsbPhotoResistors.Items.Count - 1; // 스크롤 처리, index는 배열이라 0부터 시작이고 count는 1부터 시작이라 -1해줌

            // 차트에 데이터 출력
            ChtPhotoResistors.Series[0].Points.Add(v);

            // 200개 넘으면
            ChtPhotoResistors.ChartAreas[0].AxisX.Minimum = 0;
            ChtPhotoResistors.ChartAreas[0].AxisX.Maximum = (sensors.Count >= xCount) ? sensors.Count : xCount;

            // Zoom처리
            if (sensors.Count > xCount)
                ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            else
                ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(0, xCount);

            // BtnDislay 표시
            if (IsSimulation)
                BtnDisconnect.Text = v.ToString();
            else
                BtnDisplay.Text = "~" + "\n" + v.ToString();
        }

        /// <summary>
        /// IoTData 데이터베이스 내 Tbl_PhotoResistor 테이블에 센서데이터 입력
        /// </summary>
        /// <param name="data"></param>
        private void InsertTable(SensorData data)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    var query = $"insert into Tbl_PhotoResistor " +
                                $"(CurrentDt, Value, SimulFlag)" +
                                $" values" +
                                $" ('{data.Current.ToString("yyyy-MM-dd HH:mm:ss")}','{data.Value}', '{(data.SimulFlag == true ? "1" : "0")}');";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"예외발생 : {ex.Message}");
            }
        }

        /// <summary>
        /// 시뮬레이션 끝
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuEndSimulation_Click(object sender, EventArgs e)
        {
            IsSimulation = false;
            timerSimul.Stop();
        }
        
        /// <summary>
        /// 종료버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (IsSimulation)
            {
                MessageBox.Show("시뮬레이션 멈춘후 프로그램을 종료하세요","종료",
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

            ChtPhotoResistors.ChartAreas[0].AxisX.ScaleView.Zoom(sensors.Count - xCount, sensors.Count);
            ChtPhotoResistors.ChartAreas[0].AxisX.Interval = xCount / 4;

        }
    }
}
