internal class Program
{
    private static void Main(string[] args)
    {
        var product = new Product
        {
            Name = "iPhone",
            Price = 1000
        };

        var databaseManager = new ProductDatabaseManager();
        var discountCalculator = new DiscountCalculator();
        var reportGenerator = new ReportGenerator();

        databaseManager.SaveToDatabase(product);
        discountCalculator.CalculateDiscount(product);
        reportGenerator.GenerateReport(product);

        
        
    }
}