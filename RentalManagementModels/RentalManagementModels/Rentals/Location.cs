using System;
using System.Collections.Generic;
using System.Text;
using RentalManagementModels.Utility;

namespace RentalManagementModels.Rentals
{
    public class Location : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Location(bool isNew)
        {
            SetupModel(isNew);
        }


        #region Address1
        private string _Address1;

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


        #region Address2
        private string _Address2;

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


        #region City
        private string _City;

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


        #region State
        private State _State;

        public State State
        {
            get
            {
                return _State;
            }
            set
            {
                if (value != _State)
                {
                    PropertyChanged();
                    _State = value;
                }
            }
        }

        #endregion // State


        #region ZipCode
        private string _ZipCode;

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


        #region Lat
        private decimal _Lat;

        public decimal Lat
        {
            get
            {
                return _Lat;
            }
            set
            {
                if (value != _Lat)
                {
                    PropertyChanged();
                    _Lat = value;
                }
            }
        }

        #endregion // Lat


        #region Long
        private decimal _Long;

        public decimal Long
        {
            get
            {
                return _Long;
            }
            set
            {
                if (value != _Long)
                {
                    PropertyChanged();
                    _Long = value;
                }
            }
        }

        #endregion // Long

    }
}
