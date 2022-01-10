using System.Collections.Generic;

namespace Tasks
{
    /// <summary>
    /// 212. Word Search II
    /// </summary>
    public class WordSearch2
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            var result = new List<string>();
            var height = board.Length;
            var width = board[0].Length;
            var letters = new Dictionary<char, List<string>>();
            for (var i = 0; i < words.Length; i++)
            {
                if (letters.ContainsKey(words[i][0]))
                {
                    letters[words[i][0]].Add(words[i]);
                }
                else
                {
                    letters.Add(words[i][0], new List<string>(){ words[i]});
                }
            }

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    if (letters.ContainsKey(board[i][j]))
                    {
                        for (var w = letters[board[i][j]].Count -1; w >= 0; w--)
                        {
                            var word = letters[board[i][j]][w];
                            if (Exists(board, word, 0, i, j))
                            {
                                result.Add(word);
                                letters[board[i][j]].RemoveAt(w);
                            }
                        }
                    }
                }
            }

            return result;
        }

        private bool Exists(char[][] board, string word, int pos, int i, int j)
        {
            if (board[i][j] != word[pos]) return false;
            
            if (pos == word.Length - 1) return true;

            var current = board[i][j];
            board[i][j] = ' ';

            var height = board.Length;
            var width = board[0].Length;
            
            var top = i - 1;
            if (top >= 0)
            {
                if (Exists(board, word, pos + 1, top, j))
                {
                    board[i][j] = current;
                    return true;
                }
            }
            var bottom = i + 1;
            if (bottom < height)
            {
                if (Exists(board, word, pos + 1, bottom, j))
                {
                    board[i][j] = current;
                    return true;
                }
            }
            var left = j - 1;
            if (left >= 0)
            {
                if (Exists(board, word, pos + 1, i, left))
                {
                    board[i][j] = current;
                    return true;
                }
            }
            var right = j + 1;
            if (right < width)
            {
                if (Exists(board, word, pos + 1, i, right))
                {
                    board[i][j] = current;
                    return true;
                }
            }
            board[i][j] = current;
            return false;
        }
    }
}