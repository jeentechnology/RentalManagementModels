using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Renter : IModel
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public List<RenterInfo> RentalHistroy { get; set; }

        public Uri PictureUrl { get; set; }

    }
}
