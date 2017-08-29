using System;
using System.Collections.Generic;
using System.Text;

namespace RentalManagementModels.Rentals
{
    public class Response : IModel
    {
        public int Id { get; set; }

        public DateTime ResponseDateTimeStamp { get; set; }

        public string ResponseValue { get; set; }

        public int QuestionId { get; set; }

        public int ScaleId { get; set; }
    }
}
