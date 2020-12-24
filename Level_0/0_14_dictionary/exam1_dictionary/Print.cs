using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam1_dictionary
{
    public static class Print
    {
        public static void SelectTypeMenu()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Выберите тип словаря:               |");
            Console.WriteLine("1. Русский - Английский.            |");
            Console.WriteLine("2. Английский - Русский.            |");
            Console.WriteLine("3. Выход.                           |");
            Console.WriteLine("*************************************");
            Console.Write("Ваш выбор: ");

        }

        public static void DictionaryMenu()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Меню словаря:                             |");
            Console.WriteLine("1. Добавить словарь.                      |");
            Console.WriteLine("2. Перевести слово или выражение.         |");
            Console.WriteLine("3. Добавить новое слово или выражение.    |");
            Console.WriteLine("4. Добавить новый перевод.                |");
            Console.WriteLine("5. Изменить перевод.                      |");
            Console.WriteLine("6. Удалить перевод.                       |");
            Console.WriteLine("7. Показать все слова.                    |");
            Console.WriteLine("8. Выход.                                 |");
            Console.WriteLine("*******************************************");
            Console.Write("Ваш выбор: ");
        }

        public static void DictionaryEmpty()
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("Словарь пуст! Для начала заполните его данными. |");
            Console.WriteLine("Для выхода нажмите любую клавишу...             |");
            Console.WriteLine("*************************************************");
        }

        public static void DataIsIncorrect()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Данные не корректны, повторите ввод.      |");
            Console.WriteLine("Для выхода нажмите любую клавишу...       |");
            Console.WriteLine("*******************************************");
        }

        public static void rusTypeDictionary()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Тип словаря: Русско - Английский.         |");
            Console.WriteLine("-------------------------------------------");
        }
        public static void engTypeDictionary()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Тип словаря: Английско - Русский.         |");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
