// See https://aka.ms/new-console-template for more information
Console.WriteLine("Clase 29 Agosto!");

//string[] casillero = new string[4];

/* casillero[4-1] = "Cuaderno 1";

Console.WriteLine(casillero[3]);

//string tem = casillero[3];

casillero[1] = casillero[3];

casillero[3] = "cuaderno 2";

Console.WriteLine("-------------------");
Console.WriteLine(casillero[1]);
Console.WriteLine(casillero[3]); */


Random random = new Random();

/* int[] numeros = new int[5];

for (int i = 0; i < numeros.length; i++)
{
    Console.WriteLine("Ingrese numero\n");
    num = Int32.Parse(Console.ReadLine());
    numeros[i] = num;
}

for (int i = 0; i < vector.Length; i++)
{
    Console.WriteLine(vector[i]+"-");
} */

/* int[] numeros = new int[50];
int mayor = ;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(50);
    if(mayor<=numeros[i]){

    }
}
 */


int[,] numeros = new int[6, 6];


for (int i = 0; i < numeros.Length; i++)
{
     
    for (int j = 0; j < numeros.Length; j++)
    {
        if (i == j)
        {
            numeros[i, j] = 0;
            continue;
        }

        numeros[i, j] = random.Next(50);
       Console.WriteLine(i);
        Console.WriteLine(j);

    }
}

/* for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("\n");
    for (int j = 0; j < numeros.Length; j++)
    {
        Console.WriteLine(numeros[i, j]);

    }
}
 */