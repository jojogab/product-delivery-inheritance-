using Products.Entities;


Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product #{i+1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (type == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (type == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        list.Add(new UsedProduct(manufactureDate, name, price));
    }
    else if(type == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine());

        list.Add(new ImportedProduct(customFee, name, price));
    }
}

foreach (Product product in list)
{
    Console.WriteLine(product.priceTag());
}