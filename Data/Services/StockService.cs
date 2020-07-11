using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public interface StockService: IStockService
    {
        public void AddStock(Stock stock)
        { }

        public void DeleteStock(int stockId)
        { }

        public List<Stock> GetAllStocks()
        { }

        public Stock GetStockById(int stockId)
        { }


    }
}