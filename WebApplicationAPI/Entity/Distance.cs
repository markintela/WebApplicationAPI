using System.Collections.Generic;

namespace WebApplicationAPI.Entity
{
    public class Distance
    {

        public double DistanceMiles { get; set; }
        public double DistanceKilometres { get; set; }
        public PostCode PostCodeOrigin { get; set; }
        public PostCode PostCodeDestination { get; set; }
    }
}
