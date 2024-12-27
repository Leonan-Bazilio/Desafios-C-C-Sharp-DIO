using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
 Smartphone nokia = new Nokia("12", "Nokia", "11", 2);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Smartphone iphone = new Iphone("123", "iPhone", "22", 3);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");