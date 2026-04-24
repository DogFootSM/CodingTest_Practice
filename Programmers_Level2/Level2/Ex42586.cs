namespace Level2;

/// <summary>
/// 날짜 : 2026-04-15
/// 문제 : 기능 개발
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42586
/// </summary>
public class Ex42586
{
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        Dictionary<int, int> returnValues = new Dictionary<int, int>();
        Stack<int> progressStack = new Stack<int>();
        int day = 1;
        int index = 0;
        int returnValue = 0;
        
        for(int i = progresses.Length -1; i >= 0; i--)
        {
            progressStack.Push(progresses[i]);
        }
        
        while(progressStack.Count != 0)
        {
            int progress = progressStack.Peek();
            
            progress += speeds[index] * day;
            
            if(progress >= 100)
            {
                if(!returnValues.ContainsKey(day))
                {
                    returnValues.Add(day, 0);
                }
                    
                returnValue++;
                index++;
                progressStack.Pop();
                returnValues[day] = returnValue;
            }
            else
            {
                returnValue = 0;
                day++;
            } 
        }
        
        index = 0;
        answer = new int[returnValues.Keys.Count];
        
        foreach(var val in returnValues)
        {
            answer[index++] = val.Value;
        }
        
        return answer;
    }
}