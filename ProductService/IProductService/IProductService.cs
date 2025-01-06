using ProductService.Business;

namespace ProductService.IProductService
{
    public interface IProductServices
    {
        public Task<List<Product>> GetProductList();
        public Task<Product> GetProductByName(string productName);
    }
}
