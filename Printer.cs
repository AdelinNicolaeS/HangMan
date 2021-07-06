using System;
using System.Collections.Generic;
using System.Text;

namespace Spanzuratoare
{
    public class Printer : IPrinter
    {
        public void PrintGame(int mistakes, List<char> output)
        {
            switch (mistakes)
            {
                case 0:
                    PrintNoMistakes();
                    break;
                case 1:
                    PrintOneMistake();
                    break;
                case 2:
                    PrintTwoMistakes();
                    break;
                case 3:
                    PrintThreeMistakes();
                    break;
                case 4:
                    PrintFourMistakes();
                    break;
                case 5:
                    PrintFiveMistakes();
                    break;
                case 6:
                    PrintSixMistakes();
                    break;
                default:
                    Console.WriteLine(Utils.ERROR);
                    break;
            }
            output.ForEach(x => Console.Write(x));
            Console.WriteLine();
        }

        public void PrintNoMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             \n" +
                              "|                             \n" +
                              "|                            \n" +
                              "|                             \n" +
                              "|                                  \n" +
                              "|                                 \n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                \n" +
                              "|                               \n" +
                              "|                              \n");
        }
        public void PrintOneMistake()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n");
        }
        public void PrintTwoMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 / \n" +
                              "|                                /   \n" +
                              "|                               /     \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n");
        }
        public void PrintThreeMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 / \\\n" +
                              "|                                /   \\\n" +
                              "|                               /     \\\n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                  \n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n");
        }
        public void PrintFourMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 / \\\n" +
                              "|                                /   \\\n" +
                              "|                               /     \\\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                 \n" +
                              "|                                \n" +
                              "|                               \n");
        }
        public void PrintFiveMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 / \\\n" +
                              "|                                /   \\\n" +
                              "|                               /     \\\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                 / \n" +
                              "|                                /   \n" +
                              "|                               /     \n");
        }
        public void PrintSixMistakes()
        {
            Console.WriteLine("-----------------------------------\n" +
                              "|                                  |\n" +
                              "|                             ------------\n" +
                              "|                             |  -    -  |\n" +
                              "|                             |    -     |\n" +
                              "|                             ------------\n" +
                              "|                                  |\n" +
                              "|                                  | \n" +
                              "|                                 / \\\n" +
                              "|                                /   \\\n" +
                              "|                               /     \\\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                  |\n" +
                              "|                                 / \\\n" +
                              "|                                /   \\\n" +
                              "|                               /     \\\n");
        }
    }
}
