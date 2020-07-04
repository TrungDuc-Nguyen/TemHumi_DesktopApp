using CsvHelper;
using CsvHelper.Configuration;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_uart
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Rk2NtmNiepwvw0UFnT2q1bhBtouKZogbZvpvDtPK",
            BasePath = "https://temhumidht12.firebaseio.com/"
        };

        IFirebaseClient client;

        SerialPort serial = null;
        float temInt;
        float temF;
        float humiInt;
        float humiF;
        int i = 0;
        float tem_old = 0;
        float humi_old = 0;
        int wait_read = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            /*if(client != null)
            {
                //MessageBox.Show("CLient ok");
            }*/

            serial = new SerialPort("COM6");
            serial.BaudRate = 2400;
            serial.Parity = Parity.None;
            serial.StopBits = StopBits.One;
            serial.DataBits = 8;

            serial.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

            serial.Open();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            serial.Close();
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private float convert(float a, float b)
        {
            if(b < 10)
            {
                return a + b / 10f;
            }
            else if(b < 100)
            {
                return a + b / 100f;
            }
            else
            {
                return a + b / 1000f;
            }
        }

        private async void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            float a = serial.ReadChar();
            if (i == 0)
            {
                humiInt = a;
                i++;
            }
            else if(i == 1)
            {
                humiF = a;
                i++;
            }
            else if(i == 2)
            {
                temInt = a;
                i++;
            }
            else if(i == 3)
            {
                temF = a;
                i++;
            }

            Console.WriteLine("");

            if(i == 4)
            {
                i = 0;
                wait_read = 1;
                Console.WriteLine("--Read Start--");
                Console.WriteLine("Nhiet do:");
                Console.WriteLine(convert(temInt, temF));

                Console.WriteLine("Do am:");
                Console.WriteLine(convert(humiInt, humiF));

                DateTime dTime = DateTime.Now;
                int year = dTime.Year;
                int month = dTime.Month;
                int day = dTime.Day;
                int hour = dTime.Hour;
                int minute = dTime.Minute;
                int second = dTime.Second;

                String time_check = year.ToString() + ":" + month.ToString() + ":"
                    + day.ToString() + "/" + hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();

                //MessageBox.Show(serial.ReadExisting());

                // write data to csv file 
                var records = new List<TemHumiHistory>
                {
                    new TemHumiHistory{Time = time_check, Temperature = convert(temInt, temF), Humidity = convert(humiInt, humiF)},
                };

               // Task.Delay(50000);
                // lb_tem_value.Text = convert(temInt, temF).ToString();
                // lb_humi_value.Text = convert(humiInt, humiF).ToString();
                //lb_tem_value.Text = "hello";
                using(FileStream fileStream = new FileStream("tem_humi.csv", FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (var sw = new StreamWriter(fileStream))
                    {
                        using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
                        {

                            csv.WriteRecords(records);
                        }
                    }
                }


                

                // send data to firebase
                var dt = new TemHumiHistory
                { Time = time_check, Temperature = convert(temInt, temF), Humidity = convert(humiInt, humiF) };

                SetResponse response = await client.SetTaskAsync("TemHumiObject", dt);
                // TemHumiHistory res = response.ResultAs<TemHumiHistory>();

                /*if(res != null)
                {
                    MessageBox.Show("Sen ok");
                }*/

                

            }
        }


        private void Btn_check_Click(object sender, EventArgs e)
        {
            serial.Write(new char[] { '0' }, 0, 1); // send to atmega to check data
            
            lb_tem_value.Text = convert(temInt, temF).ToString()+ " ℃";
            lb_humi_value.Text = convert(humiInt, humiF).ToString() + "%";
        }

    }
}
