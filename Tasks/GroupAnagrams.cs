using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    /// <summary>
    /// 49. Group Anagrams
    /// </summary>
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, IList<string>>();
            for (var i = 0; i < strs.Length; i++)
            {
                var chars = strs[i].ToCharArray();
                Array.Sort(chars);
                var group = new string(chars);
                if (result.ContainsKey(group))
                {
                    result[group].Add(strs[i]);
                }
                else
                {
                    result.Add(group, new List<string>() { strs[i]});
                }
            }
            return result.Values.ToList();
        }
    }
}