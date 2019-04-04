using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Answer
    {
        private int[] numbers = new int[Constant.Digit];
        public int At(int index) //몇번 째 어디에 위히 해 있는
        {
            return numbers[index];
        }

        public void Create()
        {
            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < Constant.Digit; i++)
                    numbers[i] = random.Next(Constant.MaxValue);

                // todo: 
                if (numbers[0] != numbers[1] && numbers[1] != numbers[2] && numbers[2] != numbers[0])
                    break;
            }
        }

        public void Print()
        {
            Console.WriteLine("[정답] ");
            for (int i = 0; i < Constant.Digit; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();
        }
    }
}
