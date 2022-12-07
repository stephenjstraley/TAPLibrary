using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TAPLibrary
{
    public class Crypto
    {
        private static CryptoSettings _settings;

        //IMPORTANT: salt should not contain any of the characters that are in _cList!!!
        private static string[] _salt = new string[] { "ast", "ut", "e", "da", "inc" };
        private const string _cList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly char[] _cListArray = _cList.ToCharArray();

        static Crypto()
        {
            _settings = new TAPLibrary.CryptoSettings();
            _settings.PassPhrase = "p@$$w0rD";
            _settings.SaltValue = "s0lb";
            _settings.HashAlgorithm = "MD5";
            _settings.InitVector = "@Hd62mQq903CfhR2";
            _settings.PasswordIterations = 3;
            _settings.KeySize = 256;
        }

        public static long Base36Decode(string inputString)
        {
            long result = 0;
            var pow = 0;
            for (var i = inputString.Length - 1; i >= 0; i--)
            {
                var c = inputString[i];
                var pos = _cList.IndexOf(c);
                if (pos > -1)
                {
                    result += pos * (long)Math.Pow(_cList.Length, pow);
                }
                else
                {
                    return -1;
                }
                pow++;
            }
            return result;
        }

        public static string Base36Encode(long inputNumber)
        {
            var sb = new StringBuilder();
            do
            {
                sb.Append(_cListArray[inputNumber % (long)_cList.Length]);
                inputNumber /= (long)_cList.Length;
            } while (inputNumber != 0);
            return Reverse(sb.ToString());
        }

        private static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string AddSalt(string val)
        {
            string rtn = "";
            int cnt = 0;
            foreach (char letter in val.ToCharArray())
            {
                if (cnt == _salt.Length)
                {
                    cnt = 0;
                }
                rtn = $"{rtn}{letter}{_salt[cnt]}";
                cnt++;
            }
            return rtn;
        }

        private static string RemoveSalt(string val)
        {
            foreach (string saltElement in _salt)
            {
                val = val.Replace(saltElement, "");
            }
            return val;
        }

        public static string Encrypt(string val)
        {
            string rtnValue = "";
            try
            {
                rtnValue = Encrypt(val, _settings.PassPhrase, _settings.SaltValue, _settings.HashAlgorithm, _settings.PasswordIterations, _settings.InitVector, _settings.KeySize);
            }
            catch
            {
            }
            return rtnValue;
        }

        public static string Decrypt(string val)
        {
            string rtnValue = "";
            try
            {
                rtnValue = Decrypt(val, _settings.PassPhrase, _settings.SaltValue, _settings.HashAlgorithm, _settings.PasswordIterations, _settings.InitVector, _settings.KeySize);
            }
            catch
            {
            }
            return rtnValue;
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string hashedPassword = Convert.ToBase64String(hashBytes);
            return hashedPassword;
        }

        public static bool IsPasswordValid(string storedPassword, string checkedPassword)
        {
            bool rtn = false;
            try
            {
                byte[] hashBytes = Convert.FromBase64String(storedPassword);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(checkedPassword, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        throw new UnauthorizedAccessException();
                    }
                }
                rtn = true;
            }
            catch
            {
            }
            return rtn;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Hash(string input, string algorithm = "sha256")
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            return Hash(Encoding.UTF8.GetBytes(input), algorithm);
        }

        private static string Hash(byte[] input, string algorithm = "sha256")
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            using (var alg = HashAlgorithm.Create(algorithm))
            {
                if (alg != null)
                {
                    byte[] hashData = alg.ComputeHash(input);
                    return BinaryToHex(hashData);
                }
                else
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Algorithm: {0} is not supported.", algorithm));
                }
            }
        }

        private static string BinaryToHex(byte[] data)
        {
            char[] hex = new char[data.Length * 2];
            for (int iter = 0; iter < data.Length; iter++)
            {
                byte hexChar = ((byte)(data[iter] >> 4));
                hex[iter * 2] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
                hexChar = ((byte)(data[iter] & 0xF));
                hex[(iter * 2) + 1] = (char)(hexChar > 9 ? hexChar + 0x37 : hexChar + 0x30);
            }
            return new string(hex);
        }

        private static string Encrypt(string plainText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            var symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }

        private static string Decrypt(string cipherText, string passPhrase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            var password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            var symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }

    }
}
