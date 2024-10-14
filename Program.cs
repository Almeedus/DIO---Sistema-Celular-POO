using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new(numero: "123123", modelo: "ABC123", imei: "11111", memoria: 128);
Iphone iphone = new(numero: "321312", modelo: "DEF123", imei: "234243", memoria: 256);

iphone.Ligar();
iphone.InstalarAplicativo(nomeApp: "Whatsapp");


nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Facebook");