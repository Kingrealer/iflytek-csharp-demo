using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace tts
{
    public enum ee { 
        aaaa,
        bbbb,
        cccc
    }

    public partial class Form1 : Form,ITTS
    {
        private TTS _tts;
        private string _folderPath;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            
            System.Diagnostics.Debug.WriteLine("start");
            
            //判断目录是否存在
            if (_folderPath == "") {
                this.appendMsg("请选择保存目录");
                return;
            }
            if (!Directory.Exists(_folderPath)) {
                this.appendMsg("保存目录不存在");
                return;
            }
            startBtn.Enabled = false;
            contentTxtBox.ReadOnly = true;
            this.appendMsg("开始生成");
            try
            {
                _tts.multiSpeak(contentTxtBox.Text, _folderPath,customRbtn.Checked);
            }
            catch (Exception ex) {
                this.appendMsg(ex.Message);
            }
            

            startBtn.Enabled = true;
            contentTxtBox.ReadOnly = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _tts.end();
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusTxtBox.Text = "";
            
            this.appendMsg("程序启动");
            _folderPath = "";
            string config = "appid = 54058c94";
            try
            {
                if (_tts == null)
                {
                    _tts = new TTS(config);
                    _tts.tts_SpeakFinishedEvent += new TTS.TTS_SpeakFinished(this.speakFinished);
                }
            }
            catch (Exception ex) {
                this.appendMsg(ex.Message);
            }
            


        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                _folderPath = fbd.SelectedPath;
                folderPathLbl.Text = _folderPath;
            }
            
            
        }

        public void speakFinished(string msg) {

            this.appendMsg(msg);
        }

        private void appendMsg(string msg) {
            statusTxtBox.AppendText("[" + System.DateTime.Now.ToString() + "]\r\n"+msg+"\r\n");
        }
    }
}
