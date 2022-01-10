using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    /// <summary>
    /// 253. Meeting Rooms II
    /// </summary>
    public class MeetingRooms2
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, (ints, ints1) => ints[0].CompareTo(ints1[0]));

            var rooms = new List<int>();
            
            for (var i = 0; i < intervals.Length; i++)
            {
                var current = intervals[i];
                // looking for a free room
                var found = false;
                for (var r = 0; r < rooms.Count; r++)
                {
                    if (rooms[r] <= current[0])
                    {
                        found = true;
                        rooms[r] = current[1];
                        break;
                    }
                }

                if (!found)
                {
                    rooms.Add(current[1]);
                }
            }

            return rooms.Count;
        }

     
    }
}