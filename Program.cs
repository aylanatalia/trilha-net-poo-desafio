using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "xxtr", imei: "212121", memoria: 125);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("/n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "9876", modelo: "10plus", imei: "454545", memoria: 360);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");