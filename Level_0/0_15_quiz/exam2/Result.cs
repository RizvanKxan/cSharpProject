using System;
using System.Collections.Generic;

namespace exam2
{
    public class Result
    {
        [NonSerialized]
        public List<Dictionary<string, int>> listRes = new List<Dictionary<string, int>>();
        public Dictionary<string, List<Dictionary<string, int>>> allRes = new Dictionary<string, List<Dictionary<string, int>>>();
        /// <summary>
        /// Функция добавляющая информацию о результатах викторины в класс Result.
        /// </summary>
        /// <param name="loginUser">Логин пользователя.</param>
        /// <param name="countTrueAnswer">Количество правильных ответов.</param>
        /// <param name="type">Тип викторины(имя).</param>
        public void Add(string loginUser, short countTrueAnswer, string type)
        {
            var tempDictionary = new Dictionary<string, int>
            {
                { loginUser, countTrueAnswer }
            };

            if (allRes.ContainsKey(type))
            {
                allRes[type].Add(tempDictionary);
            }
            else
            {
                listRes.Add(tempDictionary);
                allRes.Add(type, listRes);
            }
            
        }
        public Result()
        {

        }
    }
}
