namespace Level2;

/// <summary>
/// 날짜 : 2026-04-18
/// 문제 : 프로세스
/// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42587
/// </summary>
public class Ex42587
{
    public int solution(int[] priorities, int location) {
        int answer = 1;
        Queue<(bool, int)> priorQueue = new Queue<(bool, int)>();        
        Queue<(bool, int)> waitQueue = new Queue<(bool, int)>();
        
        for(int i = 0; i < priorities.Length; i++)
        {
            bool isFind = location == i;
            var process = (isFind, priorities[i]);
            priorQueue.Enqueue(process);
        } 
        
        while(priorQueue.Count != 0 || waitQueue.Count != 0)
        {
            bool canExecute = true;
            
            var outProcess = priorQueue.Dequeue();

            while(priorQueue.Count != 0)
            {
                var compare = priorQueue.Dequeue();
                
                if(outProcess.Item2 < compare.Item2) canExecute = false;
                
                waitQueue.Enqueue(compare);
            }
            
            if(!canExecute)
            {
                waitQueue.Enqueue(outProcess);
            }
            else
            {
                if(outProcess.Item1)
                {
                    return answer;
                }
                else
                {
                    answer++;
                }
            }

            while(waitQueue.Count != 0)
            {
                priorQueue.Enqueue(waitQueue.Dequeue());
            } 
        }
        
        
        return answer;
    }
}