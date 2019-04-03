using System;
// 04. 배열의 특징은 순서대로 저장되는것
namespace BaseBall
{
    class Program
    {
        /// <summary>
        /// 숫자 배열을 출력한다.
        /// </summary>
        /// <param name="prefix">숫자 출력 전에 출력할 문자열</param>
        /// <param name="numbers">출력할 숫자</param>
        static void PrintNumbers(string prefix, int[] numbers)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < constant.Digit; i++)
                Console.WriteLine(numbers[i] + " ");
             Console.WriteLine();

            //Console.WriteLine("[추측] ");
            //for (int i = 0; i < constant.Digit; i++)
            //    Console.WriteLine(guesses[i] + " ");
            //Console.WriteLine();
        }

        //const int MaxValue = 10; //03. 코드의 가독성이 좋아짐
        //const int Digit = 3; //03. find all reference : Digit가 사용된 모든 레코드를 보여줌

        static void Main(string[] args)
        { // 01. 정답, 추측, 결과
          // 01. 배열은 0부터 시작한다. 0부터 설정해보기
          // 1. (중복되지 않는 세 개의 0~9 사이의 정수로 이루어진 정답을 생성한다.
            Random random = new Random();   // 02. Random이라는 공간을 만듬
                                            // 02. Random random2; >> 공간을 만들지 않았음
                                            // 04. 배열은 개발된지 너무 오래돼서 잘 쓰지 않음. 배열 말고 Collection (Datastructure)을 써야함
            int[] answers = new int[constant.Digit]; // 04. 배열은 복수로!

            while (true)
            {
                // 04. int i = 0;
                // 04. while (i<Digit)
                // 04. {
                // 04.     answers[i] = random.Next(MaxValue);
                // 04.     i++; //i +=1 // i = i +  1
                // 04. }
                for (int j = 0; j < constant.Digit; j++)
                    // { 04. 한줄일때는 {} 생략 가능
                    answers[j] = int.Parse(Console.ReadLine());
                // }
                if (answers[0] != answers[1] && answers[1] != answers[2] && answers[2] != answers[0]) //todo: 04. 이 로직은 어려움. 나중에 수정!!! view<testlist
                    break;

            }
            //02. Console.WriteLine("[정답]");
            //02. Console.Write(answer0 + " "); = Console.WriteLine(answer0); => 오류. 지역변수라 answer0이라는 이름이 없음 
            //02. Console.Write(answer1 + " ");
            //02. Console.Write(answer2 + " ");
            //02. Console.WriteLine();

            //Console.WriteLine("[정답]");
            //for (int i = 0; i < constant.Digit; i++)
            //    Console.WriteLine(answers[i] + " ");
            // Console.WriteLine();

            PrintNumbers("[정답] ", answers);

            int tryCount = 0;

            while (true)
            {
                tryCount++;
                // 2. 추측을 입력받는다.

                int[] guesses = new int[constant.Digit];
                for (int i = 0; i < constant.Digit; i++) // 04. for (int i = 0; i < guesses.Length; i++)  Length : property, Digit의 길이를 나타내주는것
                    guesses[i] = int.Parse(Console.ReadLine());

                PrintNumbers("[추측] ", guesses);

                //Console.WriteLine("[추측] ");
                //for (int i = 0; i < constant.Digit; i++)
                //   Console.WriteLine(guesses[i] + " ");
                //Console.WriteLine();


                // 03. int guess0 := Console.ReadLine(); readline은 문자열구를 반환 ->숫자구로 바꿔야함
                // 02. Console.WriteLine("[추측] ");
                // 02. Console.Write(guess0 + " ");
                // 02. Console.Write(guess1 + " ");
                // 02. Console.Write(guess2 + " ");
                // 02. Console.WriteLine();


                // 3. 정답과 추측을 비교하여 결과를 생성한다.

                //int strike = 0;
                //int ball = 0;
                //int @out = 0;

                Result result = new Result();

                //   for (int i = 0; i < Digit; i ++)
                //   {
                //       int j = (i + 1) % Digit;
                //       int k = (i + 2) % Digit;
                //           if (answers[i] == guesses[i])
                //               result.Strike++;
                //          else if (answers[i] == guesses[j] || answers[i] == guesses[k])
                //              result.Ball++;
                //          else
                //              result.Out++;
                //  }

                result.Calculate(answers, guesses);

                // 4. 결과를 출력한다.
                //Console.WriteLine($"S: {result.Strike}, B: {result.Ball}, O: {result.Out}"); // STRING INTERPOLATION
                result.Print();

                // 5. 정답과 추측이 일치하지 않으면 2번으로 돌아간다.
                if (result.IsCorrect())
                    break;
            }

            // 6. 정답을 맞추는데 소요된 시간을 출력하고 종료한다.
            Console.WriteLine($"S: 총 {tryCount} 번만에 출력하였습니다.");
        }
    }
}