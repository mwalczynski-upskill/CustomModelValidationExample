﻿namespace CustomModelValidation.Models
{
    using Attributes;

    [ProductValidation]
    public class AttributeValidatedProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
