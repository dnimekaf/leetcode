using System.Collections.Generic;

namespace Tasks
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var height = matrix[0].Length;
            var elements = matrix.Length * height;
            var result = new List<int>();
            var direction = 0; // 0 to left // 1 to down // 2 to right // 3 to up 
            var xAxis = 0;
            var yAxis = 0;
            var borders = new [] { height - 1, matrix.Length - 1, 0 , 0 };

            while (result.Count < elements)
            {
                result.Add(matrix[yAxis][xAxis]);

                switch (direction)
                {
                    case 0: 
                        if (xAxis == borders[0])
                        {
                            direction = 1;
                            borders[3]++;
                            yAxis++;
                        }
                        else
                        {
                            xAxis++;
                        }

                        break;
                    case 1:
                        if (yAxis == borders[1])
                        {
                            direction = 2;
                            borders[0]--;
                            xAxis--;
                        }
                        else
                        {
                            yAxis++;
                        }

                        break;
                    case 2:
                        if (xAxis == borders[2])
                        {
                            direction = 3;
                            borders[2]++;
                            yAxis--;
                        }
                        else
                        {
                            xAxis--;
                        }

                        break;
                    case 3:
                        if (yAxis == borders[3])
                        {
                            direction = 0;
                            borders[1]--;
                            xAxis++;
                        }
                        else
                        {
                            yAxis--;
                        }

                        break;
                    
                }
            }

            return result;
        }
    }
}