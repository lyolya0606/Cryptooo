using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptooo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            System.Text.Encoding utf8Encoding = System.Text.Encoding.UTF8;
            AESResult_textBox.Text = ((char)225).ToString();
            AESResult_textBox.Font = new Font("Arial", 12);
        }

        private void crypt_button_Click(object sender, EventArgs e) {
            byte[] inputText = Encoding.UTF8.GetBytes(AES_textBox.Text.ToString());
            byte[] key = Encoding.UTF8.GetBytes(key_textBox.Text.ToString());

            byte[] key16 = new byte[16];

            if (key.Length < 16) {
                key16 = key.Concat(Enumerable.Repeat((byte)0, 16 - key.Length % 16).ToArray()).ToArray();
            } else {
                key16 = key;
            }

            Twofish algorithmTwofish = new Twofish();
            algorithmTwofish.Init(true, key16);
            byte[] z = inputText.Concat(Enumerable.Repeat((byte)0, 16 - inputText.Length % 16).ToArray()).ToArray();
            byte[] output = new byte[z.Length];
            for (int i = 0; i < output.Length / 16; i++) {
                int bytesWritten = algorithmTwofish.ProcessBlock(z, i * 16, output, i * 16);
            }

            string texts = "";
            foreach (byte b in output) {
                texts += b.ToString() + " ";
            }
            twofishResult_textBox.Text = texts;
        }

        private void decrypt_button_Click(object sender, EventArgs e) {
            //byte[] inputText = Encoding.UTF8.GetBytes(AES_textBox.Text.ToString());

            string[] numberStrings = AES_textBox.Text.ToString().Trim().Split(' ');
            byte[] inputText = numberStrings.Select(byte.Parse).ToArray();

            byte[] key = Encoding.UTF8.GetBytes(key_textBox.Text.ToString());

            Twofish algorithmTwofish = new Twofish();
            algorithmTwofish.Init(false, key);

            byte[] output = new byte[inputText.Length];
            for (int i = 0; i < output.Length / 16; i++) {
                int bytesWritten = algorithmTwofish.ProcessBlock(inputText, i * 16, output, i * 16);
            }

            string texts = "";
            foreach (byte b in output) {
                texts += (char)b;
            }
            twofishResult_textBox.Text = texts;
        }
    }
}
