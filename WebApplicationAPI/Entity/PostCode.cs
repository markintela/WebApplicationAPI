using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplicationAPI.Entity
{
    public partial class PostCode
    {

        public string Local { get; set; }

        public string Postcode { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        

    }
}
