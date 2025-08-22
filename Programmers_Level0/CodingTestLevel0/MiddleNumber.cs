namespace CodingTestLevel0
{
    internal class MiddleNumber
    {
        static void Main(string[] args)
        {   

            int[] array = { 10, 5, 1, -4, 9 };
            int temp = 0;

            //중앙값을 구하기 위한 인덱스
            int pivot = array.Length / 2;

            for(int i = 0; i < array.Length; i++)
            {
                //맨 처음부터 마지막 요소 -1까지 반복
                for(int j = 0; j < array.Length -1; j++)
                {
                    //j 번째 값이 j + 1 값보다 크다면 값을 교환해주어 정렬
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"array 배열의 중앙값 : {array[pivot]}");
        }
         


    }
}
