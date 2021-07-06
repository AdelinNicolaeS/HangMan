using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Spanzuratoare
{
    public class Worker
    {
        private List<string> all_words = new List<string>();
        private void BuildInput()
        {
           
            string line;
  
            var file = new System.IO.StreamReader(@"test.txt");

            while ((line = file.ReadLine()) != null)
            {
                all_words.Add(line);
            }

            file.Close();
            
        }

        private List<char> PickWord()
        {
            var rnd = new Random();
            var index = rnd.Next(0, all_words.Count);
            return all_words[index].ToList();
        }

        private List<int> GetPositions(List<char> word, char ch)
        {
            // get occurencies of ch in word
            var positions = Enumerable.Range(0, word.Count)
             .Where(i => word[i] == ch)
             .ToList();
            return positions;
        }

        private void LetsPlay()
        {
            var toFind = PickWord();
            var notFound = toFind.Count;
            var mistakes = 0;
            var printer = new Printer();
            var output = Enumerable.Range(0, notFound).Select(x => '_').ToList();
            while (notFound > 0 && mistakes <= Utils.MAX_MISTAKES)
            {
                Console.WriteLine("Choose a character: ");
                var input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (toFind.Any(x => x == input))
                {
                    var positions = GetPositions(toFind, input);
                    
                    output = Enumerable.Range(0, output.Count).Select(x =>
                    {
                        if (positions.Contains(x))
                        {
                            return input;
                        } else
                        {
                            return output[x];
                        }
                    }).ToList();
                    notFound = output.Count(x => x == '_');
                } else
                {
                    mistakes++;
                }
                printer.PrintGame(mistakes, output);
            }
            
            if (notFound == 0)
            {
                Console.WriteLine(Utils.WINNER);
            } else
            {
                Console.WriteLine(Utils.LOSER);
            }
            Console.WriteLine(Utils.FINAL_ANSWER + new string(toFind.ToArray()));
        }

        public void Work()
        {
            BuildInput();
            LetsPlay();
        }
    }
}
