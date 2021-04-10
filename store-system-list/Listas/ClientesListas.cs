using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.Clases;
using store_system_list.Nodos;

namespace store_system_list.Listas
{
    class ClientesListas
    {
        public ClientesNodo Head;

        public void AddClientes(Clientes clientesToAdd)
        {
            ClientesNodo newClientesNodo = new ClientesNodo();
            newClientesNodo.Clientes = clientesToAdd;

            if (Head == null)
            {
                Head = newClientesNodo;
            }
            else
            {
                ClientesNodo Last = Head;
                while (Last.Next!= null)
                {
                    Last = Last.Next;
                }
                Last.Next = newClientesNodo;
            }
        }
    }
}
