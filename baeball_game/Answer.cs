using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Answer : NumberContainer
    {

        public int At(int index)
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

                // todo: 나중에 수정하겠다능
                if (numbers[0] != numbers[1] && numbers[1] != numbers[2] && numbers[2] != numbers[0])
                    break;
            }
        }
    }
}
