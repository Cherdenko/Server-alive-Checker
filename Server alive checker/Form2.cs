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
    public partial class Form2 : Form
    {
        public bool saved = false;
        

            public Form2()
        {
            InitializeComponent();
            StandartInit();
            InitRestartTimer();
        }

        private void StandartInit()
        {
            modBox.Text = "This option is currently not yet available";
            //int portStandart = Properties.Settings.Default.Port;
            if (saved)
            {
                portBox.Text = Properties.Settings.Default.Port;
                configBox.Text = Properties.Settings.Default.configBoxPath;
                profileBox.Text = Properties.Settings.Default.profileBoxPath;
             }
            else
            {
                portBox.Text = "2302";
                configBox.Text = "cfg\\serverDZ.cfg";
                profileBox.Text = "ServerProfiles";

            }

            
        }
        private void InitRestartTimer()
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            
            var items = new[] {
            new { Text = "1", Value = "1" },
            new { Text = "2", Value = "2" },
            new { Text = "3", Value = "3" },
            new { Text = "4", Value = "4" },
            new { Text = "5", Value = "5" },
            new { Text = "6", Value = "6" }
            };
            
            
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            

            comboBox1.DataSource = items;
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            //Properties.Settings.Default.Upgrade();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
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
            saved = true;
            Properties.Settings.Default.saved = saved;
            Properties.Settings.Default.Save();
            

        }
    }
}
