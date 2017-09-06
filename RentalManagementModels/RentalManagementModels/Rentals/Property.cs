using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Property : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Property(bool isNew)
        {
            SetupModel(isNew);
        }


        #region Name
        private string _Name;

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


        #region Description
        private string _Description;

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


        #region PropertyLocation
        private Location _PropertyLocation;

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


        #region RentalStatus
        private Rental _RentalStatus;

        public Rental RentalStatus
        {
            get
            {
                return _RentalStatus;
            }
            set
            {
                if (value != _RentalStatus)
                {
                    PropertyChanged();
                    _RentalStatus = value;
                }
            }
        }

        #endregion // RentalStatus


        #region PropertyImage
        private Uri _PropertyImage;

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

    }
}
