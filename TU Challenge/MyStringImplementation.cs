using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static string MixString(string a, string b)
        {
            int length = Math.Max(a.Length, b.Length);
            StringBuilder mixedString = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (i < a.Length)
                    mixedString.Append(a[i]);
                if (i < b.Length)
                    mixedString.Append(b[i]);
            }
            return mixedString.ToString();
        }

        public static string Reverse(string a)
            
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            a = new string(charArray);
            return a;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
               if (a[i] >= 65 && a[i] <= 90) { a[i] += 32; }
            }
            return a;
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                char currentChar = a[i];
                if (!(currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'A' || currentChar == 'E' || currentChar == 'I' || currentChar == 'O' || currentChar == 'U'))
                {
                    a = a.Remove(i, 1);
                    i--;
                }
            }
            return a;
        }
    }
}
