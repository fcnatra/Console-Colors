var min = 30; var max = 47;

Console.Write("Normal: ");
for (int i = min; i <= max; i++)
{
    Console.Write($"\x001B[{i}m{i}\x001B[0m"); Console.Write($"\x001B[0m ");
}

Console.Write("\n\nBright: ");
for (int i = min; i <= max; i++)
{
    Console.Write($"\x001B[{i};1m{i}"); Console.Write($"\x001B[0m ");
}

Console.WriteLine("\n\nAll Fg: ");
for (int i = 0; i <= 255; i++) Console.Write($"\x001B[38;5;{i}m{i,4}");
Console.Write($"\x001B[0m ");

Console.WriteLine("\n\nAll Bg: ");
for (int i = 0; i <= 255; i++)
{
    Console.Write($"\x001B[48;5;{i}m{i,4}"); Console.Write($"\x001B[0m ");
}
