using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0_13
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool isFemale { get; set; }
        public string country { get; set; }

        public Person(string name, int age, bool isFemale, string country)
        {
            this.name = name;
            this.age = age;
            this.isFemale = isFemale;
            this.country = country;
        }

        public void printInfo()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("IsFemale: " + isFemale);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("************************");
            Console.WriteLine();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>()
            {
                new Person("Вася", 25, false, "Минск"),
                new Person("Марина", 24, true, "Гомель" ),
                new Person("Владимир", 26, false, "Витебск")
            };

            var Igor = new Person("Игорь", 30, false, "Снов");
            personList.Add(Igor);

            var personListAge = personList.Where(t => t.age > 25);

            foreach (Person person in personList)
            {
                person.printInfo();
                Console.WriteLine("Index: " + personList.IndexOf(person));
                Console.WriteLine();

            }

            Console.WriteLine("Пользователи старше 25 лет: ");
            Console.WriteLine();
            foreach (Person person in personListAge)
            {
                person.printInfo();
            }

            // Console.Clear();

            Console.WriteLine("------------");


            Console.WriteLine("Index of user Vladimir in the list: " + personList.IndexOf(personList.Where(t => t.name == "Владимир").First()));




            Console.ReadKey();
        }
    }
}

