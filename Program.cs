using NestedExceptionsApp.Controllers;
using NestedExceptionsApp.Repositories;
using NestedExceptionsApp.Services;

namespace NestedExceptionsDemo
{
    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            IDataRepository repository = new DataRepository();
            IDataService service = new DataService(repository);
            var controller = new DataController(service);

            // Intentar mostrar datos con un ID inválido para generar una excepción
            controller.DisplayData(0);

            Console.ReadKey();
        }
    }
}
