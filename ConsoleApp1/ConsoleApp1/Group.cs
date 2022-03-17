using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Group
    {
        private string _no;
        private int _studentlimit;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (Checker(value))
                    _no = value;
            }
        }
        public int Student
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if(value > 0)
                _studentlimit = value;
            }
        }
        static bool Checker(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length == 5)
            {
                if (char.IsUpper(value[0]) && char.IsUpper(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                    return true;
            }
            return false;
        }
    }
}
