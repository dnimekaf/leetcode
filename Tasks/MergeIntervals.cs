using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (ints, ints1) => ints[0].CompareTo(ints1[0]));
            
            var result = new List<int[]>();            
            for (var i = 0; i < intervals.Length; i++)
            {
                var current = intervals[i];
                for (var j = i+1; j < intervals.Length; j++)
                {
                    var tested = intervals[j];
                    var joined = false;
                    
                    // overlaps
                    if(current[0] <= tested[0] && current[1] >= tested[1])
                    {
                        joined = true;
                    }

                    if (current[0] <= tested[0] && current[1] >= tested[0])
                    {
                        joined = true;
                        if (tested[1] > current[1]) current[1] = tested[1];
                    }

                    if (joined) i++;
                }
                result.Add(current);
            }

            return result.ToArray();
        }
    
    }
}