using System.Threading.Tasks;

namespace WebApplicationAPI.Interfaces
{
    public interface IMensureService
    {

        double MensureMiles(double distanceInMetres);

        double MensureKilometres(double distanceInMetres);
    }
}
