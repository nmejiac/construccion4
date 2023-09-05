// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inicio APP");
/* int nombre = 1;
string name = "Norbey"; */

//string name = Console.ReadLine();
//string lastname;
//int age;

//lastname = Console.ReadLine();
//age = Int32.Parse(Console.ReadLine());

//Console.WriteLine("#####################\nNombre: "+ name +"\nApellido: " + lastname + "\nEdad: "+ age);
//Console.WriteLine("#####################\nHola\n " + name +" "+ lastname +"\n#####################\nSu edad es: "+age);


/* int dolares;
int pesos = 4080;
int total;


Console.WriteLine("Ingrese cantidad en Dolares (USD)");
dolares = Int32.Parse(Console.ReadLine());

total = dolares * pesos;

if (total < 38500)
{
    Console.WriteLine("Estudia Ingles");
    //Enviroment.Exit(0)
}
else
{
    Console.WriteLine("Puede Comprar pollo asado");
};
 */
//Console.WriteLine("Total en Pesos\n"+"$"+total); 


/* int numero;
Console.WriteLine("Ingrese Numero");
numero = Int32.Parse(Console.ReadLine());
if (numero % 2 == 0 && numero > 25) {
    Console.WriteLine("es mayor de 25 y es par");
    Environment.Exit(0);

}

Console.WriteLine("No es par  ");

 */

 int numero;
Console.WriteLine("Ingrese Numero");
numero = Int32.Parse(Console.ReadLine());
if (numero >= 10 && numero <= 35 && numero != 20) {
    Console.WriteLine("Cumple");
    Environment.Exit(0);

}

Console.WriteLine("No Cumple  ");



