using System;
using System.Collections.Generic;

namespace Tasks
{
    public class MinCostClimbingStairsSolution
    {
        private readonly Dictionary<int, int> _memo = new Dictionary<int, int>();
        
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length < 2)
                return 0;
            return Dp(cost.Length, ref cost);
        }

        private int Dp(int i, ref int[] cost)
        {
            if (i < 2) return 0;
            if (!_memo.TryGetValue(i, out var result))
            {
                var takeOneStep = Dp(i - 1, ref cost) + cost[i - 1];
                var takeTwoStep = Dp(i - 2, ref cost) + cost[i - 2];
                result = Math.Min(takeOneStep, takeTwoStep);
                _memo.Add(i, result);
            }
            return result;
        }
        
        public int Tribonacci(int n) {
            var minArray = Math.Max(3, n);
        
            var dp = new int[minArray + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;
            for (var i = 3; i < dp.Length ; i++) {
                dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
            }
            return dp[n];
        }
        
        
        // public int MinCostClimbingStairs(int[] cost)
        // {
        //     if (cost.Length < 2)
        //         return 0;
        //
        //     var dp = new int[cost.Length + 1];
        //
        //     for (int i = 2; i < dp.Length; i++)
        //     {
        //         var takeOneStep = dp[i - 1] + cost[i - 1];
        //         var takeTwoStep = dp[i - 2] + cost[i - 2];
        //         dp[i] = Math.Min(takeOneStep, takeTwoStep);
        //     }
        //
        //     return dp[dp.Length - 1];
        // }
    }
}