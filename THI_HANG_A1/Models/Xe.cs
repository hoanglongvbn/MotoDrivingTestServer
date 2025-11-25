using THI_HANG_A1.Managers;

namespace THI_HANG_A1.Models
{
    public class Xe
    {
        public string MaXe { get; set; }
        public bool DangRanh { get; set; }
        public string SBDThiSinhHienTai { get; set; }
        public int GiaiDoan { get; set; }


        private string Name;

        public SocketHandler socketConn = new SocketHandler();

        public void configSocket(string ip, int port)
        {
            socketConn.IPAddress = ip;
            socketConn.IPPort = port;
        }
        public void connect()
        {
            if (socketConn.Connect())
            {
                // Lắng nghe dữ liệu từ ESP32
                socketConn.OnDataReceived += (data) =>
                {
                    this.Invoke(new Action(() =>
                    {
                        txtLog.Text += "ESP32: " + data + Environment.NewLine;
                    }));
                };

                socketConn.OnDisconnected += () =>
                {
                    this.Invoke(new Action(() =>
                    {
                        txtLog.Text += "Mất kết nối ESP32 !!!\n";
                    }));
                };
            }
        }
        public void disconnect() { socketConn.Disconnect(); }







    }
}
