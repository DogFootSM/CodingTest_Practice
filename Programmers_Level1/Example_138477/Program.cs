namespace Example_138477
{

    /// <summary>
    /// 날짜 : 2024-10-27
    /// 문제 : 명예의 전당 (1)
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/138477
    /// </summary>
    public class Solution
    {
        public int[] solution(int k, int[] score)
        {

            int[] answer = new int[score.Length];
            
            //최하위 점수를 확인할 List
            List<int> minScore = new List<int>();

            for (int i = 0; i < score.Length; i++)
            {
                //List의 개수가 K보다 작을 경우 List에 추가
                if (minScore.Count < k)
                {
                    minScore.Add(score[i]);

                }
                else
                {
                    //List의 개수가 k보다 클 경우 저장할 값이 list의 가장 작은 값보다 클 경우 리스트 0 번째에 값 추가
                    if (score[i] > minScore.Min())
                    {
                        minScore[0] = score[i];
                    }
                }

                //리스트 오름차순 정렬
                minScore.Sort();

                //최하위 점수 배열에 저장
                answer[i] = minScore.Min();
            }


            return answer;
        }
    }
}
