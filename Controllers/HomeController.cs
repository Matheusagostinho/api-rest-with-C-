
using Microsoft.AspNetCore.Mvc;

namespace ApiRestfull.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
        public Object  GetMensagem(){
           
             var result = new
                    {
                        message = "Hello World"
                        
                    };

            return result;
        }
    [HttpPost]
        public Object PostHome([FromBody] object data){

            return data;
        }

     [HttpPut]
        public Object PutHome([FromBody] object data){

           
            
            return data;
        }
    [HttpDelete]
        public Object DeleteHome(){

           var result = new
                    {
                        message = "successfully delete"
                        
                    };
            
            return result;
        }

   
}
