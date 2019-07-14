namespace CustomModelValidation.Services
{
    public interface IProductsProvider
    {
        bool Exists(int productId);
    }
}