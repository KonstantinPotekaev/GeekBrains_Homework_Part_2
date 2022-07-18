using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Lesson_2_3
{
    
    

    

    public class GB_String
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void SearchMail(ref string s)
        {
            string[] s1 = s.Split(' ');
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == "&")
                {
                    s = s1[i + 1];
                    break;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account_1 = new BankAccount(1000, "base", "Konstantin");
            BankAccount account_2 = new BankAccount(10000, "base", "Artem");
            Console.WriteLine(account_1.WithDraw(500));
            Console.WriteLine(account_1);
            Console.WriteLine(account_2.PutOn(500));
            Console.WriteLine(account_2);
            Console.WriteLine(account_2.TarnsferMoney(account_1, 500));
            Console.WriteLine(account_1);
            Console.WriteLine(account_2);
            //Console.ReadKey();



            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(GB_String.Reverse(s) + '\n');

            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        GB_String.SearchMail(ref line);
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        
    }
}
