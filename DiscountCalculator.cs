
public class DiscountCalculator
{
    public double CalculateDiscount(Product product)
    {
        Console.WriteLine($"Calculando el descuento para el producto '{product.Name}'...");
        // Lógica para calcular el descuento del producto
        double discount = product.Price * 0.1;
        Console.WriteLine($"Descuento calculado para el producto '{product.Name}': {discount:C}.");
        return discount;
    }
}
