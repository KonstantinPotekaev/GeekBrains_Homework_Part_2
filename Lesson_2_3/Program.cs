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
        public static Dictionary<long, BankAccount> Accounts = new Dictionary<long, BankAccount>();
        private long _Id;
        private decimal _Balance;
        private string _Type, _User_Name;
        

        public void Create(int Balance, string Type, string User_Name)
        {
            _Id = Generate_Id.Generate_id();
            Accounts.Add(_Id, new BankAccount { _Balance = Balance, _Type = Type, _User_Name = User_Name });
            Invoice_Output(_Id);
            
        }
        private void Invoice_Output(long id)
        {
            Console.Write("Id = " + id + '\n' + "Name = " + Accounts[id]._User_Name + '\n' + "Balance = " + Accounts[id]._Balance + '\n' + "Type = " + Accounts[id]._Type + '\n' + '\n');
        }
        public void WithDraw(long id, decimal sum)
        {
            if (Accounts[id]._Balance >= sum)
            {
                Accounts[id]._Balance -= sum;
                Invoice_Output(id);
            }
            else
            {
                Console.WriteLine("Недостаточно средств");

            }

        }
        public void PutOn(long id, decimal sum)
        {
            Accounts[id]._Balance += sum;
            Invoice_Output(id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                
                Console.Write("Вы хотите открыть новый счет, произвести действия с уже существующим или выйти: ");
                string n = Console.ReadLine().ToLower();
                
                switch (n)
                {
                    case "открыть новый счет":
                        Console.Write("Введите сумму: ");
                        int sum = int.Parse(Console.ReadLine());
                        Console.Write("Введите тип счета: ");
                        string type = Console.ReadLine();
                        Console.Write("Введите Ваше имя: ");
                        string name = Console.ReadLine();
                        new BankAccount().Create(sum, type, name);
                        break;
                    case "произвести действия":
                        Console.Write("Введите номер вашего счета: ");
                        long Id = long.Parse(Console.ReadLine());
                        Console.Write("Вы хотите снять или положить деньги: ");
                        string n1 = Console.ReadLine().ToLower();
                        switch (n1)
                        {
                            case "снять":
                                Console.Write("Введите сумму: ");
                                decimal decrease = decimal.Parse(Console.ReadLine());
                                new BankAccount().WithDraw(Id, decrease);
                                break;
                            case "положить":
                                Console.Write("Введите сумму: ");
                                decimal increase = decimal.Parse(Console.ReadLine()); 
                                new BankAccount().PutOn(Id, increase);
                                break;
                        }
                        break;
                }
            }
        }
    }
}
