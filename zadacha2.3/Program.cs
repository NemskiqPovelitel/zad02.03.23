using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Vuvedi elementite na spisuka:");
            string[] input = Console.ReadLine().Split();
            foreach (string s in input)
            {
                list.Add(int.Parse(s));
            }

            Console.WriteLine($"Broi elementi v spisuka: {list.Count}");

            Console.WriteLine("Vuvedi elementite na masivi:");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            list.AddRange(array);
            list.Sort();

            Console.WriteLine($"Sortiran spisuk: {string.Join(", ", list)}");

            Console.Write("Vuvedi chislo za proverka: ");
            int number = int.Parse(Console.ReadLine());
            if (list.Contains(number))
            {
                int index = list.IndexOf(number);
                Console.WriteLine($"Chisloto {number} go ima na indeksa {index}");
            }
            else
            {
                Console.WriteLine($"Chisoloto {number} go nqma v spisuka");
            }


            Console.WriteLine("Vuvedi elementite na vtoriq masiv:");
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list.InsertRange(3, array2);
            Console.WriteLine(list);

            list.Sort();
            Console.WriteLine($"Spisukut sled vtoriq masiv: {string.Join("*", list)}" );
        }
    }
}
