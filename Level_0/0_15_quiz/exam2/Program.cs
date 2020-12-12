using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace exam2
{
    class Program
    {

        static void Main()
        {
            string json;
            string pathUserInfo = @"UserInfo.json";
            string pathCsharpTest = @"CsharpTest.json";
            string pathAllResult = @"AllResult.json";
            string pathResultatCsharp = @"ResultatCsharp.json";
            string activeUserLogin = "";

            Result resultatCsharp = new Result();
            if (File.Exists(pathResultatCsharp))
            {
                json = File.ReadAllText(pathResultatCsharp);
                resultatCsharp = JsonConvert.DeserializeObject<Result>(json);
            }

            Result allResult = new Result();
            if (File.Exists(pathAllResult))
            {
                json = File.ReadAllText(pathAllResult);
                allResult = JsonConvert.DeserializeObject<Result>(json);
            }

            Dictionary<string, PersonData> users = new Dictionary<string, PersonData>();
            if (File.Exists(pathUserInfo))
            {
                json = File.ReadAllText(pathUserInfo);
                users = JsonConvert.DeserializeObject<Dictionary<string, PersonData>>(json);
            }

            Dictionary<int, QuestionAnswer> cSharp = new Dictionary<int, QuestionAnswer>();
            if (File.Exists(pathCsharpTest))
            {
                json = File.ReadAllText(pathCsharpTest);
                cSharp = JsonConvert.DeserializeObject<Dictionary<int, QuestionAnswer>>(json);
            }

            short choiceMainMenu;
            do
            {
                Console.Clear();
                Print.Autorization();
                if (!short.TryParse(Console.ReadLine(), out choiceMainMenu) || choiceMainMenu <= 0 || choiceMainMenu > 2)
                {
                    Console.Clear();
                    Print.DataIsIncorrect();
                    Console.ReadKey();
                }
                else if (choiceMainMenu == 2)
                {
                    break;
                }
                else
                {
                    while (true)
                    {
                        var tempUser = autorization();
                        string dateOfBirth;
                        bool checkUserCorrect = true;
                        foreach (KeyValuePair<string, PersonData> keyValue in tempUser)
                        {


                            if (users.ContainsKey(keyValue.Key))
                            {
                                if (keyValue.Value.password == users[keyValue.Key].password)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"WELCOME, {keyValue.Key}!");
                                    Console.ReadKey();
                                }
                                    
                                else
                                {
                                    Console.WriteLine("Пароль не правильный!!!");
                                    checkUserCorrect = false;
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                Console.Write("Введите свой день рождения: ");
                                dateOfBirth = Console.ReadLine();
                                users.Add(keyValue.Key, new PersonData(keyValue.Value.password, dateOfBirth));
                                Console.WriteLine("Пользователь успешно зарегестрирован!");
                                Console.ReadKey();
                            }
                            activeUserLogin = keyValue.Key;
                        }
                        short choiceQuizMenu = 0;
                        if (!checkUserCorrect) { break; }
                        do
                        {

                            Console.Clear();
                            Print.QuizMenu();
                            if (!short.TryParse(Console.ReadLine(), out choiceQuizMenu) || choiceQuizMenu <= 0 || choiceQuizMenu > 5)
                            {
                                Console.Clear();
                                Print.DataIsIncorrect();
                                Console.ReadKey();
                            }
                            else
                            {
                                switch (choiceQuizMenu)
                                {
                                    case 1: // Начать новую викторину. 
                                        short choiceTheme = 0;
                                        do
                                        {
                                            Console.Clear();
                                            Print.ThemeSelection();
                                            if (!short.TryParse(Console.ReadLine(), out choiceTheme) || choiceTheme <= 0 || choiceTheme > 6)
                                            {
                                                Print.DataIsIncorrect();
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                switch (choiceTheme)
                                                {
                                                    case 1:
                                                        short countTrueAnswer = 0;
                                                        Dictionary<int, string> tempAnswers = new Dictionary<int, string>();
                                                        foreach (var it in cSharp)
                                                        {
                                                            Console.Clear();
                                                            int count = 1;
                                                            int choiceAnswer;
                                                            string checkAnswer;
                                                            Console.WriteLine("Вопрос: " + it.Value.Question);
                                                            Console.WriteLine("Варианты ответа: ");
                                                            foreach (var i in it.Value.answers)
                                                            {
                                                                Console.WriteLine(count + " " + i.Key);
                                                                tempAnswers.Add(count, i.Key);
                                                                count++;
                                                            }
                                                            Console.Write("Выберите номер правильного ответа: ");
                                                            if (!int.TryParse(Console.ReadLine(), out choiceAnswer) || choiceAnswer <= 0 || choiceAnswer > 4)
                                                            {
                                                                Console.WriteLine("Данные не корректны.");
                                                                Console.ReadKey();
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                checkAnswer = tempAnswers[choiceAnswer];
                                                                foreach (var i in it.Value.answers)
                                                                {
                                                                    if (i.Key == checkAnswer)
                                                                    {
                                                                        if (i.Value == true)
                                                                        {
                                                                            Console.WriteLine("Ваш ответ правильный.");
                                                                            countTrueAnswer++;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Ваш ответ не правильный.");
                                                                        }
                                                                    }
                                                                    else if (i.Value == true)
                                                                    {
                                                                        Console.WriteLine("Правильный ответ: " + i.Key);
                                                                    }
                                                                }
                                                            }
                                                            tempAnswers.Clear();
                                                            Console.ReadKey();
                                                        }
                                                        resultatCsharp.Add(activeUserLogin, countTrueAnswer);
                                                        allResult.Add(activeUserLogin, countTrueAnswer, "C#");
                                                        Console.Clear();
                                                        Console.WriteLine("Результаты:");
                                                        Console.WriteLine("Всего правильных ответов: " + countTrueAnswer + " из " + cSharp.Count());
                                                        Console.ReadKey();
                                                        break;
                                                    case 2:


                                                        break;
                                                    case 3:
                                                        break;
                                                    case 4:
                                                        break;
                                                    case 5:
                                                        break;

                                                    default:
                                                        break;
                                                }
                                            }
                                        } while (choiceTheme != 6);
                                        break;
                                    case 2: // Посмотреть ТОП-10 по викторинам.
                                        Console.Clear();
                                        short choiceResult;
                                        Print.TypeResult();
                                        if (!short.TryParse(Console.ReadLine(), out choiceResult) || choiceResult <= 0 || choiceResult > 2)
                                        {
                                            Console.Clear();
                                            Print.DataIsIncorrect();
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            switch (choiceResult)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    if (resultatCsharp.res.Count > 0)
                                                    {
                                                        Console.WriteLine("***************************************");
                                                        Console.WriteLine("|_______________TOP 10________________|");
                                                        Console.WriteLine("|_____________________________________|");
                                                        Console.WriteLine("| Пользователь|     Правильных ответов|");
                                                        Console.WriteLine("|_____________|_______________________|");
                                                        int j = 20;
                                                        int koll = 0;
                                                        do
                                                        {
                                                            foreach (var res in resultatCsharp.res)
                                                            {
                                                                foreach (var r in res.Value)
                                                                {
                                                                    if (koll >= 10) break;
                                                                    if (r.Value == j)
                                                                    {
                                                                        Console.WriteLine("|{0,13}| {1,22}|", r.Key, r.Value);
                                                                        koll++;
                                                                    }
                                                                }
                                                            }
                                                            j--;
                                                        } while (j >= 0);
                                                        Console.WriteLine("|_____________|_______________________|");
                                                        Console.WriteLine("***************************************");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Результатов пока нет!");
                                                    }
                                                    break;
                                            }
                                        }
                                        Console.ReadKey();
                                        break;
                                    case 3: // Посмотреть результаты прошлых викторин.
                                        Console.Clear();
                                        //работает не совсем корректно, пользователь мог не отвечать ещё на тест по c#, но resultatCsharp.res.Count может быть больше нуля
                                        if (resultatCsharp.res.Count > 0)
                                        {
                                            Console.WriteLine("*****************************************");
                                            Console.WriteLine("|            Результаты                 |");
                                            Console.WriteLine("|_______________________________________|");
                                            Console.WriteLine("|     Тема     |   Правильных ответов   |");
                                            Console.WriteLine("|______________|________________________|");

                                            foreach (var res in allResult.res)
                                            {
                                                foreach (var line in res.Value)
                                                {
                                                    if(line.Key == activeUserLogin)
                                                    {
                                                        Console.WriteLine("|{0,14}| {1,23}|", allResult.type, line.Value);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("|______________|________________________|");
                                            Console.WriteLine("*****************************************");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Результатов пока нет!");
                                        }
                                        Console.ReadKey();
                                        break;
                                    case 4: // Изменить настройки.
                                        short choiceSettingMenu = 0;
                                        do
                                        {
                                            Console.Clear();
                                            Print.SettingMenu();

                                            if (!short.TryParse(Console.ReadLine(), out choiceSettingMenu) || choiceSettingMenu <= 0 || choiceSettingMenu > 4)
                                            {
                                                Print.DataIsIncorrect();
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                switch (choiceSettingMenu)
                                                {
                                                    case 1: // 1. Изменить пароль.
                                                        while (true)
                                                        {
                                                            string oldPassword, newPassword;
                                                            Console.Write("Введите старый пароль: ");
                                                            oldPassword = Console.ReadLine();
                                                            Console.Write("Введите новый пароль: ");
                                                            newPassword = Console.ReadLine();

                                                            if (oldPassword == newPassword)
                                                            {
                                                                Console.WriteLine("Новый пароль должен отличаться от старого пароля.");
                                                                Console.ReadKey();
                                                            }
                                                            else if (oldPassword.Contains(" ") || newPassword.Contains(" "))
                                                            {
                                                                Console.WriteLine("Пароль не должен содержать в себе пробелы.");
                                                                Console.ReadKey();
                                                            }
                                                            else
                                                            {
                                                                if (users[activeUserLogin].password == oldPassword)
                                                                {
                                                                    users[activeUserLogin].password = newPassword;
                                                                    Console.WriteLine("Пароль изменён.");
                                                                    Console.ReadKey();
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Старый пароль введён не верно.");
                                                                }
                                                            }

                                                        }

                                                        break;
                                                    case 2: // 2. Изменить дату рождения.
                                                        while (true)
                                                        {
                                                            string newDateOfBirth;
                                                            Console.Write("Введите новую дату рождения: ");
                                                            newDateOfBirth = Console.ReadLine();
                                                            if (newDateOfBirth.Trim() == "")
                                                            {
                                                                Console.WriteLine("Дата не должна быть пустой.");
                                                            }
                                                            else
                                                            {
                                                                users[activeUserLogin].dateOfBirth = newDateOfBirth;
                                                                Console.WriteLine("Дата рождения изменена.");
                                                                Console.ReadKey();
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("*************************************************");
                                                        Console.WriteLine("Логин: " + activeUserLogin);
                                                        Console.WriteLine("Пароль: " + users[activeUserLogin].password);
                                                        Console.WriteLine("Дата рождения: " + users[activeUserLogin].dateOfBirth);
                                                        Console.WriteLine("*************************************************");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                            }
                                        } while (choiceSettingMenu != 4);
                                        break;
                                    case 5: // 5. Выход.
                                        break;
                                }

                            }
                        } while (choiceQuizMenu != 5);
                        break;
                    }
                }
            } while (choiceMainMenu != 2);

            string end = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(pathUserInfo, end);
            end = JsonConvert.SerializeObject(cSharp, Formatting.Indented);
            File.WriteAllText(pathCsharpTest, end);
            end = JsonConvert.SerializeObject(resultatCsharp, Formatting.Indented);
            File.WriteAllText(pathResultatCsharp, end);
            end = JsonConvert.SerializeObject(allResult, Formatting.Indented);
            File.WriteAllText(pathAllResult, end);
        }
        public static Dictionary<string, PersonData> autorization()
        {
            string login, password;
            var tempUserrr = new Dictionary<string, PersonData>();

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Логин не может быть больше 13 символов!");
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                if (login.Length > 13)
                {
                    Console.Clear();
                    Console.WriteLine("Длина логина больше 13 символов!");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                if (login.Contains(" ") || password.Contains(" ") || login == password)
                {
                    Print.LoginOrPasswordInCorrect();
                    Console.ReadKey();
                    continue;
                }
                else
                {
                   tempUserrr.Add(login, new PersonData(password));
                   break;
                }
            }

            return tempUserrr;
        }


    }
         
    public static class Print
    {
        public static void Autorization()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("Меню входа.                                       |");
            Console.WriteLine("1. Войти в систему или зарегестрироваться.        |");
            Console.WriteLine("2. Выйти из программы.                            |");
            Console.WriteLine("**************************************************");
            Console.Write("Ваш выбор: ");
        }

        public static void LoginOrPasswordInCorrect()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Логин и пароль не должны содержать в себе пробелы.  |");
            Console.WriteLine("Логин и пароль не могут быть одинаковыми.           |");
            Console.WriteLine("Для продолжения нажмите любую клавишу...            |");
            Console.WriteLine("*****************************************************");
        }

        public static void QuizMenu()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("Меню Викторины:                                 |");
            Console.WriteLine("1. Начать новую викторину.                      |");
            Console.WriteLine("2. Посмотреть ТОП-10 по викторинам.             |");
            Console.WriteLine("3. Посмотреть результаты прошлых викторин.      |");
            Console.WriteLine("4. Изменить настройки.                          |");
            Console.WriteLine("5. Выход.                                       |");
            Console.WriteLine("*************************************************");
            Console.Write("Ваш выбор: ");
        }

        public static void DataIsIncorrect()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Данные не корректны, повторите ввод.      |");
            Console.WriteLine("Для выхода нажмите любую клавишу...       |");
            Console.WriteLine("*******************************************");
        }

        public static void SettingMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Настройки профиля:                        |");
            Console.WriteLine("1. Изменить пароль.                       |");
            Console.WriteLine("2. Изменить дату рождения.                |");
            Console.WriteLine("3. Показать данные пользователя.         |");
            Console.WriteLine("4. Выход.                                 |");
            Console.WriteLine("*******************************************");
            Console.Write("Ваш выбор: ");
        }
        public static void ThemeSelection()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*Выберите тему викторины:                 |");
            Console.WriteLine("1. С#.                                    |");
            Console.WriteLine("2. Python.                                |");
            Console.WriteLine("3. HTML.                                  |");
            Console.WriteLine("4. CSS.                                   |");
            Console.WriteLine("5. Тестирование ПО.                       |");
            Console.WriteLine("6. Выход.                                 |");
            Console.WriteLine("*******************************************");
            Console.Write("Ваш выбор: ");
        }

        public static void TypeResult()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*Выберите викторину:                      |");
            Console.WriteLine("1. С#.                                    |");
            Console.WriteLine("2. Python.                                |");
            Console.WriteLine("*******************************************");
            Console.Write("Ваш выбор: ");
        }
    }

    public class PersonData
    {
        public string password { get; set; }
        public string dateOfBirth { get; set; }

        public PersonData(string password, string dateOfBirth)
        {
            this.password = password;
            this.dateOfBirth = dateOfBirth;
        }

        public PersonData(string password)
        {
            this.password = password;
            dateOfBirth = "";
        }

        public PersonData()
        {

        }
    }

    public class QuestionAnswer
    {
        public string Question;
        public Dictionary<string, bool> answers;

        public QuestionAnswer(string question, Dictionary<string, bool> answers)
        {
            Question = question;
            this.answers = answers;
        }
    }

    public class Result
    {
        public int counter = 0;
        public string type;
        public  Dictionary<int, Dictionary<string, int>> res = new Dictionary<int, Dictionary<string, int>>();
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




