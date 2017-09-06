using RentalManagementModels.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
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


        #region AllResponses
        private List<Response> _AllResponses;

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


        #region EvaluationStarted
        private DateTime _EvaluationStarted;

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


        #region EvaluationEnded
        private DateTime _EvaluationEnded;

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


        #region PropertyEvaluated
        private Location _PropertyEvaluated;

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

        
        #region EvaluationUserId
        private int _EvaluationUserId;

        public int EvaluationUserId
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
