using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Response : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Response(bool isNew)
        {
            SetupModel(isNew);
        }

        #region ResponseDateTimeStamp
        private DateTime _ResponseDateTimeStamp;

        public DateTime ResponseDateTimeStamp
        {
            get
            {
                return _ResponseDateTimeStamp;
            }
            set
            {
                if (value != _ResponseDateTimeStamp)
                {
                    PropertyChanged();
                    _ResponseDateTimeStamp = value;
                }
            }
        }

        #endregion // ResponseDateTimeStamp

        #region ResposneValue
        private string _ResposneValue;

        public string ResposneValue
        {
            get
            {
                return _ResposneValue;
            }
            set
            {
                if (value != _ResposneValue)
                {
                    PropertyChanged();
                    _ResposneValue = value;
                }
            }
        }

        #endregion // ResposneValue

        #region QuestionId
        private int _QuestionId;

        public int QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                if (value != _QuestionId)
                {
                    PropertyChanged();
                    _QuestionId = value;
                }
            }
        }

        #endregion // QuestionId

        #region ScaleId
        private int _ScaleId;

        public int ScaleId
        {
            get
            {
                return _ScaleId;
            }
            set
            {
                if (value != _ScaleId)
                {
                    PropertyChanged();
                    _ScaleId = value;
                }
            }
        }

        #endregion // ScaleId

    }
}
