namespace Example_050
{


    /// <summary>
    /// 날짜 : 
    /// 문제 : 
    /// URL : 
    /// </summary>
    public class Solution
    {
        public int solution(int[] array, int n)
        {

            int approximateValue = 9999;    //근사치를 저장할 변수
            int compareValue = 9999;        //값의 차이를 저장할 변수

            for (int i = 0; i < array.Length; i++)
            {

                //현재 배열의 값에서 n을 뺀 값을 비교
                if (Math.Abs(array[i] - n) < compareValue)  
                {
                    compareValue = Math.Abs(array[i] - n);      //현재 값이 근사치에 더 가까우면 변수에 저장
                    approximateValue = array[i];                //반환할 근사치의 원본 값
                }

                //근사치의 값이 똑같을 경우 13 - 12(n), 11 - 12(n)
                if (Math.Abs(array[i] - n) == compareValue)
                { 
                    //현재 저장되어있는 근사치가 array의 i번째 값보다 크다면 작은 값으로 교체
                    approximateValue = approximateValue > array[i] ? array[i] : approximateValue;
                }
            }
            return approximateValue;
        }
    }
}
