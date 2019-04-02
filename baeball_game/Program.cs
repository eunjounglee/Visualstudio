using System;

namespace BaseBall
{
    class Program
    {
        static void Main(string[] args)
        { // 정답, 추측, 결과
          // 배열은 0부터 시작한다. 0붜 설정해보기
          // 1. (중복되지 않는 세 개의 0~9 사이의 정수로 이루어진 정답을 생성한다.
            Random random = new Random(); // Random이라는 공간을 만듬
                                          // Random random2; >> 공간을 만들지 않았음
            int answer0;
            int answer1;
            int answer2;
            while (true)
            {
                answer0 = random.Next(10);
                answer1 = random.Next(10);
                answer2 = random.Next(10);
                if (answer0 != answer1 && answer1 != answer2 && answer2 != answer0)
                    break;

            }
            //Console.WriteLine("[정답]");
            //Console.Write(answer0 + " "); = Console.WriteLine(answer0); => 오류. 지역변수라 answer0이라는 이름이 없음 
            //Console.Write(answer1 + " ");
            //Console.Write(answer2 + " ");
            //Console.WriteLine();

            int tryCount = 0;

            while (true)
            {
                tryCount++;
                // 2. 추측을 입력받는다.
                int guess0 = int.Parse(Console.ReadLine());
                int guess1 = Convert.ToInt32(Console.ReadLine());
                int guess2 = Convert.ToInt32(Console.ReadLine());
                //int guess0 := Console.ReadLine(); readline은 문자열구를 반환 ->숫자구로 바꿔야함

                // Console.WriteLine("[추측] ");
                // Console.Write(guess0 + " ");
                // Console.Write(guess1 + " ");
                // Console.Write(guess2 + " ");
                // Console.WriteLine();


                // 3. 정답과 추측을 비교하여 결과를 생성한다.

                int strike = 0;
                int ball = 0;
                int @out = 0;

                if (answer0 == guess0)
                    strike++;
                else if (answer0 == guess1 || answer0 == guess2)
                    ball++;
                else
                    @out++;

                if (answer1 == guess1)
                    strike++;
                else if (answer1 == guess2 || answer1 == guess0)
                    ball++;
                else
                    @out++;

                if (answer2 == guess2)
                    strike++;
                else if (answer2 == guess0 || answer2 == guess1)
                    ball++;
                else
                    @out++;

                // 4. 결과를 출력한다.
                Console.WriteLine($"S: {strike}, B: {ball}, O: {@out}"); // STRING INTERPOLATION

                // 5. 정답과 추측이 일치하지 않으면 2번으로 돌아간다.
                if (strike == 3)
                    break;
            }

            // 6. 정답을 맞추는데 소요된 시간을 출력하고 종료한다.
            Console.WriteLine($"S: 총 {tryCount} 번만에 출력하였습니다.");

        }
    }
}