using System.Collections.Generic;

namespace SAGA.Basket.BL.Interfaces
{
    public interface IBasketBL
    {
        Data.BasketDto GetBasket(string transactionNumber);
        List<Data.BasketDto> GetAll(int? domain = null);
    }
}
