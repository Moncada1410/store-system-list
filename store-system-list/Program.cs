using System;
using store_system_list.Clases;
using store_system_list.Nodos;
using store_system_list.Listas;

namespace store_system_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesListas clientesListas = new ClientesListas();
            Clientes c1 = new Clientes();
            c1.Nombre = "Martha";
            c1.Estrato = 4;
            c1.Genero = "Mujer";
            c1.Edad = 32;
            c1.CC = 75074983;
            c1.Codigo = 1;
            clientesListas.AddClientes(c1);


            Clientes c2 = new Clientes();
            c2.Nombre = "Julian";
            c2.Estrato = 5;
            c2.Genero = "Hombre";
            c2.Edad = 19;
            c2.CC = 75074987;
            c2.Codigo = 2;
            clientesListas.AddClientes(c2);

            Clientes c3 = new Clientes();
            c3.Nombre = "Chirsthoper";
            c3.Estrato = 6;
            c3.Genero = "Hombre";
            c3.Edad = 25;
            c3.CC = 75077883;
            c3.Codigo = 3;
            clientesListas.AddClientes(c3);

            Clientes c4 = new Clientes();
            c4.Nombre = "Mario";
            c4.Estrato = 3;
            c4.Genero = "Hombre";
            c4.Edad = 25;
            c4.CC = 75077883;
            c4.Codigo = 4;
            clientesListas.AddClientes(c4);

            Clientes c5 = new Clientes();
            c5.Nombre = "Karen";
            c5.Estrato = 3;
            c5.Genero = "Hombre";
            c5.Edad = 25;
            c5.CC = 75077883;
            c5.Codigo = 5;
            clientesListas.AddClientes(c5);

            VendedorListas vendedorListas = new VendedorListas();

            Vendedor v1 = new Vendedor();
            v1.Nombre = "Pepito";
            v1.Estrato = 1;
            v1.CC = 76562498;
            v1.Edad = 23;
            v1.Genero = "Hombre";
            v1.Codigo = 01;
            vendedorListas.AddVendedor(v1);

            Vendedor v2 = new Vendedor();
            v2.Nombre = "Sofia";
            v2.Estrato = 2;
            v2.CC = 79562498;
            v2.Edad = 30;
            v2.Genero = "Mujer";
            v2.Codigo = 02;
            vendedorListas.AddVendedor(v2);

            Vendedor v3 = new Vendedor();
            v3.Nombre = "Andres";
            v3.Estrato = 3;
            v3.CC = 78362498;
            v3.Edad = 18;
            v3.Genero = "Hombre";
            v3.Codigo = 03;
            vendedorListas.AddVendedor(v3);

            Vendedor v4 = new Vendedor();
            v4.Nombre = "Adriana";
            v4.Estrato = 5;
            v4.CC = 78562498;
            v4.Edad = 32;
            v4.Genero = "Hombre";
            v4.Codigo = 04;
            vendedorListas.AddVendedor(v4);

            Vendedor v5 = new Vendedor();
            v5.Nombre = "Carlos";
            v5.Estrato = 4;
            v5.CC = 78569498;
            v5.Edad = 21;
            v5.Genero = "Hombre";
            v5.Codigo = 05;
            vendedorListas.AddVendedor(v5);

            ProductosListas productosListas = new ProductosListas();

            Productos p1 = new Productos();
            p1.Nombre = "God of war";
            p1.Precio = 49.99;
            p1.Categoria = "Videojuegos";
            p1.CodigoProducto = 1;
            p1.Existencias = 31;
            productosListas.AddProductos(p1);


            Productos p2 = new Productos();
            p2.Nombre = "Ghost recon";
            p2.Precio = 39.99;
            p2.Categoria = "Videojuegos";
            p2.CodigoProducto = 2;
            p2.Existencias = 6;
            productosListas.AddProductos(p2);

            Productos p3 = new Productos();
            p3.Nombre = "Arroz";
            p3.Precio = 9.99;
            p3.Categoria = "Comida";
            p3.CodigoProducto = 3;
            p3.Existencias = 28;
            productosListas.AddProductos(p3);

            Productos p4 = new Productos();
            p4.Nombre = "LOL";
            p4.Precio = 19.99;
            p4.Categoria = "Videojuegos";
            p4.CodigoProducto = 4;
            p4.Existencias = 21;
            productosListas.AddProductos(p4);

            Productos p5 = new Productos();
            p5.Nombre = "Cepillo dental";
            p5.Precio = 8.99;
            p5.Categoria = "Aseo";
            p5.CodigoProducto = 5;
            p5.Existencias = 17;
            productosListas.AddProductos(p5);

            Productos p6 = new Productos();
            p6.Nombre = "Escoba";
            p6.Precio = 3.99;
            p6.Categoria = "Aseo";
            p6.CodigoProducto = 6;
            p6.Existencias = 25;
            productosListas.AddProductos(p6);

            Productos p7 = new Productos();
            p7.Nombre = "Juguito hit";
            p7.Precio = 1.99;
            p7.Categoria = "Comida";
            p7.CodigoProducto = 7;
            p7.Existencias = 54;
            productosListas.AddProductos(p7);

            Productos p8 = new Productos();
            p8.Nombre = "Avena";
            p8.Precio = 0.99;
            p8.Categoria = "Comida";
            p8.CodigoProducto = 8;
            p8.Existencias = 71;
            productosListas.AddProductos(p8);

            Productos p9 = new Productos();
            p9.Nombre = "GTA V";
            p9.Precio = 60.99;
            p9.Categoria = "Videojuegos";
            p9.CodigoProducto = 9;
            p9.Existencias = 99;
            productosListas.AddProductos(p9);

            Productos p10 = new Productos();
            p10.Nombre = "GTA IV";
            p10.Precio = 10;
            p10.Categoria = "Videojuegos";
            p10.CodigoProducto = 10;
            p10.Existencias = 50;
            productosListas.AddProductos(p10);

            VentasListas ventasListas = new VentasListas();

            Ventas ve1 = new Ventas();
            ve1.Productos = p1;
            ve1.Clientes = c1;
            ve1.Vendedor = v2;
            ve1.Codigo = 101;
            ve1.Cantidad = 4;
            ve1.PrecioTotal = ve1.Cantidad * p1.Precio;
            ventasListas.AddVentas(ve1);

            Ventas ve2 = new Ventas();
            ve2.Productos = p2;
            ve2.Clientes = c1;
            ve2.Vendedor = v2;
            ve2.Codigo = 102;
            ve2.Cantidad = 4;
            ve2.PrecioTotal = ve2.Cantidad * p2.Precio;
            ventasListas.AddVentas(ve2);

            Ventas ve3 = new Ventas();
            ve3.Productos = p3;
            ve3.Clientes = c2;
            ve3.Vendedor = v1;
            ve3.Codigo = 103;
            ve3.Cantidad = 8;
            ve3.PrecioTotal = ve3.Cantidad * p3.Precio;
            ventasListas.AddVentas(ve3);

            Ventas ve4 = new Ventas();
            ve4.Productos = p4;
            ve4.Clientes = c2;
            ve4.Vendedor = v1;
            ve4.Codigo = 104;
            ve4.Cantidad = 7;
            ve4.PrecioTotal = ve4.Cantidad * p4.Precio;
            ventasListas.AddVentas(ve4);

            Ventas ve5 = new Ventas();
            ve5.Productos = p5;
            ve5.Clientes = c3;
            ve5.Vendedor = v3;
            ve5.Codigo = 105;
            ve5.Cantidad = 3;
            ve5.PrecioTotal = ve5.Cantidad * p5.Precio;
            ventasListas.AddVentas(ve5);

            Ventas ve6 = new Ventas();
            ve6.Productos = p6;
            ve6.Clientes = c3;
            ve6.Vendedor = v3;
            ve6.Codigo = 106;
            ve6.Cantidad = 9;
            ve6.PrecioTotal = ve6.Cantidad * p6.Precio;
            ventasListas.AddVentas(ve6);

            Ventas ve7 = new Ventas();
            ve7.Productos = p7;
            ve7.Clientes = c4;
            ve7.Vendedor = v4;
            ve7.Codigo = 107;
            ve7.Cantidad = 6;
            ve7.PrecioTotal = ve7.Cantidad * p7.Precio;
            ventasListas.AddVentas(ve7);

            Ventas ve8 = new Ventas();
            ve8.Productos = p8;
            ve8.Clientes = c4;
            ve8.Vendedor = v4;
            ve8.Codigo = 108;
            ve8.Cantidad = 5;
            ve8.PrecioTotal = ve8.Cantidad * p8.Precio;
            ventasListas.AddVentas(ve8);

            Ventas ve9 = new Ventas();
            ve9.Productos = p9;
            ve9.Clientes = c5;
            ve9.Vendedor = v5;
            ve9.Codigo = 109;
            ve9.Cantidad = 7;
            ve9.PrecioTotal = ve9.Cantidad * p9.Precio;
            ventasListas.AddVentas(ve9);

            Ventas ve10 = new Ventas();
            ve10.Productos = p10;
            ve10.Clientes = c5;
            ve10.Vendedor = v5;
            ve10.Codigo = 1010;
            ve10.Cantidad = 2;
            ve10.PrecioTotal = ve10.Cantidad * p10.Precio;
            ventasListas.AddVentas(ve6);


            Operaciones operaciones = new Operaciones();
            Console.WriteLine("--------------------Cantidad Total Ventas-------------------------");
            operaciones.CantidadTotalVentas(ventasListas.Head);

            Console.WriteLine("--------------------Compra Mas Grande-------------------------");
            operaciones.CompraMasGrande(ventasListas.Head);

            Console.WriteLine("--------------------Producto Con Mas Ventas-------------------------");
            operaciones.ProductoConMasVentas(ventasListas.Head);

            Console.WriteLine("--------------------Promedio Ventas-------------------------");
            operaciones.PromedioVentas(ventasListas.Head);

            Console.WriteLine("--------------------Existencias-------------------------");
            operaciones.Existencias(ventasListas.Head);

            Console.WriteLine("--------------------Insertar, Eliminar  y Imprimir clientes-------------------------");
            Console.WriteLine("");
            operaciones.InserDeleteClients(clientesListas.Head);
            Console.WriteLine("");
            operaciones.retornar6Punto(clientesListas.Head);

            Console.WriteLine("--------------------Insertar, Eliminar  y Imprimir Productos-------------------------");
            Console.WriteLine("");
            operaciones.InsertarElProductoABorrar(productosListas.Head);
            Console.WriteLine("");
            operaciones.retornar7Punto(productosListas.Head);
        }
    }
}
