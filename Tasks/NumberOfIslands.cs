namespace Tasks
{
    // 200. Number of Islands
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        result++;
                        MarkColumn(grid, i, j, grid[0].Length);
                        MarkRow(grid, i, j, grid[0].Length);
                    }
                }
            }
            return result;
        }
        
        
        private void MarkColumn(char[][] grid, int row, int col, int width)
        {
            grid[row][col] = '2';
            var top = row - 1;
            while (top >= 0 && grid[top][col] == '1')
            {
                grid[top][col] = '2';
                MarkRow(grid, top, col, width);
                top--;
            }

            var bottom = row + 1;
            while (bottom < grid.Length && grid[bottom][col] == '1')
            {
                grid[bottom][col] = '2';
                MarkRow(grid, bottom, col, width);
                bottom++;
            }
        }

        private void MarkRow(char[][] grid, int row, int col, int width)
        {
            grid[row][col] = '2';
            var left = col - 1;
            while (left >= 0 && grid[row][left] == '1')
            {
                grid[row][left] = '2';
                MarkColumn(grid, row, left, width);
                left--;
            }

            var right = col + 1;
            while (right < width && grid[row][right] == '1')
            {
                grid[row][right] = '2';
                MarkColumn(grid, row, right, width);
                right++;
            }
        }
    }
}