using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBall
{
    class Result
    {
        public int Strike;// internal은 public과 protected 사이에 있는 것. Public은 버그에 취약함.
        public int Ball;
        public int Out;//@없는 이유는 앞에 대문자이기 때문에

        public bool IsCorrect() //true 또는 fals만 가지는
        { //엄청 복잡한 로직
          // todo : 하드 코드 제거해야 함
            return Strike == Constant.Digit;
        }

        internal void Print()
        {
            Console.WriteLine($"S: {Strike}, B: {Ball}, O: {Out}"); // string interpolation
        }
        public void Calculate(Answer answer, Guess guesse)
        {
            for (int i = 0; i < Constant.Digit; i++)
            {
                int j = (i + 1) % Constant.Digit;
                int k = (i + 2) % Constant.Digit;

                if (answer.At(i) == guesse.At(i))
                    Strike++;
                else if (answer.At(i) == guesse.At(j) || answer.At(i) == guesse.At(k))
                    Ball++;
                else
                    Out++;
            }
        }
    }
}
