using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Group
    {
        private string _groupNo;
        private string _name;
        private string _lastname;
        private int _age;

        public string No
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (NoChecker(value))
                    _groupNo = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (StrChecker(value,2))
                    _name = value;
            }
        }
        public string LastName
        {
            get 
            {
                return _lastname;
            }
            set
            {
                if(StrChecker(value,5))
                _lastname = value;
            }
        }
        public int Age
        {
            get 
            { 
                return _age; 
            }
            set
            {
                if(value > 15)
                _age = value;
            }
        }
        public string GetInfo()
        {
            return $"Ad: {this.Name} - Soyad: {this.LastName}\nYasi: {this.Age} Qrup: {this.No}";
        }
        static bool NoChecker(string value)
        {
            if (value.Length == 5 && char.IsUpper(value[0]) && char.IsUpper(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                return true;
            return false;
        }
        static bool StrChecker(string value, int min)
        {
            int count = 0;
            if(value.Length > min)
            {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    count++;
                }
            }
            if (count == value.Length && char.IsUpper(value[0]))
                return true;
            }
            return false;
        }
    }
}
