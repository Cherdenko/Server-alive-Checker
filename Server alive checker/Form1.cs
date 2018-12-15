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
        bool settingsSet = false;


        public Form1()
        {
            InitializeComponent();
            if (!settingsSet)
            {
                label1.Text = "Please go to the settings first, before you try and startup the server";
            }
            else
            {
                label1.Hide();
            }
            label4.Hide();
            
            label2.Hide();
            label3.Hide();
                
            
        }
         void Start()
        {

            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists(currentDirectory + "/DayZServer_x64.exe"))
            {
                label4.Text = "Server last crashed: never";
                picyesno.BackColor = System.Drawing.Color.SpringGreen;
                label1.Text = "DayZServer_x64.exe exists";
                Console.WriteLine(currentDirectory + StartCommand);
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
                    StartCommand = "\\DayZServer_x64.exe";
                }
                else
                {
                    StartCommand = "\\DayZServer_x64.exe";
                }
                
                Process thisProc = Process.GetCurrentProcess();
                if (IsProcessOpen("DayZ") == false)
                {
                    label1.Text="Application not running";
                    if (running == 2)
                    {
                        /**
                         * 
                         * 
                         * 
                         * 
                         * 
                        **/

                        string cfg = Properties.Settings.Default.configBoxPath;
                        string profiles = Properties.Settings.Default.profileBoxPath;
                        string port = Properties.Settings.Default.Port;
                        //small logging tool
                       label1.Text = " " + DateTime.Now + " Starting up for the first time.";
                        

                          ProcessStartInfo Dayz = new ProcessStartInfo();
                          Dayz.FileName = currentDirectory + StartCommand;
                          Dayz.Arguments = "-config="+cfg+ " -profiles="+profiles+ " -port"+ port ;

                         Process.Start(Dayz); // working again without any problems
                        Refreshrate();
                    }
                    else
                    {
                        //small logging tool
                        label1.Text = " " + DateTime.Now + " Server crashed. Restarting now." ;
                        Process Dayz = new Process();
                        label4.Text = " Server last crashed at " + DateTime.Now;
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
                        label1.Text="Application is running.";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool saved = Properties.Settings.Default.saved;
            if (saved)
            {
                 Start();
            }
            else
            {
                MessageBox.Show("Settings not found. Cannot start");
            }
        }
    }

    }




