using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialInstruments.Interfaces;

namespace FinancialInstruments
{
    public class FinancialInstrument : IFinancialInstrument

    {
        #region Properties
        public double MarketValue { get; set; }

        public string Type { get; set; }
        #endregion

        #region Constructor
        public FinancialInstrument(double value, string clientSector)

        {
            MarketValue = value;

            Type = clientSector;
        }
        #endregion

    }
}
