using ProductService.IProductService;
using ProductService.Business;
using ProductService.Data;
namespace ProductService.ProductService
{
    public class ProductServices : IProductServices
    {
        public async Task<List<Product>> GetProductList()
        {
            try
            {

                ProductData productData = new ProductData();
                var ProductsList =  productData.Products();
                return ProductsList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Product> GetProductByName(string productName)
        {

            var productList = await GetProductList();
            var ProductDetail = productList.Where(x => x.productName.Contains(productName)).First();
            return ProductDetail;
        }

    }
}
