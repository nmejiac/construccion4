// See https://aka.ms/new-console-template for more information

//EmpresaDesarrolladora Blizzard = new EmpresaDesarrolladora(1, "Blizzard");
EmpresaDesarrolladora buguie = new EmpresaDesarrolladora(1, "Buguie Studios");

//Console.WriteLine($"La empresa {Blizzard.nombre}");

VideoJuegos juego = new VideoJuegos("Halo","Accion",2001,buguie);


//Blizzard.presentacion();

juego.presentacion();

class EmpresaDesarrolladora
{
    private int nit;
    public string nombre { get; }
    public EmpresaDesarrolladora(int nit, string nombre)
    {
        this.nit = nit;
        this.nombre = nombre;
    }
    public int getNit()
    {
        return this.nit;
    }
    public void presentacion()
    {
        Console.WriteLine($"La empresa {this.nombre}, con el Nit {this.getNit()} desde el metodo");
    }
}

class VideoJuegos{
    public string titulo {get;}
    public string genero {get;}
    public int age {get;}
    public EmpresaDesarrolladora empresa {get;}

    public VideoJuegos(string titulo, string genero, int age, EmpresaDesarrolladora empresa ){
        this.titulo=titulo;
        this.genero = genero;
        this.age = age;
        this.empresa = empresa;
        
    }

    public void presentacion(){
        //Console.WriteLine($"Titulo: {this.titulo}\nGenero: {this.genero}\nAño: {this.age}\nEmpresa: {this.empresa.nombre}");
        Console.WriteLine($"EL video Juego {this.titulo} de la empresa {this.empresa.nombre}, se lanzo en el Año {this.age}");
    }
}



