using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02HOL006
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class T02HOL006
    {
        public int Divide(int dividend, int devisor)
        {
            try
            {
                return dividend / devisor;
            }
            catch
            {
                throw new DivideByZeroException("You are trying to divide by zero");
            }
        }
    }
}
