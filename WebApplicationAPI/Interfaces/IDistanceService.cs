using System.Threading.Tasks;
using WebApplicationAPI.Entity;

namespace WebApplicationAPI.Interfaces
{
    public interface IDistanceService
    {

        Task<Distance> GetDistance(string codePost);

        double CalculateDistance(double latOrigin, double longOrigin, double latODestination, double longDestination);
    }
}
