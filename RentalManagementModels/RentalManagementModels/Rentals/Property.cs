using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    /// <summary>
    /// an object representation of a rental property
    /// </summary>
    public class Property : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Property(bool isNew)
        {
            _Renters = new List<Renter>();
            SetupModel(isNew);
        }

        #region Name - the name of the property
        private string _Name;

        /// <summary>
        /// the name of the property
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != _Name)
                {
                    PropertyChanged();
                    _Name = value;
                }
            }
        }

        #endregion // Name

        #region Description - a description of the property
        private string _Description;

        /// <summary>
        /// a description of the property
        /// </summary>
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (value != _Description)
                {
                    PropertyChanged();
                    _Description = value;
                }
            }
        }

        #endregion // Description

        #region PropertyLocation - the location of this property
        private Location _PropertyLocation;

        /// <summary>
        /// the location of this property
        /// </summary>
        public Location PropertyLocation
        {
            get
            {
                return _PropertyLocation;
            }
            set
            {
                if (value != _PropertyLocation)
                {
                    PropertyChanged();
                    _PropertyLocation = value;
                }
            }
        }

        #endregion // PropertyLocation
        
        #region PropertyImage - an image of the property
        private Uri _PropertyImage;

        /// <summary>
        /// an image of the property
        /// </summary>
        public Uri PropertyImage
        {
            get
            {
                return _PropertyImage;
            }
            set
            {
                if (value != _PropertyImage)
                {
                    PropertyChanged();
                    _PropertyImage = value;
                }
            }
        }

        #endregion // PropertyImage

        #region IsRented - whether or not the property is currently rented
        private bool _IsRented;

        /// <summary>
        /// whether or not the property is currently rented
        /// </summary>
        public bool IsRented
        {
            get
            {
                return _IsRented;
            }
            set
            {
                if (value != _IsRented)
                {
                    PropertyChanged();
                    _IsRented = value;
                }
            }
        }

        #endregion // IsRented

        #region RentalStartDate - the start date of the current rental
        private DateTime? _RentalStartDate;

        /// <summary>
        /// the start date of the current rental
        /// </summary>
        public DateTime? RentalStartDate
        {
            get
            {
                return _RentalStartDate;
            }
            set
            {
                if (value != _RentalStartDate)
                {
                    PropertyChanged();
                    _RentalStartDate = value;
                }
            }
        }

        #endregion // RentalStartDate

        #region RentalEndDate - the projectd end date of the current rental
        private DateTime? _RentalEndDate;

        /// <summary>
        /// the projectd end date of the current rental
        /// </summary>
        public DateTime? RentalEndDate
        {
            get
            {
                return _RentalEndDate;
            }
            set
            {
                if (value != _RentalEndDate)
                {
                    PropertyChanged();
                    _RentalEndDate = value;
                }
            }
        }

        #endregion // RentalEndDate

        #region Renters - a list of people currently renting the property
        private List<Renter> _Renters;

        /// <summary>
        /// a list of people currently renting the property
        /// </summary>
        public List<Renter> Renters
        {
            get
            {
                return _Renters;
            }
            set
            {
                if (value != _Renters)
                {
                    PropertyChanged();
                    _Renters = value;
                }
            }
        }

        #endregion // Renters

    }
}
