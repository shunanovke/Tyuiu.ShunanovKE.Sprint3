using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShunanovKE.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int cnt = 0;
            bool LastSymbIs = false;
            foreach(char ch in value)
            {
                if (ch == item)
                {
                    if (LastSymbIs)
                    {
                        cnt += 1;
                    }
                    LastSymbIs = true;
                }
                else LastSymbIs = false;
            }
            return cnt;
        }
    }
}
