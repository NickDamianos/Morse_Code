using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Threading;

namespace morse_code
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        /*
        public SpeechRecognitionEngine eng;
        public Grammar g;
        public Thread RecThread;
        public Boolean RecognizerState = true;
        */
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Red;
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
            Console.Beep(800, 100);
        }

        private void sound(string morse) {
            int Hz = 800;
            int ms = 400;
            string tmp = morse[0].ToString();
            for (int i = 1; i < morse.Length; i++) {
                if (morse[i] == '-' && morse[i - 1] == '.') {
                    tmp += " ";
                }
                tmp += morse[i];
            }
            for (int i = 0; i < tmp.Length; i++) {
                if (tmp[i] == '.')
                {
                    Console.Beep();
                }
                else if (tmp[i] == '-')
                {
                    Console.Beep(Hz, ms);
                }
                else {
                    System.Threading.Thread.Sleep(25);
                    continue;
                }
                System.Threading.Thread.Sleep(5);
            }
            System.Threading.Thread.Sleep(250);
        }

        private string morse(char gg) {
            string mrs = "";
            if (gg == 'A' || gg == 'a')
            {
                mrs = ".-";
            }
            else if (gg == 'B' || gg == 'b')
            {
                mrs = "-...";
            }
            else if (gg == 'C' || gg == 'c')
            {
                mrs = "-.-.";
            }
            else if (gg == 'D' || gg == 'd')
            {
                mrs = "-..";
            }
            else if (gg == 'E' || gg == 'e')
            {
                mrs = ".";
            }
            else if (gg == 'F' || gg == 'f')
            {
                mrs = "..-.";
            }
            else if (gg == 'G' || gg == 'g')
            {
                mrs = "--.";
            }
            else if (gg == 'H' || gg == 'h')
            {
                mrs = "....";
            }
            else if (gg == 'I' || gg == 'i')
            {
                mrs = "..";
            }
            else if (gg == 'J' || gg == 'j')
            {
                mrs = ".---";
            }
            else if (gg == 'K' || gg == 'k')
            {
                mrs = "-.-";
            }
            else if (gg == 'L' || gg == 'l')
            {
                mrs = ".-..";
            }
            else if (gg == 'M' || gg == 'm')
            {
                mrs = "--";
            }
            else if (gg == 'N' || gg == 'n')
            {
                mrs = "-.";
            }
            else if (gg == 'O' || gg == 'o')
            {
                mrs = "---";
            }
            else if (gg == 'P' || gg == 'p')
            {
                mrs = ".--.";
            }
            else if (gg == 'Q' || gg == 'q')
            {
                mrs = "--.-";
            }
            else if (gg == 'R' || gg == 'r')
            {
                mrs = ".-.";
            }
            else if (gg == 'S' || gg == 's')
            {
                mrs = "...";
            }
            else if (gg == 'T' || gg == 't')
            {
                mrs = "-";
            }
            else if (gg == 'U' || gg == 'u')
            {
                mrs = "..-";
            }
            else if (gg == 'V' || gg == 'v')
            {
                mrs = "...-";
            }
            else if (gg == 'W' || gg == 'w')
            {
                mrs = ".--";
            }
            else if (gg == 'X' || gg == 'x')
            {
                mrs = "-..-";
            }
            else if (gg == 'Y' || gg == 'y')
            {
                mrs = "-.--";
            }
            else if (gg == 'Z' || gg == 'z')
            {
                mrs = "--..";
            }
            else if (gg == '0')
            {
                mrs = "-----";
            }
            else if (gg == '1')
            {
                mrs = ".----";
            }
            else if (gg == '2')
            {
                mrs = "..---";
            }
            else if (gg == '3')
            {
                mrs = "...--";
            }
            else if (gg == '4')
            {
                mrs = "....-";
            }
            else if (gg == '5')
            {
                mrs = ".....";
            }
            else if (gg == '6')
            {
                mrs = "-....";
            }
            else if (gg == '7')
            {
                mrs = "--...";
            }
            else if (gg == '8')
            {
                mrs = "---..";
            }
            else if (gg == '9')
            {
                mrs = "----.";
            }
            else if (gg == ' ') {
                mrs = " ";
            }

            return mrs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = "";
            for (int i = 0; i < textBox2.Text.Length; i++) {
                for (int j = i; textBox2.Text[i] != ' '; i++) {
                    tmp += textBox2.Text[i];
                }

                sound(tmp);
                tmp = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Console.Beep(800, 100);
            textBox2.Text = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox2.Text += morse(textBox1.Text[i]) + " ";
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        { /*
            GrammarBuilder build = new GrammarBuilder();
            build.AppendDictation();

            // eng = new SpeechRecognitionEngine();
            // eng.SetInputToDefaultAudioDevice();
            g = new Grammar(build);
            eng.SetInputToDefaultAudioDevice();

            eng.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(eng_rec);

            //Here will initialize the recognizer thread:

            RecognizerState = true;
            RecThread = new Thread(new ThreadStart(RecThreadFunction));
            RecThread.Start();*/
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           // RecognizerState = true;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //RecognizerState = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
