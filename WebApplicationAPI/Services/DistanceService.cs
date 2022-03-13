using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplicationAPI.Entity;
using WebApplicationAPI.Helper;
using WebApplicationAPI.Interfaces;

namespace WebApplicationAPI.Services
{
    public class DistanceService : IDistanceService
    {
      
        private readonly IPostCodeService _postCodeService;
        private readonly IMensureService _mensureService;
        private const string _longitude = CoordinatesConstants._constantLongitude;
        private const string _latitude = CoordinatesConstants._constantLatitude;



        public DistanceService(IPostCodeService postCodeService, IMensureService mensureService)
        {       
            _postCodeService = postCodeService;
            _mensureService = mensureService;
        }

        public async Task<Distance> GetDistance(string codePost)
        {
           
            //Origin location
            var postCodeOrigin = await _postCodeService.GetCoordinatesByGeoCoordinates(_longitude, _latitude);          
            //Destination location
            var postCodeDestination= await _postCodeService.GetCoordinatesByCodePost(codePost);      
                     
            var distanceInMetres = CalculateDistance(postCodeOrigin.Latitude, postCodeOrigin.Longitude, postCodeDestination.Latitude, postCodeDestination.Longitude);           
            var distance = new Distance
            {
                DistanceMiles = _mensureService.MensureMiles(distanceInMetres),
                DistanceKilometres =  _mensureService.MensureKilometres(distanceInMetres),
                PostCodeOrigin = postCodeOrigin,
                PostCodeDestination = postCodeDestination
            };           
            return distance;
        }

        public double CalculateDistance(double latOrigin, double longOrigin, double latODestination, double longDestination)
        {
            
            var origin = new GeoCoordinate(latOrigin, longOrigin);
            var destination = new GeoCoordinate(latODestination, longDestination);
            double distance = origin.GetDistanceTo(destination);

            return distance;
        }
    }
}
