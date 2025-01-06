using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.IProductService;
using ProductService.Business;

namespace ProductService.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductControllers : ControllerBase
    {
        public readonly IProductServices _productServices;
        public ProductControllers(IProductServices productServices)
        {
            _productServices = productServices;
        }
        // GET: ProductControllercs

        [HttpGet]
        public async Task<List<Product>>  GetProductList()
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
        public async Task<List<Product>> GetProductListSearch(string name)
        {
            var productList =await _productServices.GetProductList();
            productList.Where(x => x.productName.Contains(name)).ToList();
            return productList;
        }
    }
}
