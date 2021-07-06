using System;
using System.Collections.Generic;
using System.Text;

namespace Spanzuratoare
{
    interface IPrinter
    {
        void PrintGame(int Mistakes, List<char> output);
        void PrintNoMistakes();
        void PrintOneMistake();
        void PrintTwoMistakes();
        void PrintThreeMistakes();
        void PrintFourMistakes();
        void PrintFiveMistakes();
        void PrintSixMistakes();
    }
}
