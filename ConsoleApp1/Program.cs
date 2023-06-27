using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
  


    public static void Main(string[] args)
    {
        agregarCliente();
        consultarClientes();
        consultarCliente();
        modificarCliente();
        eliminarCliente();
        consultarClientesFunciones();
    }

    //agregar cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        SchoolContext context = new SchoolContext();
        Cliente cliente = new Cliente();
        
        Console.WriteLine("Nombre:");
        cliente.Nombre = Console.ReadLine();

        Console.WriteLine("Apellido:");
        cliente.Apellido = Console.ReadLine();

        Console.WriteLine("Dirección:");
        cliente.Direccion = Console.ReadLine();

        Console.WriteLine("Teléfono:");
        cliente.Telefono = Console.ReadLine();

        try
        {
            Console.WriteLine("Fecha de Nacimiento:");
            cliente.FechaNacimiento = DateTime.Parse(Console.ReadLine());

        }
        catch { 
            
        }

        context.Clientes.Add(cliente);
        context.SaveChanges();
      
        Console.WriteLine("Codigo: "+ cliente.Id + " Nombre: "+ cliente.Nombre);



    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes= context.Clientes.ToList() ;

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre);
        }
        
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        SchoolContext context = new SchoolContext();
        Cliente cliente = new Cliente();

        Console.WriteLine("Id ");

        Int32 Id  = Int32.Parse(Console.ReadLine()); 

        cliente = context.Clientes.Find(Id);

       Console.WriteLine("Codigo: " + cliente.Id + " Nombre: " + cliente.Nombre);
      
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        SchoolContext context = new SchoolContext();
        Cliente cliente = new Cliente();

        Console.WriteLine("Ingrese Id ");
        Int32 Id = Int32.Parse(Console.ReadLine());

        cliente = context.Clientes.Find(Id);

        if (cliente == null)
        {
            throw new Exception("Cliente no existe");
        }

        Console.WriteLine("Nombre:");
        cliente.Nombre = Console.ReadLine();

        Console.WriteLine("Apellido:");
        cliente.Apellido = Console.ReadLine();

        Console.WriteLine("Dirección:");
        cliente.Direccion = Console.ReadLine();

        Console.WriteLine("Teléfono:");
        cliente.Telefono = Console.ReadLine();

       
        Console.WriteLine("Fecha de Nacimiento:");
        cliente.FechaNacimiento = DateTime.Parse(Console.ReadLine());

       

        context.SaveChanges();
        Console.WriteLine("Codigo: " + cliente.Id + " Nombre: " + cliente.Nombre);

    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Eliminación de clientes");
        SchoolContext context = new SchoolContext();
        Cliente std = new Cliente();

        Console.WriteLine("Ingrese Id: ");

        Int32 Id = Int32.Parse(Console.ReadLine());

        std = context.Clientes.Find(Id);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }
    public static void consultarClientesFunciones()
    {
        Console.WriteLine("Metodo consultar clientes con el uso de funciones");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente cliente = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla:" +  cliente.Id +"-" +cliente.Nombre);

        //listEstudiantes = context.Students.Where(s => s.StudentId > 2 && s.Name == "Anita").ToList();

        //listEstudiantes = context.Students.Where(s => s.Name == "Patty" || s.Name == "Anita").ToList();

        listClientes = context.Clientes.Where(s => s.Nombre.StartsWith("A")).ToList();
        
        /*
        var query = context.Students.GroupBy( s => s.Name) 
        .Select(g => new
        {
            Nombre = g.Key,
            Cantidad = g.Count()
        }). ToList();

        foreach (var result in query)
        {
            Console.WriteLine($"Nombre: {result.Nombre}, Cantidad: {result.Cantidad}");
        }
        */
        
        
        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre);
        }
        

    }
}