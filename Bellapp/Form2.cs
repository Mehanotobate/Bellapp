using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bellapp
{
    public partial class Form2 : Form
    {
        private const string SettingsFilePath = "serialportsettings.txt";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void savecom_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings() {
            try
            {
                using (StreamWriter writer = new StreamWriter(SettingsFilePath))
                {
                    writer.WriteLine("PortName = " + textBoxPort.Text);
                    writer.WriteLine("BaudRate = " + textBoxBand.Text);
                    writer.WriteLine("DataBits = " + textBoxData.Text);
                }
                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { 
                MessageBox.Show($"Faild to save settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadSettings()
        {
            try
            {
                if (File.Exists(SettingsFilePath))
                {
                    using (StreamReader reader = new StreamReader(SettingsFilePath))
                    {
                        textBoxPort.Text = reader.ReadLine();
                        textBoxBand.Text = reader.ReadLine();
                        textBoxData.Text = reader.ReadLine();
                    }
                    MessageBox.Show("Settings loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Faild to load settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadcom_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}
