using ProductService.Business;

namespace ProductService.Data
{
    public class ProductData
    {
        public List<Product> Products()
        {

            var products = new List<Product>()
                {
                    new Product{productId=1, productName="Lenovo Laptop", productDescription="Lenovo 256GB SSD, 1TB HDD, 16GB ram", productPrice=50000 },
                    new Product{productId=2, productName="HP Laptop", productDescription="HP 1TB SSD, 1TB HDD, 16GB ram", productPrice=90000 },
                    new Product{productId=3, productName="Dell Laptop", productDescription="Dell 1.5TB SSD, 500GB HDD, 16GB ram", productPrice=80000 },
                };
            return products;
        }
    }
}
