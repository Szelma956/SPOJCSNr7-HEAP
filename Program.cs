using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEAP
{

    class Heap
    {
        int heapSize;
        int lenght;
        int[] H;

        public Heap(int l, int heapData)
        {
            this.lenght = l;
            this.heapSize = heapData;
            this.H = new int[l];

        }

        public void Heapify(int a)
        {
            int largest;
            largest = H[0];

            largest = a;

            if (2 * a <= heapSize && H[2 * a] > H[largest])
            {
                largest = 2 * a + 1;
            }
            if (largest != a)
            {
                int memory = H[largest];
                H[largest] = H[a];
                H[a] = memory;
                Heapify(largest);
            }
                        
        }

        public void BuildHeap()
        {
            for(int i = 0; i < heapSize; i++) 
            {
                Heapify(i);
            }
        }

        public void Insert(int a)
        {
            int child;
            heapSize = heapSize + 1;
            child = heapSize;
            H[child] = a;

            while (child > 1 && H[child] > H[child / 2]) 
            {
                int memory = H[child];
                H[child] = H[child/2];
                H[child/2] = memory;
                child = child / 2;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
