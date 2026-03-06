using System;


// 1. 값 지정 예제
{
    Console.WriteLine((int)Animal.Horse);
    Console.WriteLine((int)Animal.Sheep);
    Console.WriteLine((int)Animal.Monkey);
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 플래그 결합하기
{
    CharacterStatus cs = CharacterStatus.None;
    cs |= CharacterStatus.Poison | CharacterStatus.Paralyzed;
    Console.WriteLine(cs);
}

// 3. 플래그 검사하기
{
    CharacterStatus cs = CharacterStatus.None;
    cs |= CharacterStatus.Poison | CharacterStatus.Confused;
    if ((cs & CharacterStatus.Poison) != 0) {
        Console.WriteLine($"캐릭터가 독에 걸렸습니다!");
    }

    if ((cs & CharacterStatus.Paralyzed) != 0) {
        Console.WriteLine($"캐릭터가 마비 상태에 걸렸습니다!");
    } else {
        Console.WriteLine($"마비 상태가 아닙니다.");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 플래그 추가 및 제거
{
    CharacterStatus cs = CharacterStatus.Poison;
    Console.WriteLine($"초기 상태 : {cs}");

    cs |= CharacterStatus.Confused;
    Console.WriteLine($"혼란 추가 : {cs}");

    cs &= ~CharacterStatus.Poison;
    Console.WriteLine($"독 제거 : {cs}");

    cs ^= CharacterStatus.Invisible;
    Console.WriteLine($"투명 토글 : {cs}");

    Console.WriteLine();
    Console.WriteLine();
}

// 5. 플래그 열거형 활용 예제 
{
    BuffStatus bs = BuffStatus.None;

    bs |= BuffStatus.AttackUp;
    Console.WriteLine($"버프 적용 : {BuffStatus.AttackUp}");
    Console.WriteLine($"현재 버프 : {bs}");
    
    bs |= BuffStatus.SpeedUp;
    Console.WriteLine($"버프 적용 : {BuffStatus.SpeedUp}");
    Console.WriteLine($"현재 버프 : {bs}");

    Console.WriteLine($"공격력 버프 있음 ? : {(bs & BuffStatus.AttackUp) != 0}");
    
    bs &= ~BuffStatus.AttackUp;
    Console.WriteLine($"버프 해제 : {BuffStatus.AttackUp}");
    Console.WriteLine($"현재 버프 : {bs}");

    Console.WriteLine($"공격력 버프 있음 ? : {(bs & BuffStatus.AttackUp) != 0}");
}

enum Animal {
    Horse,
    Sheep = 5,
    Monkey
}

[Flags]
enum CharacterStatus {
    None = 0,
    Poison = 1 << 0,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3,
}

[Flags]
enum BuffStatus {
    None = 0,
    AttackUp = 1 << 0,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2,
    All = -1
}