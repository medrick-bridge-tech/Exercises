using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private static string[] _group;

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("How many Sub-String do you want to enter: ");
                try
                {
                    var groupSize = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    _group = new string[groupSize];
                    for (var index = 0; index < groupSize; index++)
                    {
                        Console.Write("How many Char do you want to enter for this index : ");
                        try
                        {
                            var subStringSize = int.Parse(Console.ReadLine()?? throw new InvalidOperationException());
                            if (subStringSize < 2)
                            {
                                Console.WriteLine("The Limit is at least 2 chars Enter Again");
                                index--;
                            }
                            else
                            {
                                _group[index] = (Console.ReadLine()?? throw new InvalidOperationException()).ToLower();
                                if (_group[index].Length > subStringSize ||
                                    (!_group[index].Contains('a') && !_group[index].Contains('b') && !_group[index].Contains('c')))
                                {
                                    index--;
                                    Console.WriteLine("Entered string is invalid do it again");
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid Format try again");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Format try again");
                }

                if (_group == null) continue;
                foreach (var subString in _group)
                {
                    var minCount = int.MaxValue;
                    var minSubString = "";
                    var found = false;
                    for (var i = 0; i < subString.Length; i++)
                    {
                        for (var j = i + 2; j <= subString.Length; j++)
                        {
                            var currentSubString = subString.Substring(i, j - i);
                            var aCount = currentSubString.Count(c => c == 'a');
                            var bCount = currentSubString.Count(c => c == 'b');
                            var cCount = currentSubString.Count(c => c == 'c');
                            if (aCount <= bCount || aCount <= cCount || currentSubString.Length >= minCount) continue;
                            minCount = currentSubString.Length;
                            minSubString = currentSubString;
                            found = true;
                        }
                    }

                    if (found)
                    {
                        Console.WriteLine(minSubString + " with the size of : " + minCount);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
            }
        }
    }
}