using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam2
{
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
}
