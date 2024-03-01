using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialInstruments.Interfaces;

namespace FinancialInstruments.UseCases
{
    /// <summary>
    /// Implement Category Classes. Each category will be a class that implements the IFinancialCategory interface.
    /// </summary>
    public class HighCategory : IFinancialCategory
    {
        public string Name => "HIGH VALUE";

        public bool IsMatch(IFinancialInstrument trade)
        {
            return trade.MarketValue > 5_000_000;
        }
    }
}
