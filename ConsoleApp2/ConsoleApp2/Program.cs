using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.(vhod ot konsola celi chisla) List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //2.(pechat na nums             ) Console.WriteLine(string.Join(", ", nums));

            // char[] el = Console.ReadLine().ToCharArray();    =>Vavedeniqt STRING se prevrashta v masiv ot CHAR elementi

            //1. (vhod ot konsola stringove ) List<string> chisla = Console.ReadLine().Split(' ').ToList();
            //2.(pechat na nums             ) Console.WriteLine(string.Join(", ", chisla));

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.Write("Pechat na elementi NUMS:   ");
            Console.WriteLine(string.Join(", ", nums));
           
            


                nums.Reverse();
                Console.Write("Pechat na obarnati elementi NUMS:  ");
                Console.WriteLine(string.Join(", ", nums));

                nums.Sort();
                Console.Write("Pechat na sortirani elementi NUMS:  ");
                Console.WriteLine(string.Join(", ", nums));

                int Sum = nums.Sum();
                Console.Write("Sumata na elementite :  ");
                Console.WriteLine(Sum);

                int Min = nums.Min();
                Console.Write("Minimalniqt element e:   ");
                Console.WriteLine(Min);

                int Max = nums.Max();
                Console.Write("Maksimalniqt  element e:   ");
                Console.WriteLine(Max);

                Console.WriteLine("Izberete koe chislo da vmakvate na posledna poziciq");
                int LastNumber = int.Parse(Console.ReadLine());
                nums.Add(LastNumber);
                Console.WriteLine("Pechat s posledniqt vmaknat element: ");
                Console.WriteLine(string.Join(",", nums));

                Console.WriteLine("Izberete koe chislo da vmakvate");
                int RandomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Izberete poziciq");
                int PositionNumber = int.Parse(Console.ReadLine());
                nums.Insert(PositionNumber, RandomNumber);
                Console.WriteLine("Pechat s vmaknat element:{0} ", RandomNumber, "na posiciq {1}", PositionNumber);
                Console.WriteLine(string.Join(",", nums));

                Console.WriteLine("Izberete koe chislo da iztrivate");
                int DeleteChislo = int.Parse(Console.ReadLine());
                nums.Remove(DeleteChislo);
                Console.WriteLine("Izbrahte chislot :{0} ", DeleteChislo, "da bade iztrito");
                Console.WriteLine(string.Join(",", nums));

                int CountEl = nums.Count();
                Console.WriteLine("Broqt na elementite e: {0}", CountEl);
          
            
        }
        
    }
}
