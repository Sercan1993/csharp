using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    public partial class ohmaj_indicator : Form
    {
        public ohmaj_indicator()
        {
            InitializeComponent();
        }

        private void ohmaj_indicator_Load(object sender, EventArgs e)
        {
            for (int i = 0; i< System.IO.Ports.SerialPort.GetPortNames().Length;i++)
            {
                liste.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
            }
        }

        private void baglan_Click(object sender, EventArgs e)
        {
            timer1.Start();

            try
            {
                serialPort1.PortName = liste.Text;
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }

            catch
            {
                MessageBox.Show("seri bağlantı sağlandı.");
            }
        }

        private void baglantiyikes_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            catch
            {
                MessageBox.Show("seri bağlantı sona erdi");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                int alınandata = Convert.ToInt16(serialPort1.ReadExisting());
                alınandata = ((alınandata*1000)/512);
                progressBar1.Value = alınandata;
                okunandeger.Text = alınandata.ToString() + "ohm";
                System.Threading.Thread.Sleep(100);
            }
            catch(Exception ex) { }

        }
    }

       

 }

    


    


