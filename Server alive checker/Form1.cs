﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Diagnostics;
/*todo
 * need to find a valid way to log if server is alive and when
 * interchangeable options for other games
 * a config file
 * replacement of start options
 * easy configurator for noobs
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * /
namespace Server_alive_checker
{
    public partial class Form1 : Form
    {
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }

            return false;
        }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private int counter = 10;
        public int running = 2;
        public int refresh = 1;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {

            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists(currentDirectory + "/DayZServer_x64.exe"))
            {
                picyesno.BackColor = System.Drawing.Color.SpringGreen;
                label1.Text = "File exists";
                Server_alive_checker();

            }
            else
            {

                picyesno.BackColor = System.Drawing.Color.Red;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();

                label2.Text = counter.ToString();
                label1.Text = "Seems like there is no DayZServer_x64.exe file in the directory of the Alive Checker. Programm will exit in";
                textBox1.Hide();


            }






            void Server_alive_checker()
            {
                int count =+ 1;
                if (count > 10)
                {
                    textBox1.Text = String.Empty;
                }
                Process thisProc = Process.GetCurrentProcess();
                if (IsProcessOpen("DayZ") == false)
                {
                    label1.Text="Application not running";
                    if (running == 2)
                    {
                       textBox1.Text += DateTime.Now + " Starting up for the first time." + Environment.NewLine;
                        
                        Process Dayz = new Process();
                        Dayz.StartInfo.FileName = currentDirectory + "/DayZServer_x64.exe";
                        Dayz.Start();
                       
                        Refreshrate();
                    }
                    else
                    {
                        textBox1.Text += DateTime.Now + " Server crashed. Restarting now." + Environment.NewLine;
                        Process Dayz = new Process();
                        Dayz.StartInfo.FileName = currentDirectory + "/DayZServer_x64.exe";
                        Dayz.Start();
                        counter = refresh;
                        Refreshrate();
                    }
                }
                else
                {
                    // Check how many total processes have the same name as the current one
                    
                    
                        // If ther is more than one, than it is already running.
                        label1.Text="Application is already running.";
                        textBox1.Text += DateTime.Now + " Server is running without problems :)" + Environment.NewLine;
                        running = 1;
                        counter = refresh;
                        Refreshrate();
                    

                }
            }

            void Refreshrate()
            {
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(Timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();

            }

            void Timer1_Tick(object sender, EventArgs e)
                {

                    counter--;
                    if (counter < 0)
                    {
                        timer1.Stop();
                        this.Close();
                    }
                    label2.Text = counter.ToString();

                }
            void Timer2_Tick(object sender, EventArgs e)
            {
                counter--;
                if (counter < 0)
                {
                    timer2.Stop();
                    Server_alive_checker();
                }
                label2.Text = counter.ToString();

            }

        }

        }

    }



