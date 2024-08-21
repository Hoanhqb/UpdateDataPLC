using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace UpdateDataPLC
{
    public partial class FdataUpdate : Form
    {
        // Connect to PLC
        private ActUtlType plc = new ActUtlType();
        private Timer tmrUpdate = new Timer();
        Timer updateData = new Timer();

        public FdataUpdate()
        {
            InitializeComponent();
            tmrUpdate.Interval = 1000; // 1 second interval
            tmrUpdate.Tick += TmrUpdate_Tick;
            updateData.Interval = 500;
            updateData.Tick += UpdateData_Tick;
            
        }

        private void UpdateData_Tick(object? sender, EventArgs e)
        {
            
                // read register Y
                plc.GetDevice("y0", out int dataY0);
                WriteData("dataY0.txt", dataY0.ToString());
                plc.GetDevice("y1", out int dataY1);
                WriteData("dataY1.txt", dataY1.ToString());
                plc.GetDevice("y2", out int dataY2);
                WriteData("dataY2.txt", dataY2.ToString());
                plc.GetDevice("y3", out int dataY3);
                WriteData("dataY3.txt", dataY3.ToString());
                plc.GetDevice("y4", out int dataY4);
                WriteData("dataY4.txt", dataY4.ToString());
                plc.GetDevice("y5", out int dataY5);
                WriteData("dataY5.txt", dataY5.ToString());
                plc.GetDevice("y6", out int dataY6);
                WriteData("dataY6.txt", dataY6.ToString());
                plc.GetDevice("y7", out int dataY7);
                WriteData("dataY7.txt", dataY7.ToString());
                // Read register X
                plc.GetDevice("X0", out int dataX0);
                WriteData("dataX0.txt", dataX0.ToString());
                plc.GetDevice("X1", out int dataX1);
                WriteData("dataX1.txt", dataX1.ToString());
                plc.GetDevice("X2", out int dataX2);
                WriteData("dataX2.txt", dataX2.ToString());
                plc.GetDevice("X3", out int dataX3);
                WriteData("dataX3.txt", dataX3.ToString());
                plc.GetDevice("X4", out int dataX4);
                WriteData("dataX4.txt", dataX4.ToString());
                plc.GetDevice("X5", out int dataX5);
                WriteData("dataX5.txt", dataX5.ToString());
                plc.GetDevice("X6", out int dataX6);
                WriteData("dataX6.txt", dataX6.ToString());
                plc.GetDevice("X7", out int dataX7);
                WriteData("dataX7.txt", dataX7.ToString());
                // throw new NotImplementedException();
            
        }

        private void TmrUpdate_Tick(object sender, EventArgs e)
        {
           
            //read register X
        }

        private void WriteData(string filePath, string dataWrite)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, dataWrite);
            }
            else
            {
                using (FileStream fs = File.Create(filePath)) { }
                File.WriteAllText(filePath, dataWrite);
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                plc.ActLogicalStationNumber = Convert.ToInt32(textStaNO.Text);
                plc.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                picturePLCRun.BackColor = Color.GreenYellow;
                picturePLCStop.BackColor = Color.Silver;
                listBoxDisplay.Items.Add("Kết nối PLC thành công!!!");

                // Start the timer when the connection is successful
               // tmrUpdate.Start();
                updateData.Start();
            }
            catch (Exception ex)
            {
                listBoxDisplay.Items.Add(ex.Message);
                listBoxDisplay.Items.Add("Vui Lòng Nhập vào số");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            plc.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
           // tmrUpdate.Stop();
            picturePLCRun.BackColor = Color.Silver;
            picturePLCStop.BackColor = Color.Red;
            listBoxDisplay.Items.Add("Đã ngắt kết nối!!!");
            updateData.Stop();
        }

        private void FdataUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrUpdate.Stop();
            plc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FdataUpdate_Load(object sender, EventArgs e)
        {

        }

        private void setingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
           
            listBoxDisplay.Items.Clear();
        }
    }
}
