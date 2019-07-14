namespace CustomModelValidation.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Attribute(AttributeValidatedProduct product)
        {
            return Ok(product);
        }

        [HttpPost]
        public IActionResult ValidatableObject(ValidatableProduct product)
        {
            return Ok(product);
        }
    }
}
