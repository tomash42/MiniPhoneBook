using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniPhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
           bool end = false;
           string val;
           string key;

            //Created Dictonary
            Dictionary<string, string> diContacts = new Dictionary<string, string>();
            diContacts.Add("tomasz@int.pl", "tomek");
            //End
            


            do
            {               
                Console.WriteLine("--------MINI BOOK PHONE----------");
                Console.WriteLine("---------------------------------");
        
                Console.WriteLine("----------------MENU-------------");
                Console.WriteLine("1 Add Contact\t\t\t");
                Console.WriteLine("2 All List Contact\t\t");

  
                string selectMenu = Console.ReadLine();
                int selectMenuInt = int.Parse(selectMenu);

                switch (selectMenuInt)
                {
                    case 1:
                       
                        Console.WriteLine("Type your contacts :");                        
                        //get data from input
                        Console.WriteLine("Phone");
                        key = Console.ReadLine();
                        Console.WriteLine("Name");
                        val = Console.ReadLine();
                        diContacts.Add(key, val);
                        break;

                    case 2:
                        
                        Console.WriteLine("Lista kontaktow :");    
                        //Order by Linq
                        foreach (var item in diContacts.OrderBy(x=>x.Key))
                        {
                            Console.WriteLine(" {0} \t {1} ",item.Key ,item.Value);
                        }
                        Console.ReadKey();
                        break;
                    case < 0:
                        Console.WriteLine("You can choice between 1 and 2");
                        Console.ReadKey();
                        break;



                    default:

                        Console.WriteLine("You can choice between 1 and 2");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("3 Do you  Exit ?\t\t\n (y/n)\t\t\t");
                Console.WriteLine("-----------------------------");
                char exit = char.Parse(Console.ReadLine());
            
              
       
                //Way out code
                if (exit == 'y' && Char.IsDigit(ch))
                    {
                        end = false;
               
                    }
                else
                {
                    end = true;
                }
                    Console.Clear();
                } while (end);           
        }        
    }
}
