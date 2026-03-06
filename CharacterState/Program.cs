using System;
using System.ComponentModel;
using System.Threading.Channels;

CharacterState cs = CharacterState.Idle;

Console.WriteLine($"=== 캐릭터 상태 관리 ===");
do {
    Console.WriteLine($"현재 상태 : {cs}");
    Console.WriteLine();

    Console.WriteLine($"1. 상태 변경");
    Console.WriteLine($"2. 상태 목록 보기");
    Console.WriteLine($"3. 현재 행동 보기");
    Console.WriteLine($"4. 종료");
    Console.Write("선택 : ");
    if (Int32.TryParse(Console.ReadLine(),out int input)) { }
    else {
        Console.WriteLine();
        Console.WriteLine($"잘못된 입력입니다.");
        Console.WriteLine();
        continue;
    }

    if (input < 1 || input > 4) {
        Console.WriteLine();
        Console.WriteLine($"1 ~ 4사이의 정수값을 입력해주세요.");
        Console.WriteLine();
        continue;
    }
    Console.WriteLine();

    if (input == 1) {
        do {
            Console.Write($"변경할 상태 번호 입력 (0 ~ 5) : ");
            if (int.TryParse(Console.ReadLine(), out int input2)) { }
            else {
                Console.WriteLine($"잘못된 입력입니다.");
                continue;
            }
            if (input2 < 1 || input2 > 5) {
                Console.WriteLine($"1 ~ 5사이의 값을 입력해주세요");
            }

            StateUtil.ChangeState(out cs, (CharacterState)input2);
            Console.WriteLine();

            break;
        } while (true);
        
    }

    else if (input == 2) {
        StateUtil.PrintStateList();
        Console.WriteLine();
    }

    else if (input == 3) {
        StateUtil.PrintState(cs);
        Console.WriteLine();
    }

    else if (input == 4) {
        Console.WriteLine($"프로그램을 종료합니다.");
        break;
    }

} while (true);
