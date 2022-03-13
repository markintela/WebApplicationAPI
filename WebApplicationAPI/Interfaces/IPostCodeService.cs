using System.Threading.Tasks;
using WebApplicationAPI.Entity;

namespace WebApplicationAPI.Services
{
    public interface IPostCodeService
    {
        Task<PostCode> GetCoordinatesByCodePost(string codePost);
        Task<PostCode> GetCoordinatesByGeoCoordinates(string longitude, string latitude);
    }
}
