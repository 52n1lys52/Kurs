using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public class ClassEncode
    {
        char[] characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        int N = 26;
        public string Encode(string input, string key)
        {
            input = input.ToLower();
            key = key.ToLower();

            string result = "";
            int keywordIndex = 0;

            foreach (char symbol in input)
            {
                if (Char.IsLetter(symbol))
                {
                    int c = (Array.IndexOf(characters, symbol) +
                             Array.IndexOf(characters, key[keywordIndex])) % N;

                    result += characters[c];
                    keywordIndex++;

                    if (keywordIndex == key.Length)
                        keywordIndex = 0;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }
        public string Decode(string input, string key)
        {
            input = input.ToLower();
            key = key.ToLower();

            string characters = "abcdefghijklmnopqrstuvwxyz";

            string result = "";

            int keywordIndex = 0;

            foreach (char symbol in input)
            {
                if (Char.IsLetter(symbol))
                {
                    int p = (characters.IndexOf(symbol) + N -
                        characters.IndexOf(key[keywordIndex])) % N;

                    result += characters[p];
                    keywordIndex++;

                    if (keywordIndex == key.Length)
                        keywordIndex = 0;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }
    }
}

