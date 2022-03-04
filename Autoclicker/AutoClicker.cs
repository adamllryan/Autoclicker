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
        private Keys hotkey;
        private int[] modifiers;
        private bool isStarted, clicksIsCPS, mouseMode;
        private Task t;
        private CancellationToken ct;
        private CancellationTokenSource cts;
        private int mouseButton;
        const int MYACTION_HOTKEY_ID = 1;
        private char[] script;
        public AutoClicker()
        {
            InitializeComponent();
            this.modifiers = new [] { 0, 0, 0, 0};
            this.hotkey = Keys.F3;
            this.isStarted = false;
            this.clicksIsCPS = true;
            this.mouseMode = true;
            this.script = new char[0];
            this.mouseButton = 1;
            WinAPI.RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.F3);
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
                 
                ct = cts.Token;
                int mode = (!this.mouseMode) ? 2 : (cbxAddRandomness.Checked) ? 1 : 0;
                this.script = txtScript.Text.ToCharArray();
                /*for (int i = 0; i < scriptToArray.Length; i++) {
                    this.script[i] = (Keys)scriptToArray[i];
                    MessageBox.Show("test: " + this.script[i].ToString());
                }*/
                

                    t = new Task(()=>
                {
                    uint mouseDown = 0;
                    uint mouseUp = 0;
                    switch (mouseButton) {
                        case 1:
                            mouseDown = (uint)WinAPI.MouseEventFlags.LEFTDOWN;
                            mouseUp = (uint)WinAPI.MouseEventFlags.LEFTUP;
                            break;
                        case 2:
                            mouseDown = (uint)WinAPI.MouseEventFlags.RIGHTDOWN;
                            mouseUp = (uint)WinAPI.MouseEventFlags.RIGHTUP;
                            break;
                        case 3:
                            mouseDown = (uint)WinAPI.MouseEventFlags.MIDDLEDOWN;
                            mouseUp = (uint)WinAPI.MouseEventFlags.MIDDLEUP;
                            break;
                        default:
                            break;
                    }
                    switch (mode) {
                        case 0:
                            //mouse click no random
                            while (!ct.IsCancellationRequested) {
                                WinAPI.mouse_event(mouseDown, 0, 0, 0, 0);
                                WinAPI.mouse_event(mouseUp, 0, 0, 0, 0);
                                Thread.Sleep(msPerClick);
                            }
                            break;
                        case 1:
                            //maxRandom is 2* maximum delay added or subtracted so that we don't actually need to do +/-
                            int maxRandom = (int)(2 * nudRandomness.Value / 100) * msPerClick;
                            //clickDelay is msPerClick but modified so that it starts at the low range of randomness
                            int clickDelay = msPerClick - maxRandom/2;
                            var r = new Random();
                            //mouse click with random
                            while (!ct.IsCancellationRequested)
                            {
                                WinAPI.mouse_event(mouseDown, 0, 0, 0, 0);
                                WinAPI.mouse_event(mouseUp, 0, 0, 0, 0);
                                Thread.Sleep(clickDelay + (int)r.NextInt64(maxRandom));
                            }
                            break;
                        case 2:
                            //keyboard script
                            int i = 0;
                            while (!ct.IsCancellationRequested)
                            {
                                if (i == this.script.Length) ///oop
                                    i = 0;
                                SendKeys.SendWait("" + this.script[i]);
                                i++;
                                Thread.Sleep(msPerClick);
                            }
                            break;
                        default:
                            break;
                    }
                });
                t.Start(); //begin task
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nudRandomness.Enabled = cbxAddRandomness.Checked; //disable numerical up down if unchecked, vice versa
            updateMaxCPS();
        }


        private void StartStopClicked(object sender, EventArgs e)
        {
            startStop();
        }
        //toggle click speed to use value as raw ms
        private void lblClickSwap_Click(object sender, EventArgs e)
        {
            if (clicksIsCPS) {
                clicksIsCPS = false;
                lblClickRate.Text = "ms/action";
                nudClickSpeed.Maximum = 100000; //set cap much higher for slow click rates
            } else {
                clicksIsCPS = true;
                lblClickRate.Text = "action(s)/second";
                nudClickSpeed.Maximum = 100; //max is 100 by default, not sure what the maximum rate is that windows can reliably handle
            }
            updateMaxCPS();
        }
        //Call when random/speed numerical up down boxes have changed values
        private void updateCPSestimate(object sender, EventArgs e)
        {
            updateMaxCPS();
        }
        
        private void updateMaxCPS() {
            //if mode is ms per clicks then convert to cps
            double baseCPS = (clicksIsCPS) ? (double)nudClickSpeed.Value : 1000 / (double)nudClickSpeed.Value;
            double randCPS = (baseCPS * (double)nudRandomness.Value / 100.0); //multiply by the % random
            lblCPSCounter.Text = String.Format("{0:0.00}", baseCPS) + (cbxAddRandomness.Checked ? "±" + String.Format("{0:0.00}", randCPS) : "±0.00"); //display expected cps
        }

        //sets all items in form to value of b, items that require further checking can have additional checks
        private void enableAll(bool b) {
            nudClickSpeed.Enabled = b;
            nudRandomness.Enabled = cbxAddRandomness.Checked ? b : false;
            btnStart.Enabled = b;
            cbxAddRandomness.Enabled = b;
            
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) //if registered hotkey is detected
                startStop();
            base.WndProc(ref m);
        }
        private void txtHotkey_TextChanged(object sender, EventArgs e)
        {
            if (!txtHotkey.Text.Equals("") && txtHotkey.Text.Length < 3 && Enum.TryParse(txtHotkey.Text.ToUpper(), out hotkey)) {
                txtHotkey.ForeColor = Color.Black; //if invalid make text color red
                updateHotkey(); //reregister hotkey
            }
            else
            {
                txtHotkey.ForeColor = Color.Red;
            }
        }

        
        private void updateHotkey() {
            if (!WinAPI.UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID))
                MessageBox.Show("Unregister failed");
            if (!WinAPI.RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, this.modifiers.Sum(), (int)this.hotkey))
            {
                MessageBox.Show("Register failed, the hotkey may already be in use. Hotkey reset to default");
                WinAPI.RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.F3);
                txtHotkey.Text = "F3";
                cbxCtrl.Checked = false;
                cbxAlt.Checked = false;
                cbxShift.Checked = false;
                cbxSuper.Checked = false;
            }
        }

        //Sum: alt = 1, ctrl = 2, shift = 4, super = 8
        //the sum of each are used to determine which are part of the hotkey
        private void cbxAlt_CheckedChanged(object sender, EventArgs e)
        {
            this.modifiers[0] = (cbxAlt.Checked) ? 1 : 0;
            updateHotkey();
        }

        private void cbxCtrl_CheckedChanged(object sender, EventArgs e)
        {
            this.modifiers[1] = (cbxCtrl.Checked) ? 2 : 0;
            updateHotkey();
        }

        private void cbxShift_CheckedChanged(object sender, EventArgs e)
        {
            this.modifiers[2] = (cbxShift.Checked) ? 4 : 0; 
            updateHotkey();
        }

        private void cbxSuper_CheckedChanged(object sender, EventArgs e)
        {
            this.modifiers[3] = (cbxSuper.Checked) ? 8 : 0;
            updateHotkey();
        }

        private void cbxMouseClick_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mouseButton = cbxMouseClick.SelectedIndex+1;
        }
        private void rdbMouse_CheckedChanged(object sender, EventArgs e)
        {
            this.mouseMode = true;
            txtScript.Enabled = false;
            cbxMouseClick.Enabled = true;
            nudClickSpeed.Enabled = true;
            lblClickRate.Enabled = true;
        }

        private void rdbText_CheckedChanged(object sender, EventArgs e)
        {
            this.mouseMode = false;
            txtScript.Enabled = true;
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