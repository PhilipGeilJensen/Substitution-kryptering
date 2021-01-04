using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution_kryptering
{
    class Encrypter
    {
        static List<string> alphabet = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "æ", "ø", "å" };

        /// <summary>
        /// Method to encrypt the provided string
        /// </summary>
        /// <param name="text"> text to encrypt</param>
        /// <returns>Encrypted text</returns>
        public static string Encrypt(string text)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                bool isUpper = Char.IsUpper(text[i]);
                char c = Char.ToLower(text[i]);
                if (alphabet.Contains(c.ToString()))
                {
                    int index;
                    int current = alphabet.IndexOf(c.ToString());
                    if (current + 10 >= alphabet.Count)
                    {
                        index = (current + 10) - alphabet.Count;
                    }
                    else
                    {
                        index = current + 10;
                    }
                    if (isUpper)
                    {
                        c = Char.ToUpper(char.Parse(alphabet[index]));
                    } else
                    {
                        c = char.Parse(alphabet[index]);
                    }
                    s.Append(c);
                } else
                {
                    s.Append(text[i].ToString());
                }
            }
            return s.ToString();
        }

        /// <summary>
        /// Method to decrypt an encrypted text
        /// </summary>
        /// <param name="text">The text to decrypt</param>
        /// <returns>The decrypted text</returns>
        public static string Decrypt(string text)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                bool isUpper = Char.IsUpper(text[i]);
                char c = Char.ToLower(text[i]);
                if (alphabet.Contains(c.ToString()))
                {
                    int index;
                    int current = alphabet.IndexOf(c.ToString());
                    if (current - 10 <= 0)
                    {
                        index = (current - 10) + alphabet.Count;
                    }
                    else
                    {
                        index = current - 10;
                    }
                    if (isUpper)
                    {
                        c = Char.ToUpper(char.Parse(alphabet[index]));
                    }
                    else
                    {
                        c = char.Parse(alphabet[index]);
                    }
                    s.Append(c);
                }
                else
                {
                    s.Append(text[i].ToString());
                }
            }
            return s.ToString();
        }
    }
}
