using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.Clases;
using store_system_list.Nodos;

namespace store_system_list.Listas
{
    public class VendedorListas
    {
        public VendedorNodos Head;

        public void AddVendedor(Vendedor vendedorToAdd)
        {
            VendedorNodos newVendedorNodo = new VendedorNodos();
            newVendedorNodo.Vendedor = vendedorToAdd;

            if (Head == null)
            {
                Head = newVendedorNodo;
            }
            else
            {
                VendedorNodos Last = Head;
                while (Last.Next != null)
                {
                    Last = Last.Next;
                }
                Last.Next = newVendedorNodo;
            }
        }
    }
}
