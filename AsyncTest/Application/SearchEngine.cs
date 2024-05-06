using AsyncTest.Infrastructure;

namespace AsyncTest.Application
{
    public class SearchEngine : ISearchEngine
    {
        private readonly ICatalogRepo _catalogRepo;

        public SearchEngine(ICatalogRepo catalogRepo)
        {
            _catalogRepo = catalogRepo;
        }

        public async Task<IEnumerable<string>> Search(string searchString)
        {
            return await _catalogRepo.SearchProducts(searchString);
        }
    }
}
