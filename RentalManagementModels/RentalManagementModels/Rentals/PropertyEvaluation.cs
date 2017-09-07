using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    /// <summary>
    /// an object representation of a property evalation performed by a property manager
    /// </summary>
    public class PropertyEvaluation : ModelBase
    {

        /// <summary>
        /// CTOR telling the model if it is a new instance or an existing hydrated instance
        /// </summary>
        public PropertyEvaluation(bool isNew)
        {
            AllResponses = new List<Response>();
            SetupModel(isNew);
        }

        #region AllResponses - a list of the responses to the evaluation of this property
        private List<Response> _AllResponses;

        /// <summary>
        /// a list of the responses to the evaluation of this property
        /// </summary>
        public List<Response> AllResponses
        {
            get
            {
                return _AllResponses;
            }
            set
            {
                if (value != _AllResponses)
                {
                    PropertyChanged();
                    _AllResponses = value;
                }
            }
        }

        #endregion // AllResponses

        #region EvaluationStarted - the date and time that the property evalutation was started
        private DateTime _EvaluationStarted;

        /// <summary>
        /// the date and time that the property evalutation was started
        /// </summary>
        public DateTime EvaluationStarted
        {
            get
            {
                return _EvaluationStarted;
            }
            set
            {
                if (value != _EvaluationStarted)
                {
                    PropertyChanged();
                    _EvaluationStarted = value;
                }
            }
        }

        #endregion // EvaluationStarted

        #region EvaluationEnded - the date and time that the property evaluation ended
        private DateTime _EvaluationEnded;

        /// <summary>
        /// the date and time that the property evaluation ended
        /// </summary>
        public DateTime EvaluationEnded
        {
            get
            {
                return _EvaluationEnded;
            }
            set
            {
                if (value != _EvaluationEnded)
                {
                    PropertyChanged();
                    _EvaluationEnded = value;
                }
            }
        }

        #endregion // EvaluationEnded

        #region PropertyEvaluated - the location of the property that was evaluated
        private Location _PropertyEvaluated;

        /// <summary>
        /// the location of the property that was evaluated
        /// </summary>
        public Location PropertyEvaluated
        {
            get
            {
                return _PropertyEvaluated;
            }
            set
            {
                if (value != _PropertyEvaluated)
                {
                    PropertyChanged();
                    _PropertyEvaluated = value;
                }
            }
        }

        #endregion // PropertyEvaluated

        #region EvaluationUserId - the user who performed the evaluation of this property
        private string _EvaluationUserId;

        /// <summary>
        /// the user who performed the evaluation of this property
        /// </summary>
        public string EvaluationUserId
        {
            get
            {
                return _EvaluationUserId;
            }
            set
            {
                if (value != _EvaluationUserId)
                {
                    PropertyChanged();
                    _EvaluationUserId = value;
                }
            }
        }

        #endregion // EvaluationUserId

    }
}
