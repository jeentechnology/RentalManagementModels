using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    /// <summary>
    /// an object representation of an individual response to a property evaluation
    /// </summary>
    public class Response : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public Response(bool isNew)
        {
            SetupModel(isNew);
        }

        #region ResponseDateTimeStamp - the date and time that this response was collected
        private DateTime _ResponseDateTimeStamp;

        /// <summary>
        /// the date and time that this response was collected
        /// </summary>
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

        #region ResposneValue - the value that was selected for the question that was asked
        private string _ResposneValue;

        /// <summary>
        /// the value that was selected for the question that was asked
        /// </summary>
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

        #region QuestionId - the question that corresponded to this response
        private string _QuestionId;

        /// <summary>
        /// the question that corresponded to this response
        /// </summary>
        public string QuestionId
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

        #region ScaleId - the scale that corresponds to this repsonse
        private string _ScaleId;

        /// <summary>
        /// the scale that corresponds to this repsonse
        /// </summary>
        public string ScaleId
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
