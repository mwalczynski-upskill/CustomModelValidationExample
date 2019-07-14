namespace CustomModelValidation.Services
{
    public class FakeProductsProvider : IProductsProvider
    {
        public bool Exists(int productId)
        {
            return productId < 5;
        }
    }
}
