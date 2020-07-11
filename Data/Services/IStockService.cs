using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public interface IStockService
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int stock);
        void UpdateSTock(int stockId, Stock stock);
        void DeleteStock(int stockId);
        void AddStock(Stock stock);
    }
}