namespace Library;

public class VisitorMayorEdad : IVisitor<Persona>  //Heredamos de nuestra interfaz IVisitor
{
    private int Mayor = 0;
    public void Visit (Nodo<Persona> nodo) 
    {
        if (nodo.Content.Edad > Mayor)
        {
            this.Mayor = nodo.Content.Edad;
        }
        foreach (Nodo<Persona> item in nodo.Children)
        {
            item.accept(this);
        }
    }

    public int saberMayor (Nodo<Persona> nodo) 
    {
        nodo.accept(this);
        return this.Mayor;
    }
}