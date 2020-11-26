using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SpeechRecognitionEngine _recognizer = null;
        private string result, NoResult;
        private void _onSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "")
                result = result + e.Result.Text + "\n";
            txt_result.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Khởi tạo một instance
            _recognizer = new SpeechRecognitionEngine();
            // Sự kiện nhận dạng thành công
            _recognizer.SpeechRecognized += _onSpeechRecognized;
            // Sự kiện nhận dạng thất bại
            // Cài đặt thiết bị input là thiết bị mặc định
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RequestRecognizerUpdate();
            _recognizer.LoadGrammar(new DictationGrammar());
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Rate = 0;
            speechSynthesizer.SpeakAsync(txt_result.Text);
        }

        private void _onSpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            foreach (RecognizedPhrase r in e.Result.Alternates)
                NoResult += "\n" + r.Text;
            txt_NoResult.Text = NoResult;
        }


    }
}
