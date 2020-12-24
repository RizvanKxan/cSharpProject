using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace exam1_dictionary
{
    class Program
    {

        static void Main()
        {
            Console.Title = "Консольный переводчик.";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ref Dictionary<string, Word> workDictionary = ref Data.rusEng;

            
            while (true)
            {

                Console.Clear();
                Print.SelectTypeMenu();

                if ((!short.TryParse(Console.ReadLine(), out Data.choiceTypeDictionary) || ((Data.choiceTypeDictionary <= 0) || (Data.choiceTypeDictionary > 3))))
                {
                    Print.DataIsIncorrect();
                    Console.ReadKey();
                }
                else

                {
                    Console.Clear();
                    if (Data.choiceTypeDictionary == 3)
                    {
                        break;
                    }
                    if (Data.choiceTypeDictionary == 1)
                    {
                        workDictionary = ref Data.rusEng;
                    }
                    else
                    {
                        workDictionary = ref Data.engRus;
                    }

                    short choiceActionInDictionary = 0;
                    while (choiceActionInDictionary != 8)
                    {
                        Console.Clear();
                        if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
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
                                    Data.InitialInitialization();
                                    break;
                                case 2: // 2. Перевести слово или выражение.
                                        // проверка есть ли в словаре хоть один ключ
                                    Console.Clear();
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    if (workDictionary.ContainsKey("null"))
                                    {
                                        Print.DictionaryEmpty();
                                        Console.ReadKey();

                                    }
                                    else
                                    {
                                        string strToTranslate;
                                        Console.Write("Введите слово или фразу для которого хотите найти перевод: ");
                                        strToTranslate = Console.ReadLine();
                                        if ((strToTranslate.Trim() == "") || (workDictionary.ContainsKey(strToTranslate)))
                                        {
                                            Console.WriteLine("**********************************");
                                            Console.WriteLine("Перевод слова или выражения <<" + strToTranslate + ": ");
                                            Console.WriteLine("**********************************");
                                            Console.WriteLine();
                                            foreach (var v in workDictionary[strToTranslate].values)
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
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    Console.Write("Введите слово или фразу для которого хотите добавить перевод: ");
                                    str = Console.ReadLine();
                                    if ((str.Trim() == "") || (workDictionary.ContainsKey(str)))
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
                                    else if ((CheckLanguageString(str) != "Russian") && (Data.choiceTypeDictionary == 1))
                                    {
                                        Console.WriteLine("Слово должно быть на русском языке!");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else if ((CheckLanguageString(str) != "English") && (Data.choiceTypeDictionary == 2))
                                    {
                                        Console.WriteLine("Слово должно быть на английском языке!");
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

                                                if ((!string.IsNullOrEmpty(tempWord)) && (CheckLanguageString(tempWord) == "English") && (Data.choiceTypeDictionary == 1))
                                                {
                                                    strTranslate.Add(tempWord);
                                                }
                                                else if ((!string.IsNullOrEmpty(tempWord)) && (CheckLanguageString(tempWord) == "Russian") && (Data.choiceTypeDictionary == 2))
                                                {
                                                    strTranslate.Add(tempWord);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Ваша строка пуста или язык ввода не соответсвует типу словаря.");
                                                    isEmpty = true;
                                                    break;
                                                }

                                            }
                                            if (!isEmpty)
                                            {
                                                workDictionary.Remove("null");
                                                workDictionary.Add(str, new Word(strTranslate));
                                                Console.WriteLine("Перевод слова добавлен.");
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
                                    Console.Clear();
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    if (workDictionary.ContainsKey("null"))
                                    {
                                        Print.DictionaryEmpty();
                                        Console.ReadKey();
                                        break;

                                    }
                                    string strAddTranslate;

                                    Console.Write("Введите слово(выражение), перевод к которому нужно добавить: ");
                                    strAddTranslate = Console.ReadLine();
                                    if ((strAddTranslate.Trim() != "") && (workDictionary.ContainsKey(strAddTranslate)) && (CheckLanguageString(strAddTranslate) == "Russian") && (Data.choiceTypeDictionary == 1))
                                    {
                                        Console.Clear();
                                        if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                        Console.Write("Введите новый перевод: ");
                                        string tempWord = Console.ReadLine();
                                        if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "English"))
                                        {
                                            workDictionary[strAddTranslate].values.Add(tempWord);
                                            Console.WriteLine("Перевод успешно добавлен!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Строка пуста или ввод не корректен!");
                                        }
                                    }
                                    else if ((strAddTranslate.Trim() != "") && (workDictionary.ContainsKey(strAddTranslate)) && (CheckLanguageString(strAddTranslate) == "English") && (Data.choiceTypeDictionary == 2))
                                    {
                                        Console.Clear();
                                        if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                        Console.Write("Введите новый перевод: ");
                                        string tempWord = Console.ReadLine();
                                        if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "Russian"))
                                        {
                                            workDictionary[strAddTranslate].values.Add(tempWord);
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
                                    Console.Clear();
                                    bool isChange = false;
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    if (workDictionary.ContainsKey("null"))
                                    {
                                        Print.DictionaryEmpty();
                                        Console.ReadKey();
                                        break;
                                    }
                                    string strChange;
                                    Console.Write("Введите слово(выражение), перевод к которому нужно изменить: ");
                                    strChange = Console.ReadLine();
                                    if ((strChange.Trim() != "") && (workDictionary.ContainsKey(strChange)) && (CheckLanguageString(strChange) == "Russian") && (Data.choiceTypeDictionary == 1))
                                    {
                                        Console.Write("Напишите перевод который надо изменить: ");
                                        string tempWord = Console.ReadLine();
                                        if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "English"))
                                        {
                                            for (int i = 0; i < workDictionary[strChange].values.Count; i++)
                                            {
                                                if (workDictionary[strChange].values[i] == tempWord)
                                                {
                                                    Console.Write("Введите новый перевод: ");
                                                    string tempTranslate = Console.ReadLine();
                                                    if ((tempTranslate.Trim() != "") && (CheckLanguageString(tempTranslate) == "English"))
                                                    {
                                                        workDictionary[strChange].values[i] = tempTranslate;
                                                        Console.WriteLine("Перевод успешно изменён!");
                                                        isChange = true;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Строка пуста или введена не на том языке!");
                                                        break;
                                                    }
                                                }
                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Строка пуста или такого перевода у слова нет!");
                                        }

                                    }
                                    else if ((strChange.Trim() != "") && (workDictionary.ContainsKey(strChange)) && (CheckLanguageString(strChange) == "English") && (Data.choiceTypeDictionary == 2))
                                    {
                                        Console.Write("Напишите перевод который надо изменить: ");
                                        string tempWord = Console.ReadLine();
                                        if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "Russian"))
                                        {
                                            for (int i = 0; i < workDictionary[strChange].values.Count; i++)
                                            {
                                                if (workDictionary[strChange].values[i] == tempWord)
                                                {
                                                    Console.Write("Введите новый перевод: ");
                                                    string tempTranslate = Console.ReadLine();
                                                    if ((tempTranslate.Trim() != "") && (CheckLanguageString(tempTranslate) == "Russian"))
                                                    {
                                                        workDictionary[strChange].values[i] = tempTranslate;
                                                        Console.WriteLine("Перевод успешно изменён!");
                                                        isChange = true;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Строка пуста или введена не на том языке!");
                                                        break;
                                                    }
                                                }
                                            }

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
                                    if (!isChange) { Console.WriteLine("Такого перевода у слова нет."); }
                                    Console.ReadKey();
                                    break;
                                case 6: // 6. Удалить перевод.
                                    Console.Clear();
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    if (workDictionary.ContainsKey("null"))
                                    {
                                        Print.DictionaryEmpty();
                                        Console.ReadKey();
                                        break;
                                    }
                                    string strRemove;
                                    Console.Write("Введите слово(выражение), перевод к которому нужно удалить: ");
                                    strRemove = Console.ReadLine();
                                    if ((strRemove.Trim() != "") && (workDictionary.ContainsKey(strRemove)) && (CheckLanguageString(strRemove) == "Russian") && (Data.choiceTypeDictionary == 1))
                                    {
                                        if (workDictionary[strRemove].values.Count == 1)
                                        {
                                            Console.WriteLine("У слова всего один перевод - удаление невозможно!");
                                        }
                                        else
                                        {
                                            Console.Write("Напишите перевод который надо удалить: ");
                                            string tempWord = Console.ReadLine();
                                            if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "English"))
                                            {
                                                workDictionary[strRemove].values.Remove(tempWord);
                                                Console.WriteLine("Перевод успешно удалён!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Строка пуста или такого перевода у слова нет!");
                                            }
                                        }
                                    }
                                    else if ((strRemove.Trim() != "") && (workDictionary.ContainsKey(strRemove)) && (CheckLanguageString(strRemove) == "English") && (Data.choiceTypeDictionary == 2))
                                    {
                                        Console.Write("Напишите перевод который надо удалить: ");
                                        string tempWord = Console.ReadLine();
                                        if ((tempWord.Trim() != "") && (CheckLanguageString(tempWord) == "Russian"))
                                        {
                                            workDictionary[strRemove].values.Remove(tempWord);
                                            Console.WriteLine("Перевод успешно удалён!");
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
                                    Console.Clear();
                                    if (Data.choiceTypeDictionary == 1) { Print.rusTypeDictionary(); } else { Print.engTypeDictionary(); }
                                    if (workDictionary.ContainsKey("null"))
                                    {
                                        Print.DictionaryEmpty();
                                    }
                                    else
                                    {
                                        Console.WriteLine("**********************************");
                                        Console.WriteLine("Все слова:");
                                        Console.WriteLine("**********************************");
                                        foreach (var elem in workDictionary)
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
                }
            }
        }

        /// <summary>
        /// Функция определяющая язык строки(не строгое соответствие). 
        /// </summary>
        /// <param name="str">Строка на определение.</param>
        /// <returns></returns>
        public static string CheckLanguageString(string str)
        {
            byte[] b = System.Text.Encoding.Default.GetBytes(str.ToLower());

            int angl_count = 0;
            int rus_count = 0;

            foreach (byte bt in b)
            {
                if ((bt >= 97) && (bt <= 122)) angl_count++;
                if ((bt >= 192) && (bt <= 239)) rus_count++;
            }
            if (angl_count > rus_count) return "English";
            if (angl_count < rus_count) return "Russian";
            return "Unknown";
        }
    }

}




