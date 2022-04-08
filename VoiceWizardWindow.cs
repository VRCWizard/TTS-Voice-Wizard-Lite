//Wizard
//using Microsoft.CognitiveServices.Speech;//Subcription Azure
//using Microsoft.CognitiveServices.Speech.Audio; //Subcription Azure
//using Microsoft.CognitiveServices.Speech.Translation;
using SharpOSC;
using System;
using System.Speech.Recognition;//free Windows
using System.Windows.Forms;
using Vosk;
using NAudio;
using NAudio.Wave;
using NAudio.Utils;
using System.Speech;
using System.Speech.Synthesis;

namespace TTSWizardFree
{
    public partial class VoiceWizardWindow : Form
    {

        public static string YourSubscriptionKey = Settings1.Default.yourKey;
        public static string YourServiceRegion = Settings1.Default.yourRegion;
        public string dictationString = "";
        public string activationWord = Settings1.Default.activationWord;
        public int debugDelayValue = 250;// Recommended delay of 250ms 
        public int eraseDelay = 5000;
        int audioOutputIndex = -1;
        public bool profanityFilter = true;
        //  SpeechRecognitionEngine recognizer;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // WaveIn sourceStream;
        //  WaveFileWriter waveWriter;
        // private WaveFileWriter waveWriter;//opening memoryStream and write in dataavailable event
        //Stream memoryStream; //for save 
        WaveFileWriter writer;
        private MemoryStream mem;
        public WaveInEvent waveInStream;

        //  static WaveFileWriter wri;
        //  static bool stopped = false;
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;
        Model model;
        VoskRecognizer rec;

        WaveInEvent waveIn = new WaveInEvent();
        SpeechSynthesizer synthesizer;
        
        //var synthesizer1 = new SpeechSynthesizer();


        bool listeningCurrently = false;
        SpeechRecognitionEngine recognizer;
        private static bool _userRequestedAbort = false;

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        private void WaveInOnDataAvailable(object? sender, WaveInEventArgs e)
        {
            
            //synthesizer.SelectVoice("Microsoft Zira Desktop");
            
           // foreach (var voice in synthesizer.GetInstalledVoices())
           // {
           //     var info = voice.VoiceInfo;
            //    System.Diagnostics.Debug.WriteLine($"Id: {info.Id} | Name: {info.Name} | Age: { info.Age} | Gender: { info.Gender} | Culture: { info.Culture}");
            // }
            
            try
            {

                this.Invoke((MethodInvoker)delegate ()
                {
                    try
                    {
                       
                        if (rec.AcceptWaveform(e.Buffer, e.Buffer.Length))
                        {
                            string text = rec.Result().ToString();
                            text = text.Replace("\n", "").Replace("\r", "");
                            text = text.Remove(0, 13);
                            text = text.Remove(text.Length - 1);
                            text = text.Remove(text.Length - 1);
                            System.Diagnostics.Debug.WriteLine(text);
                           // synthesizer.Speak(test);
                            var ot = new OutputText();
                            //Send Text to Vrchat
                            if (checkBox2.Checked == true)
                            {
                                ot.outputLog(this, text);
                            }
                            Task.Run(() => synthesizer.Speak(text));//new
                            if (checkBox1.Checked == true)
                            {



                                Task.Run(() => ot.outputVRChat(this, text)); //original
                                                                             // ot.outputVRChat(this, text);//new
                            }

                        }
                        else
                        {
                     //   System.Diagnostics.Debug.WriteLine(rec.PartialResult());
                        }
                    }
                    catch (Exception exception)
                    {
                        System.Diagnostics.Debug.WriteLine("not working 1");
                    }

                });
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine("not working 2");
            }
        }
        public VoiceWizardWindow()
        {


            InitializeComponent();
            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                System.Diagnostics.Debug.WriteLine($"{n}: {caps.ProductName}");
            }
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                System.Diagnostics.Debug.WriteLine($"{n}: {caps.ProductName}");
            }
            synthesizer = new SpeechSynthesizer();
           // synthesizer = synthesizer;
            //synthesizer.SetOutputToDefaultAudioDevice();
            foreach (var voice in synthesizer.GetInstalledVoices())
             {
                 var info = voice.VoiceInfo;
                System.Diagnostics.Debug.WriteLine($"Id: {info.Id} | Name: {info.Name} | Age: { info.Age} | Gender: { info.Gender} | Culture: { info.Culture}");
                comboBox2.Items.Add(info.Name);
            }



