using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class PropertyEvaluation : IModel
    {
        public PropertyEvaluation()
        {
            AllResponses = new List<Response>();
        }

        public int Id { get; set; }

        public List<Response> AllResponses { get; set; }

        public DateTime EvaluationStarted { get; set; }

        public DateTime EvaluationEnded { get; set; }

        public Location PropertyEvaluated { get; set; }

        public int EvaluationUserId { get; set; }
    }
}
