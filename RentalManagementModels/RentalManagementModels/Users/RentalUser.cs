using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Users
{
    /// <summary>
    /// represents a user of the rental managment system.
    /// </summary>
    public class RentalUser : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public RentalUser(bool isNew)
        {
            UserAttributes = new List<KeyValuePair<string, string>>();
            SetupModel(isNew);
        }

        #region FirstName - the users first name
        private string _FirstName;

        /// <summary>
        /// the users first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (value != _FirstName)
                {
                    PropertyChanged();
                    _FirstName = value;
                }
            }
        }

        #endregion // FirstName

        #region LastName - the users last name
        private string _LastName;

        /// <summary>
        /// the users last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (value != _LastName)
                {
                    PropertyChanged();
                    _LastName = value;
                }
            }
        }

        #endregion // LastName

        #region Email - the users email address
        private string _Email;

        /// <summary>
        /// the users email address
        /// </summary>
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (value != _Email)
                {
                    PropertyChanged();
                    _Email = value;
                }
            }
        }

        #endregion // Email

        #region Role - the role that the user has within the rental management ecosystem
        private UserRole _Role;

        /// <summary>
        /// the role that the user has within the rental management ecosystem
        /// </summary>
        public UserRole Role
        {
            get
            {
                return _Role;
            }
            set
            {
                if (value != _Role)
                {
                    PropertyChanged();
                    _Role = value;
                }
            }
        }

        #endregion // Role

        #region UserAttributes - a collection of attributes secific to the user
        private List<KeyValuePair<string,string>> _UserAttributes;

        /// <summary>
        /// a collection of attributes secific to the user
        /// </summary>
        public List<KeyValuePair<string,string>> UserAttributes
        {
            get
            {
                return _UserAttributes;
            }
            set
            {
                if (value != _UserAttributes)
                {
                    PropertyChanged();
                    _UserAttributes = value;
                }
            }
        }

        #endregion // UserAttributes
        
        /// <summary>
        /// The different roles that are available to users
        /// Admin
        /// Owner
        /// PropertyManager
        /// Renter
        /// </summary>
        public enum UserRole
        {
            /// <summary>
            /// an admin user who can 
            /// </summary>
            Admin,

            /// <summary>
            /// a property owner who can see all aspects of a certain property
            /// </summary>
            Owner,

            /// <summary>
            /// a user designated to mangae a specific property
            /// </summary>
            PropertyManager,

            /// <summary>
            /// A user who is renting a property
            /// </summary>
            Renter
        }
    }
}