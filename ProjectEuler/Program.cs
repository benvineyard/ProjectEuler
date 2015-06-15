using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidQuestion = false;
            short questionNumber = 0;

            while (!isValidQuestion)
            {
                Console.WriteLine("...:::Please enter the number of the ProjectEuler.net question you would like to see the answer for (1-510):  ");    
                isValidQuestion = short.TryParse(Console.ReadLine(), out questionNumber);

                if (isValidQuestion)
                    MenuRouter.Route(questionNumber);
            }
            
            Console.ReadKey();
        }
    }
}
