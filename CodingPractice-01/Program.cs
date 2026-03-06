using Q1;
using Q2;
using Q4;
using Q7;
using System;
using Color = Q3.Color;

// 1. 열거형을 사용한 조건 분기
{
    Priority priority = Priority.High;
    if (priority == Priority.High) { Console.WriteLine($"높은 우선순위"); }
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 열거형 변수 선언과 비교
{
    Animal animal = Animal.Tiger;

    if (animal == Animal.Tiger) {
        Console.WriteLine(animal);
        Console.WriteLine($"호랑이");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 열거형 항목에 특정 값 지정
{
    Q3.Color red = Color.Red;
    Color green = Color.Green;
    Color blue = Color.Blue;
    Console.WriteLine($"Red : {(int)red}");
    Console.WriteLine($"Green : {(int)green}");
    Console.WriteLine($"Blue : {(int)blue}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 기반 타입 지정
{
    SmallEnum smallEnum = SmallEnum.a;
    Console.WriteLine(sizeof(SmallEnum));
    Console.WriteLine();
    Console.WriteLine();
}

// 5. Enum.GetNames
{
    Type type = typeof(ConsoleColor);
    string[] names = Enum.GetNames(type);
    foreach (var name in names) {
        Console.WriteLine(name);
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 6. Enum.Parse
{
    Type colorType = typeof(ConsoleColor);
    ConsoleColor t = (ConsoleColor)Enum.Parse(colorType, "Red");
    Console.ForegroundColor = t;
    Console.WriteLine($"빨간색 텍스트");
    Console.ResetColor();
    Console.WriteLine($"기본 색상 텍스트");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. Enum.TryPrse
{
    if (Enum.TryParse<Direction>("Up", out Direction dir)) {
        Console.WriteLine($"변환 성공 : {dir}");
    }

    if (Enum.TryParse<Direction>("Forward", out Direction dir2)) {
        Console.WriteLine($"변환 성공 : {dir}");
    } else {
        Console.WriteLine($"\'Forward\'은(는) 유효하지 않은 값");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 8. Enum.IsDefined
{
    Console.WriteLine($"1은 유효한 Animal 값인가? : {Enum.IsDefined(typeof(Animal), 1)}");
    Console.WriteLine($"100은 유효한 Animal 값인가? : {Enum.IsDefined(typeof(Animal), 100)}");
    Console.WriteLine($"\'Tiger\'은 유효한 Animal 값인가? : {Enum.IsDefined(typeof(Animal), "Tiger")}");
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 열거형과 정수 간 변환
{
    Console.WriteLine($"Right = {(int)Direction.Right}");
    Console.WriteLine($"2 = {(Direction)2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 10. 정의되지 않은 정수를 열거형으로 반환
{
    Console.WriteLine($"{(Animal)100}");
    Console.WriteLine();
    Console.WriteLine();
}