using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Smartphone nokia = new Nokia("123456789", "Nokia", "111111111111111", 64);
        Console.WriteLine($"Número: {nokia.Numero}");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe Iphone
        Smartphone iphone = new Iphone("987654321", "iPhone", "222222222222222", 128);
        Console.WriteLine($"Número: {iphone.Numero}");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
