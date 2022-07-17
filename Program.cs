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
        int[] H;

        public Heap(int heapData)
        {
            this.heapSize = 0;
            this.H = new int[heapData];

        }
        public Heap(int[] tab)
        {
            H = tab;
            heapSize = tab.Length;
            BuildHeap();
        }

        public void Heapify(int a)
        {
            int largest;
            largest = a;
            int child1 = 2 * a + 1;
            int child2 = 2 * a + 2;

            if (child1 < heapSize && H[child1] < H[largest])
            {
                largest = child1;
            }
            if (child2 < heapSize && H[child2] < H[largest])
            {
                largest = child2;
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
            for (int i = heapSize - 1; i >= 0; i--) 
            {
                Heapify(i);
            }
        
        }

        public void Insert(int a)
        {
            heapSize++;
            int child;
            int parent;
            child = heapSize - 1;
            parent = (child - 1) / 2;
            H[child] = a;

            while (child > 0 && H[child] < H[parent])
            {
                int memory = H[child];
                H[child] = H[parent];
                H[parent] = memory;
                child = parent;
                parent = (child - 1) / 2;
            }

        }

        public void PrintHeap()
        {
            string line = string.Join(" ", H.Take(heapSize));
            Console.WriteLine(line);
        }

        public int ExtractHeap()
        {
            int result = H[0];
            heapSize = heapSize - 1;
            H[0] = H[heapSize];
            Heapify(0);
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int testNuber;
            int n;
            string line = Console.ReadLine();
            testNuber = int.Parse(line);

            for (int i = 0; i < testNuber; i++)
            {
                line = Console.ReadLine();
                n = int.Parse(line);

                int[] rawHeap = new int[n];

                for (int j = 0; j < n; j++)
                {
                    int heapObject;
                    line = Console.ReadLine();
                    heapObject = int.Parse(line);
                    rawHeap[j] = heapObject;
                }

                Heap heap = new Heap(rawHeap);

                Console.ReadLine();
                int scndTestNumber;
                line = Console.ReadLine();
                scndTestNumber = int.Parse(line);
                for (int k = 0; k < scndTestNumber; k++)
                {
                    line = Console.ReadLine();
                    if (string.Equals(line, "E"))
                    {
                        Console.WriteLine(heap.ExtractHeap());
                    }
                    else if (string.Equals(line, "P"))
                    {
                        heap.PrintHeap();
                    }
                }
                Console.ReadLine();

            }
        }
    }
}
