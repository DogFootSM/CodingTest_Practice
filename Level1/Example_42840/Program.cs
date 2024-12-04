namespace Example_42840
{

    /// <summary>
    /// 날짜 : 2024-10-29
    /// 문제 : 모의고사
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42840#
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] answers)
        {
            int[] answer;

            //예제에서 제시한 패턴 배열
            int[] one = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            //최고 점수의 개수를 저장할 변수
            int count = 0;

            //최고 점수를 배열에 저장하기 위한 인덱스 변수
            int index = 0;

            //패턴 배열의 값을 저장할 변수
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            //최고 점수들을 저장할 리스트
            List<int> temp = new List<int>();
             
            //정답지의 길이만큼 반복
            for (int i = 0; i < answers.Length; i++)
            {
                //i % 배열의 Length의 나머지를 인덱스로 사용해서 패턴 반복
                //정답과 똑같으면 1점 누적
                num1 += one[i % one.Length] == answers[i] ? 1 : 0;

                num2 += two[i % two.Length] == answers[i] ? 1 : 0;

                num3 += three[i % three.Length] == answers[i] ? 1 : 0;

            }

            //각 점수들을 리스트에 저장
            temp.Add(num1);
            temp.Add(num2);
            temp.Add(num3);

            //리스트 중에서 가장 큰 값들과 같은 수의 개수
            count = temp.Where(x => x == temp.Max()).Count();
            
            //큰 값의 개수 만큼 배열 크기 선언
            answer = new int[count]; 

            
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] == temp.Max())
                {
                    answer[index++] = i + 1;
                }
            } 

            return answer;
        }
    }
}
