using System;
using SAGA.Basket.BL.Extensions;

namespace SAGA.Basket.BL.Data
{
    public class BasketDto
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

        public static BasketDto FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            BasketDto basket = new BasketDto();
            basket.TransactionNumber = values[0];
            basket.NumberOfPassengers = StringExtensions.ToNullableInt(values[1]);
            basket.Domain = StringExtensions.ToInt(values[2]);
            basket.AgentId = StringExtensions.ToNullableInt(values[3]);
            basket.ReferrerUrl = values[4];
            basket.CreatedDateTime = StringExtensions.ToDateTime(values[5]);
            basket.UserId = values[6];
            basket.SelectedCurrency = values[7];
            basket.ReservationSystem = values[8];
            return basket;
        }

    }
}
