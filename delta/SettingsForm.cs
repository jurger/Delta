using System.Windows.Forms;
using  System.IO.Ports;

namespace delta
{
    public partial class Form2 : Form
    {
        readonly IniFile ini = new IniFile(@"C:/test.ini");
        private const string section = "settings";
        public Form2()
        {

            InitializeComponent();
           
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                ComPortComboBox.Items.Add(port);


            ComPortComboBox.Text = ini.IniReadValue(section, "comport");
            BaudeRateComboBox.Text =ini.IniReadValue(section, "Bauderate");
            DataBitsComboBox.Text = ini.IniReadValue(section, "Databits");
            ParityComboBox.Text = ini.IniReadValue(section, "Parity");
            StopBitsComboBox.Text = ini.IniReadValue(section, "Stopbits");
            
            
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ini.IniWriteValue(section,"comport",ComPortComboBox.Text);
            
            ActiveForm.Close();
        }
    }
}
