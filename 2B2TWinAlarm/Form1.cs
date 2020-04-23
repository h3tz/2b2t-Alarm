/**
 * @file Form1.cs, the main script
 * @version 0.1.0
 * @license MIT
 * @see {@link https://github.com/h3tz/2b2t-Alarm|Website }
 */

using _2B2TQueAlarm.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace _2B2TWinAlarm
{
    public partial class Form1 : Form
    {
        private string pos = string.Empty;
        private Stopwatch myWatch = new Stopwatch();
        private List<TimeSpan> lastElaps = new List<TimeSpan>();
        private List<string> allAlarms = new List<string>();
        private int defaultPos = 99999;
        private string mLogFilePath = @"\.minecraft\logs\latest.log";
        private string pahtToLogFileD = string.Empty;
        private int medianCounter = 0;
        public int currentPos = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "2B2TAlarm V" + System.Windows.Forms.Application.ProductVersion;
            myWatch.Start();

            try
            {
                //init alarm field
                string directoryTocreate = Directory.GetCurrentDirectory() + "/resources";
                if (!Directory.Exists(directoryTocreate))
                {
                    Directory.CreateDirectory(directoryTocreate);
                }

                allAlarms = Directory.GetFiles(directoryTocreate,"*.wav").ToList();

                if (allAlarms.Count != 0)
                {
                    foreach (string alarmitem in allAlarms)
                    {
                        this.comboBox_alarm.Items.Add(Path.GetFileName(alarmitem));
                    }
                    this.comboBox_alarm.SelectedIndex = 0;

                    string pathToAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    this.pahtToLogFileD = pathToAppData + mLogFilePath;
                }
                else
                {
                    throw new System.ArgumentException("The ressource folder next to *.exe does not contain *.wav. Please copy at least one *.wav into the resource directory.");
                }
            }
            catch(Exception ex)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(ex.Message, "2b2t Alarm startup error", buttons);
                //if (result == System.Windows.Forms.DialogResult.Yes)
                //{
                this.Close();
                //}
            }
        }

        /// <summary>
        /// Timer to fetch queue position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (File.Exists(this.pahtToLogFileD))
            {
                this.backgroundWorker1.RunWorkerAsync(this.pahtToLogFileD);
            }
            else
            {
                AppendText(this.richTextBox_log, "ERROR: " + this.pahtToLogFileD + " does not exist to parse queue information", Color.Red);
            }
        }

        
        /// <summary>
        /// Background worker to get queue position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                e.Result = getCurrentPos(e.Argument as string);
            }
            catch (Exception ex)
            {
                AppendText(this.richTextBox_log, "ERROR: " + ex.Message, Color.Red);
            }
        }
        /// <summary>
        /// Runworker completed to update ui
        /// </summary>
        string lastPos = string.Empty;
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                string curPos = e.Result.ToString();
                this.label1.Text = curPos;
                this.label1.Update();
                toolStripStatusLabel1.Text = "Update: " + DateTime.Now.ToLongTimeString();

                if (curPos != defaultPos.ToString())
                {
                    if (lastPos != curPos)
                    {
                        lastElaps.Add(myWatch.Elapsed);
                        myWatch.Stop();
                        lastPos = curPos;
                        AppendText(this.richTextBox_log, "Update: " + DateTime.Now.ToShortTimeString() + "|Pos: " + curPos + "|took: " + lastElaps[lastElaps.Count - 1].TotalSeconds.ToString() + " - sec from pos: " + ((int.Parse(curPos)) + 1).ToString() + "|Median: " + medianTime().ToString() + "|estimated connection time: " + getPotentialFinaTime().ToString() + " \n", Color.Black);
                        myWatch.Restart();

                        if (int.Parse(curPos) <= numericUpDown1.Value)
                        {
                            if (checkBox1.Checked == true)
                            {
                                playAlarm();
                            }
                        }
                    }
                }
                else
                {
                    AppendText(this.richTextBox_log, "Info: " + " Your are not trying to connect to 2b2t.org minecraft server", Color.Red);
                }
            }
            catch (Exception ex)
            {
                AppendText(this.richTextBox_log, "ERROR: " + ex.Message, Color.Red);
            }
        }

        /// <summary>
        /// Get the current queue position out of .minecraft\logs\latest.log
        /// </summary>
        /// <param name="pahtToLogFileDir">path to latest.log</param>
        /// <returns>queue position</returns>
        public int getCurrentPos(string pahtToLogFileDir)
        {
            int quePos = defaultPos;
            var filestream = new System.IO.FileStream(pahtToLogFileDir,
                                                      System.IO.FileMode.Open,
                                                      System.IO.FileAccess.Read,
                                                      System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            string lastLine = string.Empty;
            string currentLine = string.Empty;
            while ((currentLine = file.ReadLine()) != null)
            {
                lastLine = currentLine;
            }

            if (lastLine.Contains("Position in queue"))
            {
                String[] split = lastLine.Split(':');
                quePos = int.Parse(split[split.Length - 1]);
            }
            this.currentPos = quePos;
            return quePos;
        }

        /// <summary>
        /// Helper to update richtext box
        /// </summary>
        /// <param name="box">richtextbox to update</param>
        /// <param name="text">text to append</param>
        /// <param name="color">text color</param>
        private void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(DateTime.Now +": " + text + "\n");
            box.SelectionColor = box.ForeColor;
        }

        private int medianTime()
        {
            int midTime = 0;
            foreach (TimeSpan curTimeSpan in lastElaps)
            {
                midTime = (int) curTimeSpan.TotalSeconds + midTime;
            }

            return (midTime / (lastElaps.Count-1));
        }

        /// <summary>
        /// Get a estimated time when queue position 0 is reached
        /// </summary>
        /// <returns>Datetime as short</returns>
        private string getPotentialFinaTime()
        {
            int median = medianTime();
            this.medianCounter = medianCounter + 1;

            if (this.medianCounter >= 5)
            {
                int totalSeconds = this.currentPos * median;

                TimeSpan result = TimeSpan.FromSeconds(totalSeconds);
                DateTime time = DateTime.Now;
                return time.AddSeconds(result.TotalSeconds).ToShortTimeString();
            }
            else
            {
                return " will be calculated";
            }           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlayAlarm_Click(object sender, EventArgs e)
        {
            playAlarm();
        }

        private void clearDebug_Click(object sender, EventArgs e)
        {
            richTextBox_log.Clear();
        }

        private void playAlarm()
        {
            SoundPlayer simpleSound = new SoundPlayer(allAlarms[this.comboBox_alarm.SelectedIndex]);
            simpleSound.Play();
            simpleSound.Dispose();
        }

        private void toolStripButtonOpenMLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", pahtToLogFileD);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Text = Settings.Default.queuePos;
            this.checkBox1.Checked = Settings.Default.alarmcheckBox;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.queuePos = this.numericUpDown1.Text;
            Settings.Default.alarmcheckBox = this.checkBox1.Checked;
            Settings.Default.Save();
        }
    }
}