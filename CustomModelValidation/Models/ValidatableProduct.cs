namespace CustomModelValidation.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Services;

    public class ValidatableProduct : IValidatableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var productsProvider = (IProductsProvider)validationContext.GetService(typeof(IProductsProvider));

            var product = (ValidatableProduct)validationContext.ObjectInstance;

            if (productsProvider.Exists(product.Id))
            {
                yield return new ValidationResult("Product already exists");
            }
        }
    }
}
