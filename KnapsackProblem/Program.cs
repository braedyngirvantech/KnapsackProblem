using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            List<Item> items = new List<Item> {new Item(23,92), new Item(31,57), new Item(29,49), new Item(44,68),
                new Item(53,60), new Item(38,43), new Item(63,67),new Item(85,84), new Item(89,87), new Item(82,72)};
            int[] values = new int[limit + 1];

            for (int a = 0; a <= limit; a++)
            {
                values[a] = 0;
            }

            foreach (Item i in items)
            {
                for (int weightOne = 0; weightOne + i.weight <= limit; weightOne++)
                {
                    int weightTotal = weightOne + i.weight;
                    int valueTotal = values[weightOne] + i.value;
                    values[weightTotal] = Math.Max(values[weightTotal], valueTotal);
                }
            }

            Console.WriteLine(values[limit]);
            Console.Read();
        }
    }

    class Item
    {
        public int weight, value;

        public Item(int setWeight, int setValue)
        {
            weight = setWeight;
            value = setValue;
        }
    }
}
