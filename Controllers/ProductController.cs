
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Products")]
public class ProductController
{

        private static List<Product> ListProducts = new();

     [HttpPost]
        public Object CreateProduct([FromBody] Product data){
            
            ListProducts.Add(data);
            return data;
        }
    [HttpGet]
        public List<Product>  AllProducts(){
           
            return ListProducts;
        }

        [HttpGet("{id:int}")]
        public Product  ReturnProduct([FromRoute] int id){
           Product product = ListProducts.SingleOrDefault( item => item.Id == id);
            return product;
        }

        [HttpDelete("{id:int}")]
        public Object  DeleteProduct([FromRoute] int id){
           Product product = ListProducts.SingleOrDefault( item => item.Id == id);

           ListProducts.Remove(product);
            return  new {
                message = "Product Deleted"
            };
        }

        [HttpPut("{id:int}")]
        public Product  UpdateProduct([FromRoute] int id, [FromBody] Product data){
           Product product = ListProducts.SingleOrDefault( item => item.Id == id);

            product.Title = data.Title;
            product.Amount = data.Amount;

            return product;
        }

}
