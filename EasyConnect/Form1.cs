using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyConnect
{
    public partial class Form1 : Form
    {

        string cfgContent = "";
        string url = "https://www.battle.re/setting.ini";
        string ip = "";
        string port = "";
        bool isFull = false;


        public Form1()
        {
            InitializeComponent();

            checkMyIni();

            readMyIni();

            downWebConfig();

            ip = getWebConfig("Server", "IP");
            port = getWebConfig("Server", "PORT");
            //MessageBox.Show(ip);

            textIp.Text = ip;
            textPort.Text = port;

            //WriteCfgValue("EasyConnector.ini", "IP", ip);
            //WriteCfgValue("EasyConnector.ini", "PORT", port);

        }

        private void checkMyIni()
        {
            if( File.Exists("EasyConnector.ini") ){

            } else
            {

                string filePath = "EasyConnector.ini";

                // Create a StreamWriter instance
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write lines to the file
                    writer.WriteLine("[Screen]");
                    writer.WriteLine("MODE=1280");
                    writer.WriteLine("SIZX0=800");
                    writer.WriteLine("SIZY0=600");
                    writer.WriteLine("[Server]");
                    writer.WriteLine("IP=123.234.123.234");
                    writer.WriteLine("PORT=3000");
                    writer.WriteLine("URL=https://www.battle.re/setting.ini");
                    writer.WriteLine("HOME=https://www.naver.com");
                    writer.WriteLine("RUNEXE=TacticsLand.exe");
                    writer.WriteLine("DXWNDEXE=dxwnd.exe");
                 
                }



            }
        }

        private void readMyIni()
        {
            string mode = ReadCfgValue("EasyConnector.ini", "MODE");


            radioFull.Checked = false;
            radio640.Checked = false;
            radio1280.Checked = false;
            radioCustom.Checked = false;

            switch (mode)
            {
                case "FULL":
                    radioFull.Checked = true;
                    break;
                case "640":
                    radio640.Checked = true;
                    break;

                case "1280":
                    radio1280.Checked = true;
                    break;

                case "CUSTOM":
                    radioCustom.Checked = true;
                    textWidth.Enabled = true;
                    textHeight.Enabled = true;
                    break;
            }

            string width = ReadCfgValue("EasyConnector.ini", "SIZX0");
            textWidth.Text = width;

            string height = ReadCfgValue("EasyConnector.ini", "SIZY0");
            textHeight.Text = height;


        }

        private void downWebConfig()
        {


            using (var webClient = new WebClient())
            {
                try
                {
                    cfgContent = webClient.DownloadString(url);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception : {ex.Message}");
                }

            }
            //MessageBox.Show(cfgContent);
        }

        private string getWebConfig(string _sectionName, string _keyName)
        {


            var iniParser = new IniParser(cfgContent);
            string value = iniParser.GetValue(_sectionName, _keyName);

            if (value != null)
            {
                Console.WriteLine($"Value for [{_sectionName}] {_keyName}: {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"Key [{_keyName}] not found in section [{_sectionName}].");
                return null;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (isFull  == false)
            {
                // dxwnd.exe 를 실행한다.

                Process processDxwnd = new Process();

                // Set the process start information
                processDxwnd.StartInfo.FileName = "dxwnd.exe"; // Replace with the path to your executable
                processDxwnd.StartInfo.Arguments = ""; // Add any arguments if needed
                processDxwnd.StartInfo.UseShellExecute = false;
                processDxwnd.StartInfo.RedirectStandardOutput = true;
                processDxwnd.StartInfo.RedirectStandardError = true;

                // Start the process
                processDxwnd.Start();

            } 

            // Create a new process
            Process process = new Process();

            // Set the process start information
            process.StartInfo.FileName = "TacticsLand.exe"; // Replace with the path to your executable
            process.StartInfo.Arguments = ip + " " + port; // Add any arguments if needed
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            // Start the process
            process.Start();


        }

        private void radioFull_Click(object sender, EventArgs e)
        {
            isFull = true;

            textWidth.Enabled = false;
            textHeight.Enabled = false;

            WriteCfgValue("EasyConnector.ini", "MODE", "FULL");
        }

        private void radio640_Click(object sender, EventArgs e)
        {
            isFull = false;

            WriteCfgValue("dxwnd.ini", "sizx0", "640");
            WriteCfgValue("dxwnd.ini", "sizy0", "480");

            WriteCfgValue("EasyConnector.ini", "MODE", "640");


            textWidth.Enabled = false;
            textHeight.Enabled = false;

        }

        private void radio1280_Click(object sender, EventArgs e)
        {
            isFull = false;

            WriteCfgValue("dxwnd.ini", "sizx0", "1280");
            WriteCfgValue("dxwnd.ini", "sizy0", "960");


            WriteCfgValue("EasyConnector.ini", "MODE", "1280");

            textWidth.Enabled = false;
            textHeight.Enabled = false;
        }

        private void radioCustom_Click(object sender, EventArgs e)
        {
            isFull = false;

            textWidth.Enabled = true;
            textHeight.Enabled = true;

            WriteCfgValue("EasyConnector.ini", "MODE", "CUSTOM");

        }



        private void WriteCfgValue(string filePath, string key, string value)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding(51949));
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith($"{key}="))
                    {
                        lines[i] = $"{key}={value}";
                        File.WriteAllLines(filePath, lines, Encoding.GetEncoding(51949));
                        return;
                    }
                }

                // Key not found, add a new line
                File.AppendAllText(filePath, $"{key}={value}\n", Encoding.GetEncoding(51949));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to INI file: {ex.Message}");
            }

        }

        private string ReadCfgValue(string filePath, string key)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.StartsWith($"{key}="))
                    {
                        return line.Substring(key.Length + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading INI file: {ex.Message}");
            }

            return null; // Key not found or error occurred

        }

        private void textWidth_TextChanged(object sender, EventArgs e)
        {
            WriteCfgValue("dxwnd.ini", "sizx0", textWidth.Text);
            WriteCfgValue("EasyConnector.ini", "SIZX0", textWidth.Text);
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {
            WriteCfgValue("dxwnd.ini", "sizy0", textHeight.Text);
            WriteCfgValue("EasyConnector.ini", "SIZY0", textHeight.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string home = ReadCfgValue("EasyConnector.ini", "HOME");
            Process.Start(new ProcessStartInfo
            {
                FileName = home,
                UseShellExecute = true // This is important to use the default browser
            });
        }
    }
}
