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

            Nodo<Persona> per1 = new Nodo<Persona>(Pedro);
            Nodo<Persona> per2 = new Nodo<Persona>(Maria);
            Nodo<Persona> per3 = new Nodo<Persona>(Juan);
            Nodo<Persona> per4 = new Nodo<Persona>(Jose);
            Nodo<Persona> per5 = new Nodo<Persona>(Esteban);
            Nodo<Persona> per6 = new Nodo<Persona>(Eduardo);
            Nodo<Persona> per7 = new Nodo<Persona>(Julieta);
            Nodo<Persona> per8 = new Nodo<Persona>(Agustina);

            
            per1.AddChildren(per2);
            per1.AddChildren(per3);
            per2.AddChildren(per4);
            per2.AddChildren(per5);
            per3.AddChildren(per6);
            per3.AddChildren(per7);
            per3.AddChildren(per8);

            
            VisitorSumaEdad suma = new VisitorSumaEdad();
            
            System.Console.WriteLine(suma.getAgeSum(per6));

            VisitorMayorEdad mayor = new VisitorMayorEdad();
            System.Console.WriteLine(mayor.saberMayor(per6));

            VisitorNombreLargo largo = new VisitorNombreLargo();
            System.Console.WriteLine(largo.nombreLargo(per6));
        }
    }
}
