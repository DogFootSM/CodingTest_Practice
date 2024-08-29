namespace Example_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] s; 
            s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
             
        }
    }
}
