using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    /// <summary>
    /// an object representation of a person renting a property.
    /// </summary>
    public class Renter : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Renter(bool isNew)
        {
            RentalHistory = new List<KeyValuePair<RenterInfoType, string>>();
            SetupModel(isNew);
        }

        #region FirstName - The first name of the renter
        private string _FirstName;

        /// <summary>
        /// The first name of the renter
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

        #region LastName - the last name of the renter
        private string _LastName;

        /// <summary>
        /// the last name of the renter
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

        #region SSN - the social security number of the renter
        private string _SSN;

        /// <summary>
        /// the social security number of the renter
        /// </summary>
        public string SSN
        {
            get
            {
                return _SSN;
            }
            set
            {
                if (value != _SSN)
                {
                    PropertyChanged();
                    _SSN = value;
                }
            }
        }

        #endregion // SSN

        #region RentalHistory - a list of history about this renter
        private List<KeyValuePair<RenterInfoType, string>> _RentalHistory;

        /// <summary>
        /// a list of history about this renter
        /// </summary>
        public List<KeyValuePair<RenterInfoType, string>> RentalHistory
        {
            get
            {
                return _RentalHistory;
            }
            set
            {
                if (value != _RentalHistory)
                {
                    PropertyChanged();
                    _RentalHistory = value;
                }
            }
        }

        #endregion // RentalHistory

        #region RenterImage - a picture of the renter
        private Uri _RenterImage;

        /// <summary>
        /// a picture of the renter
        /// </summary>
        public Uri RenterImage
        {
            get
            {
                return _RenterImage;
            }
            set
            {
                if (value != _RenterImage)
                {
                    PropertyChanged();
                    _RenterImage = value;
                }
            }
        }

        #endregion // RenterImage

        /// <summary>
        /// Different types of rental history
        /// Issue
        /// GeneralInfo
        /// Kudos
        /// </summary>
        public enum RenterInfoType
        {
            /// <summary>
            /// Denotes an issue that occured with a renter.
            /// </summary>
            Issue,

            /// <summary>
            /// Denotes general information about a renter.
            /// </summary>
            GeneralInfo,

            /// <summary>
            /// Denotes a positve experience with a renter.
            /// </summary>
            Kudos
        }

    }
}
