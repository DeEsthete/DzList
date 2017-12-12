using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array.Add(rand.Next(50));
                Console.WriteLine(i + "-" + array[i]);
            }
            int max = -99999999, positionMax = -1;
            int secondMax = 0, positionSecondMax = -1;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] > max)
                {
                    positionSecondMax = positionMax;
                    secondMax = max;
                    positionMax = i;
                    max = array[i];
                }
            }
            int sumEven = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = sumEven + array[i];
                }
            }
            Console.WriteLine("Позиция являющегося вторым максимальным значением в коллекции; " + positionSecondMax);
            Console.WriteLine("Сумма всех элементов стоящих на четных позициях; " + sumEven);
            Console.ReadLine();
        }
    }
}
