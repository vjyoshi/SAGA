using SAGA.Basket.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.Basket.BL
{
    public class BasketBL : IBasketBL
    {
        private static List<Data.BasketDto> _basketList = new List<Data.BasketDto>();
        private static string _databaseConnection;

        public static string DatabaseConnection { get => _databaseConnection; set => _databaseConnection = value; }

        public BasketBL(string databaseConnection)
        {
            DatabaseConnection = databaseConnection;
            _basketList = LoadBaskets();
        }

        private List<Data.BasketDto> LoadBaskets()
        {
            // A concrete implementation is required for DB but for now, only Excel DB implemented 
            return File.ReadAllLines(DatabaseConnection)
                                           .Skip(1)
                                           .Select(v => Data.BasketDto.FromCsv(v))
                                           .OrderBy(b => b.CreatedDateTime)
                                           .ToList();
        }

        public Data.BasketDto GetBasket(string transactionNumber)
        {
            if (transactionNumber == null)
                return null;

            var result = _basketList.Where(i => i.TransactionNumber == transactionNumber).ToList();
            return result.Count == 0 ? null : result.FirstOrDefault();
        }

        public List<Data.BasketDto> GetAll(int? domain = null)
        {

            if (domain == null)
                return _basketList;
            else
            {
                var results = _basketList.Where(i => i.Domain == domain).ToList();
                return results.Count == 0 ? null : results;
            }
        }
    }
}
