using NestedExceptionsApp.Exceptions;
using NestedExceptionsApp.Repositories;

namespace NestedExceptionsApp.Services
{
    // Servicio
    public interface IDataService
    {
        string ProcessData(int id);
    }
    public class DataService : IDataService
    {
        private readonly IDataRepository _repository;

        public DataService(IDataRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public string ProcessData(int id)
        {
            try
            {
                var data = _repository.GetData(id);
                // Procesar los datos (lógica de negocio)
                return $"Datos procesados: {data}";
            }
            catch (Exception ex)
            {
                // Envolver y propagar la excepción
                throw new ServiceException("Error al procesar datos en el servicio.", ex);
            }
        }
    }
}
