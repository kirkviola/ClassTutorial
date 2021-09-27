using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    class MathLib
    {
        public MathLib()
        {

        }
        public int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public int Sub(int Num1, int Num2)
        {
            return Num1 - Num2;
        }
        public int Mult(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        public int Div(int Num1, int Num2)
        {
            
                if (Num2 == 0)
                {
                    Console.WriteLine("One does not simply divide by 0.");
                    return 0;
                }
            return Num1 / Num2;
               
        }
        public int Inc(int Num)
        {
            return Num + 1;
        }
        public int Mod(int Num1, int Num2)
        {
            return Num1 - Num1 / Num2 * Num2;
        }
    }

}
