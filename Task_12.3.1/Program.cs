namespace Task_12._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}