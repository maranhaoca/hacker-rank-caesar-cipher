using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alphabetUpper = alphabetLower.ToUpper();
            
            List<char> cipher = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (alphabetLower.Contains(s[i]))
                {
                    int index = (alphabetLower.IndexOf(s[i]) + k) % 26;

                    cipher.Add(alphabetLower[index]);

                }
                else if (alphabetUpper.Contains(s[i]))
                {
                    int index = (alphabetUpper.IndexOf(s[i]) + k) % 26;

                    cipher.Add(alphabetUpper[index]);

                } else
                {
                    cipher.Add(s[i]);
                }
            }

            return String.Join("", cipher);
        }
    }
}