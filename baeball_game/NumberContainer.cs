using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baeball_game
{
    class NumberContainer
    {
        public int[] numbers = new int[Constant.Digit];

        public int At(int index)
        {
            return numbers[index];
        }

        public void Print()
        {    // todu: 둘 중 하나만 출력해야함
            Console.WriteLine("[추측] ");
             //Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
