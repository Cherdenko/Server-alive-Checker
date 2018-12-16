using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_alive_checker
{
    public partial class Settings : Form
    {
        public bool saved = Properties.Settings.Default.saved;
        public int box = Properties.Settings.Default.box;

        public Settings()
        {
            InitializeComponent();
            StandartInit();
           
            InitGame();
            boxes();
        }
        void boxes()
        {
            int boxed = Properties.Settings.Default.box;
            switch (boxed)
            {
                case 1:
                    restartBox1.Show();
                    // of course we need to also asign the boxes some values else the restarttimes would just be lost
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                   
                    break;
                case 2:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;

                    break;
                case 3:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    break;
                case 4:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    break;
                case 5:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    break;
                case 6:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox6.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    restartBox6.Value = Properties.Settings.Default.restartTime6;
                    break;
                case 7:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox6.Show();
                    restartBox7.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    restartBox6.Value = Properties.Settings.Default.restartTime6;
                    restartBox7.Value = Properties.Settings.Default.restartTime7;
                    break;
                case 8:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox6.Show();
                    restartBox7.Show();
                    restartBox8.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    restartBox6.Value = Properties.Settings.Default.restartTime6;
                    restartBox7.Value = Properties.Settings.Default.restartTime7;
                    restartBox8.Value = Properties.Settings.Default.restartTime8;
                    break;
                case 9:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox6.Show();
                    restartBox7.Show();
                    restartBox8.Show();
                    restartBox9.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    restartBox6.Value = Properties.Settings.Default.restartTime6;
                    restartBox7.Value = Properties.Settings.Default.restartTime7;
                    restartBox8.Value = Properties.Settings.Default.restartTime8;
                    restartBox9.Value = Properties.Settings.Default.restartTime9;
                    break;
                case 10:
                    restartBox1.Show();
                    restartBox2.Show();
                    restartBox3.Show();
                    restartBox4.Show();
                    restartBox5.Show();
                    restartBox6.Show();
                    restartBox7.Show();
                    restartBox8.Show();
                    restartBox9.Show();
                    restartBox10.Show();
                    restartBox1.Value = Properties.Settings.Default.restartTime1;
                    restartBox2.Value = Properties.Settings.Default.restartTime2;
                    restartBox3.Value = Properties.Settings.Default.restartTime3;
                    restartBox4.Value = Properties.Settings.Default.restartTime4;
                    restartBox5.Value = Properties.Settings.Default.restartTime5;
                    restartBox6.Value = Properties.Settings.Default.restartTime6;
                    restartBox7.Value = Properties.Settings.Default.restartTime7;
                    restartBox8.Value = Properties.Settings.Default.restartTime8;
                    restartBox9.Value = Properties.Settings.Default.restartTime9;
                    restartBox10.Value = Properties.Settings.Default.restartTime10;
                    break;
               
            }
        }
        private void StandartInit()
        {
            
            //int portStandart = Properties.Settings.Default.Port;
            if (saved)
            {
                portBox.Text = Properties.Settings.Default.Port;
                configBox.Text = Properties.Settings.Default.configBoxPath;
                profileBox.Text = Properties.Settings.Default.profileBoxPath;
                battleeyebox.Text = Properties.Settings.Default.BePath;
                string mods = Properties.Settings.Default.mods;
                Console.WriteLine(mods);
                
                    modBox.Text = Properties.Settings.Default.mods;
                
                
                    otherArmaParBox.Text = Properties.Settings.Default.otherArmaParBox;
                
            }
            else
            {
                portBox.Text = "2302";
                configBox.Text = "cfg\\serverDZ.cfg";
                profileBox.Text = "ServerProfiles";
                battleeyebox.Text = "battleye";


            }
            restartBox1.Hide();
            restartBox2.Hide();
            restartBox3.Hide();
            restartBox4.Hide();
            restartBox5.Hide();
            restartBox6.Hide();
            restartBox7.Hide();
            restartBox8.Hide();
            restartBox9.Hide();
            restartBox10.Hide();

            
        }

        private void InitGame()
        {
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            var items2 = new[] {
            new { Text = "DayZ Standalone", Value = "1" }
           // new { Text = "Arma 2", Value = "2" },
          //  new { Text = "Arma 3", Value = "3" }
            };
            comboBox2.DataSource = items2;
           
        }

       

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            //Properties.Settings.Default.Upgrade();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveRestartTimes();
            // here we are saving the path to the config file of DayZ
            if (string.IsNullOrWhiteSpace(configBox.Text)){
                  Console.WriteLine("No can do baby doll");
                  MessageBox.Show("one of the neccesary Fields is empty.");
              }
              else
              {
            Properties.Settings.Default.configBoxPath = configBox.Text;

               }
            // here we are saving the port
            if (string.IsNullOrWhiteSpace(portBox.Text))
            {
                Console.WriteLine("No can do baby doll");
                MessageBox.Show("one of the neccesary Fields is empty.");
            } else
            { 
           //   int x = Int32.Parse(portBox.Text);
           Properties.Settings.Default.Port = portBox.Text;

               
            }
            if (string.IsNullOrWhiteSpace(portBox.Text))
            {
                Console.WriteLine("No can do baby doll");
                MessageBox.Show("one of the neccesary Fields is empty.");
            }
            else
            {
                Properties.Settings.Default.profileBoxPath = profileBox.Text;
            }
            // here we are saving the restarthours to a string for later usage
            if (!string.IsNullOrWhiteSpace(otherArmaParBox.Text))
            {
                Properties.Settings.Default.otherArmaParBox = otherArmaParBox.Text;
            }
            if (string.IsNullOrWhiteSpace(battleeyebox.Text))
            {
                Console.WriteLine("No can do baby doll");
                MessageBox.Show("one of the neccesary Fields is empty.");
            }
            else
            {
                Properties.Settings.Default.BePath = battleeyebox.Text;
            }
            if (!string.IsNullOrWhiteSpace(modBox.Text))
            {
                Properties.Settings.Default.mods = modBox.Text;
            }
            Properties.Settings.Default.game = this.comboBox2.SelectedValue.ToString();
            
            saved = true;
            Properties.Settings.Default.saved = saved;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings have been saved"+" You may start the programm now");
            

        }

        // this shitfest is the save mechanism of the restartTimes
        void SaveRestartTimes()
        {
            Properties.Settings.Default.box = box;
            switch (box) {
                case 1:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    break;
                case 2:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    break;
                case 3:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    break;
                case 4:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    break;
                case 5:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    break;
                case 6:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    Properties.Settings.Default.restartTime6 = restartBox6.Value;
                    break;
                case 7:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    Properties.Settings.Default.restartTime6 = restartBox6.Value;
                    Properties.Settings.Default.restartTime7 = restartBox7.Value;
                    break;
                case 8:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    Properties.Settings.Default.restartTime6 = restartBox6.Value;
                    Properties.Settings.Default.restartTime7 = restartBox7.Value;
                    Properties.Settings.Default.restartTime8 = restartBox8.Value;
                    break;
                case 9:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    Properties.Settings.Default.restartTime6 = restartBox6.Value;
                    Properties.Settings.Default.restartTime7 = restartBox7.Value;
                    Properties.Settings.Default.restartTime8 = restartBox8.Value;
                    Properties.Settings.Default.restartTime9 = restartBox9.Value;
                    break;
                case 10:
                    Properties.Settings.Default.restartTime1 = restartBox1.Value;
                    Properties.Settings.Default.restartTime2 = restartBox2.Value;
                    Properties.Settings.Default.restartTime3 = restartBox3.Value;
                    Properties.Settings.Default.restartTime4 = restartBox4.Value;
                    Properties.Settings.Default.restartTime5 = restartBox5.Value;
                    Properties.Settings.Default.restartTime6 = restartBox6.Value;
                    Properties.Settings.Default.restartTime7 = restartBox7.Value;
                    Properties.Settings.Default.restartTime8 = restartBox8.Value;
                    Properties.Settings.Default.restartTime9 = restartBox9.Value;
                    Properties.Settings.Default.restartTime10 = restartBox10.Value;
                    break;
                    
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
           
            box++; 
            switch (box) {
                case 1:
                    restartBox1.Show();
                    Properties.Settings.Default.r1a = true;
                    /*   if (Properties.Settings.Default.restartTime1 != null)
                       {
                           restartBox1.Value = Properties.Settings.Default.restartTime1;
                       }*/
                    break;
                case 2:
                    restartBox2.Show();
                    Properties.Settings.Default.r2a = true;

                    break;
                case 3:
                    restartBox3.Show();
                    Properties.Settings.Default.r3a = true;
                    break;
                case 4:
                    restartBox4.Show();
                    Properties.Settings.Default.r4a = true;
                    break;
                case 5:
                    restartBox5.Show();
                    Properties.Settings.Default.r5a = true;
                    break;
                case 6:
                    restartBox6.Show();
                    Properties.Settings.Default.r6a = true;
                    break;
                case 7:
                    restartBox7.Show();
                    Properties.Settings.Default.r7a = true;
                    break;
                case 8:
                    restartBox8.Show();
                    Properties.Settings.Default.r8a = true;
                    break;
                case 9:
                    restartBox9.Show();
                    Properties.Settings.Default.r9a = true;
                    break;
                case 10:
                    restartBox10.Show();
                    Properties.Settings.Default.r10a = true;
                    break;
                case 11:
                    MessageBox.Show("You currently cant set more than 10 restarts");
                    box--;
                    break;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (box)
            {
                case 0:
                    MessageBox.Show("There cant be less than 0 restarts");
                    break;
                case 1:
                    restartBox1.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r1a = false;
                    break;
                case 2:
                    restartBox2.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r2a = false;
                    break;
                case 3:
                    restartBox3.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r3a = false;
                    break;
                case 4:
                    restartBox4.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r4a = false;
                    break;
                case 5:
                    restartBox5.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r5a = false;
                    break;
                case 6:
                    restartBox6.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r6a = false;
                    break;
                case 7:
                    restartBox7.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r7a = false;
                    break;
                case 8:
                    restartBox8.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r8a = false;
                    break;
                case 9:
                    restartBox9.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r9a = false;
                    break;
                case 10:
                    restartBox10.Hide();
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.r10a = false;

                    break;
              
            }
            box--;
        }
    }
}
