string frase , cebolinhaFala;

Console.WriteLine("Digite uma frase:");

frase = Console.ReadLine() ?? "";
cebolinhaFala = frase.Replace("r", "l").Replace("R", "L");
        
Console.WriteLine("\nCebolinha falaria:");
Console.WriteLine(cebolinhaFala);