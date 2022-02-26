using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Autoclicker
{

    public partial class AutoClicker : Form
    {

        
        // settings
        private Keys hotkey = Keys.F3;
        private int modifiers;
        private bool isStarted;
        private bool clicksIsCPS;
        private Task t;
        private CancellationToken ct;
        private CancellationTokenSource cts;
        const int MYACTION_HOTKEY_ID = 1;
        public AutoClicker()
        {
            InitializeComponent();
            

        }


        //toggles the clicker, called by the hotkey method and the buttons, so it is better to have its own method
        private void startStop()
        {
            if (this.isStarted)
            {
                btnStop.Enabled = false; //toggle buttons
                btnStart.Enabled = true;
                this.isStarted = false;
                cts.Cancel(); //cancel the task
            }
            else
            {
                btnStop.Enabled = true; //toggle buttons
                btnStart.Enabled = false;
                this.isStarted = true;
                cts = new CancellationTokenSource(); //create new token for task
                int msPerClick = (int)((!clicksIsCPS) ? nudClickSpeed.Value : 1000 / nudClickSpeed.Value);//calculate ms interval
                int maxRandom = (int)(nudRandomness.Value / 100) * msPerClick;//calculate random %
                var r = new Random(); 
                ct = cts.Token;
                t = new Task(() =>
                {
                    while (!ct.IsCancellationRequested)//loop until cancelled
                    {
                        //click event, TODO: will add option for other buttons 
                        WinAPI.mouse_event((uint)WinAPI.MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                        WinAPI.mouse_event((uint)WinAPI.MouseEventFlags.LEFTUP, 0, 0, 0, 0);
                        if (maxRandom > 0)
                        {
                            int rand = (int)(r.NextDouble() * maxRandom * (r.NextDouble() >= 0.5 ? -1 : 1)); //get random
                            Thread.Sleep(msPerClick + rand);
                        } else 
                            Thread.Sleep(msPerClick);
                    }
                });
                t.Start(); //begin task
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nudRandomness.Enabled = cbxAddRandomness.Checked; //disable numerical up down if unchecked, vice versa
        }


        private void StartStopClicked(object sender, EventArgs e)
        {
            startStop();
        }

        //toggle click speed to use value as raw ms
        private void btnClickSwap_Click(object sender, EventArgs e)
        {
            if (clicksIsCPS) {
                clicksIsCPS = false;
                lblClickRate.Text = "ms/click";
                nudClickSpeed.Maximum = 100000; //set cap much higher for slow click rates
            } else {
                clicksIsCPS = true;
                lblClickRate.Text = "click(s)/second";
                nudClickSpeed.Maximum = 100; //max is 100 by default, not sure what the maximum rate is that windows can reliably handle
            }
        }
        //Call when random/speed numerical up down boxes have changed values
        private void updateCPSestimate(object sender, EventArgs e)
        {
            updateMaxCPS();
        }
        
        private void updateMaxCPS() {
            //if mode is ms per clicks then convert to cps
            int baseCPS = (int)((clicksIsCPS) ? nudClickSpeed.Value : 1000 / nudClickSpeed.Value);
            double randCPS = (double)(baseCPS * nudRandomness.Value / 100); //multiply by the % random
            lblMaxMin.Text = baseCPS + (cbxAddRandomness.Checked ? "±" + randCPS : "") + " cps"; //display expected cps

        }

        //sets all items in form to value of b, items that require further checking can have additional checks
        private void enableAll(bool b) {
            nudClickSpeed.Enabled = b;
            nudRandomness.Enabled = cbxAddRandomness.Checked ? b : false;
            btnClickSwap.Enabled = b;
            btnStart.Enabled = b;
            cbxAddRandomness.Enabled = b;
            btnClickSwap.Enabled = b;
            
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) //if registered hotkey is detected
                startStop();
            base.WndProc(ref m);
        }
        private void txtHotkey_TextChanged(object sender, EventArgs e)
        {
            if (txtHotkey.Text != null || !txtHotkey.Text.Equals("")) {
                if (Enum.TryParse(txtHotkey.Text.ToUpper(), out hotkey)) //try to parse
                { 
                    txtHotkey.ForeColor = hotkey.ToString().Equals("None") ? Color.Red : Color.Black; //if invalid make text color red
                    updateHotkey(); //reregister hotkey
                }
            }
        }

        private void cbxModifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sum: alt = 1, ctrl = 2, shift = 4, super = 8
            //the sum of each are used to determine which are part of the hotkey
            this.modifiers = 0;
            this.modifiers += cbxModifiers.GetItemChecked(0) ? 1 : 0;
            this.modifiers += cbxModifiers.GetItemChecked(1) ? 2 : 0;
            this.modifiers += cbxModifiers.GetItemChecked(2) ? 4 : 0;
            this.modifiers += cbxModifiers.GetItemChecked(3) ? 8 : 0;
            updateHotkey();
        }
        private void updateHotkey() {
            if (!WinAPI.UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID))
                MessageBox.Show("Unregister failed");
            if (!WinAPI.RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, this.modifiers, (int)this.hotkey))
                MessageBox.Show("Register failed");
        }
    } 

    }
    public static class WinAPI {

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        //MouseEvent functions
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        //Test console output; currently unused
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        //Hotkey Functions
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
    }