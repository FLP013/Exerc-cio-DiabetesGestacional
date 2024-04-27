int glicose;

Console.Clear();

Console.WriteLine("---- Avalie sua diabete gestacional ----");

Console.WriteLine();

Console.WriteLine("Quanto voce tem de glicose?");
glicose = Convert.ToInt32(Console.ReadLine());

if(glicose < 92)
{
 Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}

else if(glicose >= 92 && glicose < 126 )
{
    Console.WriteLine("Compatível com Diabetes Gestacional");
}

else 
{
    Console.WriteLine(" Diabetes Mellitus na Gravidez");
}