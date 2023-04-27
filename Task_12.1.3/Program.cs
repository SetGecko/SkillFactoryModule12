namespace Task_12._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = Convert.ToInt32(Console.ReadLine());
            var array = new int[count];
            for(int i = 0; i < count; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Все элементы записаны");
        }
    }
}