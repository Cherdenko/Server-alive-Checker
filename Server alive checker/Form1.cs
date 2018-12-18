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
 * interchangeable options for other games need to add the servermod command line for arma 3
 * a config file done
 * replacement of start options done
 * easy configurator for noobs half past done
 *  email notification if server goes down fix the problem of a restart being shown as crash
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
        private static System.Timers.Timer timer;
       // public event ElapsedEventHandler Elapsed;

        public int counter = 120;
        public int running = 2;
        public int refresh = 60;
        string gameselected;
        bool restartTimerRunning = false;
        bool initializedrestartTimer = false;
        bool justRestarted = false;








        public Form1()
        {
            InitializeComponent();
            labelHide();
            if (!Properties.Settings.Default.saved)
            {
                MessageBox.Show("Since this is your first start, please go to the settings first");
          
            }
            else
            {
                DateTime userTime = Properties.Settings.Default.restartTime1;
                //used for debug only
              //  MessageBox.Show(userTime.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff"));
                
               
            }
          
           
                
            
        }
        // here we are deavctivating the labels coz it looks like shit elseway
        void labelHide()
        {
            label1.Hide();
            label4.Hide();
            label2.Hide();
            label3.Hide();
            label5.Hide();
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";

        }
        // main start
        void Start()
        {
            label1.Show();
            label4.Show();
            label2.Show();
            // label3.Show();
            label5.Show();

            int x = Int32.Parse(Properties.Settings.Default.game);

            switch (x)
            {
                case 1:
                    counter = 10;
                    gameselected = "\\DayZServer_x64.exe";
                    break;
                case 2:
                    counter = 60;
                    gameselected = "\\arma2oaserver.exe";
                    break;
                case 3:
                    counter = 120;
                    gameselected = "\\arma3server.exe";
                    break;

            }
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists(currentDirectory + gameselected))
            {
                label4.Text = "Server last crashed: never";
                picyesno.BackColor = System.Drawing.Color.SpringGreen;
                label1.Text = gameselected + "exists";
                Console.WriteLine(currentDirectory + gameselected);
                Server_alive_checker();

            }
            else
            {

                picyesno.BackColor = System.Drawing.Color.Red;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                // label3.Hide();
                label2.Text = counter.ToString();
                label1.Text = "Seems like there is no" + gameselected + " file in the directory of the Alive Checker. Programm will exit in";



            }

        }




            // here we go check, if the process (in our case DayZ SA) is still alive. currently getting reworked, as of non functionality with .bat files.

            void Server_alive_checker()
            {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();

            Process thisProc = Process.GetCurrentProcess();
                if ((IsProcessOpen("DayZ") == false)) //|| (IsProcessOpen("Arma 3 (32 Bit)")) || (IsProcessOpen("Arma2 OA"))
                {
                    label1.Text="Application not running";
                    if (running == 2)
                    {
                        if (!restartTimerRunning)
                        {

                            restartTimerRunning = false;
                            restartTimerExec();
                        }
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
                        string BePath = Properties.Settings.Default.BePath;
                        string otherArmaParBox = Properties.Settings.Default.otherArmaParBox;
                        string mods = Properties.Settings.Default.mods;
                        //small logging tool
                        label1.Text = " " + DateTime.Now + " Starting up for the first time.";
                        

                          ProcessStartInfo Dayz = new ProcessStartInfo();
                        Dayz.FileName = currentDirectory + gameselected;
                          Dayz.Arguments = "-config="+cfg+ " -profiles="+profiles+ " -port"+ port + " -BEPath=" + BePath + " " + otherArmaParBox + " \"-mod=" + mods+ "\"";

                         Process.Start(Dayz); // working again without any problems
                        Refreshrate();
                    }
                    else
                    {
                        string cfg = Properties.Settings.Default.configBoxPath;
                        string profiles = Properties.Settings.Default.profileBoxPath;
                        string port = Properties.Settings.Default.Port;
                        string BePath = Properties.Settings.Default.BePath;
                        string otherArmaParBox = Properties.Settings.Default.otherArmaParBox;
                        string mods = Properties.Settings.Default.mods;
                        //small logging tool
                        if (!justRestarted)
                        {
                            label1.Text = " " + DateTime.Now + " Server crashed. Restarting now.";
                        
                        label4.Text = " Server last crashed at " + DateTime.Now;
                        }
                        else
                        {
                            label1.Text = " " + DateTime.Now + " Server just restarted succesfully";
                        }
                        ProcessStartInfo Dayz = new ProcessStartInfo();
                        Dayz.FileName = currentDirectory + gameselected;
                        Dayz.Arguments = "-config=" + cfg + " -profiles=" + profiles + " -port" + port + " -BEPath="+BePath +" "+ otherArmaParBox + " -mod="+ mods;

                        Process.Start(Dayz); // working again without any problem
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
            void restartTimer_Tick(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Fick dich Waal");
                DateTime currentTime = DateTime.Now;
                
                    DateTime userTime1 = Properties.Settings.Default.restartTime1;
                    DateTime userTime2 = Properties.Settings.Default.restartTime2;
                    DateTime userTime3 = Properties.Settings.Default.restartTime3;
                    DateTime userTime4 = Properties.Settings.Default.restartTime4;
                    DateTime userTime5 = Properties.Settings.Default.restartTime5;
                    DateTime userTime6 = Properties.Settings.Default.restartTime6;
                    DateTime userTime7 = Properties.Settings.Default.restartTime7;
                    DateTime userTime8 = Properties.Settings.Default.restartTime8;
                    DateTime userTime9 = Properties.Settings.Default.restartTime9;
                    DateTime userTime10 = Properties.Settings.Default.restartTime10;
                if (!initializedrestartTimer)
                {
                    if (Properties.Settings.Default.r1a)
                    {
                        label7.Text = userTime1.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r2a)
                    {
                        label8.Text = userTime2.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r3a)
                    {
                        label9.Text = userTime3.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r4a)
                    {
                        label10.Text = userTime4.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r5a)
                    {
                        label11.Text = userTime5.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r6a)
                    {
                        label12.Text = userTime6.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r7a)
                    {
                        label13.Text = userTime7.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r8a)
                    {
                        label14.Text = userTime8.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r9a)
                    {
                        label15.Text = userTime9.ToString("HH':'mm");
                    }
                    if (Properties.Settings.Default.r10a)
                    {
                        label16.Text = userTime10.ToString("HH':'mm");
                    }
                }

                if (Properties.Settings.Default.r1a == true) {
                if (currentTime.Hour == userTime1.Hour && currentTime.Minute == userTime1.Minute && currentTime.Second == userTime1.Second)
                {
                    timer.Stop();
                    RestartServer();
                    Console.WriteLine("Fick dich Waal");
                    //MessageBox.Show(userTime1.ToString("HH':'mm"));
                    //label3.Text = "Server succesfully restarted @" +DateTime.Now;
                    restartTimerExec();
                        justRestarted = true;
                }
                }
                if (Properties.Settings.Default.r2a == true)
                {
                    if (currentTime.Hour == userTime2.Hour && currentTime.Minute == userTime2.Minute && currentTime.Second == userTime2.Second)
                {
                    timer.Stop();
                    RestartServer();
                    Console.WriteLine("Fick dich Waal");
                    //MessageBox.Show(userTime2.ToString("HH':'mm"));
                    //label3.Text = "Server succesfully restarted @" + DateTime.Now;
                    restartTimerExec();
                }
            }
                if (Properties.Settings.Default.r3a == true)
                {
                    if (currentTime.Hour == userTime3.Hour && currentTime.Minute == userTime3.Minute && currentTime.Second == userTime3.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                        //label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r4a == true)
                {
                    if (currentTime.Hour == userTime4.Hour && currentTime.Minute == userTime4.Minute && currentTime.Second == userTime4.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                      //  label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r5a == true)
                {
                    if (currentTime.Hour == userTime5.Hour && currentTime.Minute == userTime5.Minute && currentTime.Second == userTime5.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                      //  label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r6a == true)
                {
                    if (currentTime.Hour == userTime6.Hour && currentTime.Minute == userTime6.Minute && currentTime.Second == userTime6.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                        label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r7a == true)
                {
                    if (currentTime.Hour == userTime7.Hour && currentTime.Minute == userTime7.Minute && currentTime.Second == userTime7.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                        label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r8a == true)
                {
                    if (currentTime.Hour == userTime8.Hour && currentTime.Minute == userTime8.Minute && currentTime.Second == userTime8.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                        //label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r9a == true)
                {
                    if (currentTime.Hour == userTime9.Hour && currentTime.Minute == userTime9.Minute && currentTime.Second == userTime9.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                        //label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }
                if (Properties.Settings.Default.r10a == true)
                {
                    if (currentTime.Hour == userTime10.Hour && currentTime.Minute == userTime10.Minute && currentTime.Second == userTime10.Second)
                    {
                        timer.Stop();
                        RestartServer();
                        Console.WriteLine("Fick dich Waal");

                        // MessageBox.Show(userTime3.ToString("HH':'mm"));
                       // label3.Text = "Server succesfully restarted @" + DateTime.Now;
                        restartTimerExec();
                    }
                }

            }
            void restartTimerExec(){
               // Console.WriteLine("Fick dich Waal");
                timer = new System.Timers.Timer();
                timer.Interval = 1000;
                timer.Elapsed += restartTimer_Tick;
                timer.Start();


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
            void RestartServer()
            {

                foreach (var process in Process.GetProcessesByName("DayZServer_x64"))
                {

                    process.Kill();
                counter = 15;
                }

              

            }
// this is important for the server restart


// restartServer


        private void button1_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
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


       

        //** Just needed for debugging







    }

    }




