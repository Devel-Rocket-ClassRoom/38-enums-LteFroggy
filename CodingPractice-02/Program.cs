

// 1. 열거형의 기본 값
using System; {
    Console.WriteLine($"Animal.Dragon : {(int)Animal.Dragon}, {Animal.Dragon.ToString()}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. Enum.GetValues
{
    Console.WriteLine($"Priroity 열거형의 값들 : ");
    foreach (var v in Enum.GetValues(typeof(Priority))) {
        Console.WriteLine($"{v.ToString()} = {(int)v}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

enum Animal {
    Rabbit,
    Dragon,
    Snake
}

enum Priority {
    High = 1,
    Normal = 5,
    Low = 10
}