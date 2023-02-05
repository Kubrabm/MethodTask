
namespace MethodTask
{
    internal class ArraysTasks
    {
        internal int[] EnterArray()
        {
            Console.Write("Insert Array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"arry[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        internal int[] FindSqrtElements()
        {
            int[] array = EnterArray();

            Console.Write("Elements of an Array with square flavor: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Sqrt(array[i]) % 1 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine(" ");

            return array;
        }
    }
}
