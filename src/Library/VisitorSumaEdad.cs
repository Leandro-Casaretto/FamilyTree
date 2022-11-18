namespace Library;

public class VisitorSumaEdad : IVisitor<Persona>  //Heredamos de nuestra interfaz IVisitor
{
    private int suma = 0;
    public void Visit(Nodo<Persona> nodo) 
    {
        this.suma += nodo.Content.Edad;
        
        foreach (Nodo<Persona> item in nodo.Children) //Aceptamos todos
        {
            item.accept(this);
        }
    }

    public int getAgeSum(Nodo<Persona> nodo) 
    {
        nodo.accept(this);
        return this.suma;
    }
}