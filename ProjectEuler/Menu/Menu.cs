using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Menu
    {
        internal static void Show()
        {
            bool isValidQuestionNumber = false;
            short castedNumber = 0;

            while (!isValidQuestionNumber)
            {
                Console.Clear();
                Console.WriteLine("...:::Please enter the number of the ProjectEuler.net question you would like to see the answer for (1-510) or hit CTRL + C to quit:::...");

                isValidQuestionNumber = IsValidQuestionNumber(Console.ReadLine(), out castedNumber);

                if (isValidQuestionNumber)
                    MenuRouter.Route(castedNumber);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*****The key entered is an invalid character.  Only numbers 1-510 are allowed!*****");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine();
                Console.WriteLine("Hit ENTER to continue or CTRL + C to quit.");
                Console.ReadLine();

                isValidQuestionNumber = false;
            }
        }

        private static bool IsValidQuestionNumber(string questionNumber, out short castedNumber)
        {
            return short.TryParse(questionNumber, out castedNumber);
        }
    }
}
