using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine($"Smarthphone Nokia:");
Nokia nokia = new Nokia("12345678", "Modelo Z", "111111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine($"Smarthphone Iphone:");
Iphone iphone = new Iphone("2578", "Modelo X", "777777777", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");