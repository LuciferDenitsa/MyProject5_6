namespace MyProject5_6
{
    class Program
    {
        static (string Name, string LastName, int Age) User_info()
        {
            (string Name, string LastName, int Age) User;

            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            User.LastName = Console.ReadLine();


            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст: ");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            User.Age = intage;



            return User;

        }

        static bool CheckNum(string number, out int conumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    conumber = intnum;
                    return false;
                }
            }
            {
                conumber = 0;
                return true;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}