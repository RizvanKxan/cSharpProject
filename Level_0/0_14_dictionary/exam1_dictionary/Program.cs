﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam1_dictionary
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<string, Word> rusEng = new Dictionary<string, Word>
            {
                { "null", null }
            };
            short choiceTypeDictionary = 0;
            while (choiceTypeDictionary != 3)
            {

                Console.Clear();
                Print.SelectTypeMenu();
                if ((!short.TryParse(Console.ReadLine(), out choiceTypeDictionary) || ((choiceTypeDictionary <= 0) || (choiceTypeDictionary > 3))))
                {
                    Print.DataIsIncorrect();
                    Console.ReadKey();
                }
                else
                {

                    while (true)
                    {
                        Console.Clear();
                        switch (choiceTypeDictionary)
                        {
                            case 1:
                                short choiceActionInDictionary = 0;
                                while (choiceActionInDictionary != 8)
                                {
                                    Console.Clear();
                                    Print.DictionaryMenu();
                                    if ((!short.TryParse(Console.ReadLine(), out choiceActionInDictionary) || ((choiceActionInDictionary <= 0) || (choiceActionInDictionary > 8))))
                                    {
                                        Print.DataIsIncorrect();
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        switch (choiceActionInDictionary)
                                        {
                                            case 1: // 1. Добавить словарь.
                                                Console.Clear();
                                                // добавить проверку: если существует файл, значит словарь существует
                                                // иначе создать новый файл и создать новый словарь
                                                Console.WriteLine("*********************************************");
                                                Console.WriteLine("Словарь создан.                             |");
                                                Console.WriteLine("Для выхода нажмите любую клавишу...         |");
                                                Console.WriteLine("*********************************************");
                                                Console.ReadKey();
                                                                                
                                            break;
                                            case 2: // 2. Перевести слово или выражение.
                                            // проверка есть ли в словаре хоть один ключ
                                                if(rusEng.ContainsKey("null"))
                                                {
                                                    Print.DictionaryEmpty();
                                                    Console.ReadKey();
                                                    
                                                }
                                                else
                                                {
                                                    string strToTranslate;
                                                    Console.Write("Введите слово или фразу для которого хотите найти перевод: ");
                                                    strToTranslate = Console.ReadLine();
                                                    if ((strToTranslate.Trim() == "") || (rusEng.ContainsKey(strToTranslate)))
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("**********************************");
                                                        Console.WriteLine($"Перевод слова или выражения <<{strToTranslate}>>: ");
                                                        Console.WriteLine("**********************************");
                                                        Console.WriteLine();
                                                        foreach(var v in rusEng[strToTranslate].values)
                                                        {
                                                            Console.WriteLine(v);
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                }
                                            break;
                                            case 3: // 3. Добавить новое слово или выражение.
                                                string str;
                                                short numberOfValue;
                                                Console.Clear();
                                                Console.Write("Введите слово или фразу для которого хотите добавить перевод: ");
                                                str = Console.ReadLine();
                                                if ((str.Trim() == "") || (rusEng.ContainsKey(str)))
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("******************************************************************");
                                                    Console.WriteLine("Невозможно добавить слово. Строка пуста или слово уже существует.|");
                                                    Console.WriteLine("Для замены перевода воспользуйтесь специальным меню.             |");
                                                    Console.WriteLine("Для выхода нажмите любую клавишу..                               |");
                                                    Console.WriteLine("******************************************************************");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                else if (CheckLanguageString(str) != "Russian")
                                                {
                                                    Console.WriteLine("Слово должно быть на русском языке!");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                
                                                
                                                var strTranslate = new List<string>();
                                                Console.Write("Укажите сколько значений перевода нужно добавить: ");
                                                while (true)
                                                {
                                                    if ((!short.TryParse(Console.ReadLine(), out numberOfValue) || (numberOfValue <= 0)))
                                                    {
                                                        Print.DataIsIncorrect();
                                                        Console.ReadKey();
                                                    }
                                                    else
                                                    {
                                                        
                                                        string tempWord;
                                                        bool isEmpty = false;
                                                        for (int i = 0; i < numberOfValue; i++)
                                                        {
                                                            Console.Write("Введите перевод и нажмите ENTER: ");
                                                            tempWord = Console.ReadLine();
                                                            
                                                            if ((!string.IsNullOrEmpty(tempWord)) && (CheckLanguageString(tempWord) == "English"))
                                                            {
                                                                strTranslate.Add(tempWord);
                                                                Console.WriteLine("Перевод слова добавлен.");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Ваша строка пуста или слово введено не на анлийском языке.");
                                                                isEmpty = true;
                                                            }
                                                            
                                                        }
                                                        if(!isEmpty)
                                                        {
                                                            rusEng.Remove("null");
                                                            rusEng.Add(str, new Word(strTranslate));
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Невозможно добавить слово.");
                                                        }
                                                        
                                                        Console.ReadKey();
                                                    }
                                                break;
                                                }                                            
                                            break;
                                            case 4: // 4. Добавить новый перевод. 
                                                if(rusEng.ContainsKey("null"))
                                                {
                                                    Print.DictionaryEmpty();
                                                    Console.ReadKey();
                                                    break;
                                                    
                                                }
                                                string strAddTranslate;
                                                Console.Clear();
                                                Console.Write("Введите слово(выражение), перевод к которому нужно добавить: ");
                                                strAddTranslate = Console.ReadLine();
                                                if ((strAddTranslate.Trim() != "") && (rusEng.ContainsKey(strAddTranslate)) && (CheckLanguageString(strAddTranslate) == "Russian"))
                                                {
                                                    Console.Clear();
                                                    Console.Write("Введите новый перевод: ");
                                                    string tempWord = Console.ReadLine();
                                                    if ((tempWord.Trim() != "")  && (CheckLanguageString(tempWord) == "English"))
                                                    {
                                                        rusEng[strAddTranslate].values.Add(tempWord);
                                                        Console.WriteLine("Перевод успешно добавлен!");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Строка пуста или ввод не корректен!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Такого слова(выражения) в словаре нет или ввод не корректный.");
                                                }
                                                Console.ReadKey();
                                            break;
                                            case 5: // 5. Изменить перевод.
                                            break;
                                            case 6: // 6. Удалить перевод.
                                                if(rusEng.ContainsKey("null"))
                                                {
                                                    Print.DictionaryEmpty();
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                string strRemove;
                                                Console.Write("Введите слово(выражение), перевод к которому нужно удалить: ");
                                                strRemove = Console.ReadLine();
                                                if ((strRemove.Trim() != "") && (rusEng.ContainsKey(strRemove)) && (CheckLanguageString(strRemove) == "Russian"))
                                                {
                                                    Console.Write("Напишите перевод который надо удалить: ");
                                                    string tempWord = Console.ReadLine();
                                                    if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "English"))
                                                    {
                                                        rusEng[strRemove].values.Remove(tempWord);
                                                        Console.WriteLine("Слово успешно удалено!");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Строка пуста или такого перевода у слова нет!");
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Такого слова(выражения) в словаре нет или ввод не корректный.");
                                                }
                                                Console.ReadKey();
                                            break;
                                            case 7: // 7. Показать все слова в словаре.
                                            if(rusEng.ContainsKey("null"))
                                                {
                                                    Print.DictionaryEmpty();
                                                }
                                                else
                                                {
                                                Console.Clear();
                                                Console.WriteLine("**********************************");
                                                Console.WriteLine("Все слова:");
                                                Console.WriteLine("**********************************");
                                                foreach (var elem in rusEng)
                                                {
                                                    Console.Write(elem.Key + ":");
                                                    Console.WriteLine();
                                                    foreach (var item in elem.Value.values)
                                                    {
                                                        Console.WriteLine("\t" + item);
                                                    }
                                                    Console.WriteLine();
                                                }
                                                }
                                            Console.ReadKey();
                                            break; 
                                            case 8:
                                            break;                                           
                                            default:
                                            break;
                                        }
                                        
                                    }
                                }
                                

                                Console.WriteLine();

                                //Console.ReadKey();
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                        }
                        break;
                    }
                }
            }

        }

        public static string CheckLanguageString(string str)
        {
        
            byte[] b = System.Text.Encoding.Default.GetBytes(str.ToLower());
        
            int angl_count = 0;
            int rus_count = 0;
 
            foreach( byte bt in b )
            {
                if ( (bt >= 97) && (bt <= 122) ) angl_count ++;
                if ( (bt >= 192) && (bt <= 239) ) rus_count ++;
            }
            if (angl_count > rus_count) return  "English";
            if (angl_count < rus_count) return  "Russian";
            return  "Unknown";

        }



    }

    

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
            Console.Clear();
            Console.WriteLine("*************************************************");
            Console.WriteLine("Словарь пуст! Для начала заполните его данными. |");
            Console.WriteLine("Для выхода нажмите любую клавишу...             |");
            Console.WriteLine("*************************************************");
        }

        public static void DataIsIncorrect()
        {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("Данные не корректны, повторите ввод.    |");
            Console.WriteLine("Для выхода нажмите любую клавишу...     |");
            Console.WriteLine("*****************************************");
        }


    }

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
    }
}