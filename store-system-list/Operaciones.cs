using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.Nodos;
using store_system_list.Clases;

namespace store_system_list
{
    public class Operaciones
    {
        public void CantidadTotalVentas(VentasNodos ventasNodos)
        {
            int contadorVentas = 1;
            double cantidadTotal = 0;

            VentasNodos Last = ventasNodos;

            while (Last.Next != null)
            {
                contadorVentas++;
                Last = Last.Next;
            }

            for (int i = 0; i < contadorVentas; i++)
            {
                cantidadTotal = ventasNodos.Ventas.PrecioTotal + cantidadTotal;

                if (ventasNodos.Next != null)
                {
                    ventasNodos = ventasNodos.Next;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("La cantidad total de ventas es: " + cantidadTotal);
            Console.WriteLine("");
        }

        public void CompraMasGrande(VentasNodos ventasNodos)
        {
            string nombreCliente = "";
            string nombreProducto = "";
            double precioTotal = 0;
            double valorVenta = 0;
            int contadorVentas = 1;

            VentasNodos Last = ventasNodos;

            while (Last.Next != null)
            {
                contadorVentas++;
                Last = Last.Next;
            }
            for (int i = 0; i < contadorVentas; i++)
            {
                double precio = ventasNodos.Ventas.PrecioTotal;

                if (contadorVentas == 0)
                {
                    nombreCliente = ventasNodos.Ventas.Clientes.Nombre;
                    nombreProducto = ventasNodos.Ventas.Productos.Nombre;
                    precioTotal = ventasNodos.Ventas.PrecioTotal;
                    valorVenta = precioTotal;
                }
                else if (precio > contadorVentas)
                {
                    nombreCliente = ventasNodos.Ventas.Clientes.Nombre;
                    nombreProducto = ventasNodos.Ventas.Productos.Nombre;
                    precioTotal = ventasNodos.Ventas.PrecioTotal;
                    valorVenta = precioTotal;
                }
                if (ventasNodos.Next != null)
                {
                    ventasNodos = ventasNodos.Next;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Nombre del cliente: " + nombreCliente);
            Console.WriteLine("Nombre del producto: " + nombreProducto);
            Console.WriteLine("Valor de la venta: " + precioTotal);
            Console.WriteLine("");
        }
        public void ProductoConMasVentas(VentasNodos ventasNodos)
        {
            string nombreProducto = "";
            double masVentas = 0;
            double valorVenta = 0;
            int contadorVentas = 1;

            VentasNodos Last = ventasNodos;

            while (Last.Next != null)
            {
                contadorVentas++;
                Last = Last.Next;
            }

            for (int i = 0; i < contadorVentas; i++)
            {
                double cantidad = ventasNodos.Ventas.Cantidad;

                if (valorVenta == 0)
                {
                    nombreProducto = ventasNodos.Ventas.Productos.Nombre;
                    masVentas = ventasNodos.Ventas.Cantidad;
                    valorVenta = masVentas;

                }
                else if (cantidad > valorVenta)
                {
                    nombreProducto = ventasNodos.Ventas.Productos.Nombre;
                    masVentas = ventasNodos.Ventas.Cantidad;
                    valorVenta = masVentas;
                }
                ventasNodos = ventasNodos.Next;
            }
            Console.WriteLine("");
            Console.WriteLine("El producto que tiene mas venta: " + nombreProducto + " ,con una totalidad de: " + masVentas);
            Console.WriteLine("");


        }
        public void PromedioVentas(VentasNodos ventasNodos)
        {
            double cantidadTotal = 0;
            double promedioTotal = 0;
            int contadorVentas = 1;

            VentasNodos last = ventasNodos;

            while (last.Next != null)
            {
                contadorVentas++;
                last = last.Next;
            }

            for (int i = 0; i < contadorVentas; i++)
            {
                cantidadTotal = ventasNodos.Ventas.PrecioTotal + cantidadTotal;
                promedioTotal = cantidadTotal / contadorVentas;
                ventasNodos = ventasNodos.Next;
            }

            Console.WriteLine("");
            Console.WriteLine("El promedio de las ventas es: " + promedioTotal);
            Console.WriteLine("");
        }
        public void Existencias(VentasNodos ventasNodos)
        {
            int contadorVentas = 1;

            VentasNodos last = ventasNodos;

            while (last.Next != null)
            {
                contadorVentas++;
                last = last.Next;
            }

            for (int i = 0; i < contadorVentas; i++)
            {
                string nombreProducto = "";
                double ExistenciaDisponible = 0;

                nombreProducto = ventasNodos.Ventas.Productos.Nombre;
                ExistenciaDisponible = ventasNodos.Ventas.Productos.Existencias - ventasNodos.Ventas.Cantidad;
                ventasNodos = ventasNodos.Next;

                Console.WriteLine("Las existencias son: " + nombreProducto + " y su cantidad es: " + ExistenciaDisponible);
            }
        }
        public void ImprimirClientes(ClientesNodo clienteNodo)
        {
            int contadorCliente = 1;
            int codigo;
            string nombre;
            int Documento;

            ClientesNodo last = clienteNodo;

            while (last.Next != null)
            {
                contadorCliente++;
                last = last.Next;
            }

            for (int i = 0; i < contadorCliente; i++)
            {
                codigo = clienteNodo.Clientes.Codigo;
                nombre = clienteNodo.Clientes.Nombre;
                Documento = clienteNodo.Clientes.CC;

                Console.WriteLine("El codigo es: " + codigo + ". El nombre es: " + nombre + ". El documento es: " + Documento);

                clienteNodo = clienteNodo.Next;
            }

        }
        public int selectedMode(string typeNode) //adicionar o eliminar
        {
            string type = "falso";
            int selectedMode = 0;

            while (type == "falso") //mientras sea falso pregunta el writeline 
            {
                Console.WriteLine("Ingrese 1 si quieres ingresar " + typeNode + " o ingrese 2 si quieres eliminar " + typeNode);
                selectedMode = int.Parse(Console.ReadLine());
                if (selectedMode == 1 || selectedMode == 2)
                {
                    type = "verdad";
                }
            }
            return selectedMode;
        }
        public ClientesNodo InserDeleteClients(ClientesNodo clientesNodo)
        {
            ClientesNodo Head = clientesNodo;
            Operaciones operaciones = new Operaciones();
            int result = operaciones.selectedMode("Cliente"); //el typenode aparecera "insert a Client

            if (result == 1)
            {
                Clientes clientes = new Clientes();

                Console.WriteLine("Nombre: ");
                clientes.Nombre = Console.ReadLine();

                Console.WriteLine("Estrato: ");
                clientes.Estrato = int.Parse(Console.ReadLine());

                Console.WriteLine("Edad: ");
                clientes.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Cedula de ciudadania: ");
                clientes.CC = int.Parse(Console.ReadLine());

                Console.WriteLine("Genero: ");
                clientes.Genero = Console.ReadLine();



                ClientesNodo newClientesNodo = new ClientesNodo();
                newClientesNodo.Clientes = clientes;

                ClientesNodo last = clientesNodo;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                clientes.Codigo = last.Clientes.Codigo + 1; //toma el ultimo codigo y le suma 1 para crear uno nuevo
                last.Next = newClientesNodo;

            }
            else if (result == 2)
            {
                ClientesNodo clientes;
                ClientesNodo baseClientNode = clientesNodo;
                ClientesNodo iterator = clientesNodo;
                ClientesNodo last = clientesNodo;

                Console.WriteLine("¿Que codigo quieres eliminar? : ");
                int deleteCode = int.Parse(Console.ReadLine());

                int contadorClientes = 1;

                while (last.Next != null)
                {
                    contadorClientes++;
                    last = last.Next;
                }

                for (int i = 0; i < contadorClientes; i++)
                {

                    if (iterator.Clientes.Codigo == deleteCode)
                    {
                        clientes = iterator.Next;
                        while (baseClientNode.Clientes.Codigo != deleteCode)
                        {
                            if (baseClientNode.Next != null & baseClientNode.Next.Clientes.Codigo != deleteCode)
                            {
                                baseClientNode = baseClientNode.Next;

                            }
                            else
                            {
                                break;
                            }
                        }
                        baseClientNode.Next = clientes;
                    }
                    iterator = iterator.Next;
                }
            }
            return clientesNodo;
        }
        public ClientesNodo retornar6Punto(ClientesNodo clientesNodo)
        {
            string type = "falso";
            Operaciones operaciones = new Operaciones();
            operaciones.ImprimirClientes(clientesNodo);

            while (type == "falso")
            {
                Console.WriteLine("Ingrese 1 para volver a elegir una opcion o si no oprime otro numero para finalizar el proceso");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    clientesNodo = operaciones.InserDeleteClients(clientesNodo);
                    operaciones.ImprimirClientes(clientesNodo);
                }
                else
                {
                    type = "verdad";
                }
            }
            return clientesNodo;
        }
        public void ImprimirProducto(ProductosNodos productosNodos)
        {
            int contadorProducto = 1;
            int Codigo;
            string Nombre;
            double Precio;

            ProductosNodos last = productosNodos;

            while (last.Next != null)
            {
                contadorProducto++;
                last = last.Next;
            }

            for (int i = 0; i < contadorProducto; i++)
            {
                Codigo = productosNodos.Productos.CodigoProducto;
                Nombre = productosNodos.Productos.Nombre;
                Precio = productosNodos.Productos.Precio;


                Console.WriteLine("El codigo del producto es: " + Codigo + ". El nombre del producto es: " + Nombre + ". El precio del producto es: " + Precio);

                productosNodos = productosNodos.Next;
            }

        }
        public ProductosNodos InsertarElProductoABorrar(ProductosNodos productosNodos)
        {
            ProductosNodos Head = productosNodos;
            Operaciones operaciones = new Operaciones();
            int result = operaciones.selectedMode("producto"); //el typenode aparecera "insert a Client

            if (result == 1)
            {
                Productos productos = new Productos();

                Console.WriteLine("Nombre: ");
                productos.Nombre = Console.ReadLine();

                Console.WriteLine("Precio: ");
                productos.Precio = int.Parse(Console.ReadLine());

                Console.WriteLine("Existencias: ");
                productos.Existencias = int.Parse(Console.ReadLine());

                Console.WriteLine("Categoria: ");
                productos.Categoria = Console.ReadLine();

                Console.WriteLine("Codigo del producto: ");
                productos.CodigoProducto = int.Parse(Console.ReadLine());



                ProductosNodos newProductosNodo = new ProductosNodos();
                newProductosNodo.Productos = productos;

                ProductosNodos last = Head;

                while (last.Next != null)
                {
                    last = last.Next;
                }
                productos.CodigoProducto = last.Productos.CodigoProducto + 1; //toma el ultimo codigo y le suma 1 para crear uno nuevo
                last.Next = newProductosNodo;
            }
            else if (result == 2)
            {
                ProductosNodos products;
                ProductosNodos baseProductNode = productosNodos;
                ProductosNodos iterator = productosNodos;
                ProductosNodos last = productosNodos;

                Console.WriteLine("¿Que codigo quieres eliminar? : ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countProducts = 1;

                while (last.Next != null)
                {
                    countProducts++;
                    last = last.Next;
                }

                for (int i = 0; i < countProducts; i++)
                {

                    if (iterator.Productos.CodigoProducto == deleteCode)
                    {
                        products = iterator.Next;
                        while (baseProductNode.Productos.CodigoProducto != deleteCode)
                        {
                            if (baseProductNode.Next != null & baseProductNode.Next.Productos.CodigoProducto != deleteCode)
                            {
                                baseProductNode = baseProductNode.Next;

                            }
                            else
                            {
                                break;
                            }
                        }
                        baseProductNode.Next = products;
                    }
                    iterator = iterator.Next;
                }
            }
            return productosNodos;
        }
        public ProductosNodos retornar7Punto(ProductosNodos productosNodos)
        {
            string type = "falso";
            Operaciones operaciones = new Operaciones();
            operaciones.ImprimirProducto(productosNodos);

            while (type == "false")
            {
                Console.WriteLine("");
                Console.WriteLine("Enter 1  to re-choose an option or another number to finish the process");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    productosNodos = operaciones.InsertarElProductoABorrar(productosNodos);
                    operaciones.ImprimirProducto(productosNodos);
                }
                else
                {
                    type = "verdad";
                }
            }
            return productosNodos;
        }
    }
}
