using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialInstruments.Interfaces;

namespace FinancialInstruments
{
    /// <summary>
    /// This class will use a list of IFinancialCategory to determine the category of each.
    /// </summary>
    public class Categorizer
    {
        private readonly List<IFinancialCategory> _categories;

        public Categorizer(List<IFinancialCategory> categories)
        {
            _categories = categories ?? throw new ArgumentNullException(nameof(categories));
        }

        public List<string> CategorizeInstrument(IEnumerable<IFinancialInstrument> instruments)
        {
            var instrumentsCategories = new List<string>();

            foreach (var trade in instruments)
            {
                var category = _categories.FirstOrDefault(c => c.IsMatch(trade));

                instrumentsCategories.Add(category?.Name ?? "UNKNOWN");
            }

            return instrumentsCategories;
        }
    }
}
