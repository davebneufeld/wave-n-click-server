namespace Wave_n_Click_Server
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.buttonDeactivate = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemActivateBluetooth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeactivateBluetooth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPanel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPanel2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPanel3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPanel4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPanel5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelPanel6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelPanel7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelPanel8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelPanel9 = new System.Windows.Forms.Label();
            this.panelA = new System.Windows.Forms.Panel();
            this.labelPanelA = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.labelPanelB = new System.Windows.Forms.Label();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus1.Location = new System.Drawing.Point(7, 61);
            this.labelStatus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(0, 16);
            this.labelStatus1.TabIndex = 0;
            // 
            // buttonActivate
            // 
            this.buttonActivate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonActivate.Location = new System.Drawing.Point(19, 10);
            this.buttonActivate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(105, 49);
            this.buttonActivate.TabIndex = 10;
            this.buttonActivate.Text = "Activate";
            this.buttonActivate.UseVisualStyleBackColor = false;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // buttonDeactivate
            // 
            this.buttonDeactivate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDeactivate.Enabled = false;
            this.buttonDeactivate.Location = new System.Drawing.Point(139, 10);
            this.buttonDeactivate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeactivate.Name = "buttonDeactivate";
            this.buttonDeactivate.Size = new System.Drawing.Size(105, 49);
            this.buttonDeactivate.TabIndex = 11;
            this.buttonDeactivate.Text = "Deactivate";
            this.buttonDeactivate.UseVisualStyleBackColor = false;
            this.buttonDeactivate.Click += new System.EventHandler(this.buttonDeactivate_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Wave_n_Click Server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemActivateBluetooth,
            this.toolStripMenuItemDeactivateBluetooth,
            this.toolStripMenuItemSeparator,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 98);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // toolStripMenuItemActivateBluetooth
            // 
            this.toolStripMenuItemActivateBluetooth.Name = "toolStripMenuItemActivateBluetooth";
            this.toolStripMenuItemActivateBluetooth.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemActivateBluetooth.Text = "Activate Bluetooth";
            this.toolStripMenuItemActivateBluetooth.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // toolStripMenuItemDeactivateBluetooth
            // 
            this.toolStripMenuItemDeactivateBluetooth.Enabled = false;
            this.toolStripMenuItemDeactivateBluetooth.Name = "toolStripMenuItemDeactivateBluetooth";
            this.toolStripMenuItemDeactivateBluetooth.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemDeactivateBluetooth.Text = "Deactivate Bluetooth";
            this.toolStripMenuItemDeactivateBluetooth.Click += new System.EventHandler(this.buttonDeactivate_Click);
            // 
            // toolStripMenuItemSeparator
            // 
            this.toolStripMenuItemSeparator.Name = "toolStripMenuItemSeparator";
            this.toolStripMenuItemSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelPanel1);
            this.panel1.Location = new System.Drawing.Point(10, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 55);
            this.panel1.TabIndex = 13;
            // 
            // labelPanel1
            // 
            this.labelPanel1.AutoSize = true;
            this.labelPanel1.ForeColor = System.Drawing.Color.White;
            this.labelPanel1.Location = new System.Drawing.Point(7, 20);
            this.labelPanel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.Size = new System.Drawing.Size(0, 13);
            this.labelPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPanel2);
            this.panel2.Location = new System.Drawing.Point(66, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 55);
            this.panel2.TabIndex = 14;
            // 
            // labelPanel2
            // 
            this.labelPanel2.AutoSize = true;
            this.labelPanel2.ForeColor = System.Drawing.Color.White;
            this.labelPanel2.Location = new System.Drawing.Point(7, 20);
            this.labelPanel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.Size = new System.Drawing.Size(0, 13);
            this.labelPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelPanel3);
            this.panel3.Location = new System.Drawing.Point(122, 133);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 55);
            this.panel3.TabIndex = 14;
            // 
            // labelPanel3
            // 
            this.labelPanel3.AutoSize = true;
            this.labelPanel3.ForeColor = System.Drawing.Color.White;
            this.labelPanel3.Location = new System.Drawing.Point(7, 20);
            this.labelPanel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel3.Name = "labelPanel3";
            this.labelPanel3.Size = new System.Drawing.Size(0, 13);
            this.labelPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelPanel4);
            this.panel4.Location = new System.Drawing.Point(10, 193);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 55);
            this.panel4.TabIndex = 14;
            // 
            // labelPanel4
            // 
            this.labelPanel4.AutoSize = true;
            this.labelPanel4.ForeColor = System.Drawing.Color.White;
            this.labelPanel4.Location = new System.Drawing.Point(7, 20);
            this.labelPanel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel4.Name = "labelPanel4";
            this.labelPanel4.Size = new System.Drawing.Size(0, 13);
            this.labelPanel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelPanel5);
            this.panel5.Location = new System.Drawing.Point(66, 193);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(52, 55);
            this.panel5.TabIndex = 14;
            // 
            // labelPanel5
            // 
            this.labelPanel5.AutoSize = true;
            this.labelPanel5.ForeColor = System.Drawing.Color.White;
            this.labelPanel5.Location = new System.Drawing.Point(7, 20);
            this.labelPanel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel5.Name = "labelPanel5";
            this.labelPanel5.Size = new System.Drawing.Size(0, 13);
            this.labelPanel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelPanel6);
            this.panel6.Location = new System.Drawing.Point(122, 193);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(52, 55);
            this.panel6.TabIndex = 14;
            // 
            // labelPanel6
            // 
            this.labelPanel6.AutoSize = true;
            this.labelPanel6.ForeColor = System.Drawing.Color.White;
            this.labelPanel6.Location = new System.Drawing.Point(7, 20);
            this.labelPanel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel6.Name = "labelPanel6";
            this.labelPanel6.Size = new System.Drawing.Size(0, 13);
            this.labelPanel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.labelPanel7);
            this.panel7.Location = new System.Drawing.Point(9, 252);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(52, 55);
            this.panel7.TabIndex = 14;
            // 
            // labelPanel7
            // 
            this.labelPanel7.AutoSize = true;
            this.labelPanel7.ForeColor = System.Drawing.Color.White;
            this.labelPanel7.Location = new System.Drawing.Point(7, 20);
            this.labelPanel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel7.Name = "labelPanel7";
            this.labelPanel7.Size = new System.Drawing.Size(0, 13);
            this.labelPanel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.labelPanel8);
            this.panel8.Location = new System.Drawing.Point(66, 252);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(52, 55);
            this.panel8.TabIndex = 14;
            // 
            // labelPanel8
            // 
            this.labelPanel8.AutoSize = true;
            this.labelPanel8.ForeColor = System.Drawing.Color.White;
            this.labelPanel8.Location = new System.Drawing.Point(7, 20);
            this.labelPanel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel8.Name = "labelPanel8";
            this.labelPanel8.Size = new System.Drawing.Size(0, 13);
            this.labelPanel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.labelPanel9);
            this.panel9.Location = new System.Drawing.Point(122, 252);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(52, 55);
            this.panel9.TabIndex = 14;
            // 
            // labelPanel9
            // 
            this.labelPanel9.AutoSize = true;
            this.labelPanel9.ForeColor = System.Drawing.Color.White;
            this.labelPanel9.Location = new System.Drawing.Point(7, 20);
            this.labelPanel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel9.Name = "labelPanel9";
            this.labelPanel9.Size = new System.Drawing.Size(0, 13);
            this.labelPanel9.TabIndex = 0;
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.DarkGray;
            this.panelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelA.Controls.Add(this.labelPanelA);
            this.panelA.Location = new System.Drawing.Point(9, 311);
            this.panelA.Margin = new System.Windows.Forms.Padding(2);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(141, 55);
            this.panelA.TabIndex = 15;
            // 
            // labelPanelA
            // 
            this.labelPanelA.AutoSize = true;
            this.labelPanelA.ForeColor = System.Drawing.Color.White;
            this.labelPanelA.Location = new System.Drawing.Point(7, 20);
            this.labelPanelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanelA.Name = "labelPanelA";
            this.labelPanelA.Size = new System.Drawing.Size(0, 13);
            this.labelPanelA.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.DarkGray;
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelB.Controls.Add(this.labelPanelB);
            this.panelB.Location = new System.Drawing.Point(161, 311);
            this.panelB.Margin = new System.Windows.Forms.Padding(2);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(137, 55);
            this.panelB.TabIndex = 14;
            // 
            // labelPanelB
            // 
            this.labelPanelB.AutoSize = true;
            this.labelPanelB.ForeColor = System.Drawing.Color.White;
            this.labelPanelB.Location = new System.Drawing.Point(7, 20);
            this.labelPanelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanelB.Name = "labelPanelB";
            this.labelPanelB.Size = new System.Drawing.Size(0, 13);
            this.labelPanelB.TabIndex = 0;
            // 
            // buttonInformation
            // 
            this.buttonInformation.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInformation.Location = new System.Drawing.Point(10, 371);
            this.buttonInformation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(288, 24);
            this.buttonInformation.TabIndex = 16;
            this.buttonInformation.Text = "Information";
            this.buttonInformation.UseVisualStyleBackColor = false;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 413);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDeactivate);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.labelStatus1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Wave\'n\'Click Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Button buttonDeactivate;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemActivateBluetooth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeactivateBluetooth;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPanel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPanel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelPanel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelPanel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelPanel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelPanel9;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label labelPanelA;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label labelPanelB;
        private System.Windows.Forms.Button buttonInformation;
    }
}

