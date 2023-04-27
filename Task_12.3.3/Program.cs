namespace Task_12._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int GetIndex(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }

            return index;
        }
    }
}