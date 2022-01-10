    
namespace Tasks
{
    /// <summary>
    /// 79. Word Search
    /// </summary>
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (Exists(board, word, i, j, 0))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool Exists(char[][] board, string word, int i, int j, int wordPos) 
        {
            if (board[i][j] != word[wordPos]) return false;

            if (word.Length - 1 == wordPos) return true;

            var prev = board[i][j];
            board[i][j] = ' ';
            
            var height = board.Length;
            var width = board[0].Length;
           
            var top = i - 1;
            if (top >= 0)
            {
                if (Exists(board, word, top, j, wordPos + 1))
                {
                    return true;
                }
            }
            
            var bottom = i + 1;
            if (bottom < height)
            {
                if (Exists(board, word, bottom, j, wordPos + 1))
                {
                    return true;
                }
            }
            
            var left = j - 1;
            
            if (left >= 0)
            {
                if (Exists(board, word, i, left, wordPos + 1))
                {
                    return true;
                }
            }
            var right = j + 1;
            
            if (right < width)
            {
                if (Exists(board, word, i, right, wordPos + 1))
                {
                    return true;
                }
            }

            board[i][j] = prev;

            return false;
        }
    }
}