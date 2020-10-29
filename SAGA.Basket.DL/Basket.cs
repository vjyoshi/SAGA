using System;

namespace SAGA.Basket.DL
{
    public class Basket
    {
        public string TransactionNumber
        { get; set; }
        public Nullable<int> NumberOfPassengers
        { get; set; }
        public int Domain
        { get; set; }
        public Nullable<int> AgentId
        { get; set; }
        public string ReferrerUrl
        { get; set; }
        public DateTime CreatedDateTime
        { get; set; }
        public string UserId
        { get; set; }

        public string SelectedCurrency
        { get; set; }

        public string ReservationSystem
        { get; set; }
    }
}
