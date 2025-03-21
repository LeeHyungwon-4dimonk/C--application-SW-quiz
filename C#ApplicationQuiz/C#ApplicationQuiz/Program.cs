using System.ComponentModel.Design;
using System.Numerics;

namespace C_ApplicationQuiz
{
    internal class Program
    {
        #region FindKeyIndex

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

        #endregion

        #region IsPrime

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

        #endregion

        #region SumOfDigits
        
        // 주어진 숫자의 각 자리수의 합을 구하는 함수를 작성하시오

        // 입력 : 18234
        // 출력 : 18

        // 입력 : 3849
        // 출력 : 24

        // 입력 : 12345
        // 출력 : 15

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while(true)
            {
                sum += number % 10;
                number /= 10;
                if (number / 10 == 0)
                {
                    sum += number % 10;
                    break;
                }
                    
            }
            return sum;
        }

        #endregion

        #region FindClosestNumber
        
        // 주어진 배열에서 주어진 숫자와 가장 가까운 수를 구하는 함수를 작성하시오.

        // 입력 : { 3, 10, 28 }, 20
        // 출력 : 28

        // 입력 : { 10, 11, 12 }, 15
        // 출력 : 12

        // 입력 : { 1, 2, 3, 4, 5 }, 3
        // 출력 : 3

        public static int FindClosestNumber(int[] array, int number)
        {
            int answer = number - array[0];
            int comparison = 0;
            if (answer < 0)
            {
                answer = -answer;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (number - array[i] < 0)
                {
                    comparison = array[i] - number;
                }
                else
                {
                    comparison = number - array[i];
                }

                if (answer > comparison)
                {
                    answer = comparison;
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                if (answer == 0)
                {
                    answer = number;
                    break;
                }
                else if(array[i] == number + comparison)
                {
                    answer = number + comparison;
                }
                else if (array[i] == number - comparison)
                {
                    answer = number - comparison;
                }                
            }
            return answer;
        }

        #endregion

        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 11, 12 };
            Console.WriteLine(FindClosestNumber(array, 15));
        }
    }
}