using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColleiVoiceSpeaker
{
    public partial class Form1 : Form
    {
        const string ttsURL = "https://genshinvoice.top/api";  //定义语音合成网站
        const string speaker = "柯莱_ZH";
        public string saveFilePathCfg = System.Environment.CurrentDirectory + "\\config.cfg";
        public string fileCachePath;
        public int SDP = 4;
        public int Noise = 6;
        public int NoiseW = 8;
        public int Length = 10;
        public string finalURL = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configProgress();
            changeTextParams();
            debugTextURL();
        }

        private void param1trackBar_Scroll(object sender, EventArgs e)
        {
            SDP = param1trackBar.Value;
            changeTextParams();
            debugTextURL();
        }

        private void param2trackBar_Scroll(object sender, EventArgs e)
        {
            Noise = param2trackBar.Value;
            changeTextParams();
            debugTextURL();
        }

        private void param3trackBar_Scroll(object sender, EventArgs e)
        {
            NoiseW = param3trackBar.Value;
            changeTextParams();
            debugTextURL();
        }

        private void param4trackBar_Scroll(object sender, EventArgs e)
        {
            Length = param4trackBar.Value;
            changeTextParams();
            debugTextURL();
        }

        private void debugTextURL()
        {
            finalURL = $"{ttsURL}?speaker={System.Web.HttpUtility.UrlEncode($"{speaker}", Encoding.UTF8)}&text={System.Web.HttpUtility.UrlEncode(textBox1.Text, Encoding.UTF8)}&format=wav&language=ZH&length={Convert.ToDouble(param4trackBar.Value) / 10}&sdp={Convert.ToDouble(param1trackBar.Value) / 10}&noise={Convert.ToDouble(param2trackBar.Value) / 10}&noisew={Convert.ToDouble(param3trackBar.Value) / 10}";
            textBox2.Text = $"DebugURL：{finalURL}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            debugTextURL();
        }
        private bool getPosts(string url)
        {
            DateTime dt = DateTime.Now;
            try
            {
                string savefileName = $"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}";
                string filePath = fileCachePath + "\\colleiVoices\\" + savefileName + ".wav";
                //MessageBox.Show(filePath, this.Text);
                if (!Directory.Exists(fileCachePath + "\\colleiVoices"))
                {
                    Directory.CreateDirectory(fileCachePath + "\\colleiVoices");
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream streamResponse = response.GetResponseStream())
                using (Stream streamFile = File.Create(filePath))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = streamResponse.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        streamFile.Write(buffer, 0, bytesRead);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void progressTTS(string url) //处理生成语音
        {
            if (textBox1.Text != "") //判断文本是否存在文字，不存在则提示其他消息。
            {
                if (getPosts(url))
                {
                    MessageBox.Show("生成成功！", this.Text);
                }
                else
                {
                    MessageBox.Show("生成失败...", this.Text);
                }
                //处理下载
            }
            else
            {
                MessageBox.Show("请输入文本！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); //弹出错误消息。
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(finalURL, this.Text);
            progressTTS(finalURL);
        }
        private void changeTextParams()
        {
            param1Value.Text = Convert.ToString(Convert.ToDouble(SDP) / 10);
            param2Value.Text = Convert.ToString(Convert.ToDouble(Noise) / 10);
            param3Value.Text = Convert.ToString(Convert.ToDouble(NoiseW) / 10);
            param4Value.Text = Convert.ToString(Convert.ToDouble(Length) / 10);
        }
        private void createDefaultCfg()
        {
            FileINI fileINI = new FileINI();
            fileINI.INIWrite("VoiceConfig", "SDP", "4", saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "Noise", "6", saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "NoiseW", "8", saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "Length", "10", saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "FilePath", Convert.ToString(Environment.CurrentDirectory), saveFilePathCfg);
            param1trackBar.Value = SDP;
            param2trackBar.Value = Noise;
            param3trackBar.Value = NoiseW;
            param4trackBar.Value = Length;
            fileCachePath = Environment.CurrentDirectory;
        }
        private void configProgress()
        {
            FileINI fileIni = new FileINI();
            if (!File.Exists(saveFilePathCfg))
            {
                createDefaultCfg();
            }
            else
            {
                try
                {
                    SDP = Convert.ToInt32(fileIni.INIRead("VoiceConfig", "SDP", saveFilePathCfg));
                    Noise = Convert.ToInt32(fileIni.INIRead("VoiceConfig", "Noise", saveFilePathCfg));
                    NoiseW = Convert.ToInt32(fileIni.INIRead("VoiceConfig", "NoiseW", saveFilePathCfg));
                    Length = Convert.ToInt32(fileIni.INIRead("VoiceConfig", "Length", saveFilePathCfg));
                    fileCachePath = fileIni.INIRead("VoiceConfig", "FilePath", saveFilePathCfg);
                    param1trackBar.Value = SDP;
                    param2trackBar.Value = Noise;
                    param3trackBar.Value = NoiseW;
                    param4trackBar.Value = Length;
                }
                catch (System.FormatException)
                {
                    File.Delete(saveFilePathCfg);
                    createDefaultCfg();
                    MessageBox.Show("配置文件异常，已重新生成。", this.Text);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FileINI fileINI = new FileINI();
            fileINI.INIWrite("VoiceConfig", "SDP", Convert.ToString(SDP), saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "Noise", Convert.ToString(Noise), saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "NoiseW", Convert.ToString(NoiseW), saveFilePathCfg);
            fileINI.INIWrite("VoiceConfig", "Length", Convert.ToString(Length), saveFilePathCfg);
            MessageBox.Show("保存成功！", this.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SDP = 4;
            Noise = 6;
            NoiseW = 8;
            Length = 10;
            param1trackBar.Value = SDP;
            param2trackBar.Value = Noise;
            param3trackBar.Value = NoiseW;
            param4trackBar.Value = Length;
            changeTextParams();
            debugTextURL();
            MessageBox.Show("成功恢复为默认配置。", this.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileINI fileINI = new FileINI();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = fileCachePath;
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileCachePath = dialog.SelectedPath;
                fileINI.INIWrite("VoiceConfig", "FilePath", fileCachePath, saveFilePathCfg);
                //MessageBox.Show(fileCachePath, this.Text);
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
