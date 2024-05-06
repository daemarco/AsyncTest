namespace AsyncTest.Infrastructure
{
    public interface ICatalogRepo
    {
        Task<IEnumerable<string>> SearchProducts(string searchString);
    }
}
