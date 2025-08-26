namespace Level2;


/// <summary>
/// 날짜 : 2025-08-26
/// 문제 : 다음 큰 숫자
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12911
/// </summary>
public class Ex12911
{
    public int solution(int n) 
    {
        int answer = 0;
        int nValue = n;
        int multiple = 1;
        int temp = 0;
        int increaseNum = n;
        
        int compTemp = 0;

        while(nValue >= 1)
        {
            if(nValue % 2 != 0)
            {
                temp += (nValue % 2) * multiple;
                multiple *= 10;
            }

            nValue /= 2;
        }

        while(increaseNum < int.MaxValue)
        {
            increaseNum += 1;
            nValue = increaseNum;
            compTemp = 0;
            multiple = 1;
            
            while(nValue >= 1)
            {
                if(nValue % 2 != 0)
                {
                    compTemp += (nValue % 2) * multiple;
                    multiple *= 10;
                }
                
                nValue /= 2;
            }
            
            if(compTemp == temp && increaseNum > n)
            {
                answer = increaseNum;
                break;
            } 
        }
         
        return answer;
    }
    
    
}