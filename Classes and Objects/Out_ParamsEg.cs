using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class methodsParamsEg
    {
        void Calculation(float n1, float n2, Int l, out float s, out float p, out int c)
        {
            sum = n1+ n2;
            product = n1 * n2;
            c = l = 2 * 8;
            
        }
        static void Main()
        {
            float Num1 = 10f, Num2 = 15f;
            int l = 8;
            float sum = 0, product = 0;
            int cal = 0;
            methodsParamsEg obj = new methodsParamsEg();
            Console.WriteLine( obj.Calculation(Num1, Num2, l, sum, product, cal));
            console.WriteLine("For jenkins checking");
            conole.writeLine("Changes made by Manasvini");
            Console.Read();

            
        }
    }
}
