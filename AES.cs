using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Cryptooo {
    public class TwofishEncryption {
        public byte[] Encrypt(byte[] data, byte[] key) {
            TwofishEngine engine = new TwofishEngine();
            BufferedBlockCipher cipher = new BufferedBlockCipher(new CbcBlockCipher(engine));

            KeyParameter keyParam = new KeyParameter(key);
            ParametersWithIV parameters = new ParametersWithIV(keyParam, new byte[engine.GetBlockSize()]);

            cipher.Init(true, parameters);

            byte[] output = new byte[cipher.GetOutputSize(data.Length)];
            int bytesWritten = cipher.ProcessBytes(data, 0, data.Length, output, 0);
            cipher.DoFinal(output, bytesWritten);

            return output;
        }

        public static byte[] Decrypt(byte[] encryptedData, byte[] key) {
            TwofishEngine engine = new TwofishEngine();
            BufferedBlockCipher cipher = new BufferedBlockCipher(new CbcBlockCipher(engine));

            KeyParameter keyParam = new KeyParameter(key);
            ParametersWithIV parameters = new ParametersWithIV(keyParam, new byte[engine.GetBlockSize()]);

            cipher.Init(false, parameters);

            byte[] output = new byte[cipher.GetOutputSize(encryptedData.Length)];
            int bytesWritten = cipher.ProcessBytes(encryptedData, 0, encryptedData.Length, output, 0);
            cipher.DoFinal(output, bytesWritten);

            return output;
        }
    }
}
