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
using System.IO.Ports;
using System.Timers;

namespace Bellapp
{
    public partial class Form1 : Form
    {
        private const string SettingsFilePath = "serialportsettings.txt";
        private SerialPort serialPort1 = new SerialPort();
        private System.Timers.Timer timer; // Timer for checking the current hour
        private DateTime lastCheckedTime;
        public Form1()
        {
            InitializeComponent();
            LoadSerialPortSettings();

            // Initialize timer
            timer = new System.Timers.Timer(1000); // Check every 60 seconds (1 minute)
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            // Initialize last checked time
            lastCheckedTime = DateTime.MinValue;
        }

        private void LoadSerialPortSettings()
        {
            try
            {
                // Read settings from the text file
                string[] settings = File.ReadAllLines(SettingsFilePath);

                // Parse settings (assuming each line is in format "key=value")
                Dictionary<string, string> settingsDictionary = new Dictionary<string, string>();
                foreach (string line in settings)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        settingsDictionary.Add(parts[0].Trim(), parts[1].Trim());
                    }
                }

                // Configure serialPort1 properties based on parsed settings
                if (settingsDictionary.ContainsKey("BaudRate"))
                {
                    serialPort1.BaudRate = int.Parse(settingsDictionary["BaudRate"]);
                }
                if (settingsDictionary.ContainsKey("DataBits"))
                {
                    serialPort1.DataBits = int.Parse(settingsDictionary["DataBits"]);
                }
                if (settingsDictionary.ContainsKey("PortName"))
                {
                    serialPort1.PortName = settingsDictionary["PortName"];
                }
                // Add other properties as needed (Parity, StopBits, etc.)

                // Open the serial port
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, invalid settings, etc.)
                MessageBox.Show($"Error loading serial port settings: {ex.Message}");
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Check if the current time has changed significantly
            if (currentTime - lastCheckedTime > TimeSpan.FromMinutes(1))
            {
                // Update the last checked time
                lastCheckedTime = currentTime;

                // Get the current time
                int currentHour = currentTime.Hour;
                int currentMinute = currentTime.Minute;

                // Check if the current time matches any time in the list boxes
                foreach (string item in listBox1.Items)
                {
                    string[] timeParts = item.Split(':');
                    if (timeParts.Length == 2)
                    {
                        int scheduleHour = int.Parse(timeParts[0]);
                        int scheduleMinute = int.Parse(timeParts[1]);
                        if (scheduleHour == currentHour && scheduleMinute == currentMinute)
                        {
                            // Send "R1" to serialPort1 if a match is found
                            serialPort1.Write("R1");
                            break;
                        }
                    }
                }

                foreach (string item in listBox2.Items)
                {
                    string[] timeParts = item.Split(':');
                    if (timeParts.Length == 2)
                    {
                        int scheduleHour = int.Parse(timeParts[0]);
                        int scheduleMinute = int.Parse(timeParts[1]);
                        if (scheduleHour == currentHour && scheduleMinute == currentMinute)
                        {
                            // Send "R1" to serialPort1 if a match is found
                            serialPort1.Write("R4");
                            break;
                        }
                    }
                }

                foreach (string item in listBox3.Items)
                {
                    string[] timeParts = item.Split(':');
                    if (timeParts.Length == 2)
                    {
                        int scheduleHour = int.Parse(timeParts[0]);
                        int scheduleMinute = int.Parse(timeParts[1]);
                        if (scheduleHour == currentHour && scheduleMinute == currentMinute)
                        {
                            // Send "R1" to serialPort1 if a match is found
                            serialPort1.Write("R5");
                            break;
                        }
                    }
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Chooseport_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void Ring1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("R1");
        }

        private void EvacuationRing_Click(object sender, EventArgs e)
        {
            serialPort1.Write("R2");
        }

                private void Insert_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt"; // Filter for.txt files
                openFileDialog.Multiselect = false; // Allow only one file selection
                openFileDialog.ValidateNames = true; // Validate the selected file name

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file and split its content into lines
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    // There needs to be atleast 3 lines for the timetable to be valid
                    if (lines.Length < 3)
                    {
                        MessageBox.Show("The selected file must contain at least three lines.");
                        return;
                    }

                    // Assuming you have three ListBox controls named listBox1, listBox2, and listBox3
                    // MK: Please just rename these controls into something more logical. 
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();

                    // Split each line by the delimiter (e.g., comma or semicolon)
                    char[] delimiter = { ',', ';' };
                    for (int i = 0; i < 3; i++)
                    {
                        string[] hours = lines[i].Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                        switch(i)
                        {
                            case 0:
                                listBox1.Items.AddRange(hours);
                                break;
                            case 1:
                                listBox2.Items.AddRange(hours);
                                break;
                            case 2:
                                listBox3.Items.AddRange(hours);
                                break;
                            default:
                                throw new Exception("Range is not between 0 and 2.");
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonabout_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
