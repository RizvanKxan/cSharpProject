using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0_15_quiz
{
    class Program
    {

        static void Main()
        {

            Dictionary<string, PersonData> users = new Dictionary<string, PersonData>() { { "1", new PersonData("2") } };
            short choiceMainMenu;
            string activeUserLogin = "";
            do
            {
                Console.Clear();
                Print.Autorization();
                if ((!short.TryParse(Console.ReadLine(), out choiceMainMenu) || (choiceMainMenu <= 0) || (choiceMainMenu > 2)))
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
                        foreach (KeyValuePair<string, PersonData> keyValue in tempUser)
                        {


                            if (users.ContainsKey(keyValue.Key))
                            {
                                Console.WriteLine("Такой пользователь уже существует!");
                            }
                            else
                            {
                                //Console.WriteLine("Такого пользователя ещё нет!");
                                // Console.WriteLine("Добро пожаловать " + keyValue.Key + "");
                                Console.Write("Введите свой день рождения: ");
                                dateOfBirth = Console.ReadLine();
                                users.Add(keyValue.Key, new PersonData(keyValue.Value.password, dateOfBirth));
                                Console.WriteLine("Пользователь успешно зарегестрирован!");
                                foreach (var user in users)
                                {
                                    Console.WriteLine("Логин: " + user.Key);
                                    Console.WriteLine("Пароль: " + user.Value.password);
                                    Console.WriteLine("Дата рождения: " + user.Value.dateOfBirth);
                                }
                            }
                            activeUserLogin = keyValue.Key;
                        }
                        short choiceQuizMenu = 0;
                        do
                        {

                            Console.Clear();
                            Print.QuizMenu();
                            if ((!short.TryParse(Console.ReadLine(), out choiceQuizMenu) || (choiceQuizMenu <= 0) || (choiceQuizMenu > 5)))
                            {
                                Print.DataIsIncorrect();
                                Console.ReadKey();
                            }
                            else
                            {
                                switch (choiceQuizMenu)
                                {
                                    case 1: // Начать новую викторину. 
                                        break;
                                    case 2: // Посмотреть результаты прошлых викторин.
                                        break;
                                    case 3: // Посмотреть ТОП-10 по викторинам.
                                        break;
                                    case 4: // Изменить настройки.
                                        short choiceSettingMenu = 0;
                                        do
                                        {
                                            Console.Clear();
                                            Print.SettingMenu();

                                            if ((!short.TryParse(Console.ReadLine(), out choiceSettingMenu)) || (choiceSettingMenu <= 0) || (choiceSettingMenu > 3))
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
                                                            else if ((oldPassword.Contains(" ")) || (newPassword.Contains(" ")))
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
                                                        break;
                                                }
                                            }
                                        } while (choiceSettingMenu != 3);
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

        }
        public static Dictionary<string, PersonData> autorization()
        {
            string login, password;
            var tempUserrr = new Dictionary<string, PersonData>();

            while (true)
            {

                Console.Clear();

                Console.Write("Введите логин: ");
                login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                Console.WriteLine("------------------------------------|");
                if ((login.Contains(" ")) || (password.Contains(" ")) || (login == password))
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
            Console.WriteLine("2. Посмотреть результаты прошлых викторин.      |");
            Console.WriteLine("3. Посмотреть ТОП-10 по викторинам.             |");
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
            Console.WriteLine("3. Выход.                                 |");
            Console.WriteLine("*******************************************");
            Console.Write("Ваш выбор: ");
        }
        public static void engTypeDictionary()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Тип словаря: Английско - Русский.         |");
            Console.WriteLine("-------------------------------------------");
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
            this.dateOfBirth = "";
        }
    }
}




