namespace Task_12._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возраст");
            var age = Convert.ToInt32(Console.ReadLine());
            //if (age < 13)
            //{
            //    Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
            //}
            //else 
            //{
            //    Console.WriteLine("Вы успешно зарегестрированы");
            //}
            switch (age)
            {
                case < 13:
                    Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
                    break;
                case >= 14:
                    Console.WriteLine("Вы успешно зарегестрированы");
                    break;
            }
        }
    }
}