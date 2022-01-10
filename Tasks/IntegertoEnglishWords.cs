using System.Collections.Generic;

namespace Tasks
{
    /// <summary>
    /// 273.  Integer to English Words  
    /// </summary>
    public class IntegerToEnglishWords
    {
        public string NumberToWords(int num)
        {
            var parts = new List<string>();
            if (num == 0) return _words[0];
            
            Decimals(num, parts);
            Hundreds(num, parts);

            long toAdd = 1000;
            
            while (toAdd <= num)
            {
                var workingNum = num / toAdd;

                var before = parts.Count;
                parts.Add(_words[toAdd]);
                
                Decimals((int)workingNum, parts);
                Hundreds((int)workingNum, parts);

                if (before + 1 == parts.Count)
                {
                    parts.RemoveAt(parts.Count - 1);
                }

                toAdd *= 1000;
            }

            parts.Reverse();
            return string.Join(" ", parts);
        }

        private void Hundreds(int num, List<string> parts)
        {
            var hundreds = num % 1000;
            var amount = hundreds / 100;
            if (amount != 0)
            {
                parts.Add(_words[100]);
                parts.Add(_words[amount]);
            }
        }
        private void Decimals(int num, List<string> parts)
        {
            var d = num % 100;
            if (d == 0) return;
            if (d <= 20)
            {
                parts.Add(_words[d]);
            }
            else
            {
                var last = d % 10;
                var first = d - last;
                if (last != 0)
                {
                    parts.Add(_words[last]);
                }

                if (first != 0)
                {
                    parts.Add(_words[first]);
                }
            }
        }

        private Dictionary<long, string> _words = new()
        {
            {0, "Zero"},
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},
            {10, "Ten"},
            {11, "Eleven"},
            {12, "Twelve"},
            {13, "Thirteen"},
            {14, "Fourteen"},
            {15, "Fifteen"},
            {16, "Sixteen"},
            {17, "Seventeen"},
            {18, "Eighteen"},
            {19, "Nineteen"},
            {20, "Twenty"},
            {30, "Thirty"},
            {40, "Forty"},
            {50, "Fifty"},
            {60, "Sixty"},
            {70, "Seventy"},
            {80, "Eighty"},
            {90, "Ninety"},
            {100, "Hundred"},
            {1000, "Thousand"},
            {1_000_000, "Million"},
            {1_000_000_000, "Billion"}
        };
    }
}