// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PuntoParcial.Clases;

PagoTarjeta pagoT1 = new PagoTarjeta();

PagoPayPal pagoP1 = new PagoPayPal();


pagoT1.TipoDePago(200.2);

pagoP1.TipoDePago(1200.2);