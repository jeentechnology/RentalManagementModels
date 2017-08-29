using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class RenterInfo
    {
        public string Description { get; set; }

        public RenterInfoType InfoType { get; set; } 

        public enum RenterInfoType
        {
            Issue,
            GeneralInfo,
            Kudos
        }
    }
}
