using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("12356", "Modelo 1", "11111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("789", "Modelo 2", "2222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");