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
using System.Speech.Recognition;
using System.Speech.Synthesis;
namespace Voice_O_Clock_2
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sRec = new SpeechRecognitionEngine();
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder conteudo = new PromptBuilder();
        string somDespertador = "H:/Área de Desenvolvimento/SOFTWARES/C#/Projetos/Voice O Clock_2/02 - day 69.mp3";
        public Form1()
        {
            InitializeComponent();
            sRec.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"H:/Área de Desenvolvimento/SOFTWARES/C#/Projetos/Voice O Clock_2/commands.txt")))));
            sRec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sRec_SpeechRecognized);
            sRec.SetInputToDefaultAudioDevice();
            sRec.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void horaAtual_Tick_1(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        void sRec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            string fala = e.Result.Text;
            string hrNum;
            switch (fala)
            {

                // Setar horários. [engine blockCode]
                //==================================================

                case "Set alarm to midnight":
                    hrNum = "00:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 00 minutes":
                    hrNum = "00:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 01 minutes":
                    hrNum = "00:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 02 minutes":
                    hrNum = "00:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 03 minutes":
                    hrNum = "00:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 04 minutes":
                    hrNum = "00:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 05 minutes":
                    hrNum = "00:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 06 minutes":
                    hrNum = "00:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 07 minutes":
                    hrNum = "00:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 08 minutes":
                    hrNum = "00:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 09 minutes":
                    hrNum = "00:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 10 minutes":
                    hrNum = "00:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 11 minutes":
                    hrNum = "00:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 12 minutes":
                    hrNum = "00:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 13 minutes":
                    hrNum = "00:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 14 minutes":
                    hrNum = "00:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 15 minutes":
                    hrNum = "00:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 16 minutes":
                    hrNum = "00:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 17 minutes":
                    hrNum = "00:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 18 minutes":
                    hrNum = "00:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 19 minutes":
                    hrNum = "00:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 20 minutes":
                    hrNum = "00:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 21 minutes":
                    hrNum = "00:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 22 minutes":
                    hrNum = "00:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 23 minutes":
                    hrNum = "00:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 24 minutes":
                    hrNum = "00:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 25 minutes":
                    hrNum = "00:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 26 minutes":
                    hrNum = "00:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 27 minutes":
                    hrNum = "00:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 28 minutes":
                    hrNum = "00:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 29 minutes":
                    hrNum = "00:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 30 minutes":
                    hrNum = "00:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 31 minutes":
                    hrNum = "00:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 32 minutes":
                    hrNum = "00:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 33 minutes":
                    hrNum = "00:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 34 minutes":
                    hrNum = "00:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 35 minutes":
                    hrNum = "00:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 36 minutes":
                    hrNum = "00:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 37 minutes":
                    hrNum = "00:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 38 minutes":
                    hrNum = "00:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 39 minutes":
                    hrNum = "00:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 40 minutes":
                    hrNum = "00:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 41 minutes":
                    hrNum = "00:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 42 minutes":
                    hrNum = "00:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 43 minutes":
                    hrNum = "00:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 44 minutes":
                    hrNum = "00:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 45 minutes":
                    hrNum = "00:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 46 minutes":
                    hrNum = "00:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 47 minutes":
                    hrNum = "00:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 48 minutes":
                    hrNum = "00:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 49 minutes":
                    hrNum = "00:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 50 minutes":
                    hrNum = "00:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 51 minutes":
                    hrNum = "00:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 52 minutes":
                    hrNum = "00:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 53 minutes":
                    hrNum = "00:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 54 minutes":
                    hrNum = "00:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 55 minutes":
                    hrNum = "00:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 56 minutes":
                    hrNum = "00:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 57 minutes":
                    hrNum = "00:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 58 minutes":
                    hrNum = "00:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 00 hours and 59 minutes":
                    hrNum = "00:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 00 minutes":
                    hrNum = "01:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 01 minutes":
                    hrNum = "01:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 02 minutes":
                    hrNum = "01:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 03 minutes":
                    hrNum = "01:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 04 minutes":
                    hrNum = "01:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 05 minutes":
                    hrNum = "01:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 06 minutes":
                    hrNum = "01:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 07 minutes":
                    hrNum = "01:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 08 minutes":
                    hrNum = "01:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 09 minutes":
                    hrNum = "01:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 10 minutes":
                    hrNum = "01:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 11 minutes":
                    hrNum = "01:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 12 minutes":
                    hrNum = "01:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 13 minutes":
                    hrNum = "01:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 14 minutes":
                    hrNum = "01:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 15 minutes":
                    hrNum = "01:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 16 minutes":
                    hrNum = "01:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 17 minutes":
                    hrNum = "01:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 18 minutes":
                    hrNum = "01:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 19 minutes":
                    hrNum = "01:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 20 minutes":
                    hrNum = "01:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 21 minutes":
                    hrNum = "01:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 22 minutes":
                    hrNum = "01:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 23 minutes":
                    hrNum = "01:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 24 minutes":
                    hrNum = "01:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 25 minutes":
                    hrNum = "01:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 26 minutes":
                    hrNum = "01:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 27 minutes":
                    hrNum = "01:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 28 minutes":
                    hrNum = "01:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 29 minutes":
                    hrNum = "01:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 30 minutes":
                    hrNum = "01:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 31 minutes":
                    hrNum = "01:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 32 minutes":
                    hrNum = "01:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 33 minutes":
                    hrNum = "01:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 34 minutes":
                    hrNum = "01:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 35 minutes":
                    hrNum = "01:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 36 minutes":
                    hrNum = "01:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 37 minutes":
                    hrNum = "01:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 38 minutes":
                    hrNum = "01:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 39 minutes":
                    hrNum = "01:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 40 minutes":
                    hrNum = "01:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 41 minutes":
                    hrNum = "01:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 42 minutes":
                    hrNum = "01:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 43 minutes":
                    hrNum = "01:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 44 minutes":
                    hrNum = "01:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 45 minutes":
                    hrNum = "01:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 46 minutes":
                    hrNum = "01:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 47 minutes":
                    hrNum = "01:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 48 minutes":
                    hrNum = "01:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 49 minutes":
                    hrNum = "01:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 50 minutes":
                    hrNum = "01:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 51 minutes":
                    hrNum = "01:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 52 minutes":
                    hrNum = "01:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 53 minutes":
                    hrNum = "01:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 54 minutes":
                    hrNum = "01:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 55 minutes":
                    hrNum = "01:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 56 minutes":
                    hrNum = "01:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 57 minutes":
                    hrNum = "01:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 58 minutes":
                    hrNum = "01:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 01 hours and 59 minutes":
                    hrNum = "01:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 00 minutes":
                    hrNum = "02:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 01 minutes":
                    hrNum = "02:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 02 minutes":
                    hrNum = "02:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 03 minutes":
                    hrNum = "02:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 04 minutes":
                    hrNum = "02:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 05 minutes":
                    hrNum = "02:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 06 minutes":
                    hrNum = "02:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 07 minutes":
                    hrNum = "02:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 08 minutes":
                    hrNum = "02:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 09 minutes":
                    hrNum = "02:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 10 minutes":
                    hrNum = "02:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 11 minutes":
                    hrNum = "02:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 12 minutes":
                    hrNum = "02:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 13 minutes":
                    hrNum = "02:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 14 minutes":
                    hrNum = "02:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 15 minutes":
                    hrNum = "02:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 16 minutes":
                    hrNum = "02:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 17 minutes":
                    hrNum = "02:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 18 minutes":
                    hrNum = "02:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 19 minutes":
                    hrNum = "02:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 20 minutes":
                    hrNum = "02:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 21 minutes":
                    hrNum = "02:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 22 minutes":
                    hrNum = "02:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 23 minutes":
                    hrNum = "02:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 24 minutes":
                    hrNum = "02:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 25 minutes":
                    hrNum = "02:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 26 minutes":
                    hrNum = "02:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 27 minutes":
                    hrNum = "02:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 28 minutes":
                    hrNum = "02:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 29 minutes":
                    hrNum = "02:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 30 minutes":
                    hrNum = "02:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 31 minutes":
                    hrNum = "02:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 32 minutes":
                    hrNum = "02:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 33 minutes":
                    hrNum = "02:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 34 minutes":
                    hrNum = "02:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 35 minutes":
                    hrNum = "02:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 36 minutes":
                    hrNum = "02:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 37 minutes":
                    hrNum = "02:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 38 minutes":
                    hrNum = "02:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 39 minutes":
                    hrNum = "02:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 40 minutes":
                    hrNum = "02:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 41 minutes":
                    hrNum = "02:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 42 minutes":
                    hrNum = "02:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 43 minutes":
                    hrNum = "02:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 44 minutes":
                    hrNum = "02:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 45 minutes":
                    hrNum = "02:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 46 minutes":
                    hrNum = "02:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 47 minutes":
                    hrNum = "02:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 48 minutes":
                    hrNum = "02:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 49 minutes":
                    hrNum = "02:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 50 minutes":
                    hrNum = "02:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 51 minutes":
                    hrNum = "02:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 52 minutes":
                    hrNum = "02:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 53 minutes":
                    hrNum = "02:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 54 minutes":
                    hrNum = "02:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 55 minutes":
                    hrNum = "02:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 56 minutes":
                    hrNum = "02:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 57 minutes":
                    hrNum = "02:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 58 minutes":
                    hrNum = "02:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 02 hours and 59 minutes":
                    hrNum = "02:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 00 minutes":
                    hrNum = "03:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 01 minutes":
                    hrNum = "03:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 02 minutes":
                    hrNum = "03:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 03 minutes":
                    hrNum = "03:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 04 minutes":
                    hrNum = "03:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 05 minutes":
                    hrNum = "03:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 06 minutes":
                    hrNum = "03:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 07 minutes":
                    hrNum = "03:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 08 minutes":
                    hrNum = "03:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 09 minutes":
                    hrNum = "03:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 10 minutes":
                    hrNum = "03:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 11 minutes":
                    hrNum = "03:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 12 minutes":
                    hrNum = "03:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 13 minutes":
                    hrNum = "03:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 14 minutes":
                    hrNum = "03:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 15 minutes":
                    hrNum = "03:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 16 minutes":
                    hrNum = "03:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 17 minutes":
                    hrNum = "03:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 18 minutes":
                    hrNum = "03:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 19 minutes":
                    hrNum = "03:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 20 minutes":
                    hrNum = "03:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 21 minutes":
                    hrNum = "03:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 22 minutes":
                    hrNum = "03:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 23 minutes":
                    hrNum = "03:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 24 minutes":
                    hrNum = "03:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 25 minutes":
                    hrNum = "03:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 26 minutes":
                    hrNum = "03:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 27 minutes":
                    hrNum = "03:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 28 minutes":
                    hrNum = "03:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 29 minutes":
                    hrNum = "03:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 30 minutes":
                    hrNum = "03:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 31 minutes":
                    hrNum = "03:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 32 minutes":
                    hrNum = "03:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 33 minutes":
                    hrNum = "03:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 34 minutes":
                    hrNum = "03:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 35 minutes":
                    hrNum = "03:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 36 minutes":
                    hrNum = "03:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 37 minutes":
                    hrNum = "03:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 38 minutes":
                    hrNum = "03:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 39 minutes":
                    hrNum = "03:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 40 minutes":
                    hrNum = "03:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 41 minutes":
                    hrNum = "03:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 42 minutes":
                    hrNum = "03:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 43 minutes":
                    hrNum = "03:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 44 minutes":
                    hrNum = "03:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 45 minutes":
                    hrNum = "03:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 46 minutes":
                    hrNum = "03:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 47 minutes":
                    hrNum = "03:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 48 minutes":
                    hrNum = "03:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 49 minutes":
                    hrNum = "03:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 50 minutes":
                    hrNum = "03:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 51 minutes":
                    hrNum = "03:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 52 minutes":
                    hrNum = "03:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 53 minutes":
                    hrNum = "03:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 54 minutes":
                    hrNum = "03:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 55 minutes":
                    hrNum = "03:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 56 minutes":
                    hrNum = "03:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 57 minutes":
                    hrNum = "03:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 58 minutes":
                    hrNum = "03:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 03 hours and 59 minutes":
                    hrNum = "03:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 00 minutes":
                    hrNum = "04:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 01 minutes":
                    hrNum = "04:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 02 minutes":
                    hrNum = "04:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 03 minutes":
                    hrNum = "04:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 04 minutes":
                    hrNum = "04:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 05 minutes":
                    hrNum = "04:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 06 minutes":
                    hrNum = "04:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 07 minutes":
                    hrNum = "04:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 08 minutes":
                    hrNum = "04:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 09 minutes":
                    hrNum = "04:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 10 minutes":
                    hrNum = "04:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 11 minutes":
                    hrNum = "04:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 12 minutes":
                    hrNum = "04:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 13 minutes":
                    hrNum = "04:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 14 minutes":
                    hrNum = "04:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 15 minutes":
                    hrNum = "04:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 16 minutes":
                    hrNum = "04:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 17 minutes":
                    hrNum = "04:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 18 minutes":
                    hrNum = "04:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 19 minutes":
                    hrNum = "04:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 20 minutes":
                    hrNum = "04:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 21 minutes":
                    hrNum = "04:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 22 minutes":
                    hrNum = "04:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 23 minutes":
                    hrNum = "04:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 24 minutes":
                    hrNum = "04:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 25 minutes":
                    hrNum = "04:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 26 minutes":
                    hrNum = "04:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 27 minutes":
                    hrNum = "04:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 28 minutes":
                    hrNum = "04:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 29 minutes":
                    hrNum = "04:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 30 minutes":
                    hrNum = "04:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 31 minutes":
                    hrNum = "04:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 32 minutes":
                    hrNum = "04:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 33 minutes":
                    hrNum = "04:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 34 minutes":
                    hrNum = "04:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 35 minutes":
                    hrNum = "04:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 36 minutes":
                    hrNum = "04:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 37 minutes":
                    hrNum = "04:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 38 minutes":
                    hrNum = "04:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 39 minutes":
                    hrNum = "04:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 40 minutes":
                    hrNum = "04:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 41 minutes":
                    hrNum = "04:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 42 minutes":
                    hrNum = "04:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 43 minutes":
                    hrNum = "04:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 44 minutes":
                    hrNum = "04:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 45 minutes":
                    hrNum = "04:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 46 minutes":
                    hrNum = "04:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 47 minutes":
                    hrNum = "04:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 48 minutes":
                    hrNum = "04:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 49 minutes":
                    hrNum = "04:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 50 minutes":
                    hrNum = "04:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 51 minutes":
                    hrNum = "04:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 52 minutes":
                    hrNum = "04:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 53 minutes":
                    hrNum = "04:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 54 minutes":
                    hrNum = "04:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 55 minutes":
                    hrNum = "04:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 56 minutes":
                    hrNum = "04:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 57 minutes":
                    hrNum = "04:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 58 minutes":
                    hrNum = "04:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 04 hours and 59 minutes":
                    hrNum = "04:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 00 minutes":
                    hrNum = "05:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 01 minutes":
                    hrNum = "05:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 02 minutes":
                    hrNum = "05:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 03 minutes":
                    hrNum = "05:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 04 minutes":
                    hrNum = "05:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 05 minutes":
                    hrNum = "05:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 06 minutes":
                    hrNum = "05:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 07 minutes":
                    hrNum = "05:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 08 minutes":
                    hrNum = "05:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 09 minutes":
                    hrNum = "05:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 10 minutes":
                    hrNum = "05:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 11 minutes":
                    hrNum = "05:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 12 minutes":
                    hrNum = "05:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 13 minutes":
                    hrNum = "05:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 14 minutes":
                    hrNum = "05:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 15 minutes":
                    hrNum = "05:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 16 minutes":
                    hrNum = "05:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 17 minutes":
                    hrNum = "05:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 18 minutes":
                    hrNum = "05:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 19 minutes":
                    hrNum = "05:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 20 minutes":
                    hrNum = "05:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 21 minutes":
                    hrNum = "05:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 22 minutes":
                    hrNum = "05:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 23 minutes":
                    hrNum = "05:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 24 minutes":
                    hrNum = "05:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 25 minutes":
                    hrNum = "05:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 26 minutes":
                    hrNum = "05:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 27 minutes":
                    hrNum = "05:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 28 minutes":
                    hrNum = "05:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 29 minutes":
                    hrNum = "05:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 30 minutes":
                    hrNum = "05:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 31 minutes":
                    hrNum = "05:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 32 minutes":
                    hrNum = "05:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 33 minutes":
                    hrNum = "05:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 34 minutes":
                    hrNum = "05:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 35 minutes":
                    hrNum = "05:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 36 minutes":
                    hrNum = "05:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 37 minutes":
                    hrNum = "05:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 38 minutes":
                    hrNum = "05:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 39 minutes":
                    hrNum = "05:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 40 minutes":
                    hrNum = "05:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 41 minutes":
                    hrNum = "05:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 42 minutes":
                    hrNum = "05:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 43 minutes":
                    hrNum = "05:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 44 minutes":
                    hrNum = "05:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 45 minutes":
                    hrNum = "05:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 46 minutes":
                    hrNum = "05:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 47 minutes":
                    hrNum = "05:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 48 minutes":
                    hrNum = "05:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 49 minutes":
                    hrNum = "05:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 50 minutes":
                    hrNum = "05:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 51 minutes":
                    hrNum = "05:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 52 minutes":
                    hrNum = "05:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 53 minutes":
                    hrNum = "05:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 54 minutes":
                    hrNum = "05:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 55 minutes":
                    hrNum = "05:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 56 minutes":
                    hrNum = "05:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 57 minutes":
                    hrNum = "05:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 58 minutes":
                    hrNum = "05:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 05 hours and 59 minutes":
                    hrNum = "05:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 00 minutes":
                    hrNum = "06:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 01 minutes":
                    hrNum = "06:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 02 minutes":
                    hrNum = "06:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 03 minutes":
                    hrNum = "06:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 04 minutes":
                    hrNum = "06:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 05 minutes":
                    hrNum = "06:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 06 minutes":
                    hrNum = "06:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 07 minutes":
                    hrNum = "06:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 08 minutes":
                    hrNum = "06:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 09 minutes":
                    hrNum = "06:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 10 minutes":
                    hrNum = "06:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 11 minutes":
                    hrNum = "06:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 12 minutes":
                    hrNum = "06:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 13 minutes":
                    hrNum = "06:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 14 minutes":
                    hrNum = "06:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 15 minutes":
                    hrNum = "06:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 16 minutes":
                    hrNum = "06:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 17 minutes":
                    hrNum = "06:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 18 minutes":
                    hrNum = "06:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 19 minutes":
                    hrNum = "06:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 20 minutes":
                    hrNum = "06:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 21 minutes":
                    hrNum = "06:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 22 minutes":
                    hrNum = "06:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 23 minutes":
                    hrNum = "06:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 24 minutes":
                    hrNum = "06:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 25 minutes":
                    hrNum = "06:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 26 minutes":
                    hrNum = "06:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 27 minutes":
                    hrNum = "06:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 28 minutes":
                    hrNum = "06:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 29 minutes":
                    hrNum = "06:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 30 minutes":
                    hrNum = "06:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 31 minutes":
                    hrNum = "06:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 32 minutes":
                    hrNum = "06:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 33 minutes":
                    hrNum = "06:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 34 minutes":
                    hrNum = "06:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 35 minutes":
                    hrNum = "06:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 36 minutes":
                    hrNum = "06:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 37 minutes":
                    hrNum = "06:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 38 minutes":
                    hrNum = "06:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 39 minutes":
                    hrNum = "06:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 40 minutes":
                    hrNum = "06:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 41 minutes":
                    hrNum = "06:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 42 minutes":
                    hrNum = "06:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 43 minutes":
                    hrNum = "06:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 44 minutes":
                    hrNum = "06:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 45 minutes":
                    hrNum = "06:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 46 minutes":
                    hrNum = "06:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 47 minutes":
                    hrNum = "06:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 48 minutes":
                    hrNum = "06:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 49 minutes":
                    hrNum = "06:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 50 minutes":
                    hrNum = "06:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 51 minutes":
                    hrNum = "06:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 52 minutes":
                    hrNum = "06:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 53 minutes":
                    hrNum = "06:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 54 minutes":
                    hrNum = "06:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 55 minutes":
                    hrNum = "06:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 56 minutes":
                    hrNum = "06:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 57 minutes":
                    hrNum = "06:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 58 minutes":
                    hrNum = "06:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 06 hours and 59 minutes":
                    hrNum = "06:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 00 minutes":
                    hrNum = "07:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 01 minutes":
                    hrNum = "07:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 02 minutes":
                    hrNum = "07:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 03 minutes":
                    hrNum = "07:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 04 minutes":
                    hrNum = "07:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 05 minutes":
                    hrNum = "07:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 06 minutes":
                    hrNum = "07:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 07 minutes":
                    hrNum = "07:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 08 minutes":
                    hrNum = "07:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 09 minutes":
                    hrNum = "07:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 10 minutes":
                    hrNum = "07:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 11 minutes":
                    hrNum = "07:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 12 minutes":
                    hrNum = "07:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 13 minutes":
                    hrNum = "07:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 14 minutes":
                    hrNum = "07:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 15 minutes":
                    hrNum = "07:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 16 minutes":
                    hrNum = "07:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 17 minutes":
                    hrNum = "07:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 18 minutes":
                    hrNum = "07:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 19 minutes":
                    hrNum = "07:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 20 minutes":
                    hrNum = "07:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 21 minutes":
                    hrNum = "07:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 22 minutes":
                    hrNum = "07:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 23 minutes":
                    hrNum = "07:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 24 minutes":
                    hrNum = "07:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 25 minutes":
                    hrNum = "07:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 26 minutes":
                    hrNum = "07:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 27 minutes":
                    hrNum = "07:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 28 minutes":
                    hrNum = "07:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 29 minutes":
                    hrNum = "07:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 30 minutes":
                    hrNum = "07:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 31 minutes":
                    hrNum = "07:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 32 minutes":
                    hrNum = "07:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 33 minutes":
                    hrNum = "07:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 34 minutes":
                    hrNum = "07:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 35 minutes":
                    hrNum = "07:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 36 minutes":
                    hrNum = "07:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 37 minutes":
                    hrNum = "07:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 38 minutes":
                    hrNum = "07:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 39 minutes":
                    hrNum = "07:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 40 minutes":
                    hrNum = "07:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 41 minutes":
                    hrNum = "07:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 42 minutes":
                    hrNum = "07:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 43 minutes":
                    hrNum = "07:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 44 minutes":
                    hrNum = "07:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 45 minutes":
                    hrNum = "07:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 46 minutes":
                    hrNum = "07:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 47 minutes":
                    hrNum = "07:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 48 minutes":
                    hrNum = "07:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 49 minutes":
                    hrNum = "07:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 50 minutes":
                    hrNum = "07:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 51 minutes":
                    hrNum = "07:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 52 minutes":
                    hrNum = "07:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 53 minutes":
                    hrNum = "07:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 54 minutes":
                    hrNum = "07:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 55 minutes":
                    hrNum = "07:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 56 minutes":
                    hrNum = "07:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 57 minutes":
                    hrNum = "07:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 58 minutes":
                    hrNum = "07:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 07 hours and 59 minutes":
                    hrNum = "07:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 00 minutes":
                    hrNum = "08:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 01 minutes":
                    hrNum = "08:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 02 minutes":
                    hrNum = "08:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 03 minutes":
                    hrNum = "08:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 04 minutes":
                    hrNum = "08:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 05 minutes":
                    hrNum = "08:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 06 minutes":
                    hrNum = "08:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 07 minutes":
                    hrNum = "08:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 08 minutes":
                    hrNum = "08:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 09 minutes":
                    hrNum = "08:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 10 minutes":
                    hrNum = "08:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 11 minutes":
                    hrNum = "08:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 12 minutes":
                    hrNum = "08:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 13 minutes":
                    hrNum = "08:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 14 minutes":
                    hrNum = "08:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 15 minutes":
                    hrNum = "08:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 16 minutes":
                    hrNum = "08:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 17 minutes":
                    hrNum = "08:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 18 minutes":
                    hrNum = "08:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 19 minutes":
                    hrNum = "08:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 20 minutes":
                    hrNum = "08:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 21 minutes":
                    hrNum = "08:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 22 minutes":
                    hrNum = "08:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 23 minutes":
                    hrNum = "08:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 24 minutes":
                    hrNum = "08:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 25 minutes":
                    hrNum = "08:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 26 minutes":
                    hrNum = "08:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 27 minutes":
                    hrNum = "08:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 28 minutes":
                    hrNum = "08:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 29 minutes":
                    hrNum = "08:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 30 minutes":
                    hrNum = "08:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 31 minutes":
                    hrNum = "08:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 32 minutes":
                    hrNum = "08:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 33 minutes":
                    hrNum = "08:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 34 minutes":
                    hrNum = "08:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 35 minutes":
                    hrNum = "08:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 36 minutes":
                    hrNum = "08:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 37 minutes":
                    hrNum = "08:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 38 minutes":
                    hrNum = "08:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 39 minutes":
                    hrNum = "08:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 40 minutes":
                    hrNum = "08:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 41 minutes":
                    hrNum = "08:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 42 minutes":
                    hrNum = "08:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 43 minutes":
                    hrNum = "08:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 44 minutes":
                    hrNum = "08:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 45 minutes":
                    hrNum = "08:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 46 minutes":
                    hrNum = "08:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 47 minutes":
                    hrNum = "08:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 48 minutes":
                    hrNum = "08:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 49 minutes":
                    hrNum = "08:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 50 minutes":
                    hrNum = "08:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 51 minutes":
                    hrNum = "08:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 52 minutes":
                    hrNum = "08:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 53 minutes":
                    hrNum = "08:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 54 minutes":
                    hrNum = "08:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 55 minutes":
                    hrNum = "08:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 56 minutes":
                    hrNum = "08:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 57 minutes":
                    hrNum = "08:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 58 minutes":
                    hrNum = "08:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 08 hours and 59 minutes":
                    hrNum = "08:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 00 minutes":
                    hrNum = "09:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 01 minutes":
                    hrNum = "09:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 02 minutes":
                    hrNum = "09:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 03 minutes":
                    hrNum = "09:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 04 minutes":
                    hrNum = "09:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 05 minutes":
                    hrNum = "09:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 06 minutes":
                    hrNum = "09:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 07 minutes":
                    hrNum = "09:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 08 minutes":
                    hrNum = "09:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 09 minutes":
                    hrNum = "09:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 10 minutes":
                    hrNum = "09:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 11 minutes":
                    hrNum = "09:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 12 minutes":
                    hrNum = "09:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 13 minutes":
                    hrNum = "09:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 14 minutes":
                    hrNum = "09:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 15 minutes":
                    hrNum = "09:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 16 minutes":
                    hrNum = "09:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 17 minutes":
                    hrNum = "09:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 18 minutes":
                    hrNum = "09:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 19 minutes":
                    hrNum = "09:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 20 minutes":
                    hrNum = "09:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 21 minutes":
                    hrNum = "09:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 22 minutes":
                    hrNum = "09:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 23 minutes":
                    hrNum = "09:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 24 minutes":
                    hrNum = "09:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 25 minutes":
                    hrNum = "09:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 26 minutes":
                    hrNum = "09:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 27 minutes":
                    hrNum = "09:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 28 minutes":
                    hrNum = "09:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 29 minutes":
                    hrNum = "09:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 30 minutes":
                    hrNum = "09:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 31 minutes":
                    hrNum = "09:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 32 minutes":
                    hrNum = "09:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 33 minutes":
                    hrNum = "09:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 34 minutes":
                    hrNum = "09:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 35 minutes":
                    hrNum = "09:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 36 minutes":
                    hrNum = "09:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 37 minutes":
                    hrNum = "09:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 38 minutes":
                    hrNum = "09:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 39 minutes":
                    hrNum = "09:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 40 minutes":
                    hrNum = "09:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 41 minutes":
                    hrNum = "09:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 42 minutes":
                    hrNum = "09:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 43 minutes":
                    hrNum = "09:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 44 minutes":
                    hrNum = "09:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 45 minutes":
                    hrNum = "09:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 46 minutes":
                    hrNum = "09:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 47 minutes":
                    hrNum = "09:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 48 minutes":
                    hrNum = "09:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 49 minutes":
                    hrNum = "09:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 50 minutes":
                    hrNum = "09:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 51 minutes":
                    hrNum = "09:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 52 minutes":
                    hrNum = "09:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 53 minutes":
                    hrNum = "09:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 54 minutes":
                    hrNum = "09:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 55 minutes":
                    hrNum = "09:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 56 minutes":
                    hrNum = "09:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 57 minutes":
                    hrNum = "09:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 58 minutes":
                    hrNum = "09:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 09 hours and 59 minutes":
                    hrNum = "09:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;
                
                case "Set alarm to 10 hours and 00 minutes":
                    hrNum = "10:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 01 minutes":
                    hrNum = "10:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 02 minutes":
                    hrNum = "10:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 03 minutes":
                    hrNum = "10:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 04 minutes":
                    hrNum = "10:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 05 minutes":
                    hrNum = "10:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 06 minutes":
                    hrNum = "10:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 07 minutes":
                    hrNum = "10:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 08 minutes":
                    hrNum = "10:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 09 minutes":
                    hrNum = "10:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 10 minutes":
                    hrNum = "10:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 11 minutes":
                    hrNum = "10:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 12 minutes":
                    hrNum = "10:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 13 minutes":
                    hrNum = "10:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 14 minutes":
                    hrNum = "10:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 15 minutes":
                    hrNum = "10:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 16 minutes":
                    hrNum = "10:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 17 minutes":
                    hrNum = "10:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 18 minutes":
                    hrNum = "10:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 19 minutes":
                    hrNum = "10:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 20 minutes":
                    hrNum = "10:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 21 minutes":
                    hrNum = "10:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 22 minutes":
                    hrNum = "10:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 23 minutes":
                    hrNum = "10:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 24 minutes":
                    hrNum = "10:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 25 minutes":
                    hrNum = "10:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 26 minutes":
                    hrNum = "10:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 27 minutes":
                    hrNum = "10:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 28 minutes":
                    hrNum = "10:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 29 minutes":
                    hrNum = "10:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 30 minutes":
                    hrNum = "10:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 31 minutes":
                    hrNum = "10:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 32 minutes":
                    hrNum = "10:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 33 minutes":
                    hrNum = "10:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 34 minutes":
                    hrNum = "10:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 35 minutes":
                    hrNum = "10:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 36 minutes":
                    hrNum = "10:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 37 minutes":
                    hrNum = "10:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 38 minutes":
                    hrNum = "10:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 39 minutes":
                    hrNum = "10:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 40 minutes":
                    hrNum = "10:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 41 minutes":
                    hrNum = "10:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 42 minutes":
                    hrNum = "10:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 43 minutes":
                    hrNum = "10:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 44 minutes":
                    hrNum = "10:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 45 minutes":
                    hrNum = "10:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 46 minutes":
                    hrNum = "10:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 47 minutes":
                    hrNum = "10:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 48 minutes":
                    hrNum = "10:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 49 minutes":
                    hrNum = "10:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 50 minutes":
                    hrNum = "10:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 51 minutes":
                    hrNum = "10:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 52 minutes":
                    hrNum = "10:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 53 minutes":
                    hrNum = "10:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 54 minutes":
                    hrNum = "10:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 55 minutes":
                    hrNum = "10:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 56 minutes":
                    hrNum = "10:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 57 minutes":
                    hrNum = "10:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 58 minutes":
                    hrNum = "10:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 10 hours and 59 minutes":
                    hrNum = "10:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 00 minutes":
                    hrNum = "11:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 01 minutes":
                    hrNum = "11:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 02 minutes":
                    hrNum = "11:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 03 minutes":
                    hrNum = "11:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 04 minutes":
                    hrNum = "11:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 05 minutes":
                    hrNum = "11:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 06 minutes":
                    hrNum = "11:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 07 minutes":
                    hrNum = "11:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 08 minutes":
                    hrNum = "11:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 09 minutes":
                    hrNum = "11:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 10 minutes":
                    hrNum = "11:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 11 minutes":
                    hrNum = "11:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 12 minutes":
                    hrNum = "11:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 13 minutes":
                    hrNum = "11:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 14 minutes":
                    hrNum = "11:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 15 minutes":
                    hrNum = "11:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 16 minutes":
                    hrNum = "11:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 17 minutes":
                    hrNum = "11:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 18 minutes":
                    hrNum = "11:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 19 minutes":
                    hrNum = "11:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 20 minutes":
                    hrNum = "11:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 21 minutes":
                    hrNum = "11:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 22 minutes":
                    hrNum = "11:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 23 minutes":
                    hrNum = "11:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 24 minutes":
                    hrNum = "11:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 25 minutes":
                    hrNum = "11:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 26 minutes":
                    hrNum = "11:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 27 minutes":
                    hrNum = "11:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 28 minutes":
                    hrNum = "11:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 29 minutes":
                    hrNum = "11:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 30 minutes":
                    hrNum = "11:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 31 minutes":
                    hrNum = "11:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 32 minutes":
                    hrNum = "11:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 33 minutes":
                    hrNum = "11:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 34 minutes":
                    hrNum = "11:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 35 minutes":
                    hrNum = "11:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 36 minutes":
                    hrNum = "11:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 37 minutes":
                    hrNum = "11:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 38 minutes":
                    hrNum = "11:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 39 minutes":
                    hrNum = "11:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 40 minutes":
                    hrNum = "11:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 41 minutes":
                    hrNum = "11:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 42 minutes":
                    hrNum = "11:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 43 minutes":
                    hrNum = "11:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 44 minutes":
                    hrNum = "11:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 45 minutes":
                    hrNum = "11:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 46 minutes":
                    hrNum = "11:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 47 minutes":
                    hrNum = "11:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 48 minutes":
                    hrNum = "11:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 49 minutes":
                    hrNum = "11:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 50 minutes":
                    hrNum = "11:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 51 minutes":
                    hrNum = "11:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 52 minutes":
                    hrNum = "11:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 53 minutes":
                    hrNum = "11:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 54 minutes":
                    hrNum = "11:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 55 minutes":
                    hrNum = "11:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 56 minutes":
                    hrNum = "11:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 57 minutes":
                    hrNum = "11:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 58 minutes":
                    hrNum = "11:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 11 hours and 59 minutes":
                    hrNum = "11:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to mid day":
                    hrNum = "12:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 00 minutes":
                    hrNum = "12:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 01 minutes":
                    hrNum = "12:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 02 minutes":
                    hrNum = "12:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 03 minutes":
                    hrNum = "12:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 04 minutes":
                    hrNum = "12:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 05 minutes":
                    hrNum = "12:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 06 minutes":
                    hrNum = "12:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 07 minutes":
                    hrNum = "12:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 08 minutes":
                    hrNum = "12:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 09 minutes":
                    hrNum = "12:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 10 minutes":
                    hrNum = "12:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 11 minutes":
                    hrNum = "12:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 12 minutes":
                    hrNum = "12:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 13 minutes":
                    hrNum = "12:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 14 minutes":
                    hrNum = "12:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 15 minutes":
                    hrNum = "12:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 16 minutes":
                    hrNum = "12:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 17 minutes":
                    hrNum = "12:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 18 minutes":
                    hrNum = "12:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 19 minutes":
                    hrNum = "12:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 20 minutes":
                    hrNum = "12:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 21 minutes":
                    hrNum = "12:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 22 minutes":
                    hrNum = "12:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 23 minutes":
                    hrNum = "12:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 24 minutes":
                    hrNum = "12:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 25 minutes":
                    hrNum = "12:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 26 minutes":
                    hrNum = "12:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 27 minutes":
                    hrNum = "12:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 28 minutes":
                    hrNum = "12:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 29 minutes":
                    hrNum = "12:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 30 minutes":
                    hrNum = "12:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 31 minutes":
                    hrNum = "12:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 32 minutes":
                    hrNum = "12:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 33 minutes":
                    hrNum = "12:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 34 minutes":
                    hrNum = "12:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 35 minutes":
                    hrNum = "12:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 36 minutes":
                    hrNum = "12:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 37 minutes":
                    hrNum = "12:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 38 minutes":
                    hrNum = "12:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 39 minutes":
                    hrNum = "12:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 40 minutes":
                    hrNum = "12:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 41 minutes":
                    hrNum = "12:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 42 minutes":
                    hrNum = "12:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 43 minutes":
                    hrNum = "12:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 44 minutes":
                    hrNum = "12:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 45 minutes":
                    hrNum = "12:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 46 minutes":
                    hrNum = "12:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 47 minutes":
                    hrNum = "12:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 48 minutes":
                    hrNum = "12:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 49 minutes":
                    hrNum = "12:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 50 minutes":
                    hrNum = "12:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 51 minutes":
                    hrNum = "12:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 52 minutes":
                    hrNum = "12:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 53 minutes":
                    hrNum = "12:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 54 minutes":
                    hrNum = "12:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 55 minutes":
                    hrNum = "12:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 56 minutes":
                    hrNum = "12:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 57 minutes":
                    hrNum = "12:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 58 minutes":
                    hrNum = "12:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 12 hours and 59 minutes":
                    hrNum = "12:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 00 minutes":
                    hrNum = "13:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 01 minutes":
                    hrNum = "13:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 02 minutes":
                    hrNum = "13:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 03 minutes":
                    hrNum = "13:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 04 minutes":
                    hrNum = "13:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 05 minutes":
                    hrNum = "13:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 06 minutes":
                    hrNum = "13:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 07 minutes":
                    hrNum = "13:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 08 minutes":
                    hrNum = "13:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 09 minutes":
                    hrNum = "13:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 10 minutes":
                    hrNum = "13:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 11 minutes":
                    hrNum = "13:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 12 minutes":
                    hrNum = "13:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 13 minutes":
                    hrNum = "13:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 14 minutes":
                    hrNum = "13:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 15 minutes":
                    hrNum = "13:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 16 minutes":
                    hrNum = "13:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 17 minutes":
                    hrNum = "13:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 18 minutes":
                    hrNum = "13:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 19 minutes":
                    hrNum = "13:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 20 minutes":
                    hrNum = "13:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 21 minutes":
                    hrNum = "13:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 22 minutes":
                    hrNum = "13:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 23 minutes":
                    hrNum = "13:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 24 minutes":
                    hrNum = "13:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 25 minutes":
                    hrNum = "13:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 26 minutes":
                    hrNum = "13:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 27 minutes":
                    hrNum = "13:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 28 minutes":
                    hrNum = "13:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 29 minutes":
                    hrNum = "13:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 30 minutes":
                    hrNum = "13:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 31 minutes":
                    hrNum = "13:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 32 minutes":
                    hrNum = "13:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 33 minutes":
                    hrNum = "13:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 34 minutes":
                    hrNum = "13:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 35 minutes":
                    hrNum = "13:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 36 minutes":
                    hrNum = "13:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 37 minutes":
                    hrNum = "13:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 38 minutes":
                    hrNum = "13:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 39 minutes":
                    hrNum = "13:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 40 minutes":
                    hrNum = "13:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 41 minutes":
                    hrNum = "13:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 42 minutes":
                    hrNum = "13:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 43 minutes":
                    hrNum = "13:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 44 minutes":
                    hrNum = "13:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 45 minutes":
                    hrNum = "13:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 46 minutes":
                    hrNum = "13:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 47 minutes":
                    hrNum = "13:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 48 minutes":
                    hrNum = "13:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 49 minutes":
                    hrNum = "13:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 50 minutes":
                    hrNum = "13:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 51 minutes":
                    hrNum = "13:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 52 minutes":
                    hrNum = "13:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 53 minutes":
                    hrNum = "13:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 54 minutes":
                    hrNum = "13:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 55 minutes":
                    hrNum = "13:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 56 minutes":
                    hrNum = "13:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 57 minutes":
                    hrNum = "13:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 58 minutes":
                    hrNum = "13:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 13 hours and 59 minutes":
                    hrNum = "13:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 00 minutes":
                    hrNum = "14:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 01 minutes":
                    hrNum = "14:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 02 minutes":
                    hrNum = "14:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 03 minutes":
                    hrNum = "14:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 04 minutes":
                    hrNum = "14:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 05 minutes":
                    hrNum = "14:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 06 minutes":
                    hrNum = "14:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 07 minutes":
                    hrNum = "14:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 08 minutes":
                    hrNum = "14:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 09 minutes":
                    hrNum = "14:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 10 minutes":
                    hrNum = "14:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 11 minutes":
                    hrNum = "14:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 12 minutes":
                    hrNum = "14:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 13 minutes":
                    hrNum = "14:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 14 minutes":
                    hrNum = "14:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 15 minutes":
                    hrNum = "14:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 16 minutes":
                    hrNum = "14:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 17 minutes":
                    hrNum = "14:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 18 minutes":
                    hrNum = "14:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 19 minutes":
                    hrNum = "14:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 20 minutes":
                    hrNum = "14:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 21 minutes":
                    hrNum = "14:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 22 minutes":
                    hrNum = "14:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 23 minutes":
                    hrNum = "14:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 24 minutes":
                    hrNum = "14:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 25 minutes":
                    hrNum = "14:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 26 minutes":
                    hrNum = "14:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 27 minutes":
                    hrNum = "14:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 28 minutes":
                    hrNum = "14:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 29 minutes":
                    hrNum = "14:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 30 minutes":
                    hrNum = "14:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 31 minutes":
                    hrNum = "14:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 32 minutes":
                    hrNum = "14:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 33 minutes":
                    hrNum = "14:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 34 minutes":
                    hrNum = "14:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 35 minutes":
                    hrNum = "14:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 36 minutes":
                    hrNum = "14:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 37 minutes":
                    hrNum = "14:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 38 minutes":
                    hrNum = "14:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 39 minutes":
                    hrNum = "14:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 40 minutes":
                    hrNum = "14:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 41 minutes":
                    hrNum = "14:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 42 minutes":
                    hrNum = "14:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 43 minutes":
                    hrNum = "14:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 44 minutes":
                    hrNum = "14:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 45 minutes":
                    hrNum = "14:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 46 minutes":
                    hrNum = "14:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 47 minutes":
                    hrNum = "14:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 48 minutes":
                    hrNum = "14:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 49 minutes":
                    hrNum = "14:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 50 minutes":
                    hrNum = "14:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 51 minutes":
                    hrNum = "14:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 52 minutes":
                    hrNum = "14:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 53 minutes":
                    hrNum = "14:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 54 minutes":
                    hrNum = "14:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 55 minutes":
                    hrNum = "14:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 56 minutes":
                    hrNum = "14:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 57 minutes":
                    hrNum = "14:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 58 minutes":
                    hrNum = "14:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 14 hours and 59 minutes":
                    hrNum = "14:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 00 minutes":
                    hrNum = "15:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 01 minutes":
                    hrNum = "15:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 02 minutes":
                    hrNum = "15:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 03 minutes":
                    hrNum = "15:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 04 minutes":
                    hrNum = "15:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 05 minutes":
                    hrNum = "15:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 06 minutes":
                    hrNum = "15:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 07 minutes":
                    hrNum = "15:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 08 minutes":
                    hrNum = "15:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 09 minutes":
                    hrNum = "15:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 10 minutes":
                    hrNum = "15:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 11 minutes":
                    hrNum = "15:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 12 minutes":
                    hrNum = "15:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 13 minutes":
                    hrNum = "15:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 14 minutes":
                    hrNum = "15:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 15 minutes":
                    hrNum = "15:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 16 minutes":
                    hrNum = "15:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 17 minutes":
                    hrNum = "15:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 18 minutes":
                    hrNum = "15:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 19 minutes":
                    hrNum = "15:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 20 minutes":
                    hrNum = "15:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 21 minutes":
                    hrNum = "15:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 22 minutes":
                    hrNum = "15:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 23 minutes":
                    hrNum = "15:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 24 minutes":
                    hrNum = "15:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 25 minutes":
                    hrNum = "15:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 26 minutes":
                    hrNum = "15:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 27 minutes":
                    hrNum = "15:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 28 minutes":
                    hrNum = "15:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 29 minutes":
                    hrNum = "15:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 30 minutes":
                    hrNum = "15:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 31 minutes":
                    hrNum = "15:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 32 minutes":
                    hrNum = "15:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 33 minutes":
                    hrNum = "15:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 34 minutes":
                    hrNum = "15:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 35 minutes":
                    hrNum = "15:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 36 minutes":
                    hrNum = "15:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 37 minutes":
                    hrNum = "15:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 38 minutes":
                    hrNum = "15:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 39 minutes":
                    hrNum = "15:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 40 minutes":
                    hrNum = "15:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 41 minutes":
                    hrNum = "15:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 42 minutes":
                    hrNum = "15:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 43 minutes":
                    hrNum = "15:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 44 minutes":
                    hrNum = "15:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 45 minutes":
                    hrNum = "15:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 46 minutes":
                    hrNum = "15:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 47 minutes":
                    hrNum = "15:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 48 minutes":
                    hrNum = "15:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 49 minutes":
                    hrNum = "15:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 50 minutes":
                    hrNum = "15:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 51 minutes":
                    hrNum = "15:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 52 minutes":
                    hrNum = "15:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 53 minutes":
                    hrNum = "15:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 54 minutes":
                    hrNum = "15:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 55 minutes":
                    hrNum = "15:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 56 minutes":
                    hrNum = "15:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 57 minutes":
                    hrNum = "15:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 58 minutes":
                    hrNum = "15:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 15 hours and 59 minutes":
                    hrNum = "15:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 00 minutes":
                    hrNum = "16:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 01 minutes":
                    hrNum = "16:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 02 minutes":
                    hrNum = "16:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 03 minutes":
                    hrNum = "16:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 04 minutes":
                    hrNum = "16:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 05 minutes":
                    hrNum = "16:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 06 minutes":
                    hrNum = "16:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 07 minutes":
                    hrNum = "16:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 08 minutes":
                    hrNum = "16:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 09 minutes":
                    hrNum = "16:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 10 minutes":
                    hrNum = "16:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 11 minutes":
                    hrNum = "16:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 12 minutes":
                    hrNum = "16:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 13 minutes":
                    hrNum = "16:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 14 minutes":
                    hrNum = "16:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 15 minutes":
                    hrNum = "16:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 16 minutes":
                    hrNum = "16:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 17 minutes":
                    hrNum = "16:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 18 minutes":
                    hrNum = "16:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 19 minutes":
                    hrNum = "16:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 20 minutes":
                    hrNum = "16:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 21 minutes":
                    hrNum = "16:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 22 minutes":
                    hrNum = "16:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 23 minutes":
                    hrNum = "16:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 24 minutes":
                    hrNum = "16:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 25 minutes":
                    hrNum = "16:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 26 minutes":
                    hrNum = "16:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 27 minutes":
                    hrNum = "16:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 28 minutes":
                    hrNum = "16:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 29 minutes":
                    hrNum = "16:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 30 minutes":
                    hrNum = "16:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 31 minutes":
                    hrNum = "16:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 32 minutes":
                    hrNum = "16:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 33 minutes":
                    hrNum = "16:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 34 minutes":
                    hrNum = "16:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 35 minutes":
                    hrNum = "16:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 36 minutes":
                    hrNum = "16:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 37 minutes":
                    hrNum = "16:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 38 minutes":
                    hrNum = "16:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 39 minutes":
                    hrNum = "16:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 40 minutes":
                    hrNum = "16:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 41 minutes":
                    hrNum = "16:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 42 minutes":
                    hrNum = "16:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 43 minutes":
                    hrNum = "16:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 44 minutes":
                    hrNum = "16:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 45 minutes":
                    hrNum = "16:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 46 minutes":
                    hrNum = "16:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 47 minutes":
                    hrNum = "16:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 48 minutes":
                    hrNum = "16:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 49 minutes":
                    hrNum = "16:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 50 minutes":
                    hrNum = "16:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 51 minutes":
                    hrNum = "16:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 52 minutes":
                    hrNum = "16:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 53 minutes":
                    hrNum = "16:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 54 minutes":
                    hrNum = "16:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 55 minutes":
                    hrNum = "16:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 56 minutes":
                    hrNum = "16:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 57 minutes":
                    hrNum = "16:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 58 minutes":
                    hrNum = "16:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 16 hours and 59 minutes":
                    hrNum = "16:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 00 minutes":
                    hrNum = "17:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 01 minutes":
                    hrNum = "17:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 02 minutes":
                    hrNum = "17:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 03 minutes":
                    hrNum = "17:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 04 minutes":
                    hrNum = "17:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 05 minutes":
                    hrNum = "17:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 06 minutes":
                    hrNum = "17:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 07 minutes":
                    hrNum = "17:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 08 minutes":
                    hrNum = "17:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 09 minutes":
                    hrNum = "17:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 10 minutes":
                    hrNum = "17:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 11 minutes":
                    hrNum = "17:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 12 minutes":
                    hrNum = "17:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 13 minutes":
                    hrNum = "17:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 14 minutes":
                    hrNum = "17:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 15 minutes":
                    hrNum = "17:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 16 minutes":
                    hrNum = "17:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 17 minutes":
                    hrNum = "17:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 18 minutes":
                    hrNum = "17:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 19 minutes":
                    hrNum = "17:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 20 minutes":
                    hrNum = "17:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 21 minutes":
                    hrNum = "17:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 22 minutes":
                    hrNum = "17:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 23 minutes":
                    hrNum = "17:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 24 minutes":
                    hrNum = "17:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 25 minutes":
                    hrNum = "17:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 26 minutes":
                    hrNum = "17:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 27 minutes":
                    hrNum = "17:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 28 minutes":
                    hrNum = "17:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 29 minutes":
                    hrNum = "17:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 30 minutes":
                    hrNum = "17:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 31 minutes":
                    hrNum = "17:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 32 minutes":
                    hrNum = "17:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 33 minutes":
                    hrNum = "17:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 34 minutes":
                    hrNum = "17:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 35 minutes":
                    hrNum = "17:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 36 minutes":
                    hrNum = "17:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 37 minutes":
                    hrNum = "17:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 38 minutes":
                    hrNum = "17:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 39 minutes":
                    hrNum = "17:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 40 minutes":
                    hrNum = "17:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 41 minutes":
                    hrNum = "17:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 42 minutes":
                    hrNum = "17:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 43 minutes":
                    hrNum = "17:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 44 minutes":
                    hrNum = "17:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 45 minutes":
                    hrNum = "17:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 46 minutes":
                    hrNum = "17:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 47 minutes":
                    hrNum = "17:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 48 minutes":
                    hrNum = "17:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 49 minutes":
                    hrNum = "17:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 50 minutes":
                    hrNum = "17:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 51 minutes":
                    hrNum = "17:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 52 minutes":
                    hrNum = "17:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 53 minutes":
                    hrNum = "17:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 54 minutes":
                    hrNum = "17:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 55 minutes":
                    hrNum = "17:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 56 minutes":
                    hrNum = "17:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 57 minutes":
                    hrNum = "17:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 58 minutes":
                    hrNum = "17:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 17 hours and 59 minutes":
                    hrNum = "17:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 00 minutes":
                    hrNum = "18:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 01 minutes":
                    hrNum = "18:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 02 minutes":
                    hrNum = "18:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 03 minutes":
                    hrNum = "18:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 04 minutes":
                    hrNum = "18:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 05 minutes":
                    hrNum = "18:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 06 minutes":
                    hrNum = "18:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 07 minutes":
                    hrNum = "18:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 08 minutes":
                    hrNum = "18:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 09 minutes":
                    hrNum = "18:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 10 minutes":
                    hrNum = "18:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 11 minutes":
                    hrNum = "18:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 12 minutes":
                    hrNum = "18:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 13 minutes":
                    hrNum = "18:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 14 minutes":
                    hrNum = "18:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 15 minutes":
                    hrNum = "18:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 16 minutes":
                    hrNum = "18:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 17 minutes":
                    hrNum = "18:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 18 minutes":
                    hrNum = "18:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 19 minutes":
                    hrNum = "18:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 20 minutes":
                    hrNum = "18:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 21 minutes":
                    hrNum = "18:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 22 minutes":
                    hrNum = "18:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 23 minutes":
                    hrNum = "18:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 24 minutes":
                    hrNum = "18:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 25 minutes":
                    hrNum = "18:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 26 minutes":
                    hrNum = "18:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 27 minutes":
                    hrNum = "18:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 28 minutes":
                    hrNum = "18:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 29 minutes":
                    hrNum = "18:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 30 minutes":
                    hrNum = "18:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 31 minutes":
                    hrNum = "18:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 32 minutes":
                    hrNum = "18:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 33 minutes":
                    hrNum = "18:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 34 minutes":
                    hrNum = "18:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 35 minutes":
                    hrNum = "18:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 36 minutes":
                    hrNum = "18:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 37 minutes":
                    hrNum = "18:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 38 minutes":
                    hrNum = "18:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 39 minutes":
                    hrNum = "18:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 40 minutes":
                    hrNum = "18:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 41 minutes":
                    hrNum = "18:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 42 minutes":
                    hrNum = "18:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 43 minutes":
                    hrNum = "18:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 44 minutes":
                    hrNum = "18:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 45 minutes":
                    hrNum = "18:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 46 minutes":
                    hrNum = "18:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 47 minutes":
                    hrNum = "18:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 48 minutes":
                    hrNum = "18:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 49 minutes":
                    hrNum = "18:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 50 minutes":
                    hrNum = "18:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 51 minutes":
                    hrNum = "18:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 52 minutes":
                    hrNum = "18:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 53 minutes":
                    hrNum = "18:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 54 minutes":
                    hrNum = "18:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 55 minutes":
                    hrNum = "18:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 56 minutes":
                    hrNum = "18:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 57 minutes":
                    hrNum = "18:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 58 minutes":
                    hrNum = "18:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 18 hours and 59 minutes":
                    hrNum = "18:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 00 minutes":
                    hrNum = "19:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 01 minutes":
                    hrNum = "19:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 02 minutes":
                    hrNum = "19:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 03 minutes":
                    hrNum = "19:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 04 minutes":
                    hrNum = "19:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 05 minutes":
                    hrNum = "19:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 06 minutes":
                    hrNum = "19:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 07 minutes":
                    hrNum = "19:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 08 minutes":
                    hrNum = "19:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 09 minutes":
                    hrNum = "19:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 10 minutes":
                    hrNum = "19:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 11 minutes":
                    hrNum = "19:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 12 minutes":
                    hrNum = "19:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 13 minutes":
                    hrNum = "19:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 14 minutes":
                    hrNum = "19:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 15 minutes":
                    hrNum = "19:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 16 minutes":
                    hrNum = "19:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 17 minutes":
                    hrNum = "19:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 18 minutes":
                    hrNum = "19:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 19 minutes":
                    hrNum = "19:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 20 minutes":
                    hrNum = "19:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 21 minutes":
                    hrNum = "19:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 22 minutes":
                    hrNum = "19:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 23 minutes":
                    hrNum = "19:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 24 minutes":
                    hrNum = "19:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 25 minutes":
                    hrNum = "19:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 26 minutes":
                    hrNum = "19:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 27 minutes":
                    hrNum = "19:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 28 minutes":
                    hrNum = "19:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 29 minutes":
                    hrNum = "19:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 30 minutes":
                    hrNum = "19:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 31 minutes":
                    hrNum = "19:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 32 minutes":
                    hrNum = "19:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 33 minutes":
                    hrNum = "19:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 34 minutes":
                    hrNum = "19:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 35 minutes":
                    hrNum = "19:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 36 minutes":
                    hrNum = "19:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 37 minutes":
                    hrNum = "19:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 38 minutes":
                    hrNum = "19:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 39 minutes":
                    hrNum = "19:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 40 minutes":
                    hrNum = "19:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 41 minutes":
                    hrNum = "19:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 42 minutes":
                    hrNum = "19:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 43 minutes":
                    hrNum = "19:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 44 minutes":
                    hrNum = "19:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 45 minutes":
                    hrNum = "19:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 46 minutes":
                    hrNum = "19:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 47 minutes":
                    hrNum = "19:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 48 minutes":
                    hrNum = "19:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 49 minutes":
                    hrNum = "19:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 50 minutes":
                    hrNum = "19:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 51 minutes":
                    hrNum = "19:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 52 minutes":
                    hrNum = "19:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 53 minutes":
                    hrNum = "19:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 54 minutes":
                    hrNum = "19:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 55 minutes":
                    hrNum = "19:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 56 minutes":
                    hrNum = "19:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 57 minutes":
                    hrNum = "19:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 58 minutes":
                    hrNum = "19:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 19 hours and 59 minutes":
                    hrNum = "19:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 00 minutes":
                    hrNum = "20:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 01 minutes":
                    hrNum = "20:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 02 minutes":
                    hrNum = "20:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 03 minutes":
                    hrNum = "20:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 04 minutes":
                    hrNum = "20:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 05 minutes":
                    hrNum = "20:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 06 minutes":
                    hrNum = "20:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 07 minutes":
                    hrNum = "20:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 08 minutes":
                    hrNum = "20:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 09 minutes":
                    hrNum = "20:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 10 minutes":
                    hrNum = "20:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 11 minutes":
                    hrNum = "20:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 12 minutes":
                    hrNum = "20:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 13 minutes":
                    hrNum = "20:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 14 minutes":
                    hrNum = "20:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 15 minutes":
                    hrNum = "20:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 16 minutes":
                    hrNum = "20:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 17 minutes":
                    hrNum = "20:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 18 minutes":
                    hrNum = "20:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 19 minutes":
                    hrNum = "20:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 20 minutes":
                    hrNum = "20:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 21 minutes":
                    hrNum = "20:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 22 minutes":
                    hrNum = "20:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 23 minutes":
                    hrNum = "20:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 24 minutes":
                    hrNum = "20:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 25 minutes":
                    hrNum = "20:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 26 minutes":
                    hrNum = "20:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 27 minutes":
                    hrNum = "20:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 28 minutes":
                    hrNum = "20:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 29 minutes":
                    hrNum = "20:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 30 minutes":
                    hrNum = "20:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 31 minutes":
                    hrNum = "20:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 32 minutes":
                    hrNum = "20:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 33 minutes":
                    hrNum = "20:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 34 minutes":
                    hrNum = "20:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 35 minutes":
                    hrNum = "20:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 36 minutes":
                    hrNum = "20:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 37 minutes":
                    hrNum = "20:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 38 minutes":
                    hrNum = "20:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 39 minutes":
                    hrNum = "20:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 40 minutes":
                    hrNum = "20:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 41 minutes":
                    hrNum = "20:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 42 minutes":
                    hrNum = "20:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 43 minutes":
                    hrNum = "20:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 44 minutes":
                    hrNum = "20:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 45 minutes":
                    hrNum = "20:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 46 minutes":
                    hrNum = "20:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 47 minutes":
                    hrNum = "20:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 48 minutes":
                    hrNum = "20:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 49 minutes":
                    hrNum = "20:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 50 minutes":
                    hrNum = "20:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 51 minutes":
                    hrNum = "20:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 52 minutes":
                    hrNum = "20:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 53 minutes":
                    hrNum = "20:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 54 minutes":
                    hrNum = "20:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 55 minutes":
                    hrNum = "20:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 56 minutes":
                    hrNum = "20:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 57 minutes":
                    hrNum = "20:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 58 minutes":
                    hrNum = "20:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 20 hours and 59 minutes":
                    hrNum = "20:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 00 minutes":
                    hrNum = "21:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 01 minutes":
                    hrNum = "21:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 02 minutes":
                    hrNum = "21:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 03 minutes":
                    hrNum = "21:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 04 minutes":
                    hrNum = "21:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 05 minutes":
                    hrNum = "21:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 06 minutes":
                    hrNum = "21:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 07 minutes":
                    hrNum = "21:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 08 minutes":
                    hrNum = "21:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 09 minutes":
                    hrNum = "21:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 10 minutes":
                    hrNum = "21:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 11 minutes":
                    hrNum = "21:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 12 minutes":
                    hrNum = "21:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 13 minutes":
                    hrNum = "21:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 14 minutes":
                    hrNum = "21:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 15 minutes":
                    hrNum = "21:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 16 minutes":
                    hrNum = "21:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 17 minutes":
                    hrNum = "21:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 18 minutes":
                    hrNum = "21:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 19 minutes":
                    hrNum = "21:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 20 minutes":
                    hrNum = "21:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 21 minutes":
                    hrNum = "21:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 22 minutes":
                    hrNum = "21:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 23 minutes":
                    hrNum = "21:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 24 minutes":
                    hrNum = "21:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 25 minutes":
                    hrNum = "21:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 26 minutes":
                    hrNum = "21:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 27 minutes":
                    hrNum = "21:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 28 minutes":
                    hrNum = "21:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 29 minutes":
                    hrNum = "21:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 30 minutes":
                    hrNum = "21:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 31 minutes":
                    hrNum = "21:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 32 minutes":
                    hrNum = "21:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 33 minutes":
                    hrNum = "21:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 34 minutes":
                    hrNum = "21:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 35 minutes":
                    hrNum = "21:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 36 minutes":
                    hrNum = "21:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 37 minutes":
                    hrNum = "21:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 38 minutes":
                    hrNum = "21:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 39 minutes":
                    hrNum = "21:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 40 minutes":
                    hrNum = "21:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 41 minutes":
                    hrNum = "21:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 42 minutes":
                    hrNum = "21:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 43 minutes":
                    hrNum = "21:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 44 minutes":
                    hrNum = "21:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 45 minutes":
                    hrNum = "21:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 46 minutes":
                    hrNum = "21:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 47 minutes":
                    hrNum = "21:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 48 minutes":
                    hrNum = "21:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 49 minutes":
                    hrNum = "21:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 50 minutes":
                    hrNum = "21:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 51 minutes":
                    hrNum = "21:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 52 minutes":
                    hrNum = "21:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 53 minutes":
                    hrNum = "21:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 54 minutes":
                    hrNum = "21:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 55 minutes":
                    hrNum = "21:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 56 minutes":
                    hrNum = "21:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 57 minutes":
                    hrNum = "21:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 58 minutes":
                    hrNum = "21:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 21 hours and 59 minutes":
                    hrNum = "21:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 00 minutes":
                    hrNum = "22:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 01 minutes":
                    hrNum = "22:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 02 minutes":
                    hrNum = "22:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 03 minutes":
                    hrNum = "22:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 04 minutes":
                    hrNum = "22:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 05 minutes":
                    hrNum = "22:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 06 minutes":
                    hrNum = "22:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 07 minutes":
                    hrNum = "22:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 08 minutes":
                    hrNum = "22:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 09 minutes":
                    hrNum = "22:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 10 minutes":
                    hrNum = "22:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 11 minutes":
                    hrNum = "22:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 12 minutes":
                    hrNum = "22:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 13 minutes":
                    hrNum = "22:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 14 minutes":
                    hrNum = "22:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 15 minutes":
                    hrNum = "22:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 16 minutes":
                    hrNum = "22:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 17 minutes":
                    hrNum = "22:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 18 minutes":
                    hrNum = "22:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 19 minutes":
                    hrNum = "22:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 20 minutes":
                    hrNum = "22:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 21 minutes":
                    hrNum = "22:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 22 minutes":
                    hrNum = "22:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 23 minutes":
                    hrNum = "22:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 24 minutes":
                    hrNum = "22:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 25 minutes":
                    hrNum = "22:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 26 minutes":
                    hrNum = "22:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 27 minutes":
                    hrNum = "22:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 28 minutes":
                    hrNum = "22:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 29 minutes":
                    hrNum = "22:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 30 minutes":
                    hrNum = "22:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 31 minutes":
                    hrNum = "22:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 32 minutes":
                    hrNum = "22:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 33 minutes":
                    hrNum = "22:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 34 minutes":
                    hrNum = "22:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 35 minutes":
                    hrNum = "22:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 36 minutes":
                    hrNum = "22:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 37 minutes":
                    hrNum = "22:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 38 minutes":
                    hrNum = "22:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 39 minutes":
                    hrNum = "22:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 40 minutes":
                    hrNum = "22:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 41 minutes":
                    hrNum = "22:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 42 minutes":
                    hrNum = "22:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 43 minutes":
                    hrNum = "22:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 44 minutes":
                    hrNum = "22:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 45 minutes":
                    hrNum = "22:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 46 minutes":
                    hrNum = "22:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 47 minutes":
                    hrNum = "22:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 48 minutes":
                    hrNum = "22:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 49 minutes":
                    hrNum = "22:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 50 minutes":
                    hrNum = "22:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 51 minutes":
                    hrNum = "22:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 52 minutes":
                    hrNum = "22:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 53 minutes":
                    hrNum = "22:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 54 minutes":
                    hrNum = "22:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 55 minutes":
                    hrNum = "22:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 56 minutes":
                    hrNum = "22:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 57 minutes":
                    hrNum = "22:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 58 minutes":
                    hrNum = "22:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 22 hours and 59 minutes":
                    hrNum = "22:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 00 minutes":
                    hrNum = "23:00:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 01 minutes":
                    hrNum = "23:01:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 02 minutes":
                    hrNum = "23:02:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 03 minutes":
                    hrNum = "23:03:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 04 minutes":
                    hrNum = "23:04:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 05 minutes":
                    hrNum = "23:05:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 06 minutes":
                    hrNum = "23:06:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 07 minutes":
                    hrNum = "23:07:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 08 minutes":
                    hrNum = "23:08:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 09 minutes":
                    hrNum = "23:09:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 10 minutes":
                    hrNum = "23:10:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 11 minutes":
                    hrNum = "23:11:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 12 minutes":
                    hrNum = "23:12:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 13 minutes":
                    hrNum = "23:13:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 14 minutes":
                    hrNum = "23:14:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 15 minutes":
                    hrNum = "23:15:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 16 minutes":
                    hrNum = "23:16:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 17 minutes":
                    hrNum = "23:17:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 18 minutes":
                    hrNum = "23:18:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 19 minutes":
                    hrNum = "23:19:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 20 minutes":
                    hrNum = "23:20:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 21 minutes":
                    hrNum = "23:21:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 22 minutes":
                    hrNum = "23:22:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 23 minutes":
                    hrNum = "23:23:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 24 minutes":
                    hrNum = "23:24:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 25 minutes":
                    hrNum = "23:25:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 26 minutes":
                    hrNum = "23:26:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 27 minutes":
                    hrNum = "23:27:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 28 minutes":
                    hrNum = "23:28:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 29 minutes":
                    hrNum = "23:29:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 30 minutes":
                    hrNum = "23:30:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 31 minutes":
                    hrNum = "23:31:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 32 minutes":
                    hrNum = "23:32:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 33 minutes":
                    hrNum = "23:33:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 34 minutes":
                    hrNum = "23:34:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 35 minutes":
                    hrNum = "23:35:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 36 minutes":
                    hrNum = "23:36:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 37 minutes":
                    hrNum = "23:37:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 38 minutes":
                    hrNum = "23:38:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 39 minutes":
                    hrNum = "23:39:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 40 minutes":
                    hrNum = "23:40:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 41 minutes":
                    hrNum = "23:41:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 42 minutes":
                    hrNum = "23:42:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 43 minutes":
                    hrNum = "23:43:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 44 minutes":
                    hrNum = "23:44:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 45 minutes":
                    hrNum = "23:45:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 46 minutes":
                    hrNum = "23:46:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 47 minutes":
                    hrNum = "23:47:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 48 minutes":
                    hrNum = "23:48:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 49 minutes":
                    hrNum = "23:49:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 50 minutes":
                    hrNum = "23:50:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 51 minutes":
                    hrNum = "23:51:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 52 minutes":
                    hrNum = "23:52:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 53 minutes":
                    hrNum = "23:53:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 54 minutes":
                    hrNum = "23:54:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 55 minutes":
                    hrNum = "23:55:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 56 minutes":
                    hrNum = "23:56:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 57 minutes":
                    hrNum = "23:57:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 58 minutes":
                    hrNum = "23:58:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;

                case "Set alarm to 23 hours and 59 minutes":
                    hrNum = "23:59:00";
                    lblDesp.Text = hrNum;
                    horaDesp.Start();
                    break;


                // Parar Despertador
                case "Stop!":
                case "Stop alarm!":
                    playerMusica.Ctlcontrols.stop();
                    horaDesp.Stop();
                    break;

                // Zerar o timer de alarme
                case "Set timer alarm.":
                    lblDesp.Text = "__:__:__";
                    break;

                // Fechar o aplicativo
                case "Close":
                case "Exit":
                    Application.Exit();
                    break;
            }

        }
        
        private void horaDesp_Tick_1(object sender, EventArgs e)
        {
            if (lblAtual.Text == lblDesp.Text)
            {
                playerMusica.URL = somDespertador;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblAtual_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            playerMusica.Ctlcontrols.stop();
            Application.Exit();
        }

    }
}
