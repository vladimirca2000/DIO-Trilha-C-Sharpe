using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4565465", modelo: "Modelo 3300", imei: "123456789", memoria: 1);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "3454", modelo: "Modelo 6S", imei: "123321123", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");