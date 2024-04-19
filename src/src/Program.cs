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
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int l = 0; l < array.Length - 1; l++)
                    if (string.Compare(array[l].last_name, array[l + 1].last_name) > 0) //сравнение по первому свойству - фамилия
                    {
                        k = array[l]; //меняем местами элементы массива
                        array[l] = array[l + 1];
                        array[l + 1] = k;
                    }
                    else if (string.Compare(array[l].last_name, array[l + 1].last_name) == 0) //сравнение по второму свойству - имя
                    {
                        if (string.Compare(array[l].name, array[l + 1].name) > 0)
                        {
                            k = array[l];
                            array[l] = array[l + 1];
                            array[l + 1] = k;
                        }
                    }

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
