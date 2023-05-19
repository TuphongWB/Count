using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    internal class Program
    {
        public class CharacterCounter
        {
            public static int CountCharacter(string str, char character)
            {
                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == character)
                    {
                        count++;
                    }
                }

                return count;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Enter a string: ");
                string inputString = Console.ReadLine();

                Console.WriteLine("Enter a character: ");
                char inputCharacter = Console.ReadLine()[0];

                int occurrenceCount = CountCharacter(inputString, inputCharacter);

                Console.WriteLine("The character '{0}' occurs {1} times in the string.", inputCharacter, occurrenceCount);

                Console.ReadKey();
            }
        }
    }
}
