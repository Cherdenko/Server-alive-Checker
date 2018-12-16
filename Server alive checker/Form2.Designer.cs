namespace Server_alive_checker
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.configBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.modBox = new System.Windows.Forms.TextBox();
            this.profileBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.restartBox1 = new System.Windows.Forms.DateTimePicker();
            this.restartBox2 = new System.Windows.Forms.DateTimePicker();
            this.restartBox3 = new System.Windows.Forms.DateTimePicker();
            this.restartBox4 = new System.Windows.Forms.DateTimePicker();
            this.restartBox5 = new System.Windows.Forms.DateTimePicker();
            this.restartBox6 = new System.Windows.Forms.DateTimePicker();
            this.restartBox7 = new System.Windows.Forms.DateTimePicker();
            this.restartBox8 = new System.Windows.Forms.DateTimePicker();
            this.restartBox9 = new System.Windows.Forms.DateTimePicker();
            this.restartBox10 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.otherArmaParBox = new System.Windows.Forms.TextBox();
            this.battleeyebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            this.toolTip1.SetToolTip(this.label1, "Enter the port of your server here. E.g 2302, 2304, etc");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server config file";
            this.toolTip1.SetToolTip(this.label2, "Format: \"[path]\\Folder\" Only the path to the folder from the root directory of yo" +
        "ur server. nothing more, nothing less.\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profile";
            this.toolTip1.SetToolTip(this.label3, "The desired profile to load with DayZ. (must be a folder)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(239, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "other Startup Parameters";
            this.toolTip1.SetToolTip(this.label4, "must be seperated by space to work. \"-\" needs to be in front of parameter.\r\ngoogl" +
        "e extra parameters for more\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(126, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Battleye folder name";
            this.toolTip1.SetToolTip(this.label5, "needs to be in the server root");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mods";
            this.toolTip1.SetToolTip(this.label6, "currently not supported. Vanilla only\r\n\r\n");
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(12, 27);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(55, 20);
            this.portBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(12, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Restart times";
            this.toolTip1.SetToolTip(this.label11, "Format of the Restarts: [\"HH:mm]");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "add new Restart";
            this.toolTip1.SetToolTip(this.button1, "Format of the Restarts: [\"HH:mm]");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // configBox
            // 
            this.configBox.Location = new System.Drawing.Point(12, 79);
            this.configBox.Name = "configBox";
            this.configBox.Size = new System.Drawing.Size(88, 20);
            this.configBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = ".";
            // 
            // modBox
            // 
            this.modBox.Location = new System.Drawing.Point(12, 130);
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(574, 20);
            this.modBox.TabIndex = 14;
            // 
            // profileBox
            // 
            this.profileBox.Location = new System.Drawing.Point(129, 27);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(74, 20);
            this.profileBox.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(511, 351);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(484, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Game";
            this.toolTip1.SetToolTip(this.label10, "We currently only support the DayZ Stanalone. A2 A3 WIP");
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(451, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // restartBox1
            // 
            this.restartBox1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox1.Location = new System.Drawing.Point(12, 194);
            this.restartBox1.Name = "restartBox1";
            this.restartBox1.ShowUpDown = true;
            this.restartBox1.Size = new System.Drawing.Size(70, 20);
            this.restartBox1.TabIndex = 21;
            // 
            // restartBox2
            // 
            this.restartBox2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox2.Location = new System.Drawing.Point(88, 194);
            this.restartBox2.Name = "restartBox2";
            this.restartBox2.ShowUpDown = true;
            this.restartBox2.Size = new System.Drawing.Size(70, 20);
            this.restartBox2.TabIndex = 22;
            // 
            // restartBox3
            // 
            this.restartBox3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox3.Location = new System.Drawing.Point(164, 194);
            this.restartBox3.Name = "restartBox3";
            this.restartBox3.ShowUpDown = true;
            this.restartBox3.Size = new System.Drawing.Size(70, 20);
            this.restartBox3.TabIndex = 23;
            // 
            // restartBox4
            // 
            this.restartBox4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox4.Location = new System.Drawing.Point(240, 194);
            this.restartBox4.Name = "restartBox4";
            this.restartBox4.ShowUpDown = true;
            this.restartBox4.Size = new System.Drawing.Size(70, 20);
            this.restartBox4.TabIndex = 24;
            // 
            // restartBox5
            // 
            this.restartBox5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox5.Location = new System.Drawing.Point(316, 194);
            this.restartBox5.Name = "restartBox5";
            this.restartBox5.ShowUpDown = true;
            this.restartBox5.Size = new System.Drawing.Size(70, 20);
            this.restartBox5.TabIndex = 25;
            // 
            // restartBox6
            // 
            this.restartBox6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox6.Location = new System.Drawing.Point(392, 194);
            this.restartBox6.Name = "restartBox6";
            this.restartBox6.ShowUpDown = true;
            this.restartBox6.Size = new System.Drawing.Size(70, 20);
            this.restartBox6.TabIndex = 26;
            // 
            // restartBox7
            // 
            this.restartBox7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox7.Location = new System.Drawing.Point(468, 194);
            this.restartBox7.Name = "restartBox7";
            this.restartBox7.ShowUpDown = true;
            this.restartBox7.Size = new System.Drawing.Size(70, 20);
            this.restartBox7.TabIndex = 27;
            // 
            // restartBox8
            // 
            this.restartBox8.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox8.Location = new System.Drawing.Point(12, 220);
            this.restartBox8.Name = "restartBox8";
            this.restartBox8.ShowUpDown = true;
            this.restartBox8.Size = new System.Drawing.Size(70, 20);
            this.restartBox8.TabIndex = 28;
            // 
            // restartBox9
            // 
            this.restartBox9.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox9.Location = new System.Drawing.Point(88, 220);
            this.restartBox9.Name = "restartBox9";
            this.restartBox9.ShowUpDown = true;
            this.restartBox9.Size = new System.Drawing.Size(70, 20);
            this.restartBox9.TabIndex = 29;
            // 
            // restartBox10
            // 
            this.restartBox10.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.restartBox10.Location = new System.Drawing.Point(164, 220);
            this.restartBox10.Name = "restartBox10";
            this.restartBox10.ShowUpDown = true;
            this.restartBox10.Size = new System.Drawing.Size(70, 20);
            this.restartBox10.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "remove restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // otherArmaParBox
            // 
            this.otherArmaParBox.Location = new System.Drawing.Point(239, 27);
            this.otherArmaParBox.Name = "otherArmaParBox";
            this.otherArmaParBox.Size = new System.Drawing.Size(100, 20);
            this.otherArmaParBox.TabIndex = 32;
            // 
            // battleeyebox
            // 
            this.battleeyebox.Location = new System.Drawing.Point(126, 81);
            this.battleeyebox.Name = "battleeyebox";
            this.battleeyebox.Size = new System.Drawing.Size(100, 20);
            this.battleeyebox.TabIndex = 34;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 386);
            this.Controls.Add(this.battleeyebox);
            this.Controls.Add(this.otherArmaParBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.restartBox10);
            this.Controls.Add(this.restartBox9);
            this.Controls.Add(this.restartBox8);
            this.Controls.Add(this.restartBox7);
            this.Controls.Add(this.restartBox6);
            this.Controls.Add(this.restartBox5);
            this.Controls.Add(this.restartBox4);
            this.Controls.Add(this.restartBox3);
            this.Controls.Add(this.restartBox2);
            this.Controls.Add(this.restartBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.modBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox configBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox modBox;
        private System.Windows.Forms.TextBox profileBox;
        public System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker restartBox1;
        private System.Windows.Forms.DateTimePicker restartBox2;
        private System.Windows.Forms.DateTimePicker restartBox3;
        private System.Windows.Forms.DateTimePicker restartBox4;
        private System.Windows.Forms.DateTimePicker restartBox5;
        private System.Windows.Forms.DateTimePicker restartBox6;
        private System.Windows.Forms.DateTimePicker restartBox7;
        private System.Windows.Forms.DateTimePicker restartBox8;
        private System.Windows.Forms.DateTimePicker restartBox9;
        private System.Windows.Forms.DateTimePicker restartBox10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox otherArmaParBox;
        private System.Windows.Forms.TextBox battleeyebox;
    }
}