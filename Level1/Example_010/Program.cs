using System.Xml.Linq;

namespace Example_010
{
    /// <summary>
    /// 날짜 : 
    /// 문제 : 소수 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12921
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;


            bool[] primeNum = new bool[n + 1];
            
            for(int i = 2; i < primeNum.Length; i++)
            {
                primeNum[i] = true;
            }
             
             
        }


    }
}
