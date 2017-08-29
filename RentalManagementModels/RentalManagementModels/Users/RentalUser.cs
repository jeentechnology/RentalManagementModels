using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Users
{
    public class RentalUser : IModel
    {
        public RentalUser()
        {
            UserAttributes = new List<KeyValuePair<string, string>>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }
        
        public List<KeyValuePair<string, string>> UserAttributes { get; set; }


        public enum UserRole
        {
            Admin,
            Owner,
            PropertyManager,
            Renter
        }
    }
}