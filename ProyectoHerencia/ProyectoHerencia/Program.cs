// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Caballo babieca = new Caballo("juanchota");
Humano juan = new Humano("larga");
Gorila copito = new Gorila("pila");

babieca.Galopar();
juan.Pensar();
copito.Trepar();

babieca.Respirar();

babieca.getNombre();
juan.getNombre();
copito.getNombre();


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

    public void Pensar()
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
}
