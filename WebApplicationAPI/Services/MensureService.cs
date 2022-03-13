using GeoCoordinatePortable;
using System;
using System.Threading.Tasks;
using WebApplicationAPI.Interfaces;



namespace WebApplicationAPI.Services
{
    public class MensureService : IMensureService
    {
   
        public double MensureMiles(double distanceInMetres)
        {
            double miles = Math.Round((distanceInMetres / 1609.344),2);
            return miles;
        }

        public double MensureKilometres(double distanceInMetres)
        {
            double kilometre = Math.Round((distanceInMetres / 1000),2);
            return kilometre;
        }

       
    }
}
