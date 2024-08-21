namespace Example_062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = 5;
            int share = 3;

            int left = balls - share;
            int n = 1;
            int m = 1;
            int answer = 0;
 
            //try catch 문 사용?
            for(int i = balls; i > share; i--)
            {
                n *= i;
 
            }

            for(int j = left; j >= 1; j--)
            {
                m *= j;
 
            }
            answer = n / m;

            Console.WriteLine(answer); 
        }
    }
}
