using System;

namespace Substitution_kryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            string enc = Encrypter.Encrypt("Vi kom, Vi så, Vi sejrede");
            string dec = Encrypter.Decrypt(enc);
            Console.WriteLine("Enkrypteret: {0}", enc);
            Console.WriteLine("Dekrypteret: {0}", dec);
        }
    }
}
