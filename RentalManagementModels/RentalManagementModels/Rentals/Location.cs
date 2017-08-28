using System;
using System.Collections.Generic;
using System.Text;
using RentalManagementModels.Utility;

namespace RentalManagementModels.Rentals
{
    public class Location
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public string ZipCode { get; set; }

        public decimal Lat { get; set; }

        public decimal Long { get; set; }

    }
}
