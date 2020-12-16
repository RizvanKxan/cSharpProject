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

            Data.InitialInitialization();


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


                            if (Data.users.ContainsKey(keyValue.Key))
                            {
                                if (keyValue.Value.password == Data.users[keyValue.Key].password)
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
                                Data.users.Add(keyValue.Key, new PersonData(keyValue.Value.password, dateOfBirth));
                                Console.WriteLine("Пользователь успешно зарегестрирован!");
                                Console.ReadKey();
                            }
                            Data.activeUserLogin = keyValue.Key;
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
                                            if (!short.TryParse(Console.ReadLine(), out choiceTheme) || choiceTheme <= 0 || choiceTheme > 3)
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
                                                        foreach (var it in Data.cSharp)
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
                                                        //Data.resultatCsharp.Add(Data.activeUserLogin, countTrueAnswer);
                                                        Data.allResult.Add(Data.activeUserLogin, countTrueAnswer, "C#");
                                                        Console.Clear();
                                                        Console.WriteLine("Результаты:");
                                                        Console.WriteLine("Всего правильных ответов: " + countTrueAnswer + " из " + Data.cSharp.Count());
                                                        Console.ReadKey();
                                                        break;
                                                    case 2:
                                                        countTrueAnswer = 0;
                                                        string name;
                                                        string json;
                                                        tempAnswers = new Dictionary<int, string>();
                                                        Console.Write("Введите название файла с тестом: ");
                                                        name = Console.ReadLine();
                                                        if (File.Exists(name + ".json"))
                                                        {
                                                            json = File.ReadAllText(name + ".json");
                                                            Data.tempTest = JsonConvert.DeserializeObject<Dictionary<int, QuestionAnswer>>(json);
                                                        }
                                                        foreach (var it in Data.tempTest)
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
                                                       // Data.resultatCsharp.Add(Data.activeUserLogin, countTrueAnswer, "C#");
                                                        Data.allResult.Add(Data.activeUserLogin, countTrueAnswer, name);
                                                        Console.Clear();
                                                        Console.WriteLine("Результаты:");
                                                        Console.WriteLine("Всего правильных ответов: " + countTrueAnswer + " из " + Data.tempTest.Count());
                                                        Console.ReadKey();

                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }
                                        } while (choiceTheme != 3);
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
                                                    string type = "C#";
                                                    if (Data.allResult.allRes.ContainsKey(type))
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
                                                            
                                                            foreach (var res in Data.allResult.allRes[type])
                                                            {
                                                                foreach (var r in res)
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

                                            case 2:
                                                    Console.Clear();
                                                    Console.Write("Введите название викторины: ");
                                                    type = Console.ReadLine();
                                                    if (Data.allResult.allRes.ContainsKey(type))
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

                                                            foreach (var res in Data.allResult.allRes[type])
                                                            {
                                                                foreach (var r in res)
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
                                                        Console.WriteLine("Результатов пока нет. Либо викторины с таким названием не было!");
                                                    }
                                                    break;

                                            }
                                        }
                                        Console.ReadKey();
                                        break;
                                    case 3: // Посмотреть результаты прошлых викторин.
                                        Console.Clear();
                                        bool checkLoginInResult = false;

                                        if (Data.allResult.allRes.Count > 0)
                                        {
                                            Console.WriteLine("*****************************************");
                                            Console.WriteLine("|            Результаты                 |");
                                            Console.WriteLine("|_______________________________________|");
                                            Console.WriteLine("|     Тема     |   Правильных ответов   |");
                                            Console.WriteLine("|______________|________________________|");
                                            foreach (var res in Data.allResult.allRes)
                                            {
                                                foreach (var line in res.Value)
                                                {
                                                    foreach (var item in line)
                                                    {
                                                        if (item.Key == Data.activeUserLogin)
                                                        {
                                                            Console.WriteLine("|{0,14}| {1,23}|", res.Key, item.Value);
                                                            checkLoginInResult = true;
                                                        }
                                                    }
                                                    
                                                }
                                            }
                                            Console.WriteLine("|______________|________________________|");
                                            Console.WriteLine("*****************************************");
                                        }

                                        if(!checkLoginInResult)
                                        {
                                            Console.Clear();
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
                                                                if (Data.users[Data.activeUserLogin].password == oldPassword)
                                                                {
                                                                    Data.users[Data.activeUserLogin].password = newPassword;
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
                                                                Data.users[Data.activeUserLogin].dateOfBirth = newDateOfBirth;
                                                                Console.WriteLine("Дата рождения изменена.");
                                                                Console.ReadKey();
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        Console.Clear();
                                                        Console.WriteLine("*************************************************");
                                                        Console.WriteLine("Логин: " + Data.activeUserLogin);
                                                        Console.WriteLine("Пароль: " + Data.users[Data.activeUserLogin].password);
                                                        Console.WriteLine("Дата рождения: " + Data.users[Data.activeUserLogin].dateOfBirth);
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

            Data.FinallInitialization();
        }
        /// <summary>
        /// Функция проверяющая корректность логина и пароля. Возвращает временного пользователя если ввод корректен.
        /// </summary>
        /// <returns></returns>
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
}




