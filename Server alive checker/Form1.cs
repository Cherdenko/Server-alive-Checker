using System;
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
/**todo
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
 **/
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
        public int refresh = 60;
        bool StartBat;
        string StartCommand;


        public Form1()
        {
            InitializeComponent();
            Start();
        }
         void Start()
        {

            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists(currentDirectory + "/DayZServer_x64.exe"))
            {
                picyesno.BackColor = System.Drawing.Color.SpringGreen;
                label1.Text = "DayZServer_x64.exe exists";
                
                if (File.Exists(currentDirectory + "/Start.bat") || File.Exists(currentDirectory+"startserver.bat"))
                {
                    if (File.Exists(currentDirectory+ "/Start.Bat"))
                    {
                      StartBat = true;
                    }
                    label3.Text = "Found Starting Bat file";
                }
                else
                {
                    label3.Text = "Bat file not found. Terminating now";
                  
                }
                Server_alive_checker();

            }
            else
            {

                picyesno.BackColor = System.Drawing.Color.Red;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                label3.Hide();
                label2.Text = counter.ToString();
                label1.Text = "Seems like there is no DayZServer_x64.exe file in the directory of the Alive Checker. Programm will exit in";
                


            }





            // here we go check, if the process (in our case DayZ SA) is still alive. currently getting reworked, as of non functionality with .bat files.
            void Server_alive_checker()
            {
                if (StartBat)
                {
                    StartCommand = "/start.bat";
                }
                else
                {
                    StartCommand = "/DayZServer_x64.exe";
                }
                
                Process thisProc = Process.GetCurrentProcess();
                if (IsProcessOpen("DayZ") == false)
                {
                    label1.Text="Application not running";
                    if (running == 2)
                    {
                        //small logging tool
                       label1.Text += " " + DateTime.Now + " Starting up for the first time.";

                        /*  Process Dayz = new Process();
                          Dayz.StartInfo.FileName = currentDirectory + StartCommand;
                          Dayz.Start();// currently getting a nullpointer exception here
                         */
                        var processInfo = new ProcessStartInfo("cmd.exe", "/c" + currentDirectory+ "\"start.bat\"");
                        var process = Process.Start(processInfo);
                        process.Start();
                        
                        Refreshrate();
                    }
                    else
                    {
                        //small logging tool
                        label1.Text += " " + DateTime.Now + " Server crashed. Restarting now." ;
                        Process Dayz = new Process();
                        Dayz.StartInfo.FileName = currentDirectory + StartCommand;
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
                        label1.Text +=" "+ DateTime.Now + " Server is running without problems :)" ;
                        running = 1;
                        counter = refresh;
                        Refreshrate();
                    

                }
            }
            // used for the refresh 
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




