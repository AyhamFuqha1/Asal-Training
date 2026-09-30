using Task1;

ProductManger product = new ProductManger();

var productsExample = new[]
{
    ("ARC001", "Shampoo", "Hair shampoo 500ml", 12.50m, 5),
    ("ARC001", "Soap", "Hand soap", 3.75m, 20),
    ("ARC003", "", "Mint toothpaste", 4.25m, 15),
    ("ARC004", "Perfume", "Men perfume 100ml", 25.00m, -1),
    ("ARC005", "Body Lotion", "Moisturizing", 9.99m, 12)
};

for (int i = 0; i < productsExample.Length; i++)
{
    string message = product.addProduct(productsExample[i].Item1,
        productsExample[i].Item2,
        productsExample[i].Item3,
        productsExample[i].Item4,
        productsExample[i].Item5
    );
    Console.WriteLine( message );
}

product.ShowProducts();