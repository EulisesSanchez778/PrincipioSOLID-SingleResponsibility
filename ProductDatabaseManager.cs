
public class ProductDatabaseManager
{
    public void SaveToDatabase(Product product)
    {
        Console.WriteLine($"Guardando el producto '{product.Name}' en la base de datos...");
        // Lógica para guardar el producto en la base de datos
        Console.WriteLine($"Producto '{product.Name}' guardado exitosamente.");
    }
}
