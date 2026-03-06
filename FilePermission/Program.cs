using System;

FilePermission fp = FilePermission.None;

Console.WriteLine($"=== 파일 권한 관리 ===");
Console.WriteLine();

Console.WriteLine($"현재 권한 : {fp}");
Console.WriteLine();

Console.WriteLine($"[권한 추가]");
    
fp |= FilePermission.Read;
Console.WriteLine($"+ Read 추가 : {fp}");

fp |= FilePermission.Write;
Console.WriteLine($"+ Write 추가 : {fp}");

fp |= FilePermission.Execute;
Console.WriteLine($"+ Execute 추가 : {fp}");

Console.WriteLine();

Console.WriteLine($"[권한 확인]");
Console.WriteLine($"Read 권한 : {(fp & FilePermission.Read) != 0}");
Console.WriteLine($"Write 권한 : {(fp & FilePermission.Write) != 0}");
Console.WriteLine($"Execute 권한 : {(fp & FilePermission.Execute) != 0}");
Console.WriteLine();
Console.WriteLine();
