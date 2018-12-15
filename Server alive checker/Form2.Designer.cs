namespace Server_alive_checker
{
    partial class Form2
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
            this.configBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.modBox = new System.Windows.Forms.TextBox();
            this.profileBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profile";
            this.toolTip1.SetToolTip(this.label3, "The desired profile to load with DayZ. (must be a folder)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "other Startup Parameters";
            this.toolTip1.SetToolTip(this.label4, "following page for more information https://forums.dayz.com/topic/239635-dayz-ser" +
        "ver-files-documentation/?tab=comments#comment-2396561\r\nleave empty if not set\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Battleye path";
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
            // configBox
            // 
            this.configBox.Location = new System.Drawing.Point(12, 79);
            this.configBox.Name = "configBox";
            this.configBox.Size = new System.Drawing.Size(88, 20);
            this.configBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Restart every";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "hours, starting from";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(68, 20);
            this.dateTimePicker1.TabIndex = 12;
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
            this.profileBox.Location = new System.Drawing.Point(132, 25);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 386);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.modBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox modBox;
        private System.Windows.Forms.TextBox profileBox;
        public System.Windows.Forms.Button buttonSave;
    }
}