            tabControl1.Dock = DockStyle.Fill;


            int id = 0;// The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Control, Keys.G.GetHashCode());
            
            waveIn.DataAvailable += WaveInOnDataAvailable;
           // waveIn.StartRecording();

            model = new Model("model");
            rec = new VoskRecognizer(model, waveIn.WaveFormat.SampleRate);

         




        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Recognized text: " + e.Result.Text);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                speechTTSButton.PerformClick();
   
            }
        }
        private async void TTSButton_Click(object sender, EventArgs e)//TTS
        {
           // synthesizer = new SpeechSynthesizer();
            //synthesizer.SelectVoice("Microsoft Zira Desktop");
           // synthesizer.SetOutputToDefaultAudioDevice();


            string text = "";
            this.Invoke((MethodInvoker)delegate ()
            {
                text = richTextBox2.Text.ToString();



            });
            var ot = new OutputText();
            //Send Text to Vrchat
            if (checkBox2.Checked == true)
            {
                ot.outputLog(this, text);
            }
            Task.Run(() => synthesizer.Speak(text));//new
            if (checkBox1.Checked == true)
            {



                Task.Run(() => ot.outputVRChat(this,text)); //original
               // ot.outputVRChat(this, text);//new
            }
            //Send Text to TTS


            // Task.Run(() => AudioSynthesis.SynthesizeAudioAsync(text, emotion, rate, pitch, volume, voice)); //original


        }
        private void hideVRCTextButton_Click(object sender, EventArgs e)//speech to text
        {
            var sender2 = new SharpOSC.UDPSender("127.0.0.1", 9000);
            var message0 = new SharpOSC.OscMessage("/avatar/parameters/KAT_Visible", false);
            sender2.Send(message0);



        }
        private void logClearButton_Click(object sender, EventArgs e)//speech to text
        {
            ClearTextBox();


        }
        private void buttonDelayHere_Click(object sender, EventArgs e)//speech to text
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                debugDelayValue = Int32.Parse(textBoxDelay.Text.ToString());


            });
        }



      

        public void logLine(string line)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { line });
                return;
            }
            richTextBox1.Select(0, 0);
            richTextBox1.SelectedText = line + "\r\n";
        }


        public void AppendTextBox(string value)
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }

            richTextBox1.Text += value;

        }
        public void ClearTextBox()
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action(ClearTextBox));
                return;
            }

            richTextBox1.Text = "";

        }
        public void ClearTextBoxTTS()
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action(ClearTextBoxTTS));
                return;
            }

            richTextBox2.Text = "";

        }






        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
           
            Settings1.Default.recognition = checkBox4.Checked;
            Settings1.Default.Save();
        }

        private void comboBoxVirtualOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  audioOutputIndex = comboBoxVirtualOutput.SelectedIndex - 1; //+1 while i have mapped device in there
            System.Diagnostics.Debug.WriteLine("audio device index: " + audioOutputIndex);

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            checkBox4.Checked = Settings1.Default.recognition;
            textBoxActivationWord.Text = Settings1.Default.activationWord;
            activationWord = Settings1.Default.activationWord;
            if (Settings1.Default.recognition == true)
            {
                var va = new VoiceActivation();

                va.loadSpeechRecognition(this);
                MessageBox.Show("STTTS Voice Activation Initiated");
            }



            YourSubscriptionKey = Settings1.Default.yourKey;
            YourServiceRegion = Settings1.Default.yourRegion;

  

            
            comboBox2.SelectedIndex = 0;//voice


        }
     



        private void buttonActivationWord_Click(object sender, EventArgs e)
        {
            activationWord = textBoxActivationWord.Text.ToString();
            Settings1.Default.activationWord = textBoxActivationWord.Text.ToString();
            Settings1.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
           
                this.Invoke((MethodInvoker)delegate ()
                {
                    eraseDelay = Int32.Parse(textBoxErase.Text.ToString());


                });

        }
        private void startListeningNow()
        {
            using (recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US")))
            {
                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                bool completed = false;

                // Attach event handlers.
                recognizer.RecognizeCompleted += (o, e) =>
                {
                    if (e.Error != null)
                    {
                        System.Diagnostics.Debug.WriteLine("Error occurred during recognition: {0}", e.Error);
                    }
                    else if (e.InitialSilenceTimeout)
                    {
                        System.Diagnostics.Debug.WriteLine("Detected silence");
                    }
                    else if (e.BabbleTimeout)
                    {
                        System.Diagnostics.Debug.WriteLine("Detected babbling");
                    }
                    else if (e.InputStreamEnded)
                    {
                        System.Diagnostics.Debug.WriteLine("Input stream ended early");
                    }
                    else if (e.Result != null)
                    {
                        System.Diagnostics.Debug.WriteLine("Grammar = {0}; Text = {1}; Confidence = {2}", e.Result.Grammar.Name, e.Result.Text, e.Result.Confidence);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("No result");
                    }

                    completed = true;
                };
                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);


                while (!completed)
                {
                    if (_userRequestedAbort)
                    {
                        recognizer.RecognizeAsyncCancel();
                        break;
                    }

                    Thread.Sleep(333);
                }

                Console.WriteLine("Done.");
  
            }

        }

        private void speechTTSButton_Click(object sender, EventArgs e)
        {
            
             if(listeningCurrently ==false)
             {
                _userRequestedAbort = false;
                Task.Run(() => startListeningNow());
                //  waveIn.StartRecording();
                 var ot = new OutputText();
                 ot.outputLog(this, "[Started Listening]");
                listeningCurrently = true;
             }
             else
             {
                _userRequestedAbort = true;
               // recognizer.RecognizeAsyncStop();
               ///  waveIn.StopRecording();
                 var ot = new OutputText();
                 ot.outputLog(this, "[Stop Listening]");
                 listeningCurrently = false;
             }




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public static void DemoBytes(Model model)
        {
            // Demo byte buffer
            VoskRecognizer rec = new VoskRecognizer(model, 16000.0f);
            rec.SetMaxAlternatives(0);
            rec.SetWords(true);
            using (Stream source = File.OpenRead("test.wav"))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    if (rec.AcceptWaveform(buffer, bytesRead))
                    {
                        System.Diagnostics.Debug.WriteLine(rec.Result());
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine(rec.PartialResult());
                    }
                }
            }
            Console.WriteLine(rec.FinalResult());
        }

        public static void DemoFloats(Model model)
        {
            // Demo float array
            VoskRecognizer rec = new VoskRecognizer(model, 16000.0f);
            using (Stream source = File.OpenRead("test.wav"))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    float[] fbuffer = new float[bytesRead / 2];
                    for (int i = 0, n = 0; i < fbuffer.Length; i++, n += 2)
                    {
                        fbuffer[i] = BitConverter.ToInt16(buffer, n);
                    }
                    if (rec.AcceptWaveform(fbuffer, fbuffer.Length))
                    {
                        System.Diagnostics.Debug.WriteLine(rec.Result());
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine(rec.PartialResult());
                    }
                }
            }
            Console.WriteLine(rec.FinalResult());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            synthesizer.SelectVoice(comboBox2.Text.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxTTS();

        }
    }
}