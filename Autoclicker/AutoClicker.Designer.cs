using System;
using System.Threading;
namespace Autoclicker
{
    partial class AutoClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /*
         * TODO: Add settings to save; add keyboard typing automation; add mouse jiggler; add other mouse events
         * A basic autoclicker that can currently: set custom click rates, change click modes, set hotkeys, and 
         * add pseudorandomness to click rates
         * 
         * Demonstrates: task based threading, C# & .NET, Event Handling, GUI Interface, Hotkey usage, etc. 
         * Event Listener model
         */



        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.ttlStartStop = new System.Windows.Forms.Label();
            this.ttlClickSpeed = new System.Windows.Forms.Label();
            this.lblClickRate = new System.Windows.Forms.Label();
            this.lblPlusMinus = new System.Windows.Forms.Label();
            this.lblRandomness = new System.Windows.Forms.Label();
            this.cbxAddRandomness = new System.Windows.Forms.CheckBox();
            this.nudClickSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudRandomness = new System.Windows.Forms.NumericUpDown();
            this.lblcurrentCPS = new System.Windows.Forms.Label();
            this.lblCPSCounter = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHost = new System.Windows.Forms.Panel();
            this.ttlClickMode = new System.Windows.Forms.Label();
            this.pnlClickType = new System.Windows.Forms.Panel();
            this.cbxMouseClick = new System.Windows.Forms.ComboBox();
            this.rdbMouse = new System.Windows.Forms.RadioButton();
            this.rdbText = new System.Windows.Forms.RadioButton();
            this.ttlTypeScript = new System.Windows.Forms.Label();
            this.pnlTypeScript = new System.Windows.Forms.Panel();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.pnlStartStop = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.ttlCPS = new System.Windows.Forms.Label();
            this.ttlHotkey = new System.Windows.Forms.Label();
            this.pnlClickSpeed = new System.Windows.Forms.Panel();
            this.pnlHotkey = new System.Windows.Forms.Panel();
            this.cbxSuper = new System.Windows.Forms.CheckBox();
            this.cbxShift = new System.Windows.Forms.CheckBox();
            this.cbxAlt = new System.Windows.Forms.CheckBox();
            this.cbxCtrl = new System.Windows.Forms.CheckBox();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomness)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlHost.SuspendLayout();
            this.pnlClickType.SuspendLayout();
            this.pnlTypeScript.SuspendLayout();
            this.pnlStartStop.SuspendLayout();
            this.pnlClickSpeed.SuspendLayout();
            this.pnlHotkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(30, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartStopClicked);
            // 
            // ttlStartStop
            // 
            this.ttlStartStop.AutoSize = true;
            this.ttlStartStop.Location = new System.Drawing.Point(729, 15);
            this.ttlStartStop.Name = "ttlStartStop";
            this.ttlStartStop.Size = new System.Drawing.Size(119, 32);
            this.ttlStartStop.TabIndex = 3;
            this.ttlStartStop.Text = "Start/Stop";
            // 
            // ttlClickSpeed
            // 
            this.ttlClickSpeed.AutoSize = true;
            this.ttlClickSpeed.Location = new System.Drawing.Point(50, 15);
            this.ttlClickSpeed.Name = "ttlClickSpeed";
            this.ttlClickSpeed.Size = new System.Drawing.Size(173, 32);
            this.ttlClickSpeed.TabIndex = 4;
            this.ttlClickSpeed.Text = "Repeat Interval";
            // 
            // lblClickRate
            // 
            this.lblClickRate.AutoSize = true;
            this.lblClickRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClickRate.Location = new System.Drawing.Point(131, 30);
            this.lblClickRate.Name = "lblClickRate";
            this.lblClickRate.Size = new System.Drawing.Size(188, 32);
            this.lblClickRate.TabIndex = 5;
            this.lblClickRate.Text = "action(s)/second";
            this.lblClickRate.Click += new System.EventHandler(this.lblClickSwap_Click);
            // 
            // lblPlusMinus
            // 
            this.lblPlusMinus.AutoSize = true;
            this.lblPlusMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlusMinus.Location = new System.Drawing.Point(59, 90);
            this.lblPlusMinus.Name = "lblPlusMinus";
            this.lblPlusMinus.Size = new System.Drawing.Size(30, 32);
            this.lblPlusMinus.TabIndex = 7;
            this.lblPlusMinus.Text = "±";
            // 
            // lblRandomness
            // 
            this.lblRandomness.AutoSize = true;
            this.lblRandomness.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomness.Location = new System.Drawing.Point(192, 92);
            this.lblRandomness.Name = "lblRandomness";
            this.lblRandomness.Size = new System.Drawing.Size(133, 32);
            this.lblRandomness.TabIndex = 8;
            this.lblRandomness.Text = "% variation";
            // 
            // cbxAddRandomness
            // 
            this.cbxAddRandomness.AutoSize = true;
            this.cbxAddRandomness.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxAddRandomness.Location = new System.Drawing.Point(25, 94);
            this.cbxAddRandomness.Name = "cbxAddRandomness";
            this.cbxAddRandomness.Size = new System.Drawing.Size(28, 27);
            this.cbxAddRandomness.TabIndex = 11;
            this.cbxAddRandomness.UseVisualStyleBackColor = true;
            this.cbxAddRandomness.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudClickSpeed
            // 
            this.nudClickSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudClickSpeed.Location = new System.Drawing.Point(25, 30);
            this.nudClickSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickSpeed.Name = "nudClickSpeed";
            this.nudClickSpeed.Size = new System.Drawing.Size(100, 39);
            this.nudClickSpeed.TabIndex = 12;
            this.nudClickSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickSpeed.ValueChanged += new System.EventHandler(this.updateCPSestimate);
            // 
            // nudRandomness
            // 
            this.nudRandomness.Enabled = false;
            this.nudRandomness.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRandomness.Location = new System.Drawing.Point(86, 88);
            this.nudRandomness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandomness.Name = "nudRandomness";
            this.nudRandomness.Size = new System.Drawing.Size(100, 39);
            this.nudRandomness.TabIndex = 13;
            this.nudRandomness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandomness.ValueChanged += new System.EventHandler(this.updateCPSestimate);
            // 
            // lblcurrentCPS
            // 
            this.lblcurrentCPS.AutoSize = true;
            this.lblcurrentCPS.Location = new System.Drawing.Point(11, 259);
            this.lblcurrentCPS.Name = "lblcurrentCPS";
            this.lblcurrentCPS.Size = new System.Drawing.Size(0, 32);
            this.lblcurrentCPS.TabIndex = 14;
            // 
            // lblCPSCounter
            // 
            this.lblCPSCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCPSCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCPSCounter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPSCounter.Location = new System.Drawing.Point(710, 285);
            this.lblCPSCounter.Name = "lblCPSCounter";
            this.lblCPSCounter.Size = new System.Drawing.Size(255, 53);
            this.lblCPSCounter.TabIndex = 15;
            this.lblCPSCounter.Text = "1.00±0.00";
            this.lblCPSCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pnlHost);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1307, 373);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // pnlHost
            // 
            this.pnlHost.Controls.Add(this.ttlClickMode);
            this.pnlHost.Controls.Add(this.pnlClickType);
            this.pnlHost.Controls.Add(this.ttlTypeScript);
            this.pnlHost.Controls.Add(this.pnlTypeScript);
            this.pnlHost.Controls.Add(this.ttlStartStop);
            this.pnlHost.Controls.Add(this.pnlStartStop);
            this.pnlHost.Controls.Add(this.ttlCPS);
            this.pnlHost.Controls.Add(this.ttlClickSpeed);
            this.pnlHost.Controls.Add(this.lblCPSCounter);
            this.pnlHost.Controls.Add(this.ttlHotkey);
            this.pnlHost.Controls.Add(this.pnlClickSpeed);
            this.pnlHost.Controls.Add(this.pnlHotkey);
            this.pnlHost.Location = new System.Drawing.Point(0, 0);
            this.pnlHost.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHost.Name = "pnlHost";
            this.pnlHost.Padding = new System.Windows.Forms.Padding(30);
            this.pnlHost.Size = new System.Drawing.Size(1309, 375);
            this.pnlHost.TabIndex = 18;
            // 
            // ttlClickMode
            // 
            this.ttlClickMode.AutoSize = true;
            this.ttlClickMode.Location = new System.Drawing.Point(56, 200);
            this.ttlClickMode.Name = "ttlClickMode";
            this.ttlClickMode.Size = new System.Drawing.Size(122, 32);
            this.ttlClickMode.TabIndex = 23;
            this.ttlClickMode.Text = "Click Type";
            // 
            // pnlClickType
            // 
            this.pnlClickType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClickType.Controls.Add(this.cbxMouseClick);
            this.pnlClickType.Controls.Add(this.rdbMouse);
            this.pnlClickType.Controls.Add(this.rdbText);
            this.pnlClickType.Location = new System.Drawing.Point(30, 216);
            this.pnlClickType.Name = "pnlClickType";
            this.pnlClickType.Size = new System.Drawing.Size(371, 127);
            this.pnlClickType.TabIndex = 22;
            // 
            // cbxMouseClick
            // 
            this.cbxMouseClick.FormattingEnabled = true;
            this.cbxMouseClick.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Middle"});
            this.cbxMouseClick.Location = new System.Drawing.Point(60, 43);
            this.cbxMouseClick.Name = "cbxMouseClick";
            this.cbxMouseClick.Size = new System.Drawing.Size(120, 40);
            this.cbxMouseClick.TabIndex = 2;
            this.cbxMouseClick.Text = "Left";
            this.cbxMouseClick.SelectedIndexChanged += new System.EventHandler(this.cbxMouseClick_SelectedIndexChanged);
            // 
            // rdbMouse
            // 
            this.rdbMouse.AutoSize = true;
            this.rdbMouse.Checked = true;
            this.rdbMouse.Location = new System.Drawing.Point(26, 49);
            this.rdbMouse.Margin = new System.Windows.Forms.Padding(30);
            this.rdbMouse.Name = "rdbMouse";
            this.rdbMouse.Size = new System.Drawing.Size(27, 26);
            this.rdbMouse.TabIndex = 0;
            this.rdbMouse.TabStop = true;
            this.rdbMouse.UseVisualStyleBackColor = true;
            this.rdbMouse.CheckedChanged += new System.EventHandler(this.rdbMouse_CheckedChanged);
            // 
            // rdbText
            // 
            this.rdbText.AutoSize = true;
            this.rdbText.Location = new System.Drawing.Point(213, 47);
            this.rdbText.Name = "rdbText";
            this.rdbText.Size = new System.Drawing.Size(88, 36);
            this.rdbText.TabIndex = 1;
            this.rdbText.Text = "Text";
            this.rdbText.UseVisualStyleBackColor = true;
            this.rdbText.CheckedChanged += new System.EventHandler(this.rdbText_CheckedChanged);
            // 
            // ttlTypeScript
            // 
            this.ttlTypeScript.AutoSize = true;
            this.ttlTypeScript.Location = new System.Drawing.Point(1013, 15);
            this.ttlTypeScript.Name = "ttlTypeScript";
            this.ttlTypeScript.Size = new System.Drawing.Size(132, 32);
            this.ttlTypeScript.TabIndex = 21;
            this.ttlTypeScript.Text = "Type Script";
            // 
            // pnlTypeScript
            // 
            this.pnlTypeScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTypeScript.Controls.Add(this.txtScript);
            this.pnlTypeScript.Location = new System.Drawing.Point(998, 30);
            this.pnlTypeScript.Margin = new System.Windows.Forms.Padding(30);
            this.pnlTypeScript.Name = "pnlTypeScript";
            this.pnlTypeScript.Size = new System.Drawing.Size(278, 313);
            this.pnlTypeScript.TabIndex = 19;
            // 
            // txtScript
            // 
            this.txtScript.Enabled = false;
            this.txtScript.Location = new System.Drawing.Point(30, 30);
            this.txtScript.Margin = new System.Windows.Forms.Padding(30);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(216, 251);
            this.txtScript.TabIndex = 0;
            // 
            // pnlStartStop
            // 
            this.pnlStartStop.AutoSize = true;
            this.pnlStartStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartStop.Controls.Add(this.btnStart);
            this.pnlStartStop.Controls.Add(this.btnStop);
            this.pnlStartStop.Location = new System.Drawing.Point(710, 30);
            this.pnlStartStop.Margin = new System.Windows.Forms.Padding(30);
            this.pnlStartStop.Name = "pnlStartStop";
            this.pnlStartStop.Size = new System.Drawing.Size(255, 225);
            this.pnlStartStop.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(30, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(190, 75);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StartStopClicked);
            // 
            // ttlCPS
            // 
            this.ttlCPS.AutoSize = true;
            this.ttlCPS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ttlCPS.Location = new System.Drawing.Point(720, 253);
            this.ttlCPS.Name = "ttlCPS";
            this.ttlCPS.Size = new System.Drawing.Size(75, 45);
            this.ttlCPS.TabIndex = 16;
            this.ttlCPS.Text = "CPS";
            // 
            // ttlHotkey
            // 
            this.ttlHotkey.AutoSize = true;
            this.ttlHotkey.Location = new System.Drawing.Point(447, 15);
            this.ttlHotkey.Name = "ttlHotkey";
            this.ttlHotkey.Size = new System.Drawing.Size(90, 32);
            this.ttlHotkey.TabIndex = 5;
            this.ttlHotkey.Text = "Hotkey";
            // 
            // pnlClickSpeed
            // 
            this.pnlClickSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlClickSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClickSpeed.Controls.Add(this.nudClickSpeed);
            this.pnlClickSpeed.Controls.Add(this.lblClickRate);
            this.pnlClickSpeed.Controls.Add(this.nudRandomness);
            this.pnlClickSpeed.Controls.Add(this.lblPlusMinus);
            this.pnlClickSpeed.Controls.Add(this.cbxAddRandomness);
            this.pnlClickSpeed.Controls.Add(this.lblRandomness);
            this.pnlClickSpeed.Location = new System.Drawing.Point(30, 30);
            this.pnlClickSpeed.Margin = new System.Windows.Forms.Padding(30);
            this.pnlClickSpeed.Name = "pnlClickSpeed";
            this.pnlClickSpeed.Padding = new System.Windows.Forms.Padding(30);
            this.pnlClickSpeed.Size = new System.Drawing.Size(371, 153);
            this.pnlClickSpeed.TabIndex = 17;
            // 
            // pnlHotkey
            // 
            this.pnlHotkey.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.pnlHotkey.AutoSize = true;
            this.pnlHotkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHotkey.Controls.Add(this.cbxSuper);
            this.pnlHotkey.Controls.Add(this.cbxShift);
            this.pnlHotkey.Controls.Add(this.cbxAlt);
            this.pnlHotkey.Controls.Add(this.cbxCtrl);
            this.pnlHotkey.Controls.Add(this.txtHotkey);
            this.pnlHotkey.Location = new System.Drawing.Point(432, 30);
            this.pnlHotkey.Margin = new System.Windows.Forms.Padding(30);
            this.pnlHotkey.Name = "pnlHotkey";
            this.pnlHotkey.Padding = new System.Windows.Forms.Padding(30);
            this.pnlHotkey.Size = new System.Drawing.Size(248, 313);
            this.pnlHotkey.TabIndex = 3;
            // 
            // cbxSuper
            // 
            this.cbxSuper.AutoSize = true;
            this.cbxSuper.Location = new System.Drawing.Point(42, 172);
            this.cbxSuper.Name = "cbxSuper";
            this.cbxSuper.Size = new System.Drawing.Size(171, 36);
            this.cbxSuper.TabIndex = 12;
            this.cbxSuper.Text = "Super (Win)";
            this.cbxSuper.UseVisualStyleBackColor = true;
            this.cbxSuper.CheckedChanged += new System.EventHandler(this.cbxSuper_CheckedChanged);
            // 
            // cbxShift
            // 
            this.cbxShift.AutoSize = true;
            this.cbxShift.Location = new System.Drawing.Point(42, 130);
            this.cbxShift.Name = "cbxShift";
            this.cbxShift.Size = new System.Drawing.Size(95, 36);
            this.cbxShift.TabIndex = 11;
            this.cbxShift.Text = "Shift";
            this.cbxShift.UseVisualStyleBackColor = true;
            this.cbxShift.CheckedChanged += new System.EventHandler(this.cbxShift_CheckedChanged);
            // 
            // cbxAlt
            // 
            this.cbxAlt.AutoSize = true;
            this.cbxAlt.Location = new System.Drawing.Point(42, 88);
            this.cbxAlt.Name = "cbxAlt";
            this.cbxAlt.Size = new System.Drawing.Size(75, 36);
            this.cbxAlt.TabIndex = 10;
            this.cbxAlt.Text = "Alt";
            this.cbxAlt.UseVisualStyleBackColor = true;
            this.cbxAlt.CheckedChanged += new System.EventHandler(this.cbxAlt_CheckedChanged);
            // 
            // cbxCtrl
            // 
            this.cbxCtrl.AutoSize = true;
            this.cbxCtrl.Location = new System.Drawing.Point(42, 46);
            this.cbxCtrl.Name = "cbxCtrl";
            this.cbxCtrl.Size = new System.Drawing.Size(125, 36);
            this.cbxCtrl.TabIndex = 9;
            this.cbxCtrl.Text = "Control";
            this.cbxCtrl.UseVisualStyleBackColor = true;
            this.cbxCtrl.CheckedChanged += new System.EventHandler(this.cbxCtrl_CheckedChanged);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHotkey.Location = new System.Drawing.Point(33, 228);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(150, 50);
            this.txtHotkey.TabIndex = 8;
            this.txtHotkey.Text = "F3";
            this.txtHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHotkey.TextChanged += new System.EventHandler(this.txtHotkey_TextChanged);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1307, 373);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblcurrentCPS);
            this.KeyPreview = true;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomness)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlHost.ResumeLayout(false);
            this.pnlHost.PerformLayout();
            this.pnlClickType.ResumeLayout(false);
            this.pnlClickType.PerformLayout();
            this.pnlTypeScript.ResumeLayout(false);
            this.pnlTypeScript.PerformLayout();
            this.pnlStartStop.ResumeLayout(false);
            this.pnlClickSpeed.ResumeLayout(false);
            this.pnlClickSpeed.PerformLayout();
            this.pnlHotkey.ResumeLayout(false);
            this.pnlHotkey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Label ttlStartStop;
        private Label ttlClickSpeed;
        private Label lblClickRate;
        private Label lblPlusMinus;
        private Label lblRandomness;
        private CheckBox cbxAddRandomness;
        private NumericUpDown nudClickSpeed;
        private NumericUpDown nudRandomness;
        private Label lblcurrentCPS;
        private Label lblCPSCounter;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label ttlHotkey;
        private TextBox txtHotkey;
        private Button btnStop;
        private Label ttlCPS;
        private Panel pnlClickSpeed;
        private Panel pnlHotkey;
        private Panel pnlStartStop;
        private Panel pnlHost;
        private CheckBox cbxSuper;
        private CheckBox cbxShift;
        private CheckBox cbxAlt;
        private CheckBox cbxCtrl;
        private Label ttlTypeScript;
        private Panel pnlTypeScript;
        private TextBox txtScript;
        private ComboBox cbxMouseClick;
        private RadioButton rdbText;
        private RadioButton rdbMouse;
        private Panel pnlClickType;
        private Label ttlClickMode;
    }
}