namespace Solution
{
    public class Solution
    {
        public static int MySqrt(int x)
        {
            if (x <= 1 || x>=231)
                return x;
            return (int)Math.Floor(Math.Sqrt(x));
        }
        public static void Main()
        {
            int x = 231;
            Console.WriteLine(MySqrt(x));
        }
    }
}
