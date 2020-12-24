using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace exam1_dictionary
{
    public static class Data
    {
        public static Dictionary<string, Word> rusEng = new Dictionary<string, Word> { { "null", null } };
        public static Dictionary<string, Word> engRus = new Dictionary<string, Word> { { "null", null } };


        public const string pathRusEng = @"rusEng.json";
        public const string pathEngRus = @"engRus.json";
        /// <summary>
        /// Переменная хранящая выбор типа словаря (1 - rusEng or 2 - engRus).
        /// </summary>
        public static short choiceTypeDictionary = 0;
        public static string json;

        public static void InitialInitialization()
        {
            if (choiceTypeDictionary == 1)
            {
                Print.rusTypeDictionary();
                if (File.Exists(pathRusEng))
                {
                    json = File.ReadAllText(pathRusEng);
                    rusEng = JsonConvert.DeserializeObject<Dictionary<string, Word>>(json);

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Словарь уже существует.                     |");
                    Console.WriteLine("Для выхода нажмите любую клавишу...         |");
                    Console.WriteLine("*********************************************");
                    Console.ReadKey();

                }
                else
                {
                    json = JsonConvert.SerializeObject(rusEng, Formatting.Indented);
                    File.WriteAllText(pathRusEng, json);

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Словарь создан.                             |");
                    Console.WriteLine("Для выхода нажмите любую клавишу...         |");
                    Console.WriteLine("*********************************************");
                    Console.ReadKey();
                }
            }
            else
            {
                Print.engTypeDictionary();
                if (File.Exists(pathEngRus))
                {
                    json = File.ReadAllText(pathEngRus);
                    engRus = JsonConvert.DeserializeObject<Dictionary<string, Word>>(json);

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Словарь уже существует.                     |");
                    Console.WriteLine("Для выхода нажмите любую клавишу...         |");
                    Console.WriteLine("*********************************************");
                    Console.ReadKey();

                }
                else
                {
                    json = JsonConvert.SerializeObject(engRus, Formatting.Indented);
                    File.WriteAllText(pathEngRus, json);

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Словарь создан.                             |");
                    Console.WriteLine("Для выхода нажмите любую клавишу...         |");
                    Console.WriteLine("*********************************************");
                    Console.ReadKey();
                }
            }
        }
    }
}
