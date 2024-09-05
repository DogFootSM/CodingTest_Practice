namespace Example_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aaab";


            List<string> list = new List<string>();
            int trueCount = 1;
            int falseCount = 0;
 
            string empty = "";

            while (s.Length > 0)
            {
 
                for(int i = 1; i < s.Length; i++)
                {
                    if(s[0].ToString() == s[i].ToString())
                    {
                        trueCount++;
                    }
                    else
                    {
                        falseCount++;
                         
                    }

                    if (trueCount == falseCount)
                    {
                        for(int c = 0;  c < trueCount + falseCount; c++)
                        {
                            empty += s[c].ToString();
                        }
                        list.Add(empty);
                        s = s.Remove(0, empty.Length);
                        trueCount = 1;
                        falseCount = 0;
                        i = 0;
                        empty = "";
                    }
                }

                if(s.Length >= 1 && trueCount != falseCount)
                {
                    list.Add(s);
                    break;
                }

            }
 

        }
    }
}