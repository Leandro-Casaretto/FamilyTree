namespace Library;

public interface IVisitor<T>
{
    void Visit(Nodo<T> nodo);
}