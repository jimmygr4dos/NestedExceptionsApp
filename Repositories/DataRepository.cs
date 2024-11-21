using NestedExceptionsApp.Exceptions;

namespace NestedExceptionsApp.Repositories
{
    // Repositorio
    public interface IDataRepository
    {
        string GetData(int id);
    }
    public class DataRepository : IDataRepository
    {
        public string GetData(int id)
        {
            try
            {
                // Simular una excepción en el repositorio
                if (id <= 0)
                    throw new ArgumentOutOfRangeException(nameof(id), "El ID debe ser mayor que cero.");

                // Supongamos que aquí obtenemos datos de una base de datos
                return "Datos obtenidos del repositorio.";
            }
            catch (Exception ex)
            {
                // Envolver y propagar la excepción
                throw new RepositoryException("Error al obtener datos en el repositorio.", ex);
            }
        }
    }
}
