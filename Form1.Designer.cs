namespace ReleaseACIDS
{
    partial class MainMenu_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hids_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.hids_Panel = new System.Windows.Forms.Panel();
            this.h_expert_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.h_processList_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.h_numProcesses_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.h_RAMwarnings_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.h_availableRAM_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.h_CPUwarnings_tb = new System.Windows.Forms.TextBox();
            this.h_currentCPU_tb = new System.Windows.Forms.TextBox();
            this.h_export_btn = new System.Windows.Forms.Button();
            this.h_back_btn = new System.Windows.Forms.Button();
            this.main_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nids_btn = new System.Windows.Forms.Button();
            this.nids_Panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.networkWarningTxt = new System.Windows.Forms.TextBox();
            this.bytesReceivedTxt = new System.Windows.Forms.TextBox();
            this.bytesSentTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nidsBackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.hids_Panel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.main_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nids_Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intrusion Detection System Menu";
            // 
            // hids_btn
            // 
            this.hids_btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.hids_btn.Location = new System.Drawing.Point(497, 159);
            this.hids_btn.Name = "hids_btn";
            this.hids_btn.Size = new System.Drawing.Size(462, 222);
            this.hids_btn.TabIndex = 1;
            this.hids_btn.Text = "Hosted IDS";
            this.hids_btn.UseVisualStyleBackColor = true;
            this.hids_btn.Click += new System.EventHandler(this.hids_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.about_btn.Location = new System.Drawing.Point(12, 387);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(479, 222);
            this.about_btn.TabIndex = 3;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.exit_btn.Location = new System.Drawing.Point(497, 387);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(462, 222);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "EXIT ";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // hids_Panel
            // 
            this.hids_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.hids_Panel.Controls.Add(this.h_expert_btn);
            this.hids_Panel.Controls.Add(this.groupBox4);
            this.hids_Panel.Controls.Add(this.panel1);
            this.hids_Panel.Controls.Add(this.groupBox2);
            this.hids_Panel.Controls.Add(this.groupBox1);
            this.hids_Panel.Controls.Add(this.h_export_btn);
            this.hids_Panel.Controls.Add(this.h_back_btn);
            this.hids_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hids_Panel.Location = new System.Drawing.Point(0, 0);
            this.hids_Panel.Name = "hids_Panel";
            this.hids_Panel.Size = new System.Drawing.Size(971, 651);
            this.hids_Panel.TabIndex = 5;
            this.hids_Panel.Visible = false;
            // 
            // h_expert_btn
            // 
            this.h_expert_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.h_expert_btn.Location = new System.Drawing.Point(665, 592);
            this.h_expert_btn.Name = "h_expert_btn";
            this.h_expert_btn.Size = new System.Drawing.Size(144, 47);
            this.h_expert_btn.TabIndex = 25;
            this.h_expert_btn.Text = "Expert Mode";
            this.h_expert_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.h_processList_tb);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.h_numProcesses_tb);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(28, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 533);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Processes";
            // 
            // h_processList_tb
            // 
            this.h_processList_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_processList_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_processList_tb.Location = new System.Drawing.Point(21, 155);
            this.h_processList_tb.Multiline = true;
            this.h_processList_tb.Name = "h_processList_tb";
            this.h_processList_tb.ReadOnly = true;
            this.h_processList_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.h_processList_tb.Size = new System.Drawing.Size(338, 339);
            this.h_processList_tb.TabIndex = 13;
            this.h_processList_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.Location = new System.Drawing.Point(131, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Process List";
            // 
            // h_numProcesses_tb
            // 
            this.h_numProcesses_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_numProcesses_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_numProcesses_tb.Location = new System.Drawing.Point(247, 56);
            this.h_numProcesses_tb.Name = "h_numProcesses_tb";
            this.h_numProcesses_tb.ReadOnly = true;
            this.h_numProcesses_tb.Size = new System.Drawing.Size(106, 28);
            this.h_numProcesses_tb.TabIndex = 13;
            this.h_numProcesses_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Running Processes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(220, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hosted Intrusion Detection System";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.h_RAMwarnings_tb);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.h_availableRAM_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(515, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Warnings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available RAM";
            // 
            // h_RAMwarnings_tb
            // 
            this.h_RAMwarnings_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_RAMwarnings_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_RAMwarnings_tb.Location = new System.Drawing.Point(97, 108);
            this.h_RAMwarnings_tb.Multiline = true;
            this.h_RAMwarnings_tb.Name = "h_RAMwarnings_tb";
            this.h_RAMwarnings_tb.ReadOnly = true;
            this.h_RAMwarnings_tb.Size = new System.Drawing.Size(292, 76);
            this.h_RAMwarnings_tb.TabIndex = 9;
            this.h_RAMwarnings_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.Location = new System.Drawing.Point(-534, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 222);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hosted IDS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // h_availableRAM_tb
            // 
            this.h_availableRAM_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_availableRAM_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_availableRAM_tb.Location = new System.Drawing.Point(283, 39);
            this.h_availableRAM_tb.Name = "h_availableRAM_tb";
            this.h_availableRAM_tb.ReadOnly = true;
            this.h_availableRAM_tb.Size = new System.Drawing.Size(106, 28);
            this.h_availableRAM_tb.TabIndex = 8;
            this.h_availableRAM_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(-534, -106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Intrusion Detection System Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.h_CPUwarnings_tb);
            this.groupBox1.Controls.Add(this.h_currentCPU_tb);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(515, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Monitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Warnings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current CPU usage";
            // 
            // h_CPUwarnings_tb
            // 
            this.h_CPUwarnings_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_CPUwarnings_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_CPUwarnings_tb.Location = new System.Drawing.Point(97, 108);
            this.h_CPUwarnings_tb.Multiline = true;
            this.h_CPUwarnings_tb.Name = "h_CPUwarnings_tb";
            this.h_CPUwarnings_tb.ReadOnly = true;
            this.h_CPUwarnings_tb.Size = new System.Drawing.Size(292, 76);
            this.h_CPUwarnings_tb.TabIndex = 9;
            this.h_CPUwarnings_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // h_currentCPU_tb
            // 
            this.h_currentCPU_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h_currentCPU_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h_currentCPU_tb.Location = new System.Drawing.Point(283, 35);
            this.h_currentCPU_tb.Name = "h_currentCPU_tb";
            this.h_currentCPU_tb.ReadOnly = true;
            this.h_currentCPU_tb.Size = new System.Drawing.Size(106, 28);
            this.h_currentCPU_tb.TabIndex = 8;
            this.h_currentCPU_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // h_export_btn
            // 
            this.h_export_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.h_export_btn.Location = new System.Drawing.Point(515, 592);
            this.h_export_btn.Name = "h_export_btn";
            this.h_export_btn.Size = new System.Drawing.Size(144, 47);
            this.h_export_btn.TabIndex = 8;
            this.h_export_btn.Text = "Export Data";
            this.h_export_btn.UseVisualStyleBackColor = true;
            // 
            // h_back_btn
            // 
            this.h_back_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.h_back_btn.Location = new System.Drawing.Point(815, 592);
            this.h_back_btn.Name = "h_back_btn";
            this.h_back_btn.Size = new System.Drawing.Size(144, 47);
            this.h_back_btn.TabIndex = 1;
            this.h_back_btn.Text = "Back";
            this.h_back_btn.UseVisualStyleBackColor = true;
            // 
            // main_Panel
            // 
            this.main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.main_Panel.Controls.Add(this.panel2);
            this.main_Panel.Controls.Add(this.nids_btn);
            this.main_Panel.Controls.Add(this.exit_btn);
            this.main_Panel.Controls.Add(this.about_btn);
            this.main_Panel.Controls.Add(this.hids_btn);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(971, 651);
            this.main_Panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 100);
            this.panel2.TabIndex = 15;
            // 
            // nids_btn
            // 
            this.nids_btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nids_btn.Location = new System.Drawing.Point(12, 159);
            this.nids_btn.Name = "nids_btn";
            this.nids_btn.Size = new System.Drawing.Size(479, 222);
            this.nids_btn.TabIndex = 5;
            this.nids_btn.Text = "Network IDS";
            this.nids_btn.UseVisualStyleBackColor = true;
            this.nids_btn.Click += new System.EventHandler(this.nids_btn_Click);
            // 
            // nids_Panel
            // 
            this.nids_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.nids_Panel.Controls.Add(this.groupBox3);
            this.nids_Panel.Controls.Add(this.nidsBackBtn);
            this.nids_Panel.Controls.Add(this.panel3);
            this.nids_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nids_Panel.Location = new System.Drawing.Point(0, 0);
            this.nids_Panel.Name = "nids_Panel";
            this.nids_Panel.Size = new System.Drawing.Size(971, 651);
            this.nids_Panel.TabIndex = 1;
            this.nids_Panel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.networkWarningTxt);
            this.groupBox3.Controls.Add(this.bytesReceivedTxt);
            this.groupBox3.Controls.Add(this.bytesSentTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 251);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Traffic";
            // 
            // networkWarningTxt
            // 
            this.networkWarningTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.networkWarningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkWarningTxt.Location = new System.Drawing.Point(108, 137);
            this.networkWarningTxt.Multiline = true;
            this.networkWarningTxt.Name = "networkWarningTxt";
            this.networkWarningTxt.ReadOnly = true;
            this.networkWarningTxt.Size = new System.Drawing.Size(261, 76);
            this.networkWarningTxt.TabIndex = 19;
            // 
            // bytesReceivedTxt
            // 
            this.bytesReceivedTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bytesReceivedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytesReceivedTxt.Location = new System.Drawing.Point(210, 87);
            this.bytesReceivedTxt.Name = "bytesReceivedTxt";
            this.bytesReceivedTxt.ReadOnly = true;
            this.bytesReceivedTxt.Size = new System.Drawing.Size(159, 28);
            this.bytesReceivedTxt.TabIndex = 20;
            // 
            // bytesSentTxt
            // 
            this.bytesSentTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bytesSentTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytesSentTxt.Location = new System.Drawing.Point(210, 37);
            this.bytesSentTxt.Name = "bytesSentTxt";
            this.bytesSentTxt.ReadOnly = true;
            this.bytesSentTxt.Size = new System.Drawing.Size(159, 28);
            this.bytesSentTxt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Warnings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Bytes Received";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bytes Sent";
            // 
            // nidsBackBtn
            // 
            this.nidsBackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nidsBackBtn.Location = new System.Drawing.Point(815, 592);
            this.nidsBackBtn.Name = "nidsBackBtn";
            this.nidsBackBtn.Size = new System.Drawing.Size(144, 47);
            this.nidsBackBtn.TabIndex = 17;
            this.nidsBackBtn.Text = "Back";
            this.nidsBackBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 100);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(220, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(571, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Network Intrustion Detection System";
            // 
            // MainMenu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(971, 651);
            this.Controls.Add(this.hids_Panel);
            this.Controls.Add(this.main_Panel);
            this.Controls.Add(this.nids_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(989, 698);
            this.MinimumSize = new System.Drawing.Size(989, 698);
            this.Name = "MainMenu_form";
            this.Text = "Main Menu";
            this.hids_Panel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.main_Panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nids_Panel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hids_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel hids_Panel;
        private System.Windows.Forms.Button h_back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox h_RAMwarnings_tb;
        private System.Windows.Forms.TextBox h_availableRAM_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox h_CPUwarnings_tb;
        private System.Windows.Forms.TextBox h_currentCPU_tb;
        private System.Windows.Forms.Button h_export_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nids_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel nids_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nidsBackBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox networkWarningTxt;
        private System.Windows.Forms.TextBox bytesReceivedTxt;
        private System.Windows.Forms.TextBox bytesSentTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button h_expert_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox h_processList_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox h_numProcesses_tb;
        private System.Windows.Forms.Label label12;
    }
}

