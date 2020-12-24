using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam1_dictionary
{
    public class Word
    {
        public List<string> values = new List<string>();
        public Word(string str)
        {
            values.Add(str);
        }

        public Word(List<string> str1)
        {
            foreach (var item in str1)
            {
                values.Add(item);
            }
        }

        public Word()
        {

        }

    }
}
