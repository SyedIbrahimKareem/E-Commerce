using ProductService.Business;

namespace ProductService.Data
{
    public class ProductData
    {
        public List<Product> Products()
        {

            var products = new List<Product>()
                {
                    new Product{productId=1, productName="Lenovo Laptop", productPrice=50000 },
                    new Product{productId=2, productName="HP Laptop",  productPrice=90000 },
                    new Product{productId=3, productName="Dell Laptop", productPrice=80000 },
                };
            return products;
        }
    }
}
