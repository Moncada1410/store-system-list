using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.Clases;
using store_system_list.Nodos;

namespace store_system_list.Listas
{
    public class VentasListas
    {
        public VentasNodos Head;

        public void AddVentas(Ventas ventasToAdd)
        {
            VentasNodos newVentasNodo = new VentasNodos();
            newVentasNodo.Ventas = ventasToAdd;

            if (Head == null)
            {
                Head = newVentasNodo;
            }
            else
            {
                VentasNodos Last = Head;
                while (Last.Next != null)
                {
                    Last = Last.Next;
                }
                Last.Next = newVentasNodo;
            }
        }
    }
}
