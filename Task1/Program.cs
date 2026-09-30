using Task1;

ProductManger product = new ProductManger();

var productsExample = new[]
{
    ("ARC001", "Shampoo", "Hair shampoo 500ml", 12.50m, 5),
    ("ARC001", "Soap", "Hand soap", 3.75m, 20),
    ("ARC003", "kjl", "Mint toothpaste", 4.25m, 15),
    ("ARC004", "Perfume", "Men perfume 100ml", 25.00m, -1),
    ("ARC005", "Body Lotion", "Moisturizing", 9.99m, 12)
};


Console.WriteLine("1. Local\n2. CSV\n");

int answer = int.Parse(Console.ReadLine());

if (answer == 1)
{
    for (int i = 0; i < productsExample.Length; i++)
    {
        string message = product.addProduct(
            productsExample[i].Item1,
            productsExample[i].Item2,
            productsExample[i].Item3,
            productsExample[i].Item4,
            productsExample[i].Item5
        );

        Console.WriteLine(message);
    }
}
else
{
    string[] products = File.ReadAllLines(
        @"C:\Users\DELL\source\repos\Task1\Task1\product.csv"
    );
    for (int i= 1; i < products.Length; i++)
    {
        string[] data = products[i].Split(',');

        string code = data[0];
        string name = data[1];
        string description = data[2];
        decimal price = decimal.Parse(data[3]);
        int quantity = int.Parse(data[4]);

        string message = product.addProduct(
            code,
            name,
            description,
            price,
            quantity
        );

        Console.WriteLine(message);
    }
}

product.ShowProducts();