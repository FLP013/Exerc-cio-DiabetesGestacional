int glicose;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("---- Avalie sua diabete gestacional ----");
Console.ResetColor();

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Quanto voce tem de glicose?");
Console.ResetColor();
glicose = Convert.ToInt32(Console.ReadLine());

if(glicose < 92)
{
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
 Console.ResetColor();
}

else if(glicose >= 92 && glicose < 126 )
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Compatível com Diabetes Gestacional");
    Console.ResetColor();
}

else 
{
     Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" Diabetes Mellitus na Gravidez");
    Console.ResetColor();
}