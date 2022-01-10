namespace Tasks
{
    public class RotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == target) return 0;
                return -1;
            }

            var pivot = 0;
            
            var last = nums[nums.Length - 1];
            if (last - nums[0] < 0)
            {
                // pivoted
                var ps = 0;
                var pe = nums.Length -1 ;
                while (ps <= pe)
                {
                    var pm = (pe - ps) / 2 + ps;
                    if (nums[pm] > nums[pm + 1])
                    {
                        pivot = pm + 1;
                        break;
                    }
                    if (nums[pm] > last)
                    {
                        ps = pm + 1;
                    }
                    else
                    {
                        pe = pm - 1;
                    }
                }
            }
            
            var start = 0;
            var end = nums.Length;

            while (start <= end)
            {
                var m = (end - start) / 2 + start;
                var eMiddle = m + pivot;
                if (eMiddle > nums.Length - 1) eMiddle -= nums.Length;

                if (nums[eMiddle] == target) return eMiddle;
                if (nums[eMiddle] < target)
                {
                    start = m + 1; 
                }
                else
                {
                    end = m - 1;
                }
            }
            return -1;
        }
    }
}