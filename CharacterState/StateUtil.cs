using System;

static class StateUtil {
    public static void PrintStateList() {
        Console.WriteLine($"=== 상태 목록 ===");
        Type type = typeof(CharacterState);
        CharacterState[] states = (CharacterState[])Enum.GetValues(typeof(CharacterState));

        foreach (var v in states) {
            Console.WriteLine($"{v} = {(int)v}");
        }
    }

    public static void ChangeState(out CharacterState result, CharacterState target) {
        result = target;
        Console.WriteLine($"상태가 {target}(으)로 변경되었습니다.");
    }

    public static void PrintState(CharacterState cs) {
        switch (cs) {
            case CharacterState.Idle :
                Console.WriteLine($"(행동) 가만히 서 있습니다.");
                break;
            case CharacterState.Attacking :
                Console.WriteLine($"(행동) 적을 공격합니다!");
                break;
            case CharacterState.Running :
                Console.WriteLine($"(행동) 달리고 있습니다.");
                break;
            case CharacterState.Jumping :
                Console.WriteLine($"(행동) 점프하고 있습니다.");
                break;
            case CharacterState.Dead :
                Console.WriteLine($"(행동) 사망 상태입니다. 행동할 수 없습니다.");
                break;
        }
    }
}

