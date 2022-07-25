using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Lesson_2_3 {


    public class BankAccount
    {
        //public static Dictionary<long, BankAccount> Accounts = new Dictionary<long, BankAccount>();
        private int _Id;
        private decimal _Balance;
        private string _Type, _User_Name;


        public BankAccount(int Balance, string Type, string User_Name)
        {
            _Id = Generate_Id.Generate_id();
            _Balance = Balance;
            _Type = Type;
            _User_Name = User_Name;
           

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


        public static bool operator ==(BankAccount a, BankAccount b)
        {
            return a._Balance == b._Balance && a._Type == b._Type && a._User_Name == b._User_Name;
        }
        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return a._Balance != b._Balance || a._Type != b._Type || a._User_Name != b._User_Name;
        }
        public override bool Equals(Object a)
        {
            var b = (BankAccount)a;
            return _Balance == b._Balance && _Type == b._Type && _User_Name == b._User_Name;
        }
        public override int GetHashCode()
        {
            
            int hash = 0x18D;
            unchecked
            {
                
                hash = (hash * 0x18D) ^ _Id;
                hash = (hash * 0x18D) ^ (int)_Balance;
            }
            return hash;
        }
        public override string ToString()
        {
            return ($"Id = {_Id}\nName = {_User_Name}\nBalance = {_Balance}\nType = {_Type}\n\n");
        }
    }

} 
