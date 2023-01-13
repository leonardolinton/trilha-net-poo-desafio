using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Smartphone cel1 = new Nokia(numero: "21 9999-9999", modelo: "Modelo-ABC", imei: "ABC-321", memoria: 64);
Smartphone cel2 = new Iphone(numero: "21 1111-1111", modelo: "Modelo-XYZ", imei: "XYZ-123", memoria: 32);

Console.WriteLine("NOKIA");
cel1.Ligar();
cel1.ExibirModelo();
cel1.ExibirMemoriaROM();
Console.WriteLine(cel1.Numero);
cel1.ReceberLigacao();
cel1.InstalarAplicativo("WhatsApp");

Console.WriteLine();
Console.WriteLine("=========================================================");
Console.WriteLine();

Console.WriteLine("IPHONE");
cel2.Ligar();
cel2.ExibirModelo();
cel2.ExibirMemoriaROM();
Console.WriteLine(cel2.Numero);
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Telegram");