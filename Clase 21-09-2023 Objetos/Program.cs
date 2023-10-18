// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Programador NorbeySenior = new Programador("Norbey", 90);
Programador JorgeMid = new Programador("Jorge", 70);
Programador CarlosJR = new Programador("Carlos", 40);


if (JorgeMid.getNivel() < NorbeySenior.getNivel())
{
    Console.WriteLine($"El programador {NorbeySenior.getNombre()} tiene mas nivel que {JorgeMid.getNombre()}");
}

List<Programador> listaProgramador = new List<Programador>();

listaProgramador.Add(NorbeySenior);
listaProgramador.Add(JorgeMid);
listaProgramador.Add(CarlosJR);

//Saber cuantos objetos hay en una lista 
// listaProgramador.Count()

int sumaPromedio = 0;

foreach (Programador programador in listaProgramador)
{
    sumaPromedio += programador.getNivel();

    if (programador.getNivel() >= 80)
    {
        Console.WriteLine($"El programador {programador.getNombre()} es Senior");
        continue;
    }

    if (programador.getNivel() >= 50 && programador.getNivel() < 80)
    {
        Console.WriteLine($"El programador {programador.getNombre()} es Medio Señor");
        continue;
    }

    Console.WriteLine($"El programador {programador.getNombre()} es Junior");

}

Console.WriteLine(sumaPromedio/listaProgramador.Count());

public class Programador
{
    
    private string Nombre { get; set; }
    private int Nivel { get; set; }

    public Programador(string Nombre, int Nivel)
    {
        this.Nombre = Nombre;
        this.Nivel = Nivel;
    }

    public string getNombre()
    {
        return this.Nombre;
    }

    public int getNivel()
    {
        return this.Nivel;
    }


}