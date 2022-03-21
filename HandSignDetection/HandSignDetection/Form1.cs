using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using NAudio.Wave;


namespace HandSignDetection
{

    public partial class Form1 : Form
    {
        public Process working,working2,working3;
        public int aux = 0, aux2 = 0;
        WaveIn wave;
        WaveFileWriter writer;
        string outputFileName = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\audio\\record.wav";
        string voicetotext;

        //Constructor with all initialization
        public Form1()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.Hide();
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.uiMode = "None";
            axWindowsMediaPlayer1.settings.volume = 0;

            axWindowsMediaPlayer2.Hide();
            axWindowsMediaPlayer2.Ctlenabled = false;
            axWindowsMediaPlayer2.uiMode = "None";
            axWindowsMediaPlayer2.settings.volume = 0;

            axWindowsMediaPlayer3.Hide();
            axWindowsMediaPlayer3.Ctlenabled = false;
            axWindowsMediaPlayer3.uiMode = "None";
            axWindowsMediaPlayer3.settings.volume = 0;


            texttths.Hide();
            transformtths.Hide();
            recordbtn.Hide();
            processbtn.Hide();



        }

        //Timer Event
        private void timer1_Tick(object sender, EventArgs e)
        {

            panel4.Width += 1;

            if (panel4.Width >= 365)
            {
                timer1.Stop();
               
            }
            if (panel4.Width >= 305)
            {
                dictionarybtn1.Width = 180;
            }
        }

        //Exit App Button
        private void closebtn1_Click_1(object sender, EventArgs e)
        {
            if (panel4.Width != 0)
            {
                working.Kill();
            }
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Hide();
            this.Close();
        }

        //Run CMD
        private void run_cmd(string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\D3zhu\\AppData\\Local\\Programs\\Python\\Python39\\python.exe";
            start.Arguments = string.Format("{0}", args);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;

            working = Process.Start(start);
            timer1.Start();
        }
        private void run_cmd2(string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\ffmpeg-4.4.1-full_build\\bin\\ffmpeg.exe";
            start.Arguments = string.Format("{0}", args);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;

            working2 = Process.Start(start);
        }
        private void run_cmd3(string args)
        {
            Process start = new Process();
            start.StartInfo.FileName = "C:\\Users\\D3zhu\\AppData\\Local\\Programs\\Python\\Python39\\python.exe";
            start.StartInfo.Arguments = string.Format("{0}", args);
            start.StartInfo.UseShellExecute = false;
            start.StartInfo.RedirectStandardOutput = true;
            start.StartInfo.CreateNoWindow = true;
            working3 = Process.Start(start.StartInfo);
            working3.WaitForExit();
            Thread.Sleep(1000);
            voicetotext = working3.StandardOutput.ReadToEnd();
            string specialChars = " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            voicetotext = new string(voicetotext.Where(c => !specialChars.Contains(c)).ToArray());


            String text = new String(voicetotext.Where(Char.IsLetter).ToArray());
            String textfile = "";
            for (int i = 0; i < text.Length; i++)
            {
                textfile += "file 'C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\" + char.ToUpper(text[i]) + ".mp4'@";
            }
            textfile = textfile.Replace("@", System.Environment.NewLine);
            string fileName = @"C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\list.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    fs.Write(Encoding.ASCII.GetBytes(textfile), 0, textfile.Length);
                    fs.Close();
                }



            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            Guid nr = Guid.NewGuid();
            string name = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\mergedvideos" + nr + ".mp4";
            run_cmd2("-f concat -safe 0 -i C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\list.txt -c copy " + name);
            Thread.Sleep(1000);

