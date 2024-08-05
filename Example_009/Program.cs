namespace Example_009
{
    public class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            //정의되어 있는 메소드를 활용
            int[] answer = numbers.Skip(num1).Take((num2 - num1) + 1).ToArray();

            return answer;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //인덱스를 직접 잘라서 활용
            int num1 = 1;
            int num2 = 3;
            
            int[] arr = { 1, 2, 3, 4, 5 };
            int index = (num2 - num1) + 1;
            int[] arr2 = new int[index];
            int count = 0;

            for(int i = num1; i <= index; i++)
            {
                arr2[count] = arr[i];
                count++;
            } 
        }
    }
}
