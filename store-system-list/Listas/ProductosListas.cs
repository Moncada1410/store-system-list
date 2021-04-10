using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.Clases;
using store_system_list.Nodos;

namespace store_system_list.Listas
{
    public class ProductosListas
    {
        public ProductosNodos Head;

        public void AddProductos(Productos productosToAdd)
        {
            ProductosNodos newProductosNodos = new ProductosNodos();
            newProductosNodos.Productos = productosToAdd;

            if (Head == null)
            {
                Head = newProductosNodos;
            }
            else
            {
                ProductosNodos Last = Head;
                while (Last.Next != null)
                {
                    Last = Last.Next;
                }
                Last.Next = newProductosNodos;
            }
        }
    }
}
