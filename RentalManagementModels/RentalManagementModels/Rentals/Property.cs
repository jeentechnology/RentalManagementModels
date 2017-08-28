using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Property : IModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Location PropertyLocation { get; set; }

        public Rental RentalStatus { get; set; }
    }
}
