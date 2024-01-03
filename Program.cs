using DesafioPOO.Models;

Console.WriteLine("Teste com o Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "21999999999", modelo: "MODELO NOKIA", imei: "0000000001", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n-----");

Console.WriteLine("Teste com Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1188888888", modelo: "MODELO IPHONE", imei: "0000000002", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");