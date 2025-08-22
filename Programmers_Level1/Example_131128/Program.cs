using System.Diagnostics;

public class NumberPartner
{
    private static void Main(string[] args)
    {
        //같은 숫자가 있을 경우 그것을 모아서 가장 큰 수로 만들기
        //같은 수가 0만 있을 경우 0
        //같은 수가 없으면 -1
        //자릿수가 300만
         
        
        string x = "12222";
        string y = "21111";
        string answer = "";

        long[] xNums = new long[10];
        long[] yNums = new long[10];
  
        //시간을 잡아먹는 요소일것으로 예상
        for (int i = 0; i < 10; i++)
        {
            xNums[i] = x.Where(x => (x - 48) == i).Count(); 
        }

        for (int i = 0; i < 10; i++)
        {
            yNums[i] = y.Where(x => (x - 48) == i).Count();
        }

        for (int i = xNums.Length -1; i >= 0; i--)
        {
            if(xNums[i] == 0 || yNums[i] == 0) continue;

            long min = Math.Min(xNums[i], yNums[i]);
            
            for (int j = 0; j < min; j++)
            {
                answer += i; 
            }
             
        }

        if (answer == "")
        {
            answer = "-1";
        }
        else if (int.Parse(answer) == 0)
        {
            answer = "0";
        } 
        
        Console.WriteLine(answer);
        
    }   
}