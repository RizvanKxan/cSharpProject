using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam2
{
    public class Result
    {
        public int counter = 0;
        public string type;
        public Dictionary<int, Dictionary<string, int>> res = new Dictionary<int, Dictionary<string, int>>();
        public void Add(string loginUser, short countTrueAnswer)
        {
            var tempDictionary = new Dictionary<string, int>
            {
                { loginUser, countTrueAnswer }
            };
            res.Add(counter, tempDictionary);
            counter++;
        }
        public void Add(string loginUser, short countTrueAnswer, string type)
        {
            var tempDictionary = new Dictionary<string, int>
            {
                { loginUser, countTrueAnswer }
            };
            this.type = type;
            res.Add(counter, tempDictionary);
            counter++;
        }
        public Result()
        {

        }
    }
}
