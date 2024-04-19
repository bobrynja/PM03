using System;

namespace src
{
    class Person
    {
        public string last_name;
        public string name;
        public string age;
    }

    class HR
    {
        public Person[] array; //массив 

        public void Sort()
        {
            Person k;


            Console.ReadKey();
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Person now;
            string last_name, name, age;
            HR ar = new HR();
            Console.WriteLine("Введите количество элементов массива: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                while (i <= 0)
                {
                    Console.WriteLine("Ошибка!!! Введите количество элементов: ");
                    i = Convert.ToInt32(Console.ReadLine());
                }


                ar.array = new Person[i];
                for (int j = 0; j < i; j++)
                {
                    now = new Person();
                    Console.WriteLine($"Ввод {j + 1} элемента: ");
                    Console.WriteLine("Введите фамилию: ");
                    now.last_name = Console.ReadLine();
                    Console.WriteLine("Введите имя: ");
                    now.name = Console.ReadLine();
                    Console.WriteLine("Введите возраст: ");
                    age = Console.ReadLine();
                    try
                    {
                        if (Convert.ToInt32(age) <= 0)
                        {
                            Console.WriteLine("Ошибка!!!");
                            break;
                        }
                        now.age = age;
                        ar.array[j] = now;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка!!!");
                        System.Environment.Exit(0);
                    }
                    now.age = age;
                    ar.array[j] = now;
                }
                ar.Sort();
                ar.Save();
            }
            catch
            {
                Console.WriteLine("Ошибка!!!");
            }
        }
    }
}
