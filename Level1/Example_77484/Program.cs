

/// <summary>
/// 날짜 : 2025-02-12
/// 문제 : 로또의 최고 순위와 최저 순위
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/77484
/// </summary>
public class LottoMinMax
{
    public static void Main(string[] args)
    {
        //1등 -> 6개
        //2등 -> 5개
        //3등 -> 4개
        //4등 -> 3개
        //5등 -> 2개
        //그 외
        Dictionary<int, int> rankDict = new Dictionary<int, int>()
        {
            {6, 1},
            {5, 2},
            {4, 3},
            {3, 4},
            {2, 5},
            {1, 6},
            {0, 6}
        };

        int[] lottos = {45, 4, 35, 20, 3, 9}; //구매 번호
        int[] win_nums = {20, 9, 3, 45, 4, 35};   //당첨 번호

        int min = 0;
        int max = 0;

        min = lottos.Where(x => win_nums.Contains(x)).Count();

        max = lottos.Where(x => x == 0).Count() + min;

        int[] answer = {rankDict[max], rankDict[min]};

    }
    
    
}