using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Cryptooo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            System.Text.Encoding utf8Encoding = System.Text.Encoding.UTF8;
            AESResult_textBox.Font = new Font("Arial", 12);
        }

        private void MakeTwofishEncode(byte[] inputTextTwofish, byte[] key16) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            Twofish algorithmTwofish = new Twofish();
            algorithmTwofish.Init(true, key16);
            int addCount = (16 - inputTextTwofish.Length % 16) == 16 ? 0 : 16 - inputTextTwofish.Length % 16;
            byte[] z = inputTextTwofish.Concat(Enumerable.Repeat((byte)0, addCount).ToArray()).ToArray();
            byte[] output = new byte[z.Length];
            for (int i = 0; i < output.Length / 16; i++) {
                int bytesWritten = algorithmTwofish.ProcessBlock(z, i * 16, output, i * 16);
            }
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            timeTwofish_label.Text = $"{time.TotalMilliseconds} миллисекунд";

            string texts = "";
            foreach (byte b in output) {
                texts += b.ToString() + " ";
            }
            twofishResultBytes_textBox.Text = texts;

            string texts2 = "";
            foreach (byte b in output) {
                texts2 += (char)b;
            }
            twofishResult_textBox.Text = texts2;


        }

        private void MakeAESEncode(byte[] inputText, byte[] key) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AES aes = new AES();
            byte[] output = aes.Encode(inputText, key);
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            timeAES_label.Text = $"{time.TotalMilliseconds} миллисекунд";

            string texts = "";

            foreach (byte b in output) {
                texts += b.ToString() + " ";
            }
            AESResultBytes_textBox.Text = texts;

            string texts2 = "";
            foreach (byte b in output) {
                texts2 += (char)b;
            }
            AESResult_textBox.Text = texts2;

        }

        private void MakeTwofishDecode(byte[] inputTextTwofish, byte[] key16) {
            Twofish algorithmTwofish = new Twofish();
            algorithmTwofish.Init(false, key16);
            int addCount = (16 - inputTextTwofish.Length % 16) == 16 ? 0 : 16 - inputTextTwofish.Length % 16;
            byte[] z = inputTextTwofish.Concat(Enumerable.Repeat((byte)0, addCount).ToArray()).ToArray();
            byte[] output = new byte[z.Length];
            for (int i = 0; i < output.Length / 16; i++) {
                int bytesWritten = algorithmTwofish.ProcessBlock(z, i * 16, output, i * 16);
            }

            string texts = "";
            foreach (byte b in output) {
                texts += b.ToString() + " ";
            }
            twofishResultBytes_textBox.Text = texts;

            string texts2 = "";
            foreach (byte b in output) {
                texts2 += (char)b;
            }
            twofishResult_textBox.Text = texts2;


        }

        private void MakeAESDecode(byte[] inputText, byte[] key) {
            AES aes = new AES();
            byte[] output = aes.Decode(inputText, key);
            string texts = "";

            foreach (byte b in output) {
                texts += b.ToString() + " ";
            }
            AESResultBytes_textBox.Text = texts;

            string texts2 = "";
            foreach (byte b in output) {
                texts2 += (char)b;
            }
            AESResult_textBox.Text = texts2;

        }

        private void crypt_button_Click(object sender, EventArgs e) {
            byte[] inputTextTwofish = Encoding.UTF8.GetBytes(twofish_textBox.Text.ToString());
            byte[] inputTextAES = Encoding.UTF8.GetBytes(AES_textBox.Text.ToString());


            byte[] key = Encoding.UTF8.GetBytes(key_textBox.Text.ToString());
            //string keyAES = key_textBox.Text.ToString();

            byte[] key16 = new byte[16];

            if (key.Length < 16) {
                key16 = key.Concat(Enumerable.Repeat((byte)0, 16 - key.Length % 16).ToArray()).ToArray();
            } else {
                key16 = key;
            }
            MakeTwofishEncode(inputTextTwofish, key16);

            MakeAESEncode(inputTextAES, key16);


        }

        private void decrypt_button_Click(object sender, EventArgs e) {
            string[] textTwofish = twofishBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputTextTwofish = textTwofish.Select(byte.Parse).ToArray();

            string[] textAES = AESBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputTextAES = textAES.Select(byte.Parse).ToArray();


            byte[] key = Encoding.UTF8.GetBytes(key_textBox.Text.ToString());
            //string keyAES = key_textBox.Text.ToString();

            byte[] key16 = new byte[16];

            if (key.Length < 16) {
                key16 = key.Concat(Enumerable.Repeat((byte)0, 16 - key.Length % 16).ToArray()).ToArray();
            } else {
                key16 = key;
            }
            MakeTwofishDecode(inputTextTwofish, key16);
            MakeAESDecode(inputTextAES, key16);
        }


        private void AESBytes_textBox_Leave(object sender, EventArgs e) {
            string[] inputText = AESBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] input = inputText.Select(byte.Parse).ToArray();
            string texts = "";
            foreach (byte b in input) {
                texts += (char)b;
            }
            AES_textBox.Text = texts;
        }

        private void AES_textBox_Leave(object sender, EventArgs e) {
            byte[] inputText = Encoding.UTF8.GetBytes(AES_textBox.Text.ToString());
            string texts = "";
            foreach (byte b in inputText) {
                texts += b.ToString() + " ";
            }
            AESBytes_textBox.Text = texts;
        }

        private void twofishBytes_textBox_Leave(object sender, EventArgs e) {
            string[] inputText = twofishBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] input = inputText.Select(byte.Parse).ToArray();
            string texts = "";
            foreach (byte b in input) {
                texts += (char)b;
            }
            twofish_textBox.Text = texts;
        }


        private void twofish_textBox_Leave(object sender, EventArgs e) {
            byte[] inputText = Encoding.UTF8.GetBytes(twofish_textBox.Text.ToString());
            string texts = "";
            foreach (byte b in inputText) {
                texts += b.ToString() + " ";
            }
            twofishBytes_textBox.Text = texts;
        }

        private void saveInputToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            string key = key_textBox.Text.ToString();

            string[] inputTextTwofish = twofishBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputTwofish = inputTextTwofish.Select(byte.Parse).ToArray();

            string[] inputTextAES = AESBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputAES = inputTextAES.Select(byte.Parse).ToArray();



            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(key);
                    
                    foreach (byte b in inputAES) {
                        sr.Write(b.ToString() + " ");
                    }
                    sr.WriteLine();

                    foreach (byte b in inputTwofish) {
                        sr.Write(b.ToString() + " ");
                    }
                }
                MessageBox.Show("Исходные данные успешно сохранены!", "Успех!");
            } else {
                MessageBox.Show("Исходные данные не были сохранены(!", "Ошибка!");
            }
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            string[] inputTextTwofish = twofishResultBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputTwofish = inputTextTwofish.Select(byte.Parse).ToArray();

            string[] inputTextAES = AESResultBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputAES = inputTextAES.Select(byte.Parse).ToArray();



            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    foreach (byte b in inputAES) {
                        sr.Write(b.ToString() + " ");
                    }
                    sr.WriteLine();

                    foreach (byte b in inputTwofish) {
                        sr.Write(b.ToString() + " ");
                    }
                }
                MessageBox.Show("Исходные данные успешно сохранены!", "Успех!");
            } else {
                MessageBox.Show("Исходные данные не были сохранены(!", "Ошибка!");
            }
        }

        private void downloadInputToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) {
                MessageBox.Show("Файл не был прочтен!", "Ошибка!");
                return;
            }

            using (StreamReader streamReader = new StreamReader(openFileDialog.FileName)) {
                key_textBox.Text = streamReader.ReadLine();
                AESBytes_textBox.Text = streamReader.ReadLine();
                twofishBytes_textBox.Text = streamReader.ReadLine();

            }
            string[] inputText = AESBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] input = inputText.Select(byte.Parse).ToArray();
            string texts = "";
            foreach (byte b in input) {
                texts += (char)b;
            }
            AES_textBox.Text = texts;

            string[] inputText2 = twofishBytes_textBox.Text.ToString().Trim().Split(' ');
            byte[] input2 = inputText2.Select(byte.Parse).ToArray();
            string texts2 = "";
            foreach (byte b in input2) {
                texts2 += (char)b;
            }
            twofish_textBox.Text = texts2;
        }

        private double MakeTwofishForCharts(byte[] inputTextTwofish, byte[] key16) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Twofish algorithmTwofish = new Twofish();
            algorithmTwofish.Init(true, key16);
            int addCount = (16 - inputTextTwofish.Length % 16) == 16 ? 0 : 16 - inputTextTwofish.Length % 16;
            byte[] z = inputTextTwofish.Concat(Enumerable.Repeat((byte)0, addCount).ToArray()).ToArray();
            byte[] output = new byte[z.Length];
            for (int i = 0; i < output.Length / 16; i++) {
                int bytesWritten = algorithmTwofish.ProcessBlock(z, i * 16, output, i * 16);
            }
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            return time.TotalMilliseconds;

        }

        private double MakeAESForCharts(byte[] inputText, byte[] key) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AES aes = new AES();
            byte[] output = aes.Encode(inputText, key);
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            return time.TotalMilliseconds;

        }

        private byte[] MakeRandom(int n) {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Символы, из которых будет генерироваться текст 
            char[] text = new char[n * 16]; // Длина генерируемого текста 

            for (int i = 0; i < n * 16; i++) {
                text[i] = chars[random.Next(chars.Length)];
            }
            //string res = new string(text);
            byte[] input = Encoding.UTF8.GetBytes(new string(text));
            return input;
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e) {
            byte[] key = MakeRandom(1);
            byte[] text;
            List<double> timeFish = new List<double>();
            List<double> timeAES = new List<double>();

            double iterationFish = 0;
            double iterationAES = 0;

            //string randomText = new string(text);

            for (int i = 1; i < 1001; i+=10) {
                text = MakeRandom(i);
                iterationFish = 0;
                iterationAES = 0;
                for (int j = 0; j < 10; j++) {
                    iterationFish += MakeTwofishForCharts(text, key);
                    iterationAES += MakeAESForCharts(text, key);

                }
                timeFish.Add(Math.Round(iterationFish / 10, 3));
                timeAES.Add(Math.Round(iterationAES / 10, 3));
            }

            ChartsForm chartsForm = new ChartsForm(timeAES, timeFish);
            chartsForm.ShowDialog();
        }
    }
}
