using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Guess
    {
        public int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            return numbers[index];
        }
        public void Input()
        {
            for (int i = 0; i < numbers.Length; i++) // property
                numbers[i] = int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("[추측] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
