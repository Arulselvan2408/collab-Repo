using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Outparams
    {

        void Calculation(float n1, float n2, int l, out float s, out float p, out int c)
        {
            s = n1 + n2;
            p = n1 * n2;
            c = l* 2 * 8;
        }
        void StudentDetails(string Name,params string[]hobbies)
        {
            Console.WriteLine("name: {0}", Name);
            for (int i=0;i<3 ; i++)
            {
                Console.WriteLine(hobbies[i]);
            }

        }
        static void Main()
        {
            float Num1 = 10f, Num2 = 15f;
            int Len = 8;
            float sum = 0, product = 0;
            int cal = 0;
            Outparams obj = new Outparams();
            obj.Calculation(Num1, Num2, Len, out sum, out product, out cal);
            Console.WriteLine("Sum={0}\nProduct={1}\nCal={2}", sum, product, cal);
            

            obj.StudentDetails("Edward", "singing", "playing", "reading");
            Console.Read();


        }
    }
}
    

