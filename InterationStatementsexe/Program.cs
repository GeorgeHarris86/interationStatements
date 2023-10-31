using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace InterationStatementsexe
{

    class program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);



            while (num < 200)
            {
                num++;
                numbers.Add(num);

            }

            Console.WriteLine("Increase:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)

            {

                Console.WriteLine(i);
            }

        }
             
                  
             
        
    }
}
