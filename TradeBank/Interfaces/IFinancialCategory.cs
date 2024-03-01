using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialInstruments.Interfaces;

namespace FinancialInstruments.Interfaces
{
    /// <summary>
    /// ITradeCategory Interface, this interface will be implemented by any class that represents a financial category, such as low, medium, or High.
    /// </summary>
    public interface IFinancialCategory
    {
        string Name { get; }

        bool IsMatch(IFinancialInstrument trade);

    }
}
