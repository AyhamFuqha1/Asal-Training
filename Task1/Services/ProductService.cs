using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task1.Factories;
using Task1.Models;
using Task1.Readers.Interfaces;
using Task1.Repositories;
using Task1.Repositories.interfaces;
using Task1.Validation.Interfaces;
using Task1.Writers.Interfaces;

namespace Task1.Services
{
    internal class ProductService
    {
        private IProductReader productReader;
        private IProductWriter productWriter;

        private readonly IProductRepository productRepository;
        private readonly IProductValidator productValidator;
        private readonly ProductReaderFactory productReaderFactory;
        private readonly ProductWriterFactory productWriterFactory;

        public ProductService(
            IProductRepository productRepository,
            IProductValidator productValidator,
            ProductReaderFactory productReaderFactory,
            ProductWriterFactory productWriterFactory)
        {
            this.productRepository = productRepository;
            this.productValidator = productValidator;
            this.productReaderFactory = productReaderFactory;
            this.productWriterFactory = productWriterFactory;
        }
        public List<ProductResult> AddProduct(string type)
        {
            productReader = productReaderFactory.Create(type);
            List<Product> Product = productReader.Read();
            List<ProductResult> results = new List<ProductResult>();
            foreach (Product product in Product)
            {
                if (!productValidator.Validate(product, out string message))
                {
                    results.Add(new ProductResult(product, false, message));
                    continue;
                }
                if (!productRepository.CheckCode(product.ProductCode, out string messageCheck))
                {
                    results.Add(new ProductResult(product, false, messageCheck));
                    continue;
                }
                productRepository.AddProduct(product);

                results.Add(new ProductResult(product, true, "Product added successfully."));
            }

            return results;

        }
        public void ShowProducts(string type)
        {
            productWriter = productWriterFactory.Create(type);
            productWriter.Write(productRepository.IReadOnlyList());

        }
    }
}
