// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Caballo babieca = new Caballo("juanchota");
Humano juan = new Humano("larga");
Gorila copito = new Gorila("pila");

//babieca.Galopar();
//juan.Pensar();
//copito.Trepar();

//babieca.Respirar();

//babieca.getNombre();
//juan.getNombre();
//copito.getNombre();


Mamiferos animal = new Caballo("pedro");
Mamiferos persona = new Humano(animal.GetType().ToString());
Mamiferos Animlaito = new Mamiferos("bucefalo");
Mamiferos gorila = new Gorila("soy un mono");

animal.getNombre();
animal = Animlaito;

animal.getNombre();

persona.getNombre();


Object miAnimal = new Caballo("obshet");

miAnimal.ToString(); // no escribe nada

Mamiferos[] almacenAnimales = new Mamiferos[4];

almacenAnimales[0] = animal;
almacenAnimales[1] = Animlaito;
almacenAnimales[2] = persona;
almacenAnimales[3] = gorila;

//almacenAnimales[1].getNombre();

foreach (var bicho in almacenAnimales)
{
    bicho.Pensar();
}


Console.ReadLine();
class Mamiferos
{
    public Mamiferos(string nombreSerVivo)
    {
        this.nombreSerVivo = nombreSerVivo;
    }

    private string nombreSerVivo { get; set; }
    public void Respirar()
    {
        Console.WriteLine("soy capaz de respirar");
    }

    public void CuidarCrias()
    {
        Console.WriteLine("Cuidado de mis Crias hasta que se valgan por si solas");
    }

    public void getNombre()
    {
        Console.WriteLine("Mi nombre es {0}", this.nombreSerVivo);
    }

    public virtual void Pensar()
    {
        Console.WriteLine("pensamiento b{asico instintivo");
    }
}

class Caballo : Mamiferos
{
    public Caballo(string nombreSerVivo) : base(nombreSerVivo)
    {

    }
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }
}


class Humano : Mamiferos
{
    public Humano(string nombreSerVivo) : base(nombreSerVivo)
    {

    }

    public override void Pensar()
    {
        Console.WriteLine("Soy capaz de pensar ¿?");
    }
}

class Gorila : Mamiferos
{
    public Gorila(string nombreSerVivo) : base(nombreSerVivo)
    {

    }
    public void Trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }

    public override void Pensar()
    {
        Console.WriteLine("Pensamiento instintivo avanzado");
    }
}
