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
            this.hotkey = Keys.F3;
            this.modifiers = 0;
            this.isStarted = false;
            this.clicksIsCPS = true;
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStartStop = new System.Windows.Forms.Label();
            this.lblClickSpeed = new System.Windows.Forms.Label();
            this.lblClickRate = new System.Windows.Forms.Label();
            this.lblPlusMinus = new System.Windows.Forms.Label();
            this.lblRandomness = new System.Windows.Forms.Label();
            this.btnClickSwap = new System.Windows.Forms.Button();
            this.cbxAddRandomness = new System.Windows.Forms.CheckBox();
            this.nudClickSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudRandomness = new System.Windows.Forms.NumericUpDown();
            this.lblcurrentCPS = new System.Windows.Forms.Label();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxModifiers = new System.Windows.Forms.CheckedListBox();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomness)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(50, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartStopClicked);
            // 
            // lblStartStop
            // 
            this.lblStartStop.AutoSize = true;
            this.lblStartStop.Location = new System.Drawing.Point(850, 15);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(119, 32);
            this.lblStartStop.TabIndex = 3;
            this.lblStartStop.Text = "Start/Stop";
            // 
            // lblClickSpeed
            // 
            this.lblClickSpeed.AutoSize = true;
            this.lblClickSpeed.Location = new System.Drawing.Point(50, 15);
            this.lblClickSpeed.Name = "lblClickSpeed";
            this.lblClickSpeed.Size = new System.Drawing.Size(150, 32);
            this.lblClickSpeed.TabIndex = 4;
            this.lblClickSpeed.Text = "Click Speed: ";
            // 
            // lblClickRate
            // 
            this.lblClickRate.AutoSize = true;
            this.lblClickRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClickRate.Location = new System.Drawing.Point(156, 52);
            this.lblClickRate.Name = "lblClickRate";
            this.lblClickRate.Size = new System.Drawing.Size(230, 45);
            this.lblClickRate.TabIndex = 5;
            this.lblClickRate.Text = "click(s)/second";
            // 
            // lblPlusMinus
            // 
            this.lblPlusMinus.AutoSize = true;
            this.lblPlusMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlusMinus.Location = new System.Drawing.Point(50, 150);
            this.lblPlusMinus.Name = "lblPlusMinus";
            this.lblPlusMinus.Size = new System.Drawing.Size(42, 45);
            this.lblPlusMinus.TabIndex = 7;
            this.lblPlusMinus.Text = "±";
            // 
            // lblRandomness
            // 
            this.lblRandomness.AutoSize = true;
            this.lblRandomness.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomness.Location = new System.Drawing.Point(156, 250);
            this.lblRandomness.Name = "lblRandomness";
            this.lblRandomness.Size = new System.Drawing.Size(46, 45);
            this.lblRandomness.TabIndex = 8;
            this.lblRandomness.Text = "%";
            // 
            // btnClickSwap
            // 
            this.btnClickSwap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClickSwap.Location = new System.Drawing.Point(250, 250);
            this.btnClickSwap.Name = "btnClickSwap";
            this.btnClickSwap.Size = new System.Drawing.Size(125, 55);
            this.btnClickSwap.TabIndex = 9;
            this.btnClickSwap.Text = "Swap";
            this.btnClickSwap.UseVisualStyleBackColor = true;
            this.btnClickSwap.Click += new System.EventHandler(this.btnClickSwap_Click);
            // 
            // cbxAddRandomness
            // 
            this.cbxAddRandomness.AutoSize = true;
            this.cbxAddRandomness.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxAddRandomness.Location = new System.Drawing.Point(95, 150);
            this.cbxAddRandomness.Name = "cbxAddRandomness";
            this.cbxAddRandomness.Size = new System.Drawing.Size(316, 49);
            this.cbxAddRandomness.TabIndex = 11;
            this.cbxAddRandomness.Text = "Add Randomness?";
            this.cbxAddRandomness.UseVisualStyleBackColor = true;
            this.cbxAddRandomness.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudClickSpeed
            // 
            this.nudClickSpeed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudClickSpeed.Location = new System.Drawing.Point(50, 50);
            this.nudClickSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickSpeed.Name = "nudClickSpeed";
            this.nudClickSpeed.Size = new System.Drawing.Size(100, 50);
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
            this.nudRandomness.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRandomness.Location = new System.Drawing.Point(50, 250);
            this.nudRandomness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandomness.Name = "nudRandomness";
            this.nudRandomness.Size = new System.Drawing.Size(100, 50);
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
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaxMin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxMin.Location = new System.Drawing.Point(34, 250);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(187, 88);
            this.lblMaxMin.TabIndex = 15;
            this.lblMaxMin.Text = "1 cps";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1138, 425);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblStartStop);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.lblClickSpeed);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(50);
            this.panel5.Size = new System.Drawing.Size(1159, 423);
            this.panel5.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblMaxMin);
            this.panel3.Location = new System.Drawing.Point(831, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50, 50, 30, 15);
            this.panel3.Size = new System.Drawing.Size(276, 360);
            this.panel3.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(50, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 55);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StartStopClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "CPS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hotkey: ";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudClickSpeed);
            this.panel1.Controls.Add(this.lblClickRate);
            this.panel1.Controls.Add(this.nudRandomness);
            this.panel1.Controls.Add(this.lblPlusMinus);
            this.panel1.Controls.Add(this.btnClickSwap);
            this.panel1.Controls.Add(this.cbxAddRandomness);
            this.panel1.Controls.Add(this.lblRandomness);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(466, 360);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panel4.AutoSize = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbxModifiers);
            this.panel4.Controls.Add(this.txtHotkey);
            this.panel4.Location = new System.Drawing.Point(535, 30);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(50);
            this.panel4.Size = new System.Drawing.Size(257, 360);
            this.panel4.TabIndex = 3;
            // 
            // cbxModifiers
            // 
            this.cbxModifiers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbxModifiers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbxModifiers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxModifiers.FormattingEnabled = true;
            this.cbxModifiers.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift",
            "Super"});
            this.cbxModifiers.Location = new System.Drawing.Point(50, 50);
            this.cbxModifiers.Margin = new System.Windows.Forms.Padding(5);
            this.cbxModifiers.Name = "cbxModifiers";
            this.cbxModifiers.Size = new System.Drawing.Size(150, 188);
            this.cbxModifiers.TabIndex = 10;
            this.cbxModifiers.ThreeDCheckBoxes = true;
            this.cbxModifiers.SelectedIndexChanged += new System.EventHandler(this.cbxModifiers_SelectedIndexChanged);
            // 
            // txtHotkey
            // 
            this.txtHotkey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHotkey.Location = new System.Drawing.Point(50, 250);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1138, 425);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblcurrentCPS);
            this.KeyPreview = true;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomness)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Label lblStartStop;
        private Label lblClickSpeed;
        private Label lblClickRate;
        private Label lblPlusMinus;
        private Label lblRandomness;
        private Button btnClickSwap;
        private CheckBox cbxAddRandomness;
        private NumericUpDown nudClickSpeed;
        private NumericUpDown nudRandomness;
        private Label lblcurrentCPS;
        private Label lblMaxMin;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtHotkey;
        private Button btnStop;
        private CheckedListBox cbxModifiers;
        private Label label4;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
    }
}