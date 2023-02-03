using System;
using System.Security.Cryptography;
using System.Text;

namespace SASTTest
{
    class WeakHash
    {
        static void Main(string[] args)
        {
            string input = "SAST_Test";
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            SHA1 sha1 = SHA1.Create();
            byte[] hash = sha1.ComputeHash(inputBytes);
            Console.WriteLine($"Hash: {BitConverter.ToString(hash)}");
        }
    }
}
