namespace konsola
{
    internal class Program
    {
        static void Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] lol = new int[100];
            for(int i = 0; i < lol.Length; i++)
            {
                lol[i] = random.Next(1, 101);
            }
            Sort(lol);
        }
    }
}
