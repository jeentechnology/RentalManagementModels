using System;
using System.Collections.Generic;
using System.Text;
using RentalManagementModels.Utility;

namespace RentalManagementModels.Rentals
{
    /// <summary>
    /// An object representation of a physical location somewhere in the United States
    /// </summary>
    public class Location : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Location(bool isNew)
        {
            SetupModel(isNew);
        }

        #region Address1 - the first line of the locations address
        private string _Address1;

        /// <summary>
        /// the first line of the locations address
        /// </summary>
        public string Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                if (value != _Address1)
                {
                    PropertyChanged();
                    _Address1 = value;
                }
            }
        }

        #endregion // Address1

        #region Address2 - the second line of the locations address
        private string _Address2;

        /// <summary>
        /// the second line of the locations address
        /// </summary>
        public string Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                if (value != _Address2)
                {
                    PropertyChanged();
                    _Address2 = value;
                }
            }
        }

        #endregion // Address2

        #region City - the city of the location
        private string _City;

        /// <summary>
        /// the city of the location
        /// </summary>
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                if (value != _City)
                {
                    PropertyChanged();
                    _City = value;
                }
            }
        }

        #endregion // City

        #region LocationState - the state in the us of the location
        private USState _LocationState;

        /// <summary>
        /// the state in the us of the location
        /// </summary>
        public USState LocationState
        {
            get
            {
                return _LocationState;
            }
            set
            {
                if (value != _LocationState)
                {
                    PropertyChanged();
                    _LocationState = value;
                }
            }
        }

        #endregion // LocationState

        #region ZipCode - the zip code of the location
        private string _ZipCode;

        /// <summary>
        /// the zip code of the location
        /// </summary>
        public string ZipCode
        {
            get
            {
                return _ZipCode;
            }
            set
            {
                if (value != _ZipCode)
                {
                    PropertyChanged();
                    _ZipCode = value;
                }
            }
        }

        #endregion // ZipCode

        #region Lattitude - the lattitude of the location
        private decimal _Lattitude;

        /// <summary>
        /// the lattitude of the location
        /// </summary>
        public decimal Lattitude
        {
            get
            {
                return _Lattitude;
            }
            set
            {
                if (value != _Lattitude)
                {
                    PropertyChanged();
                    _Lattitude = value;
                }
            }
        }

        #endregion // Lattitude

        #region Longitude - the longitude of the location
        private decimal _Longitude;

        /// <summary>
        /// the longitude of the location
        /// </summary>
        public decimal Longitude
        {
            get
            {
                return _Longitude;
            }
            set
            {
                if (value != _Longitude)
                {
                    PropertyChanged();
                    _Longitude = value;
                }
            }
        }

        #endregion // Longitude

    }
}
