using System;
using System.Collections.Generic;

namespace Tasks
{
    public class DeleteAndEarnSolution
    {
        private readonly Dictionary<int, int> _memo = new Dictionary<int, int>();
        private readonly HashSet<int> _removed = new HashSet<int>();
      
        public int DeleteAndEarn(int[] nums)
        {
            Array.Sort(nums);
            return Sum(nums.Length - 1,  ref nums);
        }

        private int Sum(int i,  ref int[] nums)
        {
            if (i < 0) return 0;
            var val = nums[i];
            
            var current = GetSum(val, ref nums);
            if (current >= Sum(val - 1, ref nums))
            {
                _removed.Add(val - 1);
            }

            return current + Sum(i - 1, ref nums);
        }

        private int GetSum(int val, ref int[] nums)
        {
            if (_removed.Contains(val)) return 0;
            if (!_memo.ContainsKey(val))
            {
                int sum = 0;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val) sum += val;
                }

                _memo.Add(val, sum);
            }
            return _memo[val];
        }
    }
}