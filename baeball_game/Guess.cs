using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Guess : NumberContainer
    {

         public void Input()
        {
            for (int i = 0; i < numbers.Length; i++) // property
                numbers[i] = int.Parse(Console.ReadLine());
        }

    }
}
