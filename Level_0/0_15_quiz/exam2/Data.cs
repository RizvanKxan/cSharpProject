using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace exam2
{
    public static class Data
    {
        /// <summary>
        /// Используем для хранения json строки..
        /// </summary>
        public static string json;
        /// <summary>
        /// Файл в котором храним информацию о пользователях.
        /// </summary>
        public const string pathUserInfo = @"UserInfo.json";
        /// <summary>
        /// Файл с тестом С#.
        /// </summary>
        public const string pathCsharpTest = @"CsharpTest.json";
        /// <summary>
        /// Файл в котором храним результаты всех тестов.
        /// </summary>
        public const string pathAllResult = @"AllResult.json";
        /// <summary>
        /// Файл хранения результатов по тесту c#.
        /// </summary>
        public const string pathResultatCsharp = @"ResultatCsharp.json";
        /// <summary>
        /// Логин активного пользователя.
        /// </summary>
        public static string activeUserLogin = "";
        /// <summary>
        /// Класс хранения результатов по тесту C#.
        /// </summary>
        public static Result resultatCsharp = new Result();
        /// <summary>
        /// Класс хранения результатов всех тестов.
        /// </summary>
        public static Result allResult = new Result();
        /// <summary>
        /// Словарь в котором хранится информация о пользователях.
        /// </summary>
        public static Dictionary<string, PersonData> users = new Dictionary<string, PersonData>();
        /// <summary>
        /// Словарь в котором хранятся вопросы с ответами.
        /// </summary>
        public static Dictionary<int, QuestionAnswer> cSharp = new Dictionary<int, QuestionAnswer>();
        /// <summary>
        /// Словарь в котором хранятся вопросы с ответами из файла.
        /// </summary>
        public static Dictionary<int, QuestionAnswer> tempTest = new Dictionary<int, QuestionAnswer>();
        /// <summary>
        /// Функция инициализации всех компонентов. Если файлы с данными существуют, то десериализует в объекты программы. 
        /// </summary>
        public static void InitialInitialization()
        {
            if (File.Exists(pathResultatCsharp))
            {
                json = File.ReadAllText(pathResultatCsharp);
                resultatCsharp = JsonConvert.DeserializeObject<Result>(json);
            }

            
            if (File.Exists(pathAllResult))
            {
                json = File.ReadAllText(pathAllResult);
                allResult = JsonConvert.DeserializeObject<Result>(json);
            }
            
            if (File.Exists(pathUserInfo))
            {
                json = File.ReadAllText(pathUserInfo);
                users = JsonConvert.DeserializeObject<Dictionary<string, PersonData>>(json);
            }

            
            if (File.Exists(pathCsharpTest))
            {
                json = File.ReadAllText(pathCsharpTest);
                cSharp = JsonConvert.DeserializeObject<Dictionary<int, QuestionAnswer>>(json);
            }
        }
        /// <summary>
        /// Функция инициализации всех компонентов. Сериализует объекты программы в файлы json.
        /// </summary>
        public static void FinallInitialization()
        {
            json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(pathUserInfo, json);
            json = JsonConvert.SerializeObject(cSharp, Formatting.Indented);
            File.WriteAllText(pathCsharpTest, json);
            json = JsonConvert.SerializeObject(resultatCsharp, Formatting.Indented);
            File.WriteAllText(pathResultatCsharp, json);
            json = JsonConvert.SerializeObject(allResult, Formatting.Indented);
            File.WriteAllText(pathAllResult, json);
        }

    }
}
