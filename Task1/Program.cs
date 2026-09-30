using Task1;

ProductManger product = new ProductManger();

product.addProduct("ARC001", "Shampoo", "Hair shampoo 500ml", 12.50m, 5);
product.addProduct("ARC001", "Soap", "Hand soap", 3.75m, 20);
product.addProduct("ARC003", "Toothpaste", "Mint toothpaste", 4.25m, 15);
product.addProduct("ARC004", "Perfume", "Men perfume 100ml", 25.00m, 8);
product.addProduct("ARC005", "Body Lotion", "Moisturizing", 9.99m, 12);

product.ShowProducts();