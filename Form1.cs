using InTheHand.Net.Sockets;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Wave_n_Click_Server
{
    public partial class Form1 : Form
    {
        const int KEYEVENTF_KEYUP = 0x02;
        const byte VK_CONTROL = 0x11;

        const int MOUSEEVENTF_LEFTDOWN = 0x02;
        const int MOUSEEVENTF_LEFTUP = 0x04;
        const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        const int MOUSEEVENTF_RIGHTUP = 0x10;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        const int MOUSEEVENTF_MIDDLEUP = 0x40;

        readonly Guid serviceClassId = new Guid("94292871-3487-4027-a725-cdda07013a0f");
        readonly string serviceName = "Wave_n_Click";

        System.Windows.Forms.Timer tmr;    
        WindowsInput.MouseSimulator mouseSimulator = new WindowsInput.MouseSimulator();
        WindowsInput.KeyboardSimulator keyboardSimulator = new WindowsInput.KeyboardSimulator();
        TextWriter connectionWriter, connectionWriter2;
        BluetoothListener bluetoothListener;

        int androidScreenWidth, androidScreenHeight;
        bool bluetoothActivated = false;
        string btCommands = "", btCommandsPrev = "";
        string btText = "", btTextPrev = "";
        string btMouseButtons = "";
        string macAddress = "";
        int layoutSelected = 0;
        float accelX, accelY, accelZ;
        float amountX, amountY, zoom, zoomPrev;                      
        string[][] sensorsData;

        bool mustExit = false; // true, if pressed Exit button in system tray
        bool mustSlide = false;

        Label[] labels;
        Panel[] panels;
        string labelStatus1Text;                

        public Form1()
        {
            InitializeComponent();

            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 50;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private void PerformMouseClick(int mouseButton)
        {
            mouse_event(mouseButton, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {            
            // L - Left, R - Right, U - Up, D - Down, m - F10, o - Enter
            string cmd = btCommands;
            if (cmd != "")
            {
                btCommands = "";
                this.SuspendLayout();
                for (int i = 0; i < 11; ++i)
                    panels[i].BackColor = Color.DarkGray;
                this.PerformLayout();
                this.ResumeLayout();

                string[] cmds = cmd.Split(new char[] { (char)3, (char)4 }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < cmds.Length; i += 2)
                {
                    if (cmds[i][1] == 'C') // Single click
                    {
                        int panelIndex = 0;
                        if (cmds[i][0] == 'A')
                            panelIndex = 9;
                        else if (cmds[i][0] == 'B')
                            panelIndex = 10;
                        else
                            panelIndex = Convert.ToInt32(cmds[i][0].ToString()) - 1;
                        string labelText = cmds[i].Substring(2, cmds[i].Length - 2);
                        string commandSent = cmds[i + 1];
                        this.SuspendLayout();
                        panels[panelIndex].BackColor = Color.Red;
                        labels[panelIndex].Text = labelText;
                        labels[panelIndex].Location = new Point((panels[panelIndex].Width - labels[panelIndex].Width) / 2,
                            (panels[panelIndex].Height - labels[panelIndex].Height) / 2);
                        this.PerformLayout();
                        this.ResumeLayout();
                        try { SendKeys.Send("{" + commandSent + "}"); }
                        catch { }
                    }
                }
                btCommandsPrev = cmd;
            }

            // Mouse clicks
            cmd = btMouseButtons;
            for (int i = 0; i < cmd.Length; ++i)
            {
                if (cmd[i] == 'L')
                    PerformMouseClick(MOUSEEVENTF_LEFTDOWN);
                else if (cmd[i] == 'l')
                    PerformMouseClick(MOUSEEVENTF_LEFTUP);
                else if (cmd[i] == 'R')
                    PerformMouseClick(MOUSEEVENTF_RIGHTDOWN);
                else if (cmd[i] == 'r')
                    PerformMouseClick(MOUSEEVENTF_RIGHTUP);
            }
            btMouseButtons = "";

            bool pressedCtrl = (layoutSelected == 1);
            if (zoomPrev != zoom)
            {
                if (zoom > 1)
                {
                    if (pressedCtrl)
                        keyboardSimulator.KeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    mouseSimulator.VerticalScroll((int)(8 * zoom));
                    if (pressedCtrl)
                        keyboardSimulator.KeyUp(WindowsInput.Native.VirtualKeyCode.CONTROL);
                }
                else if (zoom < 1 && zoom != 0)
                {
                    if (pressedCtrl)
                        keyboardSimulator.KeyDown(WindowsInput.Native.VirtualKeyCode.CONTROL);
                    mouseSimulator.VerticalScroll((int)(-8 / zoom));
                    if (pressedCtrl)
                        keyboardSimulator.KeyUp(WindowsInput.Native.VirtualKeyCode.CONTROL);
                }
                zoomPrev = zoom;
            }

            if (layoutSelected == 2 && amountY != 0)
            {
                mouseSimulator.VerticalScroll((int)(amountY * 0.2f));
                mouseSimulator.HorizontalScroll((int)(amountX * 0.05f));
            }

            if (btText != "")
            {
                for (int i = 0; i < btText.Length; ++i)
                {
                    try { SendKeys.SendWait("{" + btText[i].ToString() + "}"); }
                    catch { SendKeys.SendWait(" "); }
                }
                btTextPrev = btText;
                btText = "";
            }

            labelStatus1.Text = labelStatus1Text;
            if (mustSlide && layoutSelected == 1)
            {
                SetCursorPos(Cursor.Position.X + (int)(amountX * 2),  Cursor.Position.Y + (int)(amountY * 2));
                amountX = amountY = 0;
                mustSlide = false;
            }
        }        

        private void ActivateBluetooth()
        {
            labelStatus1Text = "Activating...";
            try { new BluetoothClient(); }
            catch (Exception ex)
            {
                labelStatus1Text = "Cannot activate Bluetooth: " + ex;
            }
            StartListener();
        }

        private void StartListener()
        {
            BluetoothListener listener = new BluetoothListener(serviceClassId);
            listener.ServiceName = serviceName;
            listener.Start();
            bluetoothListener = listener;
            ThreadPool.QueueUserWorkItem(ListenerAccept_Runner, listener);
        }

        private void ListenerAccept_Runner(object state)
        {
            labelStatus1Text = "Activated";
            while (true)
            {
                BluetoothClient client = bluetoothListener.AcceptBluetoothClient();
                NetworkStream peer = client.GetStream();
                SetConnection(peer);
                ReadMessagesToEnd(peer);
            }
        }        

        private void ReadMessagesToEnd(Stream peer)
        {
            StreamReader reader = new StreamReader(peer);
            while (true)
            {
                string line;
                try { line = reader.ReadLine(); }
                catch { break; }
                if (line == null)
                    break;
                string[] command = line.Split(new string[] { ((char)0x02).ToString() }, StringSplitOptions.None);
                // TODO: parse commands in a more elegant way
                if (command.Length >= 3)
                {
                    accelX = Convert.ToSingle(command[0].Replace('.', ','));
                    accelY = Convert.ToSingle(command[1].Replace('.', ','));
                    accelZ = Convert.ToSingle(command[2].Replace('.', ','));
                    if (command.Length >= 4)
                    {
                        btCommands += command[3];
                        if (command.Length >= 5)
                        {
                            btText += command[4];
                            if (command.Length >= 7)
                            {
                                if (!mustSlide)
                                {
                                    amountX = Convert.ToSingle(command[5].Replace('.', ','));
                                    amountY = Convert.ToSingle(command[6].Replace('.', ','));
                                    mustSlide = true;
                                }
                                if (layoutSelected == 2)
                                {
                                    amountX = Convert.ToSingle(command[5].Replace('.', ','));
                                    amountY = Convert.ToSingle(command[6].Replace('.', ','));
                                }
                                if (command.Length >= 9)
                                {
                                    androidScreenWidth = int.Parse(command[7]);
                                    androidScreenHeight = int.Parse(command[8]);
                                    if (command.Length >= 10)
                                    {
                                        btMouseButtons += command[9];
                                        if (command.Length >= 11)
                                        {
                                            if (command[10].ToLower() != "infinity")
                                                zoom = Convert.ToSingle(command[10].Replace('.', ','));
                                            if (command.Length >= 12)
                                            {
                                                layoutSelected = int.Parse(command[11]);
                                                if (command.Length >= 13)
                                                {
                                                    macAddress = command[12];
                                                    if (command.Length >= 14)
                                                    {
                                                        string[] tmpSensors = command[13].Split(new char[] { (char)3 });
                                                        sensorsData = new string[3][];
                                                        for (int i = 0; i < 3; ++i)
                                                        {
                                                            string[] tmpIndication = tmpSensors[i].Split(new char[] { (char)4 });
                                                            sensorsData[i] = new string[tmpIndication.Length - 1];
                                                            for (int j = 0; j < tmpIndication.Length - 1; ++j)
                                                                sensorsData[i][j] = tmpIndication[j];
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            ConnectionCleanup();
        }

        private void SetConnection(Stream peerStream)
        {
            if (connectionWriter != null)
                return;
            StreamWriter writer = new StreamWriter(peerStream);
            connectionWriter = writer;
        }

        private void SetConnection2(Stream peerStream)
        {
            if (connectionWriter2 != null)
                return;
            StreamWriter writer = new StreamWriter(peerStream);
            connectionWriter2 = writer;
        }

        private void ConnectionCleanup()
        {
            TextWriter writer = connectionWriter;
            TextWriter writer2 = connectionWriter2;
            connectionWriter = null;
            connectionWriter2 = null;
            if (writer != null)
            {
                try { writer.Close(); }
                catch (Exception ex) { Debug.WriteLine("ConnectionCleanup close ex: " + ex.Message); }
            }
            if (writer2 != null)
            {
                try { writer2.Close(); }
                catch (Exception ex) { Debug.WriteLine("ConnectionCleanup close ex: " + ex.Message); }
            }
        }

        // Form Handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panelA, panelB };
            labels = new Label[] { labelPanel1, labelPanel2, labelPanel3, labelPanel4, labelPanel5, labelPanel6, labelPanel7,
                labelPanel8, labelPanel9, labelPanelA, labelPanelB };

            FormRedraw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            FormRedraw();
        }

        private void FormRedraw()
        {
            this.SuspendLayout();
            buttonActivate.Location = new Point((this.ClientSize.Width - buttonActivate.Width - buttonDeactivate.Width) / 3, 10);
            buttonDeactivate.Location = new Point(this.ClientSize.Width - ((this.ClientSize.Width - buttonActivate.Width - buttonDeactivate.Width) / 3) - buttonActivate.Width, 10);
            labelStatus1.Location = new Point(10, buttonActivate.Top + buttonActivate.Height + 5);

            panel1.Width = panel2.Width = panel3.Width = panel4.Width = panel5.Width = panel6.Width =
                panel7.Width = panel8.Width = panel9.Width = (this.ClientSize.Width - 40) / 3;
            panel1.Height = panel2.Height = panel3.Height = panel4.Height = panel5.Height = panel6.Height =
                panel7.Height = panel8.Height = panel9.Height = panelA.Height = panelB.Height =
                (this.ClientSize.Height - 30 - buttonActivate.Height - labelStatus1.Height) / 5;
            panel1.Location = new Point(10, labelStatus1.Top + labelStatus1.Height + 10);
            panel2.Location = new Point((this.ClientSize.Width - panel2.Width) / 2, panel1.Top);
            panel3.Location = new Point(this.ClientSize.Width - 10 - panel3.Width, panel2.Top);
            panel4.Location = new Point(10, panel1.Top + panel1.Height + 10);
            panel5.Location = new Point((this.ClientSize.Width - panel5.Width) / 2, panel4.Top);
            panel6.Location = new Point(this.ClientSize.Width - 10 - panel6.Width, panel5.Top);
            panel7.Location = new Point(10, panel4.Top + panel4.Height + 10);
            panel8.Location = new Point((this.ClientSize.Width - panel8.Width) / 2, panel7.Top);
            panel9.Location = new Point(this.ClientSize.Width - 10 - panel9.Width, panel8.Top);

            panelA.Width = panelB.Width = (this.ClientSize.Width - 30) / 2;
            panelA.Location = new Point(10, panel9.Top + panel9.Height + 15);
            panelB.Location = new Point(this.ClientSize.Width - 10 - panelB.Width, panelA.Top);

            labelPanel1.Location = new Point((panel1.Width - labelPanel1.Width) / 2, (panel1.Height - labelPanel1.Height) / 2);
            labelPanel2.Location = new Point((panel2.Width - labelPanel2.Width) / 2, (panel2.Height - labelPanel2.Height) / 2);
            labelPanel3.Location = new Point((panel3.Width - labelPanel3.Width) / 2, (panel3.Height - labelPanel3.Height) / 2);
            labelPanel4.Location = new Point((panel4.Width - labelPanel4.Width) / 2, (panel4.Height - labelPanel4.Height) / 2);
            labelPanel5.Location = new Point((panel5.Width - labelPanel5.Width) / 2, (panel5.Height - labelPanel5.Height) / 2);
            labelPanel6.Location = new Point((panel6.Width - labelPanel6.Width) / 2, (panel6.Height - labelPanel6.Height) / 2);
            labelPanel7.Location = new Point((panel7.Width - labelPanel7.Width) / 2, (panel7.Height - labelPanel7.Height) / 2);
            labelPanel8.Location = new Point((panel8.Width - labelPanel8.Width) / 2, (panel8.Height - labelPanel8.Height) / 2);
            labelPanel9.Location = new Point((panel9.Width - labelPanel9.Width) / 2, (panel9.Height - labelPanel9.Height) / 2);
            labelPanelA.Location = new Point((panelA.Width - labelPanelA.Width) / 2, (panelA.Height - labelPanelA.Height) / 2);
            labelPanelB.Location = new Point((panelB.Width - labelPanelB.Width) / 2, (panelB.Height - labelPanelB.Height) / 2);

            buttonInformation.Width = this.ClientSize.Width - 20;
            buttonInformation.Location = new Point(10, panelB.Top + panelB.Height + 10);
            this.PerformLayout();
            this.ResumeLayout();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!mustExit)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            if (!bluetoothActivated)
            {
                bluetoothActivated = true;
                buttonDeactivate.Enabled = toolStripMenuItemDeactivateBluetooth.Enabled = true;
                buttonActivate.Enabled = toolStripMenuItemActivateBluetooth.Enabled = false;
                ActivateBluetooth();
            }
        }

        private void buttonDeactivate_Click(object sender, EventArgs e)
        {
            ConnectionCleanup();
            bluetoothActivated = false;
            buttonDeactivate.Enabled = toolStripMenuItemDeactivateBluetooth.Enabled = false;
            buttonActivate.Enabled = toolStripMenuItemActivateBluetooth.Enabled = true;
            labelStatus1Text = "Deactivated";
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            string msg = "MAC address of last connected device: " + macAddress + "\n" +
                "Sensors indication:\n" + "Accelerometer:\n";
            try
            {
                if (sensorsData[0].Length >= 3)
                    msg += " (" + sensorsData[0][0] + "; " + sensorsData[0][1] + "; " + sensorsData[0][2] + ")\n";
                else msg += " (none)\n";

                msg += "Gravity sensor:";
                if (sensorsData[1].Length >= 3)
                    msg += " (" + sensorsData[1][0] + "; " + sensorsData[1][1] + "; " + sensorsData[1][2] + ")\n";
                else msg += " (none)\n";

                msg += "Orientation sensor:";
                if (sensorsData[2].Length >= 3)
                    msg += " (" + sensorsData[2][0] + "; " + sensorsData[2][1] + "; " + sensorsData[2][2] + ")\n";
                else msg += " (none)\n";

                // TODO: add support for more sensors
            }
            catch { }
            MessageBox.Show(msg);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (!this.Visible) // don't show up the window again if it has already been shown
                this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            mustExit = true;
            Application.Exit();
        }
    }
}