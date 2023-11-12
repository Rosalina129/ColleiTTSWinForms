namespace ColleiVoiceSpeaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            param4Value = new System.Windows.Forms.Label();
            param4trackBar = new System.Windows.Forms.TrackBar();
            label8 = new System.Windows.Forms.Label();
            param3Value = new System.Windows.Forms.Label();
            param3trackBar = new System.Windows.Forms.TrackBar();
            label10 = new System.Windows.Forms.Label();
            param2Value = new System.Windows.Forms.Label();
            param2trackBar = new System.Windows.Forms.TrackBar();
            label6 = new System.Windows.Forms.Label();
            param1Value = new System.Windows.Forms.Label();
            param1trackBar = new System.Windows.Forms.TrackBar();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)param4trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)param3trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)param2trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)param1trackBar).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(776, 176);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 关于ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            关于ToolStripMenuItem.Text = "关于";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(713, 451);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "生成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 444);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 30);
            label1.TabIndex = 3;
            label1.Text = "© 2016-2023 Collei_Madcat\r\n© 2023 Stardust·减";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "SDP Ratio";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(param4Value);
            panel1.Controls.Add(param4trackBar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(param3Value);
            panel1.Controls.Add(param3trackBar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(param2Value);
            panel1.Controls.Add(param2trackBar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(param1Value);
            panel1.Controls.Add(param1trackBar);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 263);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(776, 123);
            panel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(661, 97);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 23);
            button4.TabIndex = 17;
            button4.Text = "恢复默认配置";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(543, 97);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 23);
            button3.TabIndex = 12;
            button3.Text = "保存当前配置";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // param4Value
            // 
            param4Value.AutoSize = true;
            param4Value.Location = new System.Drawing.Point(720, 58);
            param4Value.Name = "param4Value";
            param4Value.Size = new System.Drawing.Size(13, 15);
            param4Value.TabIndex = 16;
            param4Value.Text = "1";
            // 
            // param4trackBar
            // 
            param4trackBar.Location = new System.Drawing.Point(452, 54);
            param4trackBar.Maximum = 20;
            param4trackBar.Minimum = 5;
            param4trackBar.Name = "param4trackBar";
            param4trackBar.Size = new System.Drawing.Size(262, 45);
            param4trackBar.TabIndex = 12;
            param4trackBar.Value = 5;
            param4trackBar.Scroll += param4trackBar_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(377, 58);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(44, 15);
            label8.TabIndex = 15;
            label8.Text = "Length";
            // 
            // param3Value
            // 
            param3Value.AutoSize = true;
            param3Value.Location = new System.Drawing.Point(720, 9);
            param3Value.Name = "param3Value";
            param3Value.Size = new System.Drawing.Size(22, 15);
            param3Value.TabIndex = 14;
            param3Value.Text = "0.6";
            // 
            // param3trackBar
            // 
            param3trackBar.Location = new System.Drawing.Point(452, 3);
            param3trackBar.Maximum = 15;
            param3trackBar.Name = "param3trackBar";
            param3trackBar.Size = new System.Drawing.Size(262, 45);
            param3trackBar.TabIndex = 11;
            param3trackBar.Scroll += param3trackBar_Scroll;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(377, 9);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(59, 15);
            label10.TabIndex = 13;
            label10.Text = "音素长度";
            // 
            // param2Value
            // 
            param2Value.AutoSize = true;
            param2Value.Location = new System.Drawing.Point(346, 58);
            param2Value.Name = "param2Value";
            param2Value.Size = new System.Drawing.Size(22, 15);
            param2Value.TabIndex = 10;
            param2Value.Text = "0.8";
            // 
            // param2trackBar
            // 
            param2trackBar.Location = new System.Drawing.Point(122, 54);
            param2trackBar.Maximum = 15;
            param2trackBar.Name = "param2trackBar";
            param2trackBar.Size = new System.Drawing.Size(218, 45);
            param2trackBar.TabIndex = 1;
            param2trackBar.Scroll += param2trackBar_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 58);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 15);
            label6.TabIndex = 8;
            label6.Text = "感情变化 (Noise)";
            // 
            // param1Value
            // 
            param1Value.AutoSize = true;
            param1Value.Location = new System.Drawing.Point(346, 9);
            param1Value.Name = "param1Value";
            param1Value.Size = new System.Drawing.Size(22, 15);
            param1Value.TabIndex = 7;
            param1Value.Text = "0.4";
            // 
            // param1trackBar
            // 
            param1trackBar.Location = new System.Drawing.Point(122, 3);
            param1trackBar.Name = "param1trackBar";
            param1trackBar.Size = new System.Drawing.Size(218, 45);
            param1trackBar.TabIndex = 0;
            param1trackBar.Scroll += param1trackBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "文本";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 245);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "参数设置";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(12, 392);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(776, 49);
            textBox2.TabIndex = 10;
            textBox2.Visible = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(595, 451);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 23);
            button2.TabIndex = 11;
            button2.Text = "修改保存位置";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 486);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Collei 语音合成";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)param4trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)param3trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)param2trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)param1trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label param1Value;
        private System.Windows.Forms.TrackBar param1trackBar;
        private System.Windows.Forms.Label param2Value;
        private System.Windows.Forms.TrackBar param2trackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label param4Value;
        private System.Windows.Forms.TrackBar param4trackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label param3Value;
        private System.Windows.Forms.TrackBar param3trackBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
