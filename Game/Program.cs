using System;

class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + "-" + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + "-" + namesArray[namesArray.Length - 1] + ".");
    }
    static void SelectRace()
    {
        string[] namesRace = { "Люди", "Эльфы", "Гномы", "Орки" };
        WriteSelect(namesRace);
        Console.WriteLine("Укажите вашу расу");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса - " + namesRace[indexRace - 1]);
    }
    static void SelectClass()
    {
        string[] namesClass = { "Воин", "Маг", "Разбойник", "Вор" };
        WriteSelect(namesClass);
        Console.WriteLine("Укажите ваш класс");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш класс - " + namesClass[indexClass - 1]);
    }
    static void SelectSex()
    {
        string[] namesSex = {"Мужской", "Женский"};
        WriteSelect(namesSex);
        Console.WriteLine("Укажите ваш пол");
        int indexSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол - " + namesSex[indexSex - 1]);
    }
    static void Main(string[] args)
    {
        SelectRace();
        SelectClass();
        SelectSex();
    }
}

