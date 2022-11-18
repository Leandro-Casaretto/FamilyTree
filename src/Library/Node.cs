using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Nodo<T>: INodo<T> //Heredamos de nuestra interfaz INode
    {
        private T content;

        private List<Nodo<T>> children = new List<Nodo<T>>();

        public T Content 
        {
            get
            {
                return this.content;
            }
        }

        public ReadOnlyCollection<Nodo<T>> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Nodo(T t)
        {
            this.content = t;
        }

        public void AddChildren(Nodo<T> n)
        {
            this.children.Add(n);
        }

        public void accept(IVisitor<T> visitor){
            visitor.Visit(this);
        }
        
    }
}
