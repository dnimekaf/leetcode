using System.Collections.Generic;

namespace Tasks
{
    public class LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            for (var i = 0; i < digits.Length; i++)
            {
                result = Combine(result, digits[i]);
            }
            return result;
        }

        private List<string> Combine(List<string> previous, char digit)
        {
            List<string> newResult = previous.Count == 0
                ? new(_digits[digit].Count)
                : new(_digits[digit].Count * previous.Count);

            for (var i = 0; i < _digits[digit].Count; i++)
            {
                if (previous.Count == 0)
                {
                    newResult.Add(_digits[digit][i].ToString());
                }
                else
                {
                    for (var j = 0; j < previous.Count; j++)
                    {
                        newResult.Add(string.Concat(previous[j], _digits[digit][i]));
                    }
                }
            }
            return newResult;
        }

        private Dictionary<char, List<char>> _digits = new Dictionary<char, List<char>>()
        {
            {'2', new List<char>(){'a','b','c'}},
            {'3', new List<char>(){'d','e','f'}},
            {'4', new List<char>(){'g','h','i'}},
            {'5', new List<char>(){'j','k','l'}},
            {'6', new List<char>(){'m','n','o'}},
            {'7', new List<char>(){'p','q','r', 's'}},
            {'8', new List<char>(){'t','u','v'}},
            {'9', new List<char>(){'w','x','y','z'}},
        };
    }
}