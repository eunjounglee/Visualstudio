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


        static void Main(string[] args)
        { // 01. 정답, 추측, 결과
          // 01. 배열은 0부터 시작한다. 0부터 설정해보기
          // 1. (중복되지 않는 세 개의 0~9 사이의 정수로 이루어진 정답을 생성한다.

            Answer answer = new Answer();
            answer.Create();
            answer.Print();
            

            int tryCount = 0;

            //Random random = new Random();   // 02. Random이라는 공간을 만듬
                                              // 02. Random random2; >> 공간을 만들지 않았음
                                              // 04. 배열은 개발된지 너무 오래돼서 잘 쓰지 않음. 배열 말고 Collection (Datastructure)을 써야함
            //int[] answers = new int[constant.Digit]; // 04. 배열은 복수로!


            while (true)
            {
                tryCount++;
                // 2. 추측을 입력받는다.

                Guess guess = new Guess();
                guess.Input(); // int[] guesses = InputGuesses();
                guess.Print(); //PrintNumbers("[추측] ", guesses);


                // 3. 정답과 추측을 비교하여 결과를 생성한다.

                //int strike = 0;
                //int ball = 0;
                //int @out = 0;

                Result result = new Result();

                result.Calculate(answer, guess);

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