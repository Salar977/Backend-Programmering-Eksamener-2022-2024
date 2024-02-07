using System.Globalization;
using System.Text;

namespace Oppgave6;

public static class ProductService
{
    // Oppgave 6B
    public static IEnumerable<Product> ReadProductsFromCsv(string csvFile)
    {
        using StreamReader reader = new(csvFile, Encoding.UTF8);

        // ID, Name, Price, Quantity
        string? header = reader.ReadLine();
        if (header == null)
        {
            return Enumerable.Empty<Product>();
        }

        List<Product> products = new();

        string? line = reader.ReadLine();
        while (line != null)
        {
            var arr = line.Split(',');

            if (arr is [var id, var name, var price, var quantity])
            {
                if (!int.TryParse(id, out int productId) ||
                    !double.TryParse(price, CultureInfo.InvariantCulture, out double productPrice) ||
                    !int.TryParse(quantity, out int productQuantity))
                {
                    Console.WriteLine($"Cannot parse line: {line}");
                }
                else
                {
                    Product product = new(productId, name, productPrice, productQuantity);
                    products.Add(product);
                }
            }
            else
            {
                Console.WriteLine($"Bad Input on line: {line}");
            }
            line = reader.ReadLine();
        }

        return products;
    }
}