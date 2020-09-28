using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace _0_5_class_satellite
{
    class Program
    {
        static void Main()
        {
            short choice = 0;
            Satellite Sputnik = new Satellite();
            while(choice != 8)
            {
                if (Sputnik != null)
                {
                    Sputnik.Satelite_Paint_Menu();
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
                        Sputnik.Satellite_Launch();
                        Console.ReadKey();
                        break;
                    case 2:
                        Sputnik.Satellite_Landing();
                        Console.ReadKey();
                        break;
                    case 3:
                        Sputnik.GetStatus();
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
                                    Sputnik.Satelite_Increase_Speed();
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Sputnik.Satelite_Reduce_Speed();
                                    Console.ReadKey();
                                }
                            break;
                            }
                        }

                        break;
                    case 5:
                        Console.Write("Enter a new message: ");
                        string str = Console.ReadLine();
                        Sputnik.Satelite_Change_Message(str);
                        Console.ReadKey();
                        break;
                    case 6:
                         Sputnik.Satelite_Go_Broadcasting();
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

    public class Satellite
    {
        private string name = "Apollon_999";
        private double speed = 1020;
        private string message = "\"Apollon_999 flies to Mars.\"";
        private bool isFly = true;

        public void Satellite_Launch()
        {
            if(isFly)
            {
                Console.WriteLine($"{name} has already been launched!");
            }
            else
            {
                isFly = true;
                Console.WriteLine($"{name} launched!");
            }
            
        }

        public void Satellite_Landing()
        {
            if (isFly == false)
            {
                Console.WriteLine($"{name} is already on Mars!");
            }
            else
            {
                isFly = false;
                Console.WriteLine($"{name} is landing!");
                
            }
        }

        public void GetStatus()
        {
            Console.WriteLine($"_______________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Name satellite: {name}");
            Console.WriteLine($"Speed satellite: {speed} mph");
            Console.WriteLine($"Message satellite: {message}");
            Console.WriteLine($"Is fly satellite: {isFly}");
            Console.WriteLine($"_______________________________________________");
        }

        public void Satelite_Increase_Speed()
        {
            if (isFly)
            {
                speed += 100;
                Console.WriteLine($"Speed increased! Speed = {speed} mph.");
            }
            else
            {
                Console.WriteLine("Speed increase is not possible!");
            }
           

        }

        public void Satelite_Reduce_Speed()
        {
            if ((speed > 100) && (isFly))
            {
                speed -= 100;
                Console.WriteLine($"Speed reduced! Speed = {speed} mph.");

            }
            else if ((speed == 100) && (isFly))
            {
                Console.WriteLine($"Speed = 0!");
            }
            else
            {
                Console.WriteLine($"Reducing speed is not possible! Speed = {speed} mph.");
            }
        }

        public void Satelite_Change_Message(string str)
        {
            message = str;
            Console.WriteLine("Message changed!");
        }

        public void Satelite_Go_Broadcasting()
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
            Console.WriteLine(message);
            Console.Beep();
            ((Timer)sender).Start();
        }
        
        public void Satelite_Paint_Menu()
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
    }
}
