using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.IProductService;
using ProductService.Business;

namespace ProductService.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductsControllers : ControllerBase
    {
        public readonly IProductServices _productServices;
        public ProductsControllers(IProductServices productServices)
        {
            _productServices = productServices;
        }
        // GET: ProductControllercs

        [HttpGet]
        public async Task<IEnumerable<Product>>  GetProductList()
        {
            var productList= await _productServices.GetProductList();
            return productList;
        }

        // GET: ProductControllercs/Details/5
        [HttpGet]
        public async Task<Product> GetProductDetailByName(string name)
        {
            var productList =await _productServices.GetProductByName(name);
            return productList;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductListSearch(string searchValue)
        {
            var productList =await _productServices.GetProductList();
            productList.Where(x => x.productName.Contains(searchValue)).ToList();
            return productList;
        }
    }
}
