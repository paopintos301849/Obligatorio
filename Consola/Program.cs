using Dominio;

namespace Consola;

class Program
{
    static void Main(string[] args)
    {
        string opcion = "";
        
        while (opcion != "0") {
            MostrarMenu();
            Console.WriteLine("Ingrese una opción");
            opcion = Console.ReadLine();
            
            switch (opcion) {
                case "1":
                    OpcionListarClientes();
                    PresioneParaContinuar();
                    break;
                case "2":
                    OpcionListarVuelosSegunAeropuerto();
                    PresioneParaContinuar();
                    break;
                case "3":
                    OpcionAltaClienteOcasional();
                    PresioneParaContinuar();
                    break;
                case "4":
                    OpcionListarPasajesEntreFechas();
                    PresioneParaContinuar();
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
                default: 
                    MostrarError("ERROR: Opción inválida");
                    PresioneParaContinuar();
                    break;
            }
        }
    }

    static void MostrarMenu() {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("***** MENU *****");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1 - Listar todos los clientes");
        Console.WriteLine("2 - Listar vuelos por código de aeropuerto");
        Console.WriteLine("3 - Alta de cliente ocasional");
        Console.WriteLine("4 - Listar pasajes entre fechas");
        Console.WriteLine("0 - Salir");
    }

    /*Listado de todos los clientes. Mostrar nombre, email, nacionalidad y puntos o si es elegible, según
    corresponda.*/
    static void OpcionListarClientes()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("***** Listar todos los clientes *****");
        Console.ForegroundColor = ConsoleColor.Gray;       
    }
    
    /*Dado un código de aeropuerto listar todos los vuelos que lo incluyen. Mostrar número de vuelo,
    modelo del avión, ruta (en formato MVD – MIA), y frecuencia.*/
    static void OpcionListarVuelosSegunAeropuerto()
    {
        
    }
    
    /*Alta de cliente ocasional.*/
    static void OpcionAltaClienteOcasional()
    {
        
    }
    
    /*Dadas dos fechas, listar los pasajes entre esas fechas. Mostrar id, nombre del pasajero, precio, fecha
    y número de vuelo.*/
    static void OpcionListarPasajesEntreFechas()
    {
        
    }
    
    static void MostrarError(string mensaje) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensaje);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
    static void MostrarExito(string mensaje) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensaje);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static void PresioneParaContinuar() {
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}