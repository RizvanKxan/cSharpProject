using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace _0_5_class_satellite
{
    public abstract class Space_Ship : Iletable
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public string Message { get; set; }
        public bool IsFly { get; set; }

        public void Space_Ship_Paint_Menu()
        {
            Console.Clear();
            Console.WriteLine("Control panel:                | *    **      *    **     **    *      **");
            Console.WriteLine("______________________________|   **           ** *@*       *           ");
            Console.WriteLine("1. Satellite launch.          | **  **       *   *@@@*    *   *       **");
            Console.WriteLine("______________________________|        ******   *@@@@@***       ** ***  ");
            Console.WriteLine("2. Satellite landing.         |         ***     @@@@@@@*         ***    ");
            Console.WriteLine("______________________________|**     **    *  *#@@@@@#***     ***   ** ");
            Console.WriteLine("3. Get information.           |  ** *         *@@*@#@*#@   * **         ");
            Console.WriteLine("______________________________|*      **    * *#*@###@#@**     **    ** ");
            Console.WriteLine("4. Change speed.              |          **   @#@*@@**@@*         **    ");
            Console.WriteLine("______________________________|  *  **       *@##@##@@##@ **  *        *");
            Console.WriteLine("5. Change message.            |   **          @##@##@###@  ***          ");
            Console.WriteLine("______________________________| *    **     ***#########**     *     ** ");
            Console.WriteLine("6. Start broadcast.           |        **** **@#########@**     *****   ");
            Console.WriteLine("______________________________| *    **   *@##############@@   **     * ");
            Console.WriteLine("7. Launch self destruct.      |   ***     *@########@######@**          ");
            Console.WriteLine("______________________________| **  **    @@###*@#@@*#@*###@@ *        *");
            Console.WriteLine("                              |*       * *@##@****@@@****@##@*  **  **  ");
            Console.WriteLine("                              |         **@#@*****@@@*****##@**   **    ");
            Console.WriteLine("8. Exit.                      |*      *    *****************   **    *  ");
            Console.WriteLine("                              |  ** *         ** *         * **        *");
            Console.WriteLine("______________________________|  ****         * **         * *         *");
        }

        public void Launch()
        {
            if (IsFly)
            {
                Console.WriteLine($"{Name} has already been launched!");
                Logger.WriteToLog($"{Name} has already been launched!");
            }
            else
            {
                IsFly = true;
                Console.WriteLine($"{Name} launched!");
                Logger.WriteToLog($"{Name} launched!");
            }

        }

        public void GetStatus()
        {
            Console.WriteLine($"_______________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Name satellite: {Name}");
            Console.WriteLine($"Speed satellite: {Speed} mph");
            Console.WriteLine($"Message satellite: {Message}");
            Console.WriteLine($"Is fly satellite: {IsFly}");
            Console.WriteLine($"_______________________________________________");
        }

        public void Landing()
        {
            if (IsFly == false)
            {
                Console.WriteLine($"{Name} is already on Mars!");
                Logger.WriteToLog($"{Name} is already on Mars!");
            }
            else
            {
                IsFly = false;
                Console.WriteLine($"{Name} is landing!");
                Logger.WriteToLog($"{Name} is landing!");
            }
        }

        public void Increase_Speed()
        {
            if (IsFly)
            {
                Speed += 100;
                Console.WriteLine($"Speed increased! Speed = {Speed} mph.");
            }
            else
            {
                Console.WriteLine("Speed increase is not possible!");
            }
        }

        public void Reduce_Speed()
        {
            if ((Speed > 100) && (IsFly))
            {
                Speed -= 100;
                Console.WriteLine($"Speed reduced! Speed = {Speed} mph.");

            }
            else if ((Speed == 100) && (IsFly))
            {
                Console.WriteLine($"Speed = 0!");
            }
            else
            {
                Console.WriteLine($"Reducing speed is not possible! Speed = {Speed} mph.");
            }
        }


        public void Change_Message(string str)
        {
            Message = str;
            Console.WriteLine("Message changed!");
        }

        public void Go_Broadcasting()
        {
            Console.Clear();
            Console.WriteLine("Broadcast started! Press any key to exit!");

            Timer timer = new Timer();
            timer.Interval = 1500;

            timer.Elapsed += Timer_Elapsed;

            timer.Start();

            Console.ReadKey();
            timer.Stop();
        }


        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ((Timer)sender).Stop();
            Console.WriteLine(Message);
            Console.Beep();
            ((Timer)sender).Start();
        }

        public void Connect(Iletable anyclass)
        {
                Console.WriteLine("Корабль присоединён.");

        }
    }


    class Program
    {
        static void Main()
        {
            short choice = 0;
            Space_Ship Sputnik = new Satellite();
            MKS Mks = new MKS();
            Plane Su147 = new Plane();
            
            while(choice != 8)
            {
                if (Sputnik != null)
                {
                    
                    Sputnik.Space_Ship_Paint_Menu();
                }
                else
                {
                    Console.Clear();
                    Destroid_Print();
                    Console.WriteLine("Satelite destroid!");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                }
                
                while (true)
                {
                    Console.Write("Choice: ");
                    if ((!short.TryParse(Console.ReadLine(), out choice) || ((choice <= 0) || (choice > 8))))
                    {
                        Console.WriteLine("!!!Wrong choice!!!");
                    }
                    else
                    {
                        break;
                    }
                }
                switch (choice)
                {
                    case 1:
                        Sputnik.Launch();
                        Console.ReadKey();
                        break;
                    case 2:
                        Sputnik.Landing();
                        Console.ReadKey();
                        break;
                    case 3:
                        Sputnik.GetStatus();
                        Mks.ConnectSatellite(Sputnik); // присоединим к мкс один спутник
                        Mks.GetStatus();
                        Mks.Connect(Su147);
                        Su147.Connect(Mks);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Speed control.");
                        Console.WriteLine("1. Increase speed.");
                        Console.WriteLine("2. Reduce speed.");
                        short x;
                        while (true)
                        {
                            Console.Write("Choice: ");
                            if ((!short.TryParse(Console.ReadLine(), out x) || ((x <= 0) || (x > 2))))
                            {
                                Console.WriteLine("!!!Wrong choice!!!");
                            }
                            else
                            {
                                if(x == 1)
                                {
                                    Sputnik.Increase_Speed();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Sputnik.Reduce_Speed();
                                    Console.ReadKey();
                                }
                            break;
                            }
                        }

                        break;
                    case 5:
                        Console.Write("Enter a new message: ");
                        string str = Console.ReadLine();
                        Sputnik.Change_Message(str);
                        Console.ReadKey();
                        break;
                    case 6:
                         Sputnik.Go_Broadcasting();
                         break;
                    case 7:
                        Sputnik = null;
                        break;
                    case 8:
                        break;
                }
            }
        }

        static void Destroid_Print()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("##########        ##  #####  ####      ###########");
            Console.WriteLine("#############* #####. ##### .#### ################");
            Console.WriteLine("#############*.#####. .   . .#### ....############");
            Console.WriteLine("#############*.#####. ##### .#### ################");
            Console.WriteLine("#############.-#####  ##### .####.......##########");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("###########-.     .# ..=#### ###  ###* ###########");
            Console.WriteLine("###########+.####### #..#### ### .#####. #########");
            Console.WriteLine("###########+.....### ###.-## ### .###### .########");
            Console.WriteLine("###########+ ####### ####%.# ### .##### .#########");
            Console.WriteLine("###########-.    .## ###### .### .### .###########");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
            Console.WriteLine();
        }

    }

    public class Satellite : Space_Ship
    {
        private string name = "Sputnik";
        private double speed = 1020;
        private string message = "\"Sputnik flies to Mars.\"";
        private bool isFly = true;
        
        public Satellite()
        {
            Name = name;
            Speed = speed;
            Message = message;
            IsFly = isFly;
        }
    }



    public class MKS : Iletable
    {
        private string name = "MKS";
        private double speed = 4420;
        private string message = "\"MKS is empty.\"";
        private bool isFly = true;
        private int count = 0;

        public void Connect(Iletable anyclass)
        {
            Console.WriteLine("Соединение в МКС успешно установлено.");
        }

        public void ConnectSatellite(Space_Ship a)
        {
            count++;
        }

        public void GetStatus()
        {
            Console.WriteLine($"_______________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Name satellite: {name}");
            Console.WriteLine($"Speed satellite: {speed} mph");
            Console.WriteLine($"Message satellite: {message}");
            Console.WriteLine($"Is fly satellite: {isFly}");
            Console.WriteLine($"Count : {count}");
            Console.WriteLine($"_______________________________________________");
        }


    }

    public class Plane : Iletable
    {
        public void Connect(Iletable anyclass)
        {
            Console.WriteLine("Самолёт присоединён.");
        }

    }

    public interface Iletable
    {
        void Connect(Iletable anyclass);
    }

}

static class Logger
{
    public static string path = @"C:\Users\Admin\Desktop\logstarlink.txt";


    public static void WriteToLog(string str)
    {
        using (FileStream fstream = new FileStream($"{path}", FileMode.Append))
        {

            byte[] array = System.Text.Encoding.Default.GetBytes(str + "\n");
            fstream.Write(array, 0, array.Length);
            Console.WriteLine("Лог добавлен!");
        }
    }
}


// класс МКС, к которому мы можем присоединять и отсоединять спутники а также получить количество подсоединённых спутников
// метод коннект и дисконнект

// абстрактный класс Самолёты и конкретный класс Самолёт Ту-147

// реализуем два интерфейса для Ship и для Самолёты, в каждом реализуем метод Коннект

// коннект должен присоединять что-то к мкс(самолёт или спутник)