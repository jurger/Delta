using System.Windows.Forms;
using  System.IO.Ports;
using System.IO;

namespace Delta
{
    public partial class PortForm : Form
    {
        public static bool port_status_changed;
        static readonly string inipath = Directory.GetCurrentDirectory() + @"\deltadvp.ini";
        readonly IniFile ini = new IniFile(inipath);
        private const string section = "settings";

        

        public PortForm()
        {

            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                ComPortComboBox.Items.Add(port);

            if (File.Exists(inipath))
            {
                ComPortComboBox.Text = ini.IniReadValue(section, "comport");
                BaudeRateComboBox.Text = ini.IniReadValue(section, "bauderate");
                DataBitsComboBox.Text = ini.IniReadValue(section, "databits");
                ParityComboBox.Text = ini.IniReadValue(section, "parity");
                StopBitsComboBox.Text = ini.IniReadValue(section, "stopbits");
                
            }
            else
            {
                 
                foreach (var cbox in groupBox1.Controls)
                {
                    if (cbox is ComboBox )
                //        if (((ComboBox) cbox).Name != "ComportComboBox")
                            ((ComboBox) cbox).SelectedIndex = 0;
                    
                }
            }
        }

        private void WriteSettings()
        {
            if (ini != null)
            {
                ini.IniWriteValue(section, "comport", ComPortComboBox.Text);
                ini.IniWriteValue(section, "bauderate", BaudeRateComboBox.Text);
                ini.IniWriteValue(section, "databits", DataBitsComboBox.Text);
                ini.IniWriteValue(section, "parity", ParityComboBox.Text);
                ini.IniWriteValue(section, "stopbits", StopBitsComboBox.Text);
                ini.IniWriteValue(section, "timeout", TimeOutEdit.Text);
                port_status_changed = true;
            }
           
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (TimeOutEdit.Text.Length <= 0)
            {
                MessageBox.Show("Timeout field is empty!");
                TimeOutEdit.Focus();
                return;
            }

            WriteSettings();
            Close();

        }

        private void PortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
                //TODO init com port if form was closed by not "apply button" (only first start)
                if (!File.Exists(inipath))
                    Application.ExitThread();

        }

        private void TimeOutEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            MainForm.SetIntMask(e);
            
        }
    }
}
