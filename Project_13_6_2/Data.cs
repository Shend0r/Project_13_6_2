using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_13_6_2
{
    internal class Data
    {
        public string[] ClearWords(string path)
        {
            string data = File.ReadAllText(path);

            var cleared_punctuation_data = new string(data.Where(c => !char.IsPunctuation(c)).ToArray());

            char[] delimiters = new char[] { ' ', '\r', '\n' };

            return cleared_punctuation_data.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
