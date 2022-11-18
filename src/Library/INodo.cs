namespace Library;


/// <summary>
/// Esta interfaz declara el método de aceptación, el cual será utilizado
/// como argumento por la interfaz IVisitor
/// </summary>

public interface INodo<T>
{
    void accept(IVisitor<T> visitor);
}