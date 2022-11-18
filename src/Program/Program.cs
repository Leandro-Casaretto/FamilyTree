using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Pedro = new Persona("Pedro", 19);
            Persona Maria = new Persona("Maria", 14);
            Persona Juan = new Persona("Juan", 28);
            Persona Jose = new Persona("Jose", 32);
            Persona Esteban = new Persona("Esteban", 27);
            Persona Eduardo = new Persona("Eduardo", 20);
            Persona Julieta = new Persona("Julieta", 31);
            Persona Agustina = new Persona("Agustina", 29);

            Nodo<Persona> n1 = new Nodo<Persona>(Pedro);
            Nodo<Persona> n2 = new Nodo<Persona>(Maria);
            Nodo<Persona> n3 = new Nodo<Persona>(Juan);
            Nodo<Persona> n4 = new Nodo<Persona>(Jose);
            Nodo<Persona> n5 = new Nodo<Persona>(Esteban);
            Nodo<Persona> n6 = new Nodo<Persona>(Eduardo);
            Nodo<Persona> n7 = new Nodo<Persona>(Julieta);
            Nodo<Persona> n8 = new Nodo<Persona>(Agustina);

            
            n1.AddChildren(n2);
            n2.AddChildren(n3);
            n3.AddChildren(n4);
            n4.AddChildren(n5);
            n5.AddChildren(n6);
            n6.AddChildren(n7);
            n7.AddChildren(n8);

            
            VisitorSumaEdad suma = new VisitorSumaEdad();
            
            System.Console.WriteLine(suma.getAgeSum(n6));

            VisitorMayorEdad mayor = new VisitorMayorEdad();
            System.Console.WriteLine(mayor.saberMayor(n6));

            VisitorNombreLargo largo = new VisitorNombreLargo();
            System.Console.WriteLine(largo.nombreLargo(n6));
        }
    }
}
