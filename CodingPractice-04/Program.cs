using System;

// 1. 열거형과 switch문
{
    Animal dog = Animal.Dog;
    switch (dog) {
        case Animal.Dog :
            Console.WriteLine($"개");
            break;
        case Animal.Chicken :
            Console.WriteLine($"닭");
            break;
        case Animal.Pig :
            Console.WriteLine($"돼지");
            break;
    }

    Console.WriteLine();
    Console.WriteLine();
}

// 2. 캐릭터 상태 관리
{
    void Update(CharacterState cs) {
        switch (cs) {
            case CharacterState.Walking:
                Console.WriteLine($"걷기 애니메이션 재생");
                break;
            case CharacterState.Running :
                Console.WriteLine($"달리기 애니메이션 재생");
                break;
            case CharacterState.Attacking :
                Console.WriteLine($"공격 애니메이션 재생");
                break;
            case CharacterState.Dead :
                Console.WriteLine($"사망 애니메이션 재생");
                break;
        }
    }
    CharacterState cs = CharacterState.Idle;
    cs = CharacterState.Attacking;
    Update(cs);
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 아이템 등급
{
    void PrintItemInfo(string name, ItemRarity ir) {
        Console.WriteLine($"아이템 : {name}");
        Console.WriteLine($"등급 : {ir}");
    }

    PrintItemInfo("전설의 검", ItemRarity.Legendary);
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 방향 처리
{
    void Move(Direction d) {
        switch (d) {
            case Direction.Up :
                Console.WriteLine($"위로 이동 : (y + 1)");
                break;
            case Direction.Down:
                Console.WriteLine($"아래로 이동 : (y - 1)");
                break;
            case Direction.Left :
                Console.WriteLine($"왼쪽으로 이동 : (x - 1)");
                break;
            case Direction.Right :
                Console.WriteLine($"오른쪽으로 이동 : (x + 1)");
                break;
        }
    }

    Move(Direction.Up);
    Move(Direction.Right);
    Console.WriteLine();
    Console.WriteLine();
}

enum Animal {
    Chicken,
    Dog,
    Pig
}

enum CharacterState {
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

enum ItemRarity {
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

enum Direction {
    Up,
    Down,
    Left,
    Right
}