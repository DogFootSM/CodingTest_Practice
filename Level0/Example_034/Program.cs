namespace Example_034
{

    /// <summary>
    /// 날짜 : 2024-08-08
    /// 문제 : 배열 회전시키기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120844
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] numbers, string direction)
        {
            int[] answer = new int[] { };

            switch (direction)
            {

                case "right":
                    int endNum = numbers[numbers.Length - 1];

                    for (int i = numbers.Length - 2; i >= 0; i--)
                    {

                        numbers[i + 1] = numbers[i];

                        if (i == 0)
                        {
                            numbers[i] = endNum;
                        }

                    }

                    break;

                case "left":

                    int firstNum = numbers[0];

                    for (int i = 0; i < numbers.Length - 1; i++)
                    {

                        numbers[i] = numbers[i + 1];

                        if (i == numbers.Length - 2)
                        {
                            numbers[numbers.Length - 1] = firstNum;
                        }

                    }

                    break;
            }
            return numbers;
        }
    }
}
