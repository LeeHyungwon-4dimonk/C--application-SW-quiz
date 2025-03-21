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

        static void Main(string[] args)
        {
            Console.WriteLine(FindKeyIndex("abcdef", 'd'));
        }
    }
}
