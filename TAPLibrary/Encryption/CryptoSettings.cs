
namespace TAPLibrary
{
    internal class CryptoSettings
    {
        public string PassPhrase { get; set; }
        public string SaltValue { get; set; }
        public string HashAlgorithm { get; set; }
        public string InitVector { get; set; }
        public int PasswordIterations { get; set; }
        public int KeySize { get; set; }

    }
}
