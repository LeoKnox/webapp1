using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Services
{
    public class IStockService
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int StockId);
        void UpdateStock(int stockId, Stock stock);
        void DeleteStock(int stockId);
        void AddStock(Stock stock);
    }
}
