
namespace Library;

public class VisitorNombreLargo : IVisitor<Persona> //Heredamos de nuestra interfaz IVisitor
{

    private string Nombre;
    private int Largo = 0;
    public void Visit (Nodo<Persona> nodo) 
    {
        if (nodo.Content.Nombre.Largo > Largo)
        {
            this.Largo = nodo.Content.Nombre.Largo;
            this.Nombre = nodo.Content.Nombre;
        }
        foreach (Nodo<Persona> item in nodo.Children)  //Aceptamos todos
        {
            item.accept(this);
        }
    }

    public string nombreLargo (Nodo<Persona> nodo) 
    {
        nodo.accept(this);
        return this.Nombre;
    }
}