using Task1.Application.Validation;
using Task1.Factories;
using Task1.Repositories;
using Task1.Services;


ProductRepository productRepository = new ProductRepository();
ProductValidator productValidator = new ProductValidator();

ProductReaderFactory productReaderFactory = new ProductReaderFactory();
ProductWriterFactory productWriterFactory = new ProductWriterFactory();



ProductService productService = new ProductService(
    productRepository,
    productValidator,
    productReaderFactory,
    productWriterFactory
);

Console.WriteLine("Choose Reader:");
Console.WriteLine("1. Console");
Console.WriteLine("2. CSV");

int answer = int.Parse(Console.ReadLine());

string readerType;

if (answer == 1)
{
    readerType = "console";
}
else
{
    readerType = "csv";
}



var results = productService.AddProduct(readerType);


foreach (var result in results)
{
    Console.WriteLine(result.Message);
}



Console.WriteLine("\nChoose Writer:");
Console.WriteLine("1. Console");
Console.WriteLine("2. CSV");

int writerAnswer = int.Parse(Console.ReadLine());

string writerType;

if (writerAnswer == 1)
{
    writerType = "console";
}
else
{
    writerType = "csv";
}


productService.ShowProducts(writerType);