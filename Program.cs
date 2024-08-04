using System;

namespace MyProject5_6
{
    internal class Program
    {
        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] FavColors) User;

        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] FavColors) User_info()
        {

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

            Console.WriteLine("Есть ли у вас питомец?");
            string answer_pet = Console.ReadLine();

            while (answer_pet != "Да" && answer_pet != "Нет" && answer_pet != "да" && answer_pet != "нет")
            {
                Console.WriteLine("Некорректный ответ, пожалуйста, ответьте Да или Нет");
                answer_pet = Console.ReadLine();
            }

            if (answer_pet == "Да" || answer_pet == "да")
            {
                User.HavePet = true;
                string pet;
                int intpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев цифрами: ");
                    pet = Console.ReadLine();

                } while (CheckNum(pet, out intpet));

                User.NumPet = intpet;

                string[] PetName = new string[intpet];
                PetName = pet_names(intpet);

                User.PetName = PetName;
            }
            else
            {
                User.NumPet = 0;
            }

            string colors;
            int intcolors;
            do
            {
                Console.Write("Напишите количество ваших любимых цветов цифрами: ");
                colors = Console.ReadLine();
            } while (CheckNum(colors, out intcolors));

            User.NumFavColor = intcolors;

            string[] FavColor = new string[intcolors];
            FavColor = fav_colors(intcolors);

            User.FavColors = FavColor;

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
                Console.WriteLine("Некорректное значение, введите значение цифрами");
                conumber = 0;
                return true;
            }
        }

        static string[] pet_names(int count_pets)
        {
            Console.WriteLine("Назовите клички своих питомцев:");
            string[] Pet = new string[count_pets];
            for (int i = 0; i < count_pets; i++)
            {
                Pet[i] = Console.ReadLine();
            }
            return Pet;
        }

        static string[] fav_colors(int count_colors)
        {
            Console.WriteLine("Назовите ваши любимые цвета:");
            string[] Fav_Colors = new string[count_colors];
            for (int i = 0; i < count_colors; i++)
            {
                Fav_Colors[i] = Console.ReadLine();
            }
            return Fav_Colors;
        }
 

        static (string Name, string LastName, int Age, int NumPet, int NumFavColor, bool HavePet, string[] PetName, string[] FavColors) ShowUserInfo()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine($"Имя: {User.Name}");
            Console.WriteLine($"Фамилия: {User.LastName}");
            Console.WriteLine($"Возраст: {User.Age}"); 
            
            if (User.HavePet)
            {
                Console.WriteLine($"Количество питомцев: {User.NumPet}");
                Console.WriteLine("Клички питомцев:");
                foreach (string pet in User.PetName)
                {
                    Console.WriteLine(pet);
                }
            }
            else
            {
                Console.WriteLine("У пользователя нет питомцев");
            }

            Console.WriteLine($"Количество любимых цветов: {User.NumFavColor}");
            Console.WriteLine("Любимые цвета:");
            foreach (string col in User.FavColors)
            {
                Console.WriteLine(col);
            }

            return User;
        }


        static void Main(string[] args)
        {
            User_info();
            ShowUserInfo();
        }
    }
}