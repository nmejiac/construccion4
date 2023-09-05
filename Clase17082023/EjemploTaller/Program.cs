// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Inicio Programa");

//string opcion;
int opc;


double num1;
string operacion;
double num2;
double resultado;
string res = "";


Console.Clear();

do
{
    Console.WriteLine("Seleccione\n 1. Realizar operación\n 2. Mostrar la última operación realizada\n 3. Salir\n ");
    opc = Int32.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.WriteLine("Ingrese Primer Numero ");
            //num1 = Int32.Parse(Console.ReadLine());
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seleccione\n +. Para sumar\n -. Para Restar\n /. Para dividir\n *. Para Multiplicar\n");
            operacion = Console.ReadLine();

            Console.WriteLine("Ingrese Segundo Numero ");
            //num2 = Int32.Parse(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());


            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    //Console.WriteLine("Resultado " + resultado);

                    res = num1 + " + " + num2 + " = " + resultado;
                    Console.WriteLine(res);
                    break;

                case "-":
                    resultado = num1 - num2;
                    //Console.WriteLine("Resultado " + resultado);
                    res = num1 + " - " + num2 + " = " + resultado;
                    Console.WriteLine(res);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("el denominador no puede ser 0 ");
                        break;
                    }
                    resultado = num1 / num2;
                    res = num1 + " / " + num2 + " = " + resultado;
                    Console.WriteLine(res);
                    break;

                case "*":
                    resultado = num1 * num2;
                    //Console.WriteLine("Resultado " + resultado);
                    res = num1 + " * " + num2 + " = " + resultado;
                    Console.WriteLine(res);
                    break;

                default:
                    Console.WriteLine("Opcion Invalida ");
                    break;
            }
            break;

        case 2:
            if (res == "")
            {
                Console.WriteLine("no se a realizado ninguna operacion ");
                break;
            }
            Console.WriteLine(res);
            break;

        case 3:
            Console.WriteLine("Saliendo...");
            break;


        default:
            Console.WriteLine("opcion Invalida");
            break;
    }

} while (opc != 3);

Console.WriteLine("Salio");