namespace Example_012
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ars = "banana";

            char[] check = { 'a','e','i','o','u' };


            for (int i = 0; i < ars.Length; i++)
            {
                for (int j = 0; j < check.Length; j++)
                { 
                    Console.WriteLine(ars[i].Equals(check[j])); 
                } 
                //ars.Contains(check[i]);
            }





        }
    }
}
