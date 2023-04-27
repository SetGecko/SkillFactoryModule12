namespace Task_12._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            string greetings = "Привет, " + name;
            Console.WriteLine(greetings);
        }
    }
}