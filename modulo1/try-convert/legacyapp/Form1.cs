using System;
using System.Windows.Forms;

namespace legacyapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ports = PortsLibrary.Helper.GetAllPorts();
            foreach (var port in ports)
            {
                listBox1.Items.Add(port);
            }
        }
    }
}
