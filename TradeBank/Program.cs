using FinancialInstruments;
using FinancialInstruments.Interfaces;
using FinancialInstruments.UseCases;

Console.WriteLine("Financial Instrument");
Console.WriteLine("--------------------");

//Execution examples below.
var trades = new List<IFinancialInstrument>
{
    new FinancialInstrument(800000, "Stock"),
    new FinancialInstrument(1500000, "Bond"),
    new FinancialInstrument(6000000, "Derivative"),
    new FinancialInstrument(300000, "Stock")
};

var categories = new List<IFinancialCategory>
{
    new LowCategory(),
    new MediumCategory(),
    new HighCategory()
};

var categorizer = new Categorizer(categories);
var tradeCategories = categorizer.CategorizeInstrument(trades);

// Output 
foreach (var category in tradeCategories)
{
    Console.WriteLine($"Result of instrument =  {category}");
}
