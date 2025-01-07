using ProductService.IProductService;
using ProductService.Business;
using ProductService.Data;
using ProductService.Dapper;
using Dapper;
namespace ProductService.ProductService
{
    public class ProductServices : IProductServices
    {
        private readonly DapperContext _dapperContext;
        public ProductServices(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Product>> GetProductList()
        {
            try
            {
                var query = "Select * FROM Products";
                using (var connection = _dapperContext.CreateConnection())
                {
                    var products= await connection.QueryAsync<Product>(query);
                    return products;
                }
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
