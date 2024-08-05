namespace Example_006
{

    public class Solution
    {
        public int solution(int n)
        {
            int pizza = 1;
            int piece = 7;

            while (piece * pizza < n)
            {
                pizza++;
            }

            return pizza;
        }



        public class Program
        {
            static void Main(string[] args)
            {


            }
        }
    }
}
