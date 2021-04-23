using System;

class Debug
{
    public static void Log(object obj)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"[INFO]: {obj}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Warn(object obj)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARN]: {obj}");
        Console.ForegroundColor = ConsoleColor.White;
    }
        
    public static void Error(object obj)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[Error]: {obj}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
