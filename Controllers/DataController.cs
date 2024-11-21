using NestedExceptionsApp.Exceptions;
using NestedExceptionsApp.Services;

namespace NestedExceptionsApp.Controllers
{
    // Controlador
    public class DataController
    {
        private readonly IDataService _service;

        public DataController(IDataService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public void DisplayData(int id)
        {
            try
            {
                var result = _service.ProcessData(id);
                Console.WriteLine(result);
            }
            catch (ServiceException ex)
            {
                Console.WriteLine($"Se produjo un error en el servicio: {ex.Message}");
                Console.WriteLine($"Detalle: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}
