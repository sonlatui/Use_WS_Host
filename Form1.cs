using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Use_WS_Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EndpointAddress address = new EndpointAddress(TbAddress1.Text);
            BasicHttpBinding binding = new BasicHttpBinding();
            Lib.ILib proxy = ChannelFactory<Lib.ILib>.CreateChannel(binding, address);
            string tacgia = proxy.GetTacGia(TbTp1.Text);
            LbStt1.Text = tacgia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EndpointAddress address = new EndpointAddress(TbAddress2.Text);
            NetTcpBinding binding = new NetTcpBinding();
            Lib.ILib proxy = ChannelFactory<Lib.ILib>.CreateChannel(binding, address);
            string tacgia = proxy.GetTacGia(TbTp2.Text);
            LbStt2.Text = tacgia;
        }
    }
}
