using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Modbus.Device;
using Modbus.Utility;


namespace Delta
{
    public partial class MainForm : Form
    {
        static readonly string inipath = Directory.GetCurrentDirectory() + @"\deltadvp.ini";
        
        const string Section = "settings";
        readonly IniFile ini = new IniFile(inipath);
        readonly SerialPort port = new SerialPort("COM1");
        DateTime dt = new DateTime();
        const byte slaveId = 0;
        const int timeout = 2000;

        private static void SetHexMask(KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            bool b = (c == '\b' || ('0' <= c && c <= '9') || ('A' <= c && c <= 'F') || ('a' <= c && c <= 'f'));
            if (!b)
                e.Handled = true;

        }

        private void SetFloatMask(KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            bool b = (c == '\b' || ('0' <= c && c <= '9') || c == ',');
            if (!b)
                e.Handled = true;
            if (WValueEdit.Text.IndexOf(',') > 1 && c == ',')
                e.Handled = true;

        }
        public static void SetIntMask(KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            bool b = (c == '\b' || ('0' <= c && c <= '9'));
            if (!b)
                e.Handled = true;
           

        }

        private void InitPort(SerialPort comPort)
        {
            if (comPort.IsOpen)
                comPort.Close();
            
            comPort.PortName = ini.IniReadValue(Section, "comport");
            comPort.BaudRate = Convert.ToInt32(ini.IniReadValue(Section, "bauderate"));
            comPort.DataBits = Convert.ToInt32(ini.IniReadValue(Section, "databits"));

            switch (ini.IniReadValue(Section, "parity"))
            {
                case "Even":
                    comPort.Parity =Parity.Even;
                    break;
                case "Mark":
                    comPort.Parity = Parity.Mark;
                    break;
                case "None":
                    comPort.Parity = Parity.None;
                    break;
                case "Odd":
                    comPort.Parity = Parity.Odd;
                    break;
                case "Space":
                    comPort.Parity = Parity.Space;
                    break;
                default:
                   // throw  new Exception("Not correct parity settings");
                    MessageBox.Show("Not correct parity settings");
                    break;
            }
            switch (ini.IniReadValue(Section, "stopbits"))
            {
                case "None":
                    comPort.StopBits = StopBits.None;
                    break;
                case "1":
                    comPort.StopBits = StopBits.One;
                    break;
                case "1.5":
                    comPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    comPort.StopBits = StopBits.Two;
                    break;
                default:
                    MessageBox.Show("Not correct stop bit settings");
                    break;
                    
            }
            comPort.ReadTimeout =Convert.ToInt32(ini.IniReadValue(Section, "timeout"));


        }
        private void CheckPort()
        {
            if (PortForm.port_status_changed)
                InitPort(port);

        }

        public MainForm()
        {
            InitializeComponent();

            if (File.Exists(inipath) )
            {
                
                InitPort(port);
            }
            else
            {
                PortForm portfrm = new PortForm();
                portfrm.ShowDialog();
               //MessageBox.Show("deltadvp.ini not found", "Header", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //string s = Properties.Resources.TextFile.ini;

            }

        }


        private ushort ReadIntRegister(ushort startAddress )
        {

          CheckPort();
            try
            {
                if (!port.IsOpen)
                    port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);


                ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, 1);

