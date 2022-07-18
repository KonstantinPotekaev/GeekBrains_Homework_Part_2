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
    public class BankAccount
    {
        //public static Dictionary<long, BankAccount> Accounts = new Dictionary<long, BankAccount>();
        private long _Id;
        private decimal _Balance;
        private string _Type, _User_Name;
        

        public BankAccount(int Balance, string Type, string User_Name)
        {
            _Id = Generate_Id.Generate_id();
            _Balance = Balance;
            _Type = Type;
            _User_Name = User_Name;
            Invoice_Output();
            
        }
        public string Invoice_Output()
        {
            return ($"Id = {_Id}\nName = {_User_Name}\nBalance = {_Balance}\nType = {_Type}\n\n");
        }
        public bool WithDraw(decimal sum)
        {
            _Balance -= sum;
            return _Balance >= sum;
                
        }
        public bool PutOn(decimal sum)
        {
            _Balance += sum;
            return true;
        }

        public bool TarnsferMoney(BankAccount Sourse, decimal Ammount)
        {
            if (Sourse._Balance >= Ammount)
            {
                Sourse._Balance -= Ammount;
                _Balance += Ammount;
                return true;
            }
            else
                return false;
        }
    }

    

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
            Console.WriteLine(account_1.Invoice_Output());
            Console.WriteLine(account_2.PutOn(500));
            Console.WriteLine(account_2.Invoice_Output());
            Console.WriteLine(account_2.TarnsferMoney(account_1, 500));
            Console.WriteLine(account_1.Invoice_Output());
            Console.WriteLine(account_2.Invoice_Output());
            //Console.ReadKey();



            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            Console.WriteLine(GB_String.Reverse(s) + '\n');

            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null )
                {
                    GB_String.SearchMail(ref line);
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }

        
    }
}
