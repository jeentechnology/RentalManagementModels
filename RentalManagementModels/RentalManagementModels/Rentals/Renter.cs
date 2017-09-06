using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Renter : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Renter(bool isNew)
        {
            RentalHistory = new List<RenterInfo>();
            SetupModel(isNew);
        }


        #region FirstName
        private string _FirstName;

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

        #region LastName
        private string _LastName;

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

        #region SSN
        private string _SSN;

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

        #region RentalHistory
        private List<RenterInfo> _RentalHistory;

        public List<RenterInfo> RentalHistory
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

        #region PictureUrl
        private Uri _PictureUrl;

        public Uri PictureUrl
        {
            get
            {
                return _PictureUrl;
            }
            set
            {
                if (value != _PictureUrl)
                {
                    PropertyChanged();
                    _PictureUrl = value;
                }
            }
        }

        #endregion // PictureUrl

    }
}
