using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uniqueCharStr
{
    public static class ClassUnique
    {
        public static string extract(string original)
        {
            List<char> c1 = new List<char>();
            string unique = string.Empty;
            foreach (char letter in original.ToCharArray())
            {
                if (!c1.Contains(letter))
                {
                    c1.Add(letter);
                }
            }
            foreach (char letter in c1)
            {
                unique += letter;
            }
            return unique;
        }
    }
}
