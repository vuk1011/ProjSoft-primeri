using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class JSLista<T>
    {
        private class Cvor<E>
        {
            public E Podatak { get; set; }
            public Cvor<E>? Sledeci { get; set; }

            public Cvor(E podatak)
            {
                Podatak = podatak;
                Sledeci = null;
            }
        }

        private Cvor<T>? Glava { get; set; }

        public void Ubaci(T element)
        {
            Cvor<T> noviCvor = new(element);
            if (Glava == null)
            {
                Glava = noviCvor;
                return;
            }
            noviCvor.Sledeci = Glava;
            Glava = noviCvor;
        }

        public void Izbaci(T element)
        {
            if (Glava == null) return;
            if (Glava.Podatak.Equals(element))
            {
                Glava = Glava.Sledeci;
                return;
            }

            Cvor<T> tmp = Glava;
            while (!tmp.Sledeci.Podatak.Equals(element))
            {
                tmp = tmp.Sledeci;
            }
            tmp.Sledeci = tmp.Sledeci.Sledeci;
        }
    }
}
