namespace CustomModelValidation.Attributes
{
    using System.ComponentModel.DataAnnotations;
    using Models;
    using Services;

    public class ProductValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var productsProvider = (IProductsProvider)validationContext.GetService(typeof(IProductsProvider));

            var product = (AttributeValidatedProduct)validationContext.ObjectInstance;

            if (productsProvider.Exists(product.Id))
            {
                return new ValidationResult("Product already exists");
            }

            return ValidationResult.Success;
        }
    }
}
