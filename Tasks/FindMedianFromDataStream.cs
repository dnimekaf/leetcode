using System.Collections.Generic;

namespace Tasks
{
    public class MedianFinder
    {
        private Queue<int> minHeap, maxHeap;
        
        
        public MedianFinder()
        {
            minHeap = new Queue<int>();
            maxHeap = new Queue<int>();
        }
    
        public void AddNum(int num) {
            if (minHeap.Count > 0 && num < minHeap.Peek())
            {
                maxHeap.Enqueue(num);
                if (maxHeap.Count > minHeap.Count + 1)
                {
                    minHeap.Enqueue(maxHeap.Dequeue());
                }
            }
            else
            {
                minHeap.Enqueue(num);
                if (minHeap.Count > maxHeap.Count + 1)
                {
                    maxHeap.Enqueue(minHeap.Dequeue());
                }
            }
        }
    
        public double FindMedian()
        {
            int median;
            if (minHeap.Count < maxHeap.Count)
            {
                median = maxHeap.Dequeue();
            } else if (minHeap.Count < maxHeap.Count)
            {
                median = minHeap.Dequeue();
            }
            else
            {
                median = (minHeap.Dequeue() + maxHeap.Dequeue()) / 2;
            }
            return median;
        }
    }
}