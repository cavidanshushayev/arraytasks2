namespace maxmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int max = 0;
            int min = arr[0];
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }else if (arr[i] < min)
                {
                    min= arr[i];
                }
            }
            Console.WriteLine("min=" + min + "max=" + max);
        }
    }
}