            axWindowsMediaPlayer3.Show();
            axWindowsMediaPlayer3.settings.rate = 2;
            axWindowsMediaPlayer3.URL = name;
            axWindowsMediaPlayer3.Ctlcontrols.play();



        }

        //Sign Detection
        private void sdbtn_Click(object sender, EventArgs e)
        {
            stopcamerabtn.Show();
            startcamerabtn.Show();
            backgroundload.Show();
            texttths.Hide();
            transformtths.Hide();
            axWindowsMediaPlayer2.Hide();
            recordbtn.Hide();
            processbtn.Hide();
            axWindowsMediaPlayer3.Hide();
        }
        private void startcamerabtn_Click(object sender, EventArgs e)
        {
            run_cmd("C:\\Users\\D3zhu\\Desktop\\RecoSign\\yolov5\\detect.py --weights C:\\Users\\D3zhu\\Desktop\\RecoSign\\yolov5\\runs/train/firstresult/weights/best.pt --img 416 --source 0 --hide-conf --max-det 1");
        }
        private void stopcamerabtn_Click(object sender, EventArgs e)
        {
            if (panel4.Width != 0)
            {
                working.Kill();
                panel4.Width = 0;
                dictionarybtn1.Width = 0;
                letterpanel1.Visible = false;
                letterpanel2.Visible = false;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Hide();
            }

        }

        //Dictionary
        private void dictionarybtn1_Click(object sender, EventArgs e)
        {
            if (letterpanel1.Visible == false) { letterpanel1.Visible = true; letterpanel2.Visible = true; return; }
            if (letterpanel1.Visible == true) { letterpanel1.Visible = false; letterpanel2.Visible = false; axWindowsMediaPlayer1.Hide(); return; }

        }

        //Text to hand signs
        private void tthsbtn_Click(object sender, EventArgs e)
        {
            stopcamerabtn.Hide();
            startcamerabtn.Hide();
            backgroundload.Hide();
            texttths.Show();
            transformtths.Show();
            recordbtn.Hide();
            processbtn.Hide();
            axWindowsMediaPlayer3.Hide();
        }
        private void transformtths_Click(object sender, EventArgs e)
        {
            String text = texttths.Text;
            string specialChars = " !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            text = new string(text.Where(c => !specialChars.Contains(c)).ToArray());
            String textfile = "";
            for (int i = 0; i < text.Length; i++)
            {
                textfile += "file 'C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\" + char.ToUpper(text[i]) + ".mp4'@";
            }
            textfile = textfile.Replace("@", System.Environment.NewLine);
            string fileName = @"C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\list.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    fs.Write(Encoding.ASCII.GetBytes(textfile), 0, textfile.Length);
                    fs.Close();
                }



            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            Guid nr = Guid.NewGuid();
            string name = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\mergedvideos" + nr + ".mp4";
            run_cmd2("-f concat -safe 0 -i C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\list.txt -c copy " + name);
            Thread.Sleep(1000);

            axWindowsMediaPlayer2.Show();
            axWindowsMediaPlayer2.settings.rate = 2;
            axWindowsMediaPlayer2.URL = name;
            axWindowsMediaPlayer2.Ctlcontrols.play();



        }

        //Voice to hand signs
        private void vthsbtn_Click(object sender, EventArgs e)
        {
            recordbtn.Show();
            stopcamerabtn.Hide();
            startcamerabtn.Hide();
            backgroundload.Hide();
            texttths.Hide();
            transformtths.Hide();
            processbtn.Show();
            
  
        }
        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
        }
        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
        private void recordbtn_Click(object sender, EventArgs e)
        {

            if(aux2 == 0)
            {
                wave = new WaveIn();
                wave.WaveFormat = new WaveFormat(44100, 1);
                wave.DeviceNumber = 0;
                wave.DataAvailable += Wave_DataAvailable;
                wave.RecordingStopped += Wave_RecordingStopped;
                writer = new WaveFileWriter(outputFileName, wave.WaveFormat);
                wave.StartRecording();
                aux2 = 1;
                recordbtn.Text = "Stop Recording";
            }
            else
            {
                wave.StopRecording();

                recordbtn.Text = "Record";
                aux2 = 0;
                
                


            }
        }
        private void processbtn_Click(object sender, EventArgs e)
        {
            run_cmd3("C:\\Users\\D3zhu\\Desktop\\RecoSign\\pythonscripts\\vths.py");
        }

        //Dictionary Buttons
        private void A_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\A.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void B_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\B.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void C_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\C.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void D_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\D.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void E_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\E.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void F_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\F.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void G_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\G.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void H_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\H.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void I_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\I.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void J_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\J.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void K_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\K.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void L_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\L.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void M_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\M.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void N_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\N.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void O_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\O.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void P_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\P.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void Q_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\Q.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void R_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\R.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void S_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\S.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void T_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\T.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void U_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\U.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void V_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\V.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void W_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\W.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void X_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\X.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }
        private void Y_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\Y.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void Z_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            axWindowsMediaPlayer1.URL = "C:\\Users\\D3zhu\\Desktop\\RecoSign\\videos\\Z.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }


        //Media Player Initialization
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {

        }

    }

}


