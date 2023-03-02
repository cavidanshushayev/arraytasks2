namespace olanolmayanelement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr_1= { 1, 2, 3, 4, 5, 6 };
            int[] arr_2 = { 1, 2, 3, 4 };
            Boolean count = false;
            for(int i = 0; i < arr_1.Length; i++)
            {
                for(int j=0;j<arr_2.Length; j++)
                {
                    if (arr_1[i] == arr_2[j])
                    {
                        count= true;
                        
                    }
                }
                if(count == false)
                {
                    Console.WriteLine(arr_1[i]);
                }
            }
        }         
    }
}