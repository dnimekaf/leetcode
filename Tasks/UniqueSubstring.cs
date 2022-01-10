using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class UniqueSubstring
    {
        public void Test()
        {
            var zero = LengthOfLongestSubstring("");
            if (zero != 0) throw new Exception("not zero");
            var pwwkew = LengthOfLongestSubstring("pwwkew");
            if (pwwkew != 3) throw new Exception("not pwwkew");
            var bbbbb = LengthOfLongestSubstring("bbbbb");
            if (bbbbb != 1) throw new Exception("not bbbbb");
            var abcabcbb = LengthOfLongestSubstring("abcabcbb");
            if (abcabcbb != 3) throw new Exception("not abcabcbb");
            var empty = LengthOfLongestSubstring(" ");
            if (empty != 1) throw new Exception("not empty");
        }
        
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int maxLength = 0;
      
            for (var i = 0; i < s.Length; i++)
            {
                if (s.Length - maxLength < 0) 
                {
                    break;
                }
                var strHash = new HashSet<char>();
                for (var j = i; j < s.Length; j++ ) 
                {
                    if (strHash.Contains(s[j]))
                    {
                        break;
                    }
                    strHash.Add(s[j]);
                }

                if (strHash.Count > maxLength)
                {
                    maxLength = strHash.Count;
                }
            }

            return maxLength;
        }
    }
}