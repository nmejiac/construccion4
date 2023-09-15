// See https://aka.ms/new-console-template for more information
using Clase14082023_POO_Herencia.clases;


Console.WriteLine("Hello, World!");

Cuenta cuenta_colombia = new Cuenta(10000);
Cuenta cuenta_peru = new Cuenta(10000);
CuentaArg cuenta_argentina = new CuentaArg(10000);

cuenta_colombia.retirar(2000);
cuenta_peru.retirar(2000);
cuenta_argentina.retirar(2000);


