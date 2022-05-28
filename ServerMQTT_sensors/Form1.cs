using RabbitMQ.Client;
using System;
using System.Net.NetworkInformation;
using System.Text;

namespace ServerMQTT_sensors
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        Dane dane = new Dane();

        //  MqttClient client = new MqttClient("sparrow.rmq.cloudamqp.com");
        //  string clientId = Guid.NewGuid().ToString();
        ConnectionFactory factory = new ConnectionFactory()
        {
            HostName = "sparrow.rmq.cloudamqp.com",
            UserName = "cpssdxpi",
            VirtualHost = "cpssdxpi",
            Password = "AURv9PPOThs9ue1xlX7CUJbGS-FWxDIb"
        };

        IConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = factory.CreateConnection();
            dane.mac = CompParam.ShowNetworkInterfaces();
            //   CompParam cp = new CompParam(show)
        }
        private void SendDataServerMQTT(IConnection connection, Dane dane)
        {



            string strValue1 = Convert.ToString(lbICPU.Text);
            string strValue2 = Convert.ToString(lbIRAM.Text);
            string strValue3 = Convert.ToString(lblFREQ.Text);

            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "sensors",
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                //  string message = Environment.MachineName + ";" + computerProperties.DomainName + "192.168.3.45"+ " + strValue1 + ";" + strValue2 + ";" + strValue3;
                string message = String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",Environment.MachineName, computerProperties.DomainName, dane.ip, dane.mac,dane.CPU,dane.RAM,dane.FRC,dane.GPUTEMP,dane.FRC_value,dane.time);

                var body = Encoding.UTF8.GetBytes(message);

               
                    channel.BasicPublish(exchange: "",
                                         routingKey: "sensors",
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine(" [x] Sent {0}", message);

                   
                
            }

            

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dane dane = new Dane();
            DateTime dt = DateTime.Now; 
          //   dane.mac = CompParam.ShowNetworkInterfaces();
            CompParam.ShowNetworkInterfaces();
            //CompParam cp = new CompParam();
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            //  float tcpu = TempCPU.NextValue();
            float freqCPU = FreqCPU.NextValue();
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float freqCPU_val = FreqCPU_value.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            metroProgressBarFREQ.Value = (int)freqCPU;
            lbICPU.Text = String.Format("{0:0.00}", fcpu);
            lbIRAM.Text = String.Format("{0:0.00}", fram);
            lblFREQ.Text = String.Format("{0:0.00}", freqCPU);
            dane.RAM = String.Format("{0:0.00}", fram);
            dane.CPU = String.Format("{0:0.00}", fcpu);
            dane.FRC = String.Format("{0:0.00}", freqCPU);
            dane.FRC_value = String.Format("{0000}", freqCPU_val);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            chart1.Series["FREQ"].Points.AddY(freqCPU);
            dane.time = Timestamp.ToString();

            SendDataServerMQTT(connection, dane);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
