using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia Modelo", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone Modelo", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.ReadLine(); // Aguarda uma tecla antes de fechar
    }
}