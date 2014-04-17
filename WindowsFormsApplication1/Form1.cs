using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //fsdfds

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] odobrane;
            UdpClient udp = new UdpClient(1234);
            IPEndPoint end =  new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);

            odobrane = udp.Receive(ref end);

        }
    }
}
