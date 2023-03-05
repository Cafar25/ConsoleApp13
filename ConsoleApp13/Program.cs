namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            int a;
            Console.Write("Uzunlugu:");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                goto l1;
            }
            var student = new dynamic[a];
            for (int i = 0; i < 10; i++)
            {
                student[i] = new
                {
                    name = Console.ReadLine(),
                    surname = Console.ReadLine(),
                    speciality = Console.ReadLine(),
                    age = int.Parse(Console.ReadLine()),
                    GroupNo = int.Parse(Console.ReadLine())
                };

                Console.WriteLine(student[i]);
            }
           
        }
    }
}