                return registers[0];
            }
            catch (TimeoutException)
            {
                timerGraphUpdate.Stop();
                MessageBox.Show("Порт не отвечает");
                return 0;
            }
            catch (Exception ex)
            {
                timerGraphUpdate.Stop();
                MessageBox.Show(ex.Message);
                return 0;
                
            }


        }

        private float ReadFloatRegister(ushort startAddress)
        {
            CheckPort();
                try
                {
                    if (!port.IsOpen)
                        port.Open();
                    IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                    //master.Transport.ReadTimeout = timeout;

                    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, 2);
                    return
                        ModbusUtility.GetSingle(registers[1], registers[0]);
                }
                catch (TimeoutException)
                {
                    timerGraphUpdate.Stop();
                    MessageBox.Show("Порт не отвечает");
                    return 0;
                }
                catch (Exception ex)
                {
                    timerGraphUpdate.Stop();
                    MessageBox.Show(ex.Message);
                    return 0;

                }

        }

        private void WriteRegisters(ushort startAddress, ushort registerValue)
        {
            CheckPort();

            try
            {
                if (!port.IsOpen)
                    port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                master.Transport.WriteTimeout = timeout;
                master.WriteSingleRegister(slaveId, startAddress, registerValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void WriteRegisters(ushort startAddress, float registerValue)
        {
            CheckPort();

            try
            {
                if (!port.IsOpen)
                    port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateAscii(port);
                var registers = new ushort[4];
                byte[] bytereg = BitConverter.GetBytes(registerValue);
                registers[0] = BitConverter.ToUInt16(bytereg, 0);
                registers[1] = BitConverter.ToUInt16(bytereg, 2);

                master.WriteMultipleRegisters(slaveId, startAddress, registers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ButtonReadIntAddresClick(object sender, EventArgs e)
        {
            if (RAddressEdit.Text.Length > 0)
                label1.Text = ReadIntRegister(Convert.ToUInt16(RAddressEdit.Text, 16)).ToString(CultureInfo.InvariantCulture);
            
            
        }

        private void ButtonWriteIntClick(object sender, EventArgs e)
        {
            if (WValueEdit.Text.IndexOf(',') > -1)
            {
                MessageBox.Show("Value must be integer");
                return;
            }
            WriteRegisters(Convert.ToUInt16(WAddressEdit.Text, 16), Convert.ToUInt16(WValueEdit.Text, 10));

        }

        private void ButtonWriteFloatClick(object sender, EventArgs e)
        {
            if (WAddressEdit.Text.Length > 0)
                WriteRegisters(Convert.ToUInt16(WAddressEdit.Text, 16), Convert.ToSingle(WValueEdit.Text));

            
        }

        private void ButtonReadFloatClick(object sender, EventArgs e)
        {
            if (RAddressEdit.Text.Length > 0)
                label1.Text = ReadFloatRegister(Convert.ToUInt16(RAddressEdit.Text, 16)).ToString(CultureInfo.InvariantCulture);

        }

        private void timerGraphUpdateTick(object sender, EventArgs e)
        {
            
            ushort t = ReadIntRegister(0x100b);
            float p = ReadFloatRegister(0x102e);

            chart1.Series[0].Points.AddXY(dt.Second, t);
            chart2.Series[0].Points.AddXY(dt.Second, p);

            label1.Text = "t = "+ t;
            label5.Text = "P = "+ p;
            
        }

        private void ButtonStartTimerClick(object sender, EventArgs e)
        {
            
            timerGraphUpdate.Start();
            
        }

        private void RAddressEditKeyPress(object sender, KeyPressEventArgs e)
        {
          
            SetHexMask(e);
           

        }


        private void WAddressEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            SetHexMask(e);
        }

        private void WValueEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetFloatMask(e);
        }

        private void comPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortForm frm = new PortForm();
            frm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerGraphUpdate.Stop();
        }

       

        private void TTaskEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || TTaskEdit.Text.Length <= 0) return;
            ushort Ttask = Convert.ToUInt16(TTaskEdit.Text);// =Convert.ToSingle(textBox1.Text);
            WriteRegisters(0x100a, Ttask);
        }

        private void KpFEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || KpFEdit.Text.Length <= 0) return;
            float KpF = Convert.ToSingle(KpFEdit.Text);
            WriteRegisters(0x100c, KpF);
        }

        private void KiFEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || KiFEdit.Text.Length <= 0) return;
            float KiF = Convert.ToSingle(KiFEdit.Text);
            WriteRegisters(0x1034, KiF);
        }

        private void KpFEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetFloatMask(e);
        }

        private void KiFEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetFloatMask(e);
        }

        private void TTaskEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetIntMask(e);
        }




    }
}
