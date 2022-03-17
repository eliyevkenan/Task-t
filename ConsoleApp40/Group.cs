using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp40
{
    internal class Group
    {
        public string _No;
        public int _Studentlimit;
        public string No
        {
            get =>this._No;
            set
            {
                if (CheckNo)
                {
                    this._No = value;
                }
            }

        }
        public int Studentlimit
        {
            get =>this._Studentlimit;
            set
            {
                if (value>=0)
                {
                    this._Studentlimit = value;
                }
            }
        }
        static bool ChecNo(string No)
        {
            if (!string.IsNullOrEmpty(No))
            {
                if(char.IsUpper(No[0])&& char.IsUpper(No[1])&& No.Length == 3)
                {
                    for (int i = 0; i < No.Length; i++)
                    {
                        if (char.IsDigit(No[i]))
                        {
                            return false;
                        }
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
