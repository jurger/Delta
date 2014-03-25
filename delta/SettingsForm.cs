using System.Windows.Forms;
using  System.IO.Ports;
using System.IO;

namespace delta
{
    public partial class Form2 : Form
    {

        static string inipath = Directory.GetCurrentDirectory() + @"\deltadvp.ini";
        readonly  IniFile ini = new IniFile(inipath);
        private const string section = "settings";
        public Form2()
        {

            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                ComPortComboBox.Items.Add(port);


            ComPortComboBox.Text = ini.IniReadValue(section, "comport");
            BaudeRateComboBox.Text =ini.IniReadValue(section, "bauderate");
            DataBitsComboBox.Text = ini.IniReadValue(section, "databits");
            ParityComboBox.Text = ini.IniReadValue(section, "parity");
            StopBitsComboBox.Text = ini.IniReadValue(section, "stopbits");
            
            
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ini.IniWriteValue(section,"comport",ComPortComboBox.Text);
            ini.IniWriteValue(section, "bauderate", BaudeRateComboBox.Text);
            ini.IniWriteValue(section, "databits", DataBitsComboBox.Text);
            ini.IniWriteValue(section, "parity", ParityComboBox.Text);
            ini.IniWriteValue(section, "stopbits", StopBitsComboBox.Text);
            
            ActiveForm.Close();
        }
    }
}
