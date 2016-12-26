namespace HomeworksHome
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Array = new System.Windows.Forms.RadioButton();
            this.Dynamic_Arr = new System.Windows.Forms.RadioButton();
            this.Linked_list = new System.Windows.Forms.RadioButton();
            this.Native_imp = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Put = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Stack = new System.Windows.Forms.RadioButton();
            this.MaxSize = new System.Windows.Forms.TextBox();
            this.Queue = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Performance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Array
            // 
            this.Array.AutoSize = true;
            this.Array.Checked = true;
            this.Array.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Array.Location = new System.Drawing.Point(3, 6);
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(91, 18);
            this.Array.TabIndex = 6;
            this.Array.TabStop = true;
            this.Array.Text = "Array_Based";
            this.Array.UseVisualStyleBackColor = true;
            this.Array.CheckedChanged += new System.EventHandler(this.Array_CheckedChanged);
            // 
            // Dynamic_Arr
            // 
            this.Dynamic_Arr.AutoSize = true;
            this.Dynamic_Arr.Location = new System.Drawing.Point(3, 29);
            this.Dynamic_Arr.Name = "Dynamic_Arr";
            this.Dynamic_Arr.Size = new System.Drawing.Size(131, 17);
            this.Dynamic_Arr.TabIndex = 7;
            this.Dynamic_Arr.Text = "Dynamic_Array_based";
            this.Dynamic_Arr.UseVisualStyleBackColor = true;
            this.Dynamic_Arr.CheckedChanged += new System.EventHandler(this.Dynamic_Arr_CheckedChanged);
            // 
            // Linked_list
            // 
            this.Linked_list.AutoSize = true;
            this.Linked_list.Location = new System.Drawing.Point(3, 52);
            this.Linked_list.Name = "Linked_list";
            this.Linked_list.Size = new System.Drawing.Size(115, 17);
            this.Linked_list.TabIndex = 8;
            this.Linked_list.Text = "Linked_List_Based";
            this.Linked_list.UseVisualStyleBackColor = true;
            this.Linked_list.CheckedChanged += new System.EventHandler(this.Linked_list_CheckedChanged);
            // 
            // Native_imp
            // 
            this.Native_imp.AutoSize = true;
            this.Native_imp.Location = new System.Drawing.Point(3, 75);
            this.Native_imp.Name = "Native_imp";
            this.Native_imp.Size = new System.Drawing.Size(106, 17);
            this.Native_imp.TabIndex = 9;
            this.Native_imp.Text = "Native_Impliment";
            this.Native_imp.UseVisualStyleBackColor = true;
            this.Native_imp.CheckedChanged += new System.EventHandler(this.Native_imp_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = " ";
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(502, 27);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(109, 46);
            this.START.TabIndex = 12;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(8, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(517, 165);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(8, 8);
            this.toolStripContainer1.TabIndex = 13;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Put
            // 
            this.Put.Location = new System.Drawing.Point(14, 74);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(102, 23);
            this.Put.TabIndex = 14;
            this.Put.Text = "Put to buffer";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(142, 74);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(99, 23);
            this.Get.TabIndex = 15;
            this.Get.Text = "Get From Buffer";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dynamic_Arr);
            this.panel1.Controls.Add(this.Array);
            this.panel1.Controls.Add(this.Linked_list);
            this.panel1.Controls.Add(this.Native_imp);
            this.panel1.Location = new System.Drawing.Point(40, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 104);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Stack);
            this.panel2.Controls.Add(this.MaxSize);
            this.panel2.Controls.Add(this.Queue);
            this.panel2.Location = new System.Drawing.Point(40, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 80);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Max Buffer Size = ";
            // 
            // Stack
            // 
            this.Stack.AutoSize = true;
            this.Stack.Location = new System.Drawing.Point(4, 26);
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(53, 17);
            this.Stack.TabIndex = 1;
            this.Stack.Text = "Stack";
            this.Stack.UseVisualStyleBackColor = true;
            this.Stack.CheckedChanged += new System.EventHandler(this.Stack_CheckedChanged);
            // 
            // MaxSize
            // 
            this.MaxSize.Location = new System.Drawing.Point(94, 44);
            this.MaxSize.Name = "MaxSize";
            this.MaxSize.Size = new System.Drawing.Size(100, 20);
            this.MaxSize.TabIndex = 20;
            this.MaxSize.Text = "10";
            // 
            // Queue
            // 
            this.Queue.AutoSize = true;
            this.Queue.Checked = true;
            this.Queue.Location = new System.Drawing.Point(4, 4);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(57, 17);
            this.Queue.TabIndex = 0;
            this.Queue.TabStop = true;
            this.Queue.Text = "Queue";
            this.Queue.UseVisualStyleBackColor = true;
            this.Queue.CheckedChanged += new System.EventHandler(this.Queue_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Get);
            this.panel3.Controls.Add(this.Put);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(247, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 100);
            this.panel3.TabIndex = 18;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.WindowText;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.ForeColor = System.Drawing.Color.Red;
            this.Stop.Location = new System.Drawing.Point(502, 85);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(109, 46);
            this.Stop.TabIndex = 19;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Performance
            // 
            this.Performance.Enabled = false;
            this.Performance.Location = new System.Drawing.Point(263, 147);
            this.Performance.Name = "Performance";
            this.Performance.Size = new System.Drawing.Size(100, 23);
            this.Performance.TabIndex = 20;
            this.Performance.Text = "Performance";
            this.Performance.UseVisualStyleBackColor = true;
            this.Performance.Click += new System.EventHandler(this.Performance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time elapsed for this test:";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(446, 215);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(10, 13);
            this.timer.TabIndex = 22;
            this.timer.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 255);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Performance);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.START);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stack and Queue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Array;
        private System.Windows.Forms.RadioButton Dynamic_Arr;
        private System.Windows.Forms.RadioButton Linked_list;
        private System.Windows.Forms.RadioButton Native_imp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Stack;
        private System.Windows.Forms.RadioButton Queue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxSize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Performance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timer;


    }
}

