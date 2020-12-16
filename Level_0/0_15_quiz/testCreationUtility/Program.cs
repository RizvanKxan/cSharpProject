using exam2;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace testCreationUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            string temp = "";
            Console.Write("Введите название викторины: ");
            temp = Console.ReadLine();
            string pathCsharpTest = temp + ".json";
            

            Dictionary<int, QuestionAnswer> cSharp = new Dictionary<int, QuestionAnswer>();
            Dictionary<string, bool> answers = new Dictionary<string, bool>();
            string question;
            short trueAnswer;
            List<string> tempAnswer = new List<string>();

            for (int i = 0; i < 1; i++)
            {
                question = "";
                tempAnswer.Clear();
                answers.Clear();
                Console.Write("Введите " + (i + 1) + " вопрос: ");
                question = Console.ReadLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Введите " + (j + 1) + " вариант ответа: ");
                    tempAnswer.Add(Console.ReadLine());
                }
                Console.Write("Укажите номер правильного ответа: ");
                trueAnswer = short.Parse(Console.ReadLine());
                for (int k = 0; k < 5; k++)
                {
                    if (k != (trueAnswer-1))
                    {
                        answers.Add(tempAnswer[k], false);
                    }
                    else
                    {
                        answers.Add(tempAnswer[k], true);
                    }
                }
                QuestionAnswer queAnswer = new QuestionAnswer(question, answers);
                cSharp.Add((i + 1), queAnswer);
            }

            short koll = 0;
            foreach (var questions in cSharp)
            {
                Console.WriteLine("Вопрос " + questions.Key + ":" + questions.Value.Question);
                foreach (var ln in questions.Value.answers)
                {
                    Console.WriteLine(++koll + ". " + ln.Key);
                }
            }
            Console.ReadKey();

            if (File.Exists(pathCsharpTest))
            {
                Console.WriteLine("Файл уже существует! Желаете его заменить?");
                Console.Write("Введите да или нет: ");
                string choice = Console.ReadLine();
                if(choice == "да")
                {
                    json = JsonConvert.SerializeObject(cSharp, Formatting.Indented);
                    File.WriteAllText(pathCsharpTest, json);
                    Console.WriteLine("Файл перезаписан!");
                }
                else
                {
                    Console.WriteLine("Изменения отменены!");
                }
                
            }
            else
            {
                json = JsonConvert.SerializeObject(cSharp, Formatting.Indented);
                File.WriteAllText(pathCsharpTest, json);
                Console.WriteLine("Викторина с именем " + temp + " создана!");
            }
            Console.ReadKey();
        }
    }
}
