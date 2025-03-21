namespace C_ApplicationQuiz
{
    internal class Program
    {
        // 주어진 문자열 중 문자가 있는 인덱스를 구하는 함수를 작성하시오. 단 없을 경우 -1을 출력하시오.

        // 입력 : "abcdef", 'd'
        // 출력 : 3

        // 입력 : "Winner winner chicken dinner", 'c'
        // 출력 : 14

        // 입력 : "Not your lucky day", 'p'
        public static int FindKeyIndex(string text, char key)
        {
            char[] array = text.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (key == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // 주어진 숫자가 소수인지 판별하는 함수를 작성하시오.

        // 입력 : 7
        // 출력 : true

        // 입력 : 4
        // 출력 : false

        // 입력 : 1
        // 출력 : false
        public static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(29));
        }
    }
}
