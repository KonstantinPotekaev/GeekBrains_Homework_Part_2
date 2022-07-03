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
        private Dictionary<int, BankAccount> Accounts = new Dictionary<int, BankAccount>();
        private int _Id = 0;
        private int _Balance;
        private string _Type, _User_Name;
        

        private void Data()
        {
            if (File.Exists(@"dictionary.json"))
            {
                string json = File.ReadAllText("dictionary.json");
                //Accounts = JsonConvert.DeserializeObject<Dictionary<int, BankAccount>>(json);
                foreach (var item in Accounts)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
            }
        }
        
        public void Create(int Balance, string Type, string User_Name)
        {
            Data();
            Accounts.Add(_Id, new BankAccount { _Balance = Balance, _Type = Type, _User_Name = User_Name });
            Invoice_Output(_Id);
            Dict_to_json();
            _Id++;
        }
        private void Invoice_Output(int id)
        {
            Console.Write("Id = " + id + '\n' + "Name = " + Accounts[id]._User_Name + '\n' + "Balance = " + Accounts[id]._Balance + '\n' + "Type = " + Accounts[id]._Type + '\n' + '\n');
        }
        public void WithDraw(int id, int sum)
        {
            Data();
            if (Accounts[id]._Balance >= sum)
            {
                Accounts[id]._Balance -= sum;
                Invoice_Output(id);
            }

        }

        private void Dict_to_json()
        {

            string json = JsonConvert.SerializeObject(Accounts);
            File.WriteAllText("dictionary.json", json);
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
                        int Id = int.Parse(Console.ReadLine());
                        Console.Write("Вы хотите снять или положить деньги: ");
                        string n1 = Console.ReadLine().ToLower();
                        switch (n1)
                        {
                            case "снять":
                                Console.Write("Введите сумму: ");
                                int sum1 = int.Parse(Console.ReadLine());
                                new BankAccount().WithDraw(Id, sum1);
                                break;
                        }
                        break;
                }

            }
        }
    }
}
