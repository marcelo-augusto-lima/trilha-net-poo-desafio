﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "4554534", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");