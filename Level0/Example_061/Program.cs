namespace Example_061
{
    /// <summary>
    /// 날짜 : 2024-08-18
    /// 문제 : 영어가 싫어요 
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120894
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "onefourzerosixseven"; //onefourzerosixseven

            string temp = "";

 
            List<string> list = new List<string>();


            for (int i = 0; i < numbers.Length; i++)
            {
                temp += string.Concat(numbers[i]);

                switch (temp) 
                {
                    case "one":
                        list.Add("1");
                        temp = "";
                        break;

                    case "two":
                        list.Add("2");
                        temp = "";
                        break;

                    case "three":
                        list.Add("3");
                        temp = "";
                        break;

                    case "four":
                        list.Add("4");
                        temp = "";
                        break;
                    case "five":
                        list.Add("5");
                        temp = "";
                        break;

                    case "six":
                        list.Add("6");
                        temp = "";
                        break;

                    case "seven":
                        list.Add("7");
                        temp = "";
                        break;
                    case "eight":
                        list.Add("8");
                        temp = "";
                        break;

                    case "nine":
                        list.Add("9");
                        temp = "";
                        break;
                    case "zero":
                        list.Add("0");
                        temp = "";
                        break; 
                } 
            }
 

            foreach(string i in list)
            {
                temp += string.Concat(i);
            } 

            long answer = long.Parse(temp);
 

        }
    }
}
