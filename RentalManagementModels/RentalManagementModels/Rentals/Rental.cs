using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public struct Rental
    {
        public bool isRented { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public List<Renter> Renters { get; set; }
    }